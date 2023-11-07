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
    public partial class TraCuuBenhNhan : Form
    {
        public TraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bENHNHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phongKhamNhaKhoaDataSet);

        }

        private void TraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongKhamNhaKhoaDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.phongKhamNhaKhoaDataSet.BENHNHAN);

        }
    }
}
