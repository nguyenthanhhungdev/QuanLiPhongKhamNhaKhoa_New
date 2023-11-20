using BUS;
using ClosedXML.Excel;
using GUI;
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
    public partial class QuanLiNhanVien : Form
    {
        private readonly NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public QuanLiNhanVien()
        {
            InitializeComponent();
            LoadDuLieuNhanVien();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void LoadDuLieuNhanVien()
        {
            DataTable dataTable = nhanVienBUS.LayDuLieuNhanVien();

            // Ẩn mật khẩu trong cột "MatKhau"
            foreach (DataRow row in dataTable.Rows)
            {
                if (dataTable.Columns.Contains("MatKhau"))
                {
                    row["MatKhau"] = "*******";
                }
            }
            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đang ở cột chứa mật khẩu hay không
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                // Ẩn giá trị thực tế của cột mật khẩu
                e.Value = "*******";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["MaNV"].Value.ToString();
                textBox6.Text = row.Cells["TenNV"].Value.ToString();
                textBox5.Text = row.Cells["DiaChi"].Value.ToString();
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
                textBox4.Text = row.Cells["Email"].Value.ToString();
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
                string calam = row.Cells["CaLam"].Value.ToString();

                if (calam == "Sáng" && IsCurrentTimeAM())
                {
                    caLamCheckBox.Checked = true;
                }
                else if (calam == "Tối" && IsCurrentTimePM())
                {
                    caLamCheckBox.Checked = true;
                }
                else
                {
                    caLamCheckBox.Checked = false;
                }
                textBox2.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }
        private bool IsCurrentTimeAM()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.Hour >= 7 && currentTime.Hour <= 15;
        }

        private bool IsCurrentTimePM()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.Hour > 15 && currentTime.Hour < 23;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVienForm = new ThemNhanVien();
            themNhanVienForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy thông tin từ dòng được chọn
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                string tenNV = selectedRow.Cells["TenNV"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgSinh"].Value);
                string sdt = selectedRow.Cells["SDT"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string calam = selectedRow.Cells["CaLam"].Value.ToString();
                string matKhau = selectedRow.Cells["MatKhau"].Value.ToString();
                // Chuyển sang form sửa thông tin
                SuaNhanVien suaForm = new SuaNhanVien(maNV, tenNV, diaChi, ngaySinh, sdt, email, gioiTinh, calam, matKhau);
                suaForm.ShowDialog();
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
                    string maNV = selectedRow.Cells["MaNV"].Value.ToString();

                    // Xóa dòng từ DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Xóa dòng từ cơ sở dữ liệu
                    NhanVienBUS nhanVienBUS = new NhanVienBUS();
                    nhanVienBUS.XoaNhanVien(maNV);

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
            LoadDuLieuNhanVien();
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
            textBox6.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            NamRadioButton.Checked = false;
            NuRadioButton.Checked = false;
            caLamCheckBox.Checked = false;
            textBox2.Text = "";
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
                    var worksheet = workbook.Worksheets.Add("DanhSachNhanVien");

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
                    saveFileDialog.FileName = "DanhSachNhanVien.xlsx";

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

        /*public void AddRowToDataGridView(string maNV, string tenNV, string diaChi, DateTime ngaySinh, string sdt, string email, string gioiTinh, string calam, string matKhau)
        {
            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add(maNV, tenNV, diaChi, ngaySinh, sdt, email, gioiTinh, calam, matKhau);
        }*/




    }
}
