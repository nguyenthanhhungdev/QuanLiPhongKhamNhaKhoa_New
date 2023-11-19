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
    public partial class QuanLiDichVu : Form
    {
        private readonly DichVuBUS dichVuBUS = new DichVuBUS();

        public QuanLiDichVu()
        {
            InitializeComponent();
            LoadDuLieuDV();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void LoadDuLieuDV()
        {
            dataGridView1.DataSource = dichVuBUS.LayDuLieuDichVu();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["MaDV"].Value.ToString();
                textBox2.Text = row.Cells["TenDV"].Value.ToString();
                textBox3.Text = row.Cells["Gia"].Value.ToString();
                textBox4.Text = row.Cells["TenLDV"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVuForm = new ThemDichVu();
            themDichVuForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy thông tin từ dòng được chọn
                string maDV = selectedRow.Cells["MaDV"].Value.ToString();
                string tenDV = selectedRow.Cells["TenDV"].Value.ToString();
                if (float.TryParse(selectedRow.Cells["Gia"].Value.ToString(), out float gia))
                {
                    string tenLDV = selectedRow.Cells["TenLDV"].Value.ToString();

                    // Chuyển sang form sửa thông tin
                    SuaDichVu suaForm = new SuaDichVu(maDV, tenDV, gia, tenLDV);
                    suaForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lỗi chuyển đổi giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Lấy thông tin từ dòng được chọn
                    string maDV = selectedRow.Cells["MaDV"].Value.ToString();

                    // Xóa dòng từ DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Xóa dòng từ cơ sở dữ liệu
                    DichVuBUS DichVuBUS = new DichVuBUS();
                    dichVuBUS.XoaDichVu(maDV);

                    MessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDuLieuDV();
            // Clear các thông tin trên form
            ClearForm();

            // Bỏ chọn dòng đang được chọn trong DataGridView
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportToExcel();
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
                    var worksheet = workbook.Worksheets.Add("DanhSachDichVu");

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
                    saveFileDialog.FileName = "DanhSachDichVu.xlsx";

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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        private void ClearForm()
        {
            // Đặt giá trị rỗng hoặc mặc định cho các điều khiển trên form
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
