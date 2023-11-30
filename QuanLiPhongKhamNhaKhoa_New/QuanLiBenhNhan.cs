using BUS;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class QuanLiBenhNhan : Form
    {
        private readonly BenhNhanBUS benhNhanBUS = new BenhNhanBUS();

        public QuanLiBenhNhan()
        {
            InitializeComponent();
            LoadDuLieuBenhNhan();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void LoadDuLieuBenhNhan()
        {
            dataGridView1.DataSource = benhNhanBUS.LayDuLieuBenhNhan();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["MaBN"].Value.ToString();
                textBox3.Text = row.Cells["TenBN"].Value.ToString();
                textBox2.Text = row.Cells["CMND"].Value.ToString();
                textBox4.Text = row.Cells["DiaChi"].Value.ToString();
                DateTime? ngaySinhNullable = row.Cells["NgSinh"].Value as DateTime?;
                if (ngaySinhNullable != null)
                {
                    dateTimePicker1.Value = (DateTime)ngaySinhNullable;
                }
                else
                {
                    dateTimePicker1.Value = DateTimePicker.MinimumDateTime; // hoặc giá trị mặc định khác bạn chọn
                }
                maskedTextBox1.Text = row.Cells["SDT"].Value.ToString();
                textBox5.Text = row.Cells["BenhLy"].Value.ToString();
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                // Gán giá trị từ cơ sở dữ liệu cho RadioButton
                if (gioiTinh == "Nam")
                {
                    NamRadioButton.Checked = true;
                    NuRadioButton.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    NamRadioButton.Checked = false;
                    NuRadioButton.Checked = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDuLieuBenhNhan();
            // Clear các thông tin trên form
            ClearForm();

            // Bỏ chọn dòng đang được chọn trong DataGridView
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {
            // Đặt giá trị rỗng hoặc mặc định cho các điều khiển trên form
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            maskedTextBox1.Text = "";
            textBox5.Text = "";
            NamRadioButton.Checked = false;
            NuRadioButton.Checked = false;
        }
        private void ExportToExcel()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DanhSachBenhNhan");

                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).Value = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            object cellValue = dataGridView1.Rows[i].Cells[j].Value;

                            // Chuyển đổi giá trị của ô thành kiểu chuỗi nếu không phải là null
                            string stringValue = cellValue != null ? cellValue.ToString() : string.Empty;

                            worksheet.Cell(i + 2, j + 1).Value = stringValue;
                        }
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "DanhSachBenhNhan.xlsx";
                    saveFileDialog.InitialDirectory = @"C:\Users\ACER\Desktop\DeAnCuoiKy_C#\QuanLiPhongKhamNhaKhoa_New\Excel";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
