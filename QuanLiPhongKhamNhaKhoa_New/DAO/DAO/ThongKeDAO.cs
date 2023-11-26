using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiPhongKhamNhaKhoa_New.DAO.DAO
{
    internal class ThongKeDAO
    {
        public DataTable getLoaiDichVu(string fDay, string lDay, string tenDV)
        {
            string query = "select TenDV , NgayKham , TenBN , Gia , SoLuong , (Gia * SoLuong) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' and dv.TenDV = '" + tenDV + "'";
            return DataProvider.ExecuteQuery(query);
        }
        public DataTable getAll(string fDay, string lDay)
        {
            string query = "select TenDV , NgayKham , TenBN , Gia , SoLuong , (Gia * SoLuong) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' ";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienAll(string fDay, string lDay)
        {
            string query = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00'";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienTungDV(string fDay, string lDay, string tenDV)
        {
            string query = "select TenDV , SUM(SoLuong*Gia) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' and dv.TenDV = '" + tenDV + "'\r\ngroup by TenDV";
            return DataProvider.ExecuteQuery(query);
        }
    }
}
