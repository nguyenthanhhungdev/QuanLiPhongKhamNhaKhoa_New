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
    public partial class XacNhanPay : UserControl
    {
        private readonly PhieuKetQuaBUS PKQBUS = new PhieuKetQuaBUS();
        public static bool isCheckclick;
        public XacNhanPay()
        {
            InitializeComponent(); ;
            isCheckclick = false;
        }

        private void txtGive_TextChanged(object sender, EventArgs e)
        {
            string moneyString = txtMoney.Text.Trim();
            moneyString = moneyString.Replace(".", "").Replace(" VNĐ", "");

            if (float.TryParse(txtReceive.Text.Trim(), out float moneyFloatReceive))
            {
                float moneyFloat = float.Parse(moneyString);

                if (moneyFloat > moneyFloatReceive)
                {
                    decimal moneyDebt = (decimal)moneyFloat - (decimal)moneyFloatReceive;
                    //MessageBox.Show(moneyDebt.ToString());
                    decimal totalAmount = decimal.Parse(moneyDebt.ToString());
                    string formattedAmount = totalAmount.ToString("#,##0") + " VNĐ";
                    txtDebt.Text = formattedAmount;
                    txtGive.Text = "0";
                }
                else if (moneyFloat < moneyFloatReceive)
                {
                    decimal moneyGive = (decimal)moneyFloatReceive - (decimal)moneyFloat;
                    decimal totalAmount = decimal.Parse(moneyGive.ToString());
                    string formattedAmount = totalAmount.ToString("#,##0") + " VNĐ";
                    txtGive.Text = formattedAmount;
                    txtDebt.Text = "0";
                }
                else
                {
                    txtGive.Text = "0";
                    txtDebt.Text = "0";
                }
            }

        }

        private void btnXnPay_Click(object sender, EventArgs e)
        {
            if (txtDebt.Text == "0")
            {
                if (PKQBUS.UpdatePay(lblSoPhieu.Text.Trim()))
                {
                    string moneyString = txtGive.Text.Trim();
                    moneyString = moneyString.Replace(".", "").Replace(" VNĐ", "");
                    float moneyFloat = float.Parse(moneyString);
                    if (moneyFloat > 0) {
                        MessageBox.Show("Tiền thối: " + txtGive.Text);
                    }
                    MessageBox.Show("Thanh toán thành công!");
                    isCheckclick = true;
                     
               } 
                else
                {

                    MessageBox.Show("Thanh toán thất bại!");
                }
            } 
            else
            {
                MessageBox.Show("Phải thanh toán đủ tiền");
            }
        }
    }
}
