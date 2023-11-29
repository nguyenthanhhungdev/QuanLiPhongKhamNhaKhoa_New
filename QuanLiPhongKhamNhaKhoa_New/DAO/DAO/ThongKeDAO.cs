using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace ThongKe
{
    internal class ThongKeDAO
    {
        public DataTable getLoaiDichVu(string fDay, string lDay, string tenDV)
        {
            string query2 = "select TenDV , NgayKham , TenBN , Gia , SoLuong , (Gia * SoLuong) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' and dv.TenDV = '" + tenDV + "'";
            string query = "select pdv.SoPhieuDV AS [Ngày lập] , TenDV AS [Tên dịch vụ] , TenBN AS [Tên bệnh nhân] , SoLuong AS [Số lượng], Gia AS [Giá], (Gia * SoLuong) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere pdv.SoPhieuDV >= '" + fDay + "%' and pdv.SoPhieuDV <= '" + lDay + "999' and dv.TenDV = '" + tenDV + "'";
           return DataProvider.ExecuteQuery(query);
        }
        public DataTable getAll(string fDay,string lDay)
        {
            string query2 = "select TenDV  , NgayKham , TenBN , Gia , SoLuong , (Gia * SoLuong) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' ";
            string query = "select pdv.SoPhieuDV AS [Ngày lập] , TenDV AS [Tên dịch vụ] , TenBN AS [Tên bệnh nhân] , SoLuong AS [Số lượng] , Gia AS [Giá] , (Gia * SoLuong) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere pdv.SoPhieuDV >= '" + fDay + "%' and pdv.SoPhieuDV <= '" + lDay + "999'";
           return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienAll(string fDay, string lDay)
        {
            string query2 = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00'";
            string query = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere pdv.SoPhieuDV >= '" + fDay + "%' and pdv.SoPhieuDV <= '" + lDay + "999'";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienTungDV(string fDay, string lDay, string tenDV)
        {
            string query2 = "select TenDV , SUM(SoLuong*Gia) as ThanhTien\r\nfrom (((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join BENHNHAN as bn on pdv.MaBN = bn.MaBN)join TIEPDONBN as td on bn.MaBN = td.MaBN)join DICHVU as dv on dv.MaDV = ct.MaDV\r\nwhere NgayKham >= '" + fDay + "' and NgayKham <= '" + lDay + " 23:59:00' and dv.TenDV = '" + tenDV + "'\r\ngroup by TenDV";
            string query = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere pdv.SoPhieuDV >= '" + fDay + "%' and pdv.SoPhieuDV <= '" + lDay + "999' and dv.TenDV = '" + tenDV + "'\r\ngroup by TenDV";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable listDichVu()
        {
            string query = "select * from DICHVU";
            return DataProvider.ExecuteQuery(query);
        }

    }
}
