using BUS;
using DevExpress.XtraEditors.Mask.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Layout.Borders;

namespace QuanLiPhongKhamNhaKhoa_New.GUI.BacSI
{
    public partial class resuftTicket : Form
    {
        private readonly Home_Origin homeOriginInstance;
        private readonly TaiKhamBUS TKBUS = new TaiKhamBUS();
        private readonly TiepDonBNBUS TDBNBUS = new TiepDonBNBUS();
        private readonly PhieuDichVuBUS PDVBUS = new PhieuDichVuBUS();
        private readonly PhieuKetQuaBUS PKQBUS = new PhieuKetQuaBUS();
        DataTable TKTbl;
        DataTable TKTbladd;
        DataTable PDVTbl;
        DataTable PKQTbl;
        DataTable TDBNTbl;
        private DataTable tblChooseDVResuft = new DataTable();
        public resuftTicket(Home_Origin home)
        {
            InitializeComponent();
            homeOriginInstance = home;
            TKTbl = TKBUS.Getlist();
            PKQTbl = new DataTable();
            PDVTbl = new DataTable();
            TDBNTbl=new DataTable();
            TKTbladd = new DataTable();
            TKTbladd = TKTbl.Clone();
            //thêm cột cho bảng dịch vụ đã chọn
            tblChooseDVResuft.Columns.Add("MaDV", typeof(string));
            tblChooseDVResuft.Columns.Add("Tên Dịch Vụ", typeof(string));
            tblChooseDVResuft.Columns.Add("Loại Dịch Vụ", typeof(string));
            tblChooseDVResuft.Columns.Add("Số Lượng", typeof(int));
            tblChooseDVResuft.Columns.Add("Đơn Giá", typeof(string));
            tblChooseDVResuft.Columns.Add("Thành Tiền", typeof(string));
            listDVChooseRusuft.DataSource = tblChooseDVResuft;
            //thêm cột cho bảng phiếu kết quả
            PKQTbl.Columns.Add("SoPhieuKQ", typeof(String));
            PKQTbl.Columns.Add("KetLuan", typeof(String));
            PKQTbl.Columns.Add("MaTK", typeof(String));
            PDVTbl.Columns.Add("SoPhieuDV", typeof(String));
            PDVTbl.Columns.Add("ThanhTien", typeof(String));
            PDVTbl.Columns.Add("MaBS", typeof(string));
            PDVTbl.Columns.Add("SoPhieuKQ", typeof(String));
            //thêm cột cho tieps đón bệnh nhân
            TDBNTbl.Columns.Add("MaBN", typeof(String));
            TDBNTbl.Columns.Add("MaNV", typeof(String));
            TDBNTbl.Columns.Add("MaMP", typeof(String));
            TDBNTbl.Columns.Add("NgayKham", typeof(String));
            TDBNTbl.Columns.Add("TinhTrang", typeof(String));
        }
        private bool isFirstClick = true;
        public string autoMaPhieu(int soPhieu)
        {
            string maPhieu = "TK" + soPhieu.ToString("D3");
            return maPhieu;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                string maPhieu = autoMaPhieu(TKTbl.Rows.Count + 1);
                txtMaTK.Text = maPhieu;
                isFirstClick = false;
                DateTK.Enabled = true;
            }
            else
            {
                txtMaTK.Text = string.Empty; // Clear the text box
                isFirstClick = true; // Reset the flag for the next click
                DateTK.Enabled = false;
            }
        }

        private void resuftTicket_Load(object sender, EventArgs e)
        {
            DateTK.KeyPress += DateTK_KeyPress;
            DateTK.KeyDown += DateTK_KeyDown;
        }

