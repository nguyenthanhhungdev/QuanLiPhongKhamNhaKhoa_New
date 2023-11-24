using BUS;
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
    public partial class PayBill : Form
    {
        private readonly BenhNhanBUS BNBUS = new BenhNhanBUS();
        private readonly PhieuKetQuaBUS PKQBUS = new PhieuKetQuaBUS();
        private readonly PhieuDichVuBUS PDVBUS = new PhieuDichVuBUS();
        DataTable pkqTbl;
        DataTable bnTbl;
        DataTable pdvTbl;
        public PayBill()
        {
            InitializeComponent();
        }

        private void PayBill_Load(object sender, EventArgs e)
        {
            TextBox1_Leave(txtFind, EventArgs.Empty);
            showTableKQ();
        }
        private void showTableKQ()
        {
            if (txtFind.Text == "Nhập Số Phiếu Kết Quả...")
            {
                // Nếu TextBox chưa được điền giá trị, gọi GetBill mà không truyền giá trị vào
                pkqTbl = PKQBUS.GetBill("");
            }
            else
            {
                // Ngược lại, truyền giá trị từ TextBox vào GetBill
                pkqTbl = PKQBUS.GetBill(txtFind.Text.Trim());
            }
            if (pkqTbl.Rows.Count == 0)
            {
                // Nếu rỗng, thêm một dòng thông báo vào DataTable
                DataRow newRow = pkqTbl.NewRow();
                newRow["SoPhieuKQ"] = "Không tìm thấy phiếu nào!"; 
                newRow["TenBN"] = DBNull.Value;
                newRow["ThanhTien"] = DBNull.Value;
                pkqTbl.Rows.Add(newRow);
            }
            listPhieuKQ.DataSource = pkqTbl;
        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            // Xử lý khi TextBox được focus
            if (txtFind.Text == "Nhập Số Phiếu Kết Quả...")
            {
                txtFind.Text = "";
                txtFind.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // Xử lý khi TextBox không còn focus
            if (string.IsNullOrWhiteSpace(txtFind.Text))
            {
                txtFind.Text = "Nhập Số Phiếu Kết Quả...";
                txtFind.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            showTableKQ(); // Khi giá trị trong TextBox thay đổi, cập nhật dữ liệu hiển thị
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string maphieu=txtSoPhieu.Text;
            if (!maphieu.Trim().Equals(""))
            {
                XacNhanPay xacNhanPay = new XacNhanPay();
                Form xnPay = new Form();
                xnPay.Controls.Add(xacNhanPay);
                xnPay.AutoSize = true;
                xacNhanPay.lblSoPhieu.Text =txtSoPhieu.Text.Trim();
                //float thanhtien=Convert.pa
                decimal totalAmount = decimal.Parse(txtTT.Text);
                string formattedAmount = totalAmount.ToString("#,##0") + " VNĐ";
                xacNhanPay.txtMoney.Text = formattedAmount;
                xacNhanPay.txtReceive.Text = "0";
                xacNhanPay.txtDebt.Text = formattedAmount;
                xacNhanPay.txtGive.Text = "0";
                xnPay.StartPosition = FormStartPosition.CenterScreen;
                xnPay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Phiếu!");
                return;
            }
            
        }

        private void listPhieuKQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listPhieuKQ.Rows.Count-1)
            {
                DataGridViewRow selectedRow = listPhieuKQ.Rows[e.RowIndex];
                // Lấy giá trị của cột có tên "SoPhieuKQ" từ dòng được chọn
                txtSoPhieu.Text = Convert.ToString(selectedRow.Cells["SoPhieuKQ"].Value);
                string mabn = Convert.ToString(selectedRow.Cells["MaBN"].Value);
                bnTbl = BNBUS.GetListMaBN(mabn);
                pdvTbl = PDVBUS.getTenBS(txtSoPhieu.Text.Trim());
                txtTenBS.Text = pdvTbl.Rows[0][1].ToString();
                txtMaBN.Text = mabn;
                txtTT.Text = Convert.ToString(selectedRow.Cells["ThanhTien"].Value);
                txtTenBN.Text= bnTbl.Rows[0]["TenBN"].ToString();
                txtNgS.Text = bnTbl.Rows[0]["NgSinh"].ToString();
                txtSdt.Text= bnTbl.Rows[0]["SDT"].ToString();
                txtCmnd.Text= bnTbl.Rows[0]["CMND"].ToString();
            }
            else
            {
                txtSoPhieu.Text ="";
                txtTenBS.Text = "";
                txtMaBN.Text = "";
                txtTT.Text = "";
                txtTenBN.Text = "";
                txtNgS.Text = "";
                txtSdt.Text = "";
                txtCmnd.Text = "";
            }
        }
    }
}
