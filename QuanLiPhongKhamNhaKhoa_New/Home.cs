using DevExpress.XtraBars;
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
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new TraCuuBenhNhan());
        }
    }
}