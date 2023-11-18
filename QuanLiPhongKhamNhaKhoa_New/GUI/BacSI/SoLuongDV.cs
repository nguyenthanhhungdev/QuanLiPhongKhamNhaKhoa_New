using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
namespace QuanLiPhongKhamNhaKhoa_New.GUI.BacSI
{
    public partial class SoLuongDV : UserControl
    {
        public int SelectedQuantity { get; private set; }
        public SoLuongDV()
        {
            InitializeComponent();
        }




        public event EventHandler<int> QuantitySelected;

        private void button1_Click(object sender, EventArgs e)
        {
            int inputValue = (int)numericUpDown1.Value;

            // Kiểm tra nếu giá trị nhập vào bé hơn hoặc bằng 0
            if (inputValue <= 0)
            {
                MessageBox.Show("Giá trị không hợp lệ. Hãy nhập số lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Đặt giá trị về một giá trị mặc định (ví dụ: 1)
                numericUpDown1.Value = 0;
                selectnumericUpDown1();
            }
            else
            {
                // Kích hoạt sự kiện và truyền giá trị số lượng về form cha
                QuantitySelected?.Invoke(this, inputValue);
            }
        }

        private void SoLuongDV_Load(object sender, EventArgs e)
        {
            selectnumericUpDown1();
        }
        public void selectnumericUpDown1()
        {
            // Move the cursor to the end by setting the selection
            numericUpDown1.Select(0, numericUpDown1.Text.Length);
            // Ensure that the control is selected
            numericUpDown1.Select();
        }
    }
}