        private void DateTK_ValueChanged(object sender, EventArgs e)
        {
            checkNgayTaiKham(DateTK.Value);
        }
        private bool checkNgayTaiKham(DateTime date)
        {
            if (date <= DateTime.Now)
            {
                MessageBox.Show("Ngày được chọn phải lớn hơn ngày hiện tại!");
                return false;
            }
            DateTime currentDate = DateTime.Now;
            DateTime minValidDate = currentDate.AddDays(7);

            if (date <= minValidDate)
            {
                MessageBox.Show("Ngày tái khám phải cách ngày khám ít nhất 7 ngày!");
                return false;
            }
            return true;
        }
        private void DateTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Ngăn chặn sự kiện KeyPress để ngăn nhập giá trị từ bàn phím
        }

        private void DateTK_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true; // Ngăn chặn sự kiện KeyDown để ngăn nhập giá trị từ bàn phím
        }

        private void btnSaveRS_Click(object sender, EventArgs e)
        {
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
            // Hiển thị hộp thoại hỏi người dùng có muốn lưu hay không
            DialogResult result = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                // Kiểm tra nếu txtMaTK rỗng
                if (string.IsNullOrEmpty(txtMaTK.Text))
                {
                    DataRow rowtdbn = TDBNTbl.NewRow();
                    rowtdbn["MaBN"]=txtMaBN.Text;
                    rowtdbn["TinhTrang"] = "Đã Khám";
                    TDBNTbl.Rows.Add(rowtdbn);

                    // Thêm dữ liệu vào bảng PKQTbl
                    DataRow rowkq = PKQTbl.NewRow();
                    rowkq["SoPhieuKQ"] = txtPDV.Text;
                    rowkq["KetLuan"] = txtKL.Text;
                    rowkq["MaTK"] = txtMaTK.Text;
                    PKQTbl.Rows.Add(rowkq);
                    // Thêm dữ liệu vào bảng PDVTbl
                    string thanhtien = txtTT.Text;
                    string numericOnly = Regex.Replace(thanhtien, "[^0-9]", "");
                    float colTTValue = float.Parse(numericOnly);
                    DataRow rowdv = PDVTbl.NewRow();
                    rowdv["SoPhieuDV"] = txtPDV.Text;
                    rowdv["ThanhTien"] = colTTValue;
                    rowdv["MaBS"] = "BS01";
                    rowdv["SoPhieuKQ"] = txtPDV.Text;
                    PDVTbl.Rows.Add(rowdv);
                    if (PKQBUS.insertPKQ(PKQTbl) && PDVBUS.insertPDV(PDVTbl) && TDBNBUS.UpdateTDBN(TDBNTbl))
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }

                }
                else
                {
                    // Kiểm tra nếu DateTK đã được chọn
                    if (checkNgayTaiKham(DateTK.Value))
                    {

                        DataRow rowtdbn = TDBNTbl.NewRow();
                        rowtdbn["MaBN"] = txtMaBN.Text;
                        rowtdbn["TinhTrang"] = "Đã Khám";
                        TDBNTbl.Rows.Add(rowtdbn);
                        DataRow rowtk = TKTbladd.NewRow();
                        rowtk["MaTK"] = txtMaTK.Text;
                        rowtk["NgayTK"] = DateTK.Text;
                        rowtk["TinhTrang"] = true;
                        TKTbladd.Rows.Add(rowtk);
                        DataRow rowkq = PKQTbl.NewRow();
                        rowkq["SoPhieuKQ"] = txtPDV.Text;
                        rowkq["KetLuan"] = txtKL.Text;
                        rowkq["MaTK"] = txtMaTK.Text;
                        PKQTbl.Rows.Add(rowkq);
                        string thanhtien = txtTT.Text;
                        string numericOnly = Regex.Replace(thanhtien, "[^0-9]", "");
                        float colTTValue = float.Parse(numericOnly);
                        DataRow rowdv = PDVTbl.NewRow();
                        rowdv["SoPhieuDV"] = txtPDV.Text;
                        rowdv["ThanhTien"] = colTTValue;
                        rowdv["MaBS"] = "BS01";
                        rowdv["SoPhieuKQ"] = txtPDV.Text;
                        PDVTbl.Rows.Add(rowdv);
                        if (TKBUS.insertTK(TKTbladd))
                        {
                            if (PKQBUS.insertPKQ(PKQTbl) && PDVBUS.insertPDV(PDVTbl)&& TDBNBUS.UpdateTDBN(TDBNTbl))
                            {
                                MessageBox.Show("Cập nhật thành công");

                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại");
                            }
                        }

                    }
                }
            }
        }
        private void btnPrintRS_Click(object sender, EventArgs e)
        {
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
            SaveFileDialog save = new SaveFileDialog();
            DateTime time= DateTime.Now;
            string formattedDateTime = time.ToString("HHmmssddMMyyyy");
            save.Filter = "PDF (*.pdf)|*.pdf";
            string namefile = ""+txtTen.Text +","+ formattedDateTime;
            save.FileName = $"{namefile}.pdf";
            bool ErrorMessage = false;
            save.InitialDirectory = @"D:\OneDrive\Tai Lieu\Ngôn Ngữ C #\DeAnCuoiKy\QuanLiPhongKhamNhaKhoa_New\QuanLiPhongKhamNhaKhoa_New\PhieuKetQua";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(save.FileName))
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage = true;
                        MessageBox.Show("Unable to write data to disk" + ex.Message);
                    }
                }

                if (!ErrorMessage)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            PdfWriter pdfWriter = new PdfWriter(fileStream);
                            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                            Document document = new Document(pdfDocument);

                            // Sử dụng font mặc định (VD: Helvetica)
                            PdfFont font = PdfFontFactory.CreateFont(@"C:\Windows\Fonts\Arial.ttf", PdfEncodings.IDENTITY_H, true);
                            document.SetFont(font);

                            // Thêm thông tin địa chỉ và điện thoại
                            document.Add(new Paragraph("Địa chỉ: An Dương Vương, quận 5, Hồ Chí Minh").SetTextAlignment(TextAlignment.CENTER));
                            document.Add(new Paragraph("Điện thoại: 0393515608").SetTextAlignment(TextAlignment.CENTER));
                            document.Add(new Paragraph("NHA KHOA").SetTextAlignment(TextAlignment.CENTER));
                            document.Add(new Paragraph("Website: Nhakhoa.com").SetTextAlignment(TextAlignment.CENTER));
                            document.Add(new Paragraph("Phiếu Khám Và Điều Trị Răng").SetTextAlignment(TextAlignment.CENTER).SetFont(font).SetFontSize(18));
                            DateTime currentDate = DateTime.Now;

                            // Định dạng ngày theo yêu cầu
                            string formattedDate = $"Ngày {currentDate.Day} tháng {currentDate.Month} năm {currentDate.Year}";

                            // Thêm ngày đã định dạng vào tài liệu PDF
                            document.Add(new Paragraph(formattedDate).SetTextAlignment(TextAlignment.CENTER).SetFont(font).SetFontSize(10));
                            // Tiếp tục thêm nội dung của bạn ở đây
                            Paragraph infoBN = new Paragraph("Thông Tin Bệnh Nhân").SetTextAlignment(TextAlignment.LEFT).SetFont(font).SetFontSize(12);
                            document.Add(infoBN);
                            Table infoTable = new Table(2);
                            infoTable.SetWidth(UnitValue.CreatePercentValue(100));

                            Cell cell1 = new Cell().Add(new Paragraph("Họ Và Tên: " + txtTen.Text));
                            Cell cell2 = new Cell().Add(new Paragraph("Ngày Sinh: " + txtNgS.Text));
                            Cell cell3 = new Cell().Add(new Paragraph("Địa Chỉ: " + txtDC.Text));
                            Cell cell4 = new Cell().Add(new Paragraph("Giới Tính: " + txtGT.Text));
                            Cell cell5 = new Cell().Add(new Paragraph("SĐT: " + txtSdt.Text));
                            Cell cell6 = new Cell().Add(new Paragraph("Bệnh Lý: " + txtBL.Text));

                            // Đặt không viền cho từng ô
                            cell1.SetBorder(Border.NO_BORDER);
                            cell2.SetBorder(Border.NO_BORDER);
                            cell3.SetBorder(Border.NO_BORDER);
                            cell4.SetBorder(Border.NO_BORDER);
                            cell5.SetBorder(Border.NO_BORDER);
                            cell6.SetBorder(Border.NO_BORDER);

                            infoTable.AddCell(cell1);
                            infoTable.AddCell(cell2);
                            infoTable.AddCell(cell3);
                            infoTable.AddCell(cell4);
                            infoTable.AddCell(cell5);
                            infoTable.AddCell(cell6);

                            document.Add(infoTable);
                            // Thêm tiêu đề của bảng
                            Paragraph danhSachDichVuTitle = new Paragraph("Danh Sách Dịch Vụ").SetTextAlignment(TextAlignment.CENTER).SetFont(font).SetFontSize(14);
                            document.Add(danhSachDichVuTitle);

                            // Tạo bảng với số cột là số cột trong DataGridView
                            Table table = new Table(listDVChooseRusuft.Columns.Count);

                            // Đặt chiều rộng của các cột trong bảng
                            foreach (DataGridViewColumn column in (listDVChooseRusuft.Columns))
                            {
                                table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)).SetFont(font).SetFontSize(12));
                            }
                            table.SetWidth(UnitValue.CreatePercentValue(100));
                            int rowCount = listDVChooseRusuft.Rows.Count;

                            for (int i = 0; i < rowCount - 1; i++)
                            {
                                DataGridViewRow row = listDVChooseRusuft.Rows[i];

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value != null ? cell.Value.ToString() : "";

                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)).SetFont(font).SetFontSize(10));
                                }
                            }
                            // Thêm bảng vào tài liệu PDF
                            document.Add(table);
                            // Thêm vị trí cho "Tổng Tiền"
                            Paragraph TongTien = new Paragraph("Tổng Tiền: " + txtTT.Text).SetTextAlignment(TextAlignment.RIGHT).SetFont(font).SetFontSize(10);
                            document.Add(TongTien);
                            if (string.IsNullOrWhiteSpace(txtMaTK.Text))
                            {
                                // Code xử lý khi txtMaTK rỗng
                                Table ChuKyTable = new Table(3);
                                ChuKyTable.SetWidth(UnitValue.CreatePercentValue(100));
                                Cell cellck1 = new Cell().Add(new Paragraph("Chữ Ký Bệnh Nhân")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                Cell cellck2 = new Cell().Add(new Paragraph("Chữ Ký Nhân Viên Thu Ngân")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                Cell cellck3 = new Cell().Add(new Paragraph("Chữ Ký Bác Sĩ")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                cellck1.SetBorder(Border.NO_BORDER);
                                cellck2.SetBorder(Border.NO_BORDER);
                                cellck3.SetBorder(Border.NO_BORDER);
                                ChuKyTable.AddCell(cellck1);
                                ChuKyTable.AddCell(cellck2);
                                ChuKyTable.AddCell(cellck3);
                                document.Add(ChuKyTable);
                            }
                            else
                            {
                                // Code xử lý khi txtMaTK không rỗng
                                Paragraph MaTK = new Paragraph("Mã Tái Khám: " + txtMaTK.Text).SetTextAlignment(TextAlignment.LEFT).SetFont(font).SetFontSize(10);
                                Paragraph NgTK = new Paragraph("Ngày Tái Khám: " + DateTK.Text).SetTextAlignment(TextAlignment.LEFT).SetFont(font).SetFontSize(10);
                                document.Add(MaTK);
                                document.Add(NgTK);
                                Table ChuKyTable = new Table(3);
                                ChuKyTable.SetWidth(UnitValue.CreatePercentValue(100));
                                Cell cellck1 = new Cell().Add(new Paragraph("Chữ Ký Bệnh Nhân")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                Cell cellck2 = new Cell().Add(new Paragraph("Chữ Ký Nhân Viên Thu Ngân")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                Cell cellck3 = new Cell().Add(new Paragraph("Chữ Ký Bác Sĩ")).Add(new Paragraph("(Họ và tên)")).SetTextAlignment(TextAlignment.CENTER);
                                cellck1.SetBorder(Border.NO_BORDER);
                                cellck2.SetBorder(Border.NO_BORDER);
                                cellck3.SetBorder(Border.NO_BORDER);
                                ChuKyTable.AddCell(cellck1);
                                ChuKyTable.AddCell(cellck2);
                                ChuKyTable.AddCell(cellck3);
                                document.Add(ChuKyTable);
                            }

                            document.Close();
                            fileStream.Close();
                        }


                        MessageBox.Show("Xuất PDF thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi");
                    }

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trang(Yes) hay muốn xóa hết trang(No)?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                homeOriginInstance.panelDoctor.Controls.Clear();
            }
        }   
    }
}
