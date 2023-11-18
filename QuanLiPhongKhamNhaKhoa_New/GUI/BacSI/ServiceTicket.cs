using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLiPhongKhamNhaKhoa_New.GUI.BacSI
{
    public partial class ServiceTicket : Form
    {
        private readonly Home_Origin homeOriginInstance;
        private readonly LoaiDichVuBUS LDVBUS = new LoaiDichVuBUS();
        private readonly DichVuBUS DVBUS = new DichVuBUS();
        private DataTable loaidvlist;
        private DataTable dvlist;
        private DataTable tblChooseDV = new DataTable();

        private float thanhtien = 0;
        public readonly bool isMedicalFormVisible;
        public ServiceTicket()
        {
            InitializeComponent();
            loaidvlist = LDVBUS.GetListTypeService();
            dvlist = DVBUS.GetListService();
        }
        public ServiceTicket(Home_Origin home)
        {
            InitializeComponent();
            homeOriginInstance = home;
            loaidvlist = LDVBUS.GetListTypeService();
            dvlist = DVBUS.GetListService();
        }
        private void ServiceTicket_Load(object sender, EventArgs e)
        {
            //load combobox loaidichvu
            cbbTypeDV.Items.Add("Tất Cả");
            cbbTypeDV.SelectedIndex = 0;
            foreach (DataRow rowldv in loaidvlist.Rows)
            {
                cbbTypeDV.Items.Add(rowldv["TenLDV"].ToString().Trim());
            }
            //load bang dichvu
            listService.DataSource = dvlist;
            listService.Columns["MaLDV"].Visible = false;

            tblChooseDV.Columns.Add("MaDV", typeof(string));
            tblChooseDV.Columns.Add("Tên Dịch Vụ", typeof(string));
            tblChooseDV.Columns.Add("Loại Dịch Vụ", typeof(string));
            tblChooseDV.Columns.Add("Số Lượng", typeof(int));
            tblChooseDV.Columns.Add("Đơn Giá", typeof(string));
            tblChooseDV.Columns.Add("Thành Tiền", typeof(string));
            listDVChoose.DataSource = tblChooseDV;

        }

        private void cbbTypeDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTenDV = cbbTypeDV.SelectedItem.ToString();
            string selectedMaDV = "";
            foreach (DataRow rowldv in loaidvlist.Rows)
            {
                if (selectedTenDV.Trim().Equals(rowldv["TenLDV"].ToString().Trim()))
                {
                    selectedMaDV = rowldv["MaLDV"].ToString().Trim();
                }
            }
            DataView dv = new DataView(dvlist);

            // Kiểm tra xem có chọn "Tất Cả" không
            if (selectedTenDV != "Tất Cả")
            {
                // Áp dụng bộ lọc để hiển thị chỉ các dòng có MaLDV tương ứng với giá trị đã chọn
                dv.RowFilter = $"MaLDV = '{selectedMaDV}'";
            }
            else
            {
                // Nếu chọn "Tất Cả", hiển thị tất cả các dòng
                dv.RowFilter = "";
            }

            // Gán DataView đã lọc làm nguồn dữ liệu cho DataGridView listService
            listService.DataSource = dv;
        }

        private void addService_Click(object sender, EventArgs e)
        {
           
            if (listService.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = listService.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                // Kiểm tra xem rowIndex có nằm trong khoảng hợp lệ (trong danh sách) hay không
                if ((rowIndex + 1) >= 0 && (rowIndex + 1) < listService.RowCount)
                {
                    string maDichVu = selectedRow.Cells["MaDV"].Value.ToString();
                    string tenDichVu = selectedRow.Cells["TenDV"].Value.ToString();
                    string maLoaiDichVu = selectedRow.Cells["MaLDV"].Value.ToString();
                    float giaDichVu = float.Parse(selectedRow.Cells["Gia"].Value.ToString(), CultureInfo.InvariantCulture);

                    string tenLoaiDichVu = "";
                    foreach (DataRow rowdv in loaidvlist.Rows)
                    {
                        if (rowdv["MaLDV"].ToString().Trim().Equals(maLoaiDichVu.Trim()))
                        {
                            tenLoaiDichVu = rowdv["TenLDV"].ToString().Trim();
                        }
                    }
                    SoLuongDV SLDialog = new SoLuongDV();
                    Form formSL = new Form();
                    formSL.Text = "Nhập Số Lượng";
                    formSL.Controls.Add(SLDialog);
                    formSL.Size = new Size(385, 145);
                    formSL.FormBorderStyle = FormBorderStyle.FixedDialog;
                    // Không hiển thị nút Maximize
                    formSL.MaximizeBox = false;

                    SLDialog.QuantitySelected += (s, quantity) =>
                    {
                        DataRow existingRow = tblChooseDV.AsEnumerable().FirstOrDefault(row => row.Field<string>("MaDV") == maDichVu);

                        if (existingRow != null)
                        {
                            // Nếu đã có, tăng số lượng
                            int currentQuantity = Convert.ToInt32(existingRow["Số Lượng"]);
                            existingRow["Số Lượng"] = currentQuantity + quantity;
                            thanhtien = thanhtien - (currentQuantity * giaDichVu) + ((currentQuantity + quantity) * giaDichVu);
                            existingRow["Thành Tiền"] = ((currentQuantity + quantity) * giaDichVu).ToString("N0").Replace(",", ".");
                            txtTT.Text = thanhtien.ToString("N0").Replace(",", ".") + " VNĐ";
                        }
                        else
                        {
                            // Nếu chưa có, thêm mới
                            DataRow newRow = tblChooseDV.NewRow();
                            newRow["MaDV"] = maDichVu;
                            newRow["Tên Dịch Vụ"] = tenDichVu;
                            newRow["Loại Dịch Vụ"] = tenLoaiDichVu;
                            newRow["Số Lượng"] = quantity;
                            newRow["Đơn Giá"] = giaDichVu.ToString("N0").Replace(",", ".");
                            thanhtien = thanhtien + quantity * giaDichVu;
                            newRow["Thành Tiền"] = (quantity * giaDichVu).ToString("N0").Replace(",", ".");
                            tblChooseDV.Rows.Add(newRow);
                            txtTT.Text = (thanhtien).ToString("N0").Replace(",", ".") + " VNĐ";
                        }
                        // Cập nhật DataSource cho DataGridView
                        listDVChoose.DataSource = tblChooseDV;
                        formSL.Close();

                    };
                    formSL.StartPosition = FormStartPosition.CenterScreen;
                    formSL.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dòng đã chọn không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ từ danh sách trước khi thêm.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listDVChoose.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listDVChoose.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                // Kiểm tra xem rowIndex có nằm trong khoảng hợp lệ (trong danh sách) hay không
                if ((rowIndex+1) >= 0 && (rowIndex+1) < listDVChoose.RowCount)
                {
                    DataRow selectedDataRow = ((DataRowView)selectedRow.DataBoundItem).Row;
                    // Lấy giá trị từ DataRow
                    string colTT = selectedDataRow["Thành Tiền"].ToString();
                    string numericOnly = Regex.Replace(colTT, "[^0-9]", "");
                    float colTTValue = float.Parse(numericOnly);
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Nếu người dùng chọn Yes, thì thực hiện xóa
                        tblChooseDV.Rows.RemoveAt(rowIndex);
                        listDVChoose.DataSource = tblChooseDV;
                        thanhtien = thanhtien - colTTValue;
                        txtTT.Text = thanhtien.ToString("N0").Replace(",", ".") + " VNĐ";
                        MessageBox.Show("Đã xóa dịch vụ khỏi danh sách đã chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Dòng đã chọn không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ muốn xóa!");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (listDVChoose.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listDVChoose.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // Kiểm tra xem rowIndex có nằm trong khoảng hợp lệ (trong danh sách) hay không
                if ((rowIndex + 1) >= 0 && (rowIndex + 1) < listDVChoose.RowCount)
                {
                    SoLuongDV SLDialog = new SoLuongDV();
                    Form formSL = new Form();
                    formSL.Text = "Nhập Số Lượng";
                    formSL.Controls.Add(SLDialog);
                    formSL.Size = new Size(385, 145);
                    formSL.FormBorderStyle = FormBorderStyle.FixedDialog;
                    // Không hiển thị nút Maximize
                    formSL.MaximizeBox = false;
                    SLDialog.QuantitySelected += (s, quantity) =>
                    {
                        //DataGridViewRow selectedRow = listDVChoose.SelectedRows[0];
                        int SLOld = int.Parse(selectedRow.Cells["Số Lượng"].Value.ToString());
                        selectedRow.Cells["Số Lượng"].Value = quantity;
                        string colDG = selectedRow.Cells["Đơn Giá"].Value.ToString();
                        string numericOnly = Regex.Replace(colDG, "[^0-9]", "");
                        float colDGValue = float.Parse(numericOnly);
                        selectedRow.Cells["Thành Tiền"].Value = (quantity * colDGValue).ToString("N0").Replace(",", ".");
                        thanhtien = thanhtien - (SLOld * colDGValue) + (quantity * colDGValue);
                        formSL.Close();
                        txtTT.Text = thanhtien.ToString("N0").Replace(",", ".") + " VNĐ";
                    };
                    formSL.StartPosition = FormStartPosition.CenterScreen;
                    formSL.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dòng đã chọn không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ muốn xóa!");
            }
        }
        public bool isServiceFormVisible = false;
        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            if (isServiceFormVisible)
            {
                MessageBox.Show("Đang Lập Phiếu Dịch Vụ Rồi!");
                return;
            }
            // Kiểm tra các trường có trống không

            string sdt = txtSdt.Text.Trim();
            string diaChi = txtDC.Text.Trim();
            string madv = txtPDV.Text.Trim();
            string ngsinh = txtNgS.Text.Trim();
            string cmnd = txtCmnd.Text.Trim();

            if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(ngsinh) || string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Các trường không được để trống không được để trống.");
                return;
            }
            if ((listDVChoose.Rows.Count - 1) == 0)
            {
                MessageBox.Show("Phải Chọn Dịch Vụ!");
                return;
            }
            else
            {
                isServiceFormVisible = true;
                resuftTicket rstk = new resuftTicket(homeOriginInstance);
                rstk.FormClosed += (s, args) => { isServiceFormVisible = false; };
                rstk.TopLevel = false;
                homeOriginInstance.panelDoctor.Controls.Add(rstk);
                rstk.Show();
                rstk.BringToFront();
                rstk.txtMaBN.Text = txtMaBN.Text.ToString();
                rstk.txtPDV.Text = txtPDV.Text.ToString();
                rstk.txtTen.Text = txtTen.Text.ToString();
                rstk.txtSdt.Text = txtSdt.Text.ToString();
                rstk.txtNgS.Text = txtNgS.Text.ToString();
                rstk.txtDC.Text = txtDC.Text.ToString();
                rstk.txtBL.Text = txtBL.Text.ToString();
                rstk.txtCmnd.Text = txtCmnd.Text.ToString();
                rstk.txtGT.Text = txtGT.Text.ToString();
                rstk.txtTT.Text = txtTT.Text.ToString();
                rstk.txtLK.Text = txtLK.Text.ToString();
                DataTable tblChooseDVResuft = new DataTable();
                // Thêm cột từ listDVChoose vào tblChooseDVResuft
                foreach (DataGridViewColumn column in listDVChoose.Columns)
                {
                    tblChooseDVResuft.Columns.Add(column.Name, column.ValueType);
                }

                // Thêm dữ liệu từ listDVChoose vào tblChooseDVResuft
                int rowCount = listDVChoose.Rows.Count;

                for (int i = 0; i < rowCount - 1; i++)
                {
                    DataGridViewRow sourceRow = listDVChoose.Rows[i];
                    DataRow newRow = tblChooseDVResuft.NewRow();

                    foreach (DataGridViewColumn column in listDVChoose.Columns)
                    {
                        object cellValue = sourceRow.Cells[column.Name].Value;
                        newRow[column.Name] = cellValue;
                    }

                    tblChooseDVResuft.Rows.Add(newRow);
                }
                // Xuất dữ liệu của DataTable
                /*foreach (DataRow row in tblChooseDVResuft.Rows)
                {
                    foreach (DataColumn column in tblChooseDVResuft.Columns)
                    {
                        MessageBox.Show($"{column.ColumnName}: {row[column]}");
                    }
                }*/
                rstk.listDVChooseRusuft.DataSource = tblChooseDVResuft;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}

