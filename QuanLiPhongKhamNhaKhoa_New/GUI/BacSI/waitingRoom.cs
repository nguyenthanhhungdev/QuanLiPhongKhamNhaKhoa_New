using BUS;
using DevExpress.Data.Filtering;
using DTO;
using GUI;
using QuanLiPhongKhamNhaKhoa_New;
using QuanLiPhongKhamNhaKhoa_New.GUI.BacSI;
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
    public partial class waitingRoom : Form
    {
        
        private readonly TiepDonBNBUS TDBUS=new TiepDonBNBUS();
        private readonly BenhNhanBUS BNBUS = new BenhNhanBUS();
        public DataTable TdTbl;
        public DataTable BNTbl;
        private readonly Home_Origin homeOriginInstance;

        public waitingRoom(Home_Origin homeOrigin)
        {
            InitializeComponent();
            homeOriginInstance = homeOrigin;
            String maphong = "P01"; // Thay mã phòng bằng mã phòng bác sĩ đăng nhập 
            TdTbl = TDBUS.GetListWaitingRoom(maphong);
            BNTbl = BNBUS.GetList();
        }
        public waitingRoom()
        {
            InitializeComponent();
            String maphong = "P01"; // Thay mã phòng bằng mã phòng bác sĩ đăng nhập 
            TdTbl = TDBUS.GetListWaitingRoom(maphong);
            BNTbl = BNBUS.GetList();
        }
        List<string> columnOrder;
        private void waitingRoom_Load(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
            DataColumn sttColumn = new DataColumn("STT", typeof(int));
            TdTbl.Columns.Add(sttColumn);
            TdTbl.Columns["STT"].SetOrdinal(0);

            // Gán giá trị STT cho từng dòng trong TdTbl
            for (int i = 0; i < TdTbl.Rows.Count; i++)
            {
                TdTbl.Rows[i]["STT"] = i + 1;
            }

            // Thêm cột TenBenhNhan vào TdTbl
            DataColumn tenBenhNhanColumn = new DataColumn("TenBenhNhan", typeof(string));
            TdTbl.Columns.Add(tenBenhNhanColumn);

            // Thêm cột Button cho mỗi dòng
            foreach (DataRow rowtd in TdTbl.Rows)
            {
                // Tìm thông tin tương ứng từ BNTbl
                foreach (DataRow rowbn in BNTbl.Rows)
                {
                    if (rowtd["MaBN"].ToString().Trim().Equals(rowbn["MaBN"].ToString().Trim()))
                    {
                        rowtd["TenBenhNhan"] = rowbn["TenBN"].ToString().Trim();
                    }
                }
            }
            // Thêm cột DataGridViewButtonColumn vào listWaiting
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Khám";
            buttonColumn.Name = "btnKham";
            buttonColumn.UseColumnTextForButtonValue = true;

            SaveColumnOrder(); // Lưu trước khi thêm cột "btnKham"
            listWaiting.Columns.Add(buttonColumn);
            RestoreColumnOrder(); // Khôi phục sau khi thêm cột "btnKham"
            //ẩn cột muốn ẩn
            listWaiting.Columns["NgayKham"].Visible = false;
            listWaiting.Columns["MaPhong"].Visible = false;
            listWaiting.Columns["MaBN"].Visible = false;
            listWaiting.Columns["TinhTrang"].Visible = false;

            //lấp đầy datagridview
            listWaiting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sự kiện CellFormatting cho cột "btnKham"
            listWaiting.CellFormatting += listWaiting_CellFormatting;
            listWaiting.CellContentClick += listWaiting_CellContentClick;

        }

        private void listWaiting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == listWaiting.Columns["btnKham"].Index && e.RowIndex >= 0 && e.RowIndex < listWaiting.RowCount - 1)
            {
                // Đặt văn bản của nút dựa trên giá trị trong cột "TinhTrang" tương ứng
                String tinhTrangValue = listWaiting.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString().Trim();
                // Đặt văn bản của nút dựa trên giá trị trong cột "TinhTrang" tương ứng
                if (tinhTrangValue == "Khám")
                {
                    // Nếu TinhTrang là "Khám", đặt văn bản nút là "Khám"
                    e.Value = "Khám";
                }
                else if (tinhTrangValue == "Tái Khám")
                {
                    // Nếu TinhTrang là "Tái Khám", đặt văn bản nút là "Tái Khám"
                    e.Value = "Tái Khám";
                }
            }
        }
        private bool isMedicalFormVisible = false;

        private void ShowMedicalForm(string tinhTrangValue, string maBenhNhan)
        {
            // Nếu form đã hiển thị, không thực hiện gì cả
            if (isMedicalFormVisible) {
                MessageBox.Show("Đang Thực Hiện Khám Bệnh Nhân Rồi!");
                return;
            }
                

            // Tạo form mới
            MedicalTicket mdform = new MedicalTicket(homeOriginInstance);
            mdform.TopLevel = false;

            // Lấy vị trí và kích thước của form waiting
            homeOriginInstance.panelDoctor.Controls.Add(mdform);
            mdform.Show();
            mdform.BringToFront();
            isMedicalFormVisible = true;

            // Thực hiện các thao tác cần thiết dựa trên giá trị của nút
            
            foreach(DataRow rowbn in BNTbl.Rows)
            {
                if (rowbn["MaBN"].ToString().Trim().Equals(maBenhNhan.Trim()))
                {
                    mdform.txtMaBN.Text= rowbn["MaBN"].ToString().Trim();
                    mdform.txtTen.Text = rowbn["TenBN"].ToString().Trim();
                    mdform.txtGT.Text= rowbn["GioiTinh"].ToString().Trim();
                    mdform.txtNgS.Text = rowbn["NgSinh"].ToString().Trim();
                    mdform.txtDC.Text = rowbn["DiaChi"].ToString().Trim();
                    mdform.txtSdt.Text = rowbn["SDT"].ToString().Trim();
                    mdform.txtCmnd.Text = rowbn["CMND"].ToString().Trim();
                    mdform.txtBL.Text = rowbn["BenhLy"].ToString().Trim();
                    mdform.txtLK.Text = tinhTrangValue.Trim();
                    
                }
                    
            }
            
            // Sự kiện Closed của form medical để đặt lại trạng thái isMedicalFormVisible khi form được đóng
            mdform.FormClosed += (sender, e) => { isMedicalFormVisible = false; };
        }
        private void listWaiting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào cột "btnKham" không
            if (listWaiting.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex < listWaiting.RowCount - 1)
            {
                string tinhTrangValue = listWaiting.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString().Trim();
                string maBenhNhan = listWaiting.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();
                ShowMedicalForm(tinhTrangValue, maBenhNhan);
            }
        }


        private void rdoChuakham_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPatientsByTinhTrang("Khám");
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            RestoreColumnOrder();
            DisplayAllPatients();
        }

        private void rdoTaiKham_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPatientsByTinhTrang("Tái Khám");
        }
        private void DisplayAllPatients()
        {
            // Hiển thị tất cả bệnh nhân
            listWaiting.DataSource = TdTbl;
        }
        private void DisplayPatientsByTinhTrang(String tinhTrangValue)
        {
            RestoreColumnOrder();
            // Thực hiện truy vấn hoặc lọc dữ liệu để hiển thị những bệnh nhân theo tình trạng
            DataView dv = new DataView(TdTbl);
            dv.RowFilter = $"TinhTrang = '{tinhTrangValue}'";

            // Trả về DataTable đã lọc
            DataTable filteredData = dv.ToTable();

            // Gán dữ liệu đã lọc vào DataGridView hoặc điều chỉnh hiển thị tùy thuộc vào cách bạn quản lý dữ liệu
            listWaiting.DataSource = filteredData;
        }
        //lưu thứ tự cột
        private void SaveColumnOrder()
        {
            // Lưu trữ thứ tự hiện tại của các cột
            columnOrder = new List<string>();
            foreach (DataGridViewColumn column in listWaiting.Columns)
            {
                columnOrder.Add(column.Name);
            }
        }
        private void RestoreColumnOrder()
        {
            // Khôi phục thứ tự của các cột dựa trên danh sách đã lưu
            if (columnOrder != null)
            {
                foreach (string columnName in columnOrder)
                {
                    if (listWaiting.Columns.Contains(columnName))
                    {
                        DataGridViewColumn column = listWaiting.Columns[columnName];
                        column.DisplayIndex = columnOrder.IndexOf(columnName);
                    }
                }
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
