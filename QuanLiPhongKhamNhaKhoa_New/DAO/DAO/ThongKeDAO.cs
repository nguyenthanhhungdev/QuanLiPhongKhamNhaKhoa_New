using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
            string query = "select LEFT(pdv.SoPhieuDV,6) AS [Ngày lập]   , TenDV AS [Tên dịch vụ] , TenBN AS [Tên bệnh nhân] , SoLuong AS [Số lượng], Gia AS [Giá], (Gia * SoLuong) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "' and dv.TenDV = N'" + tenDV + "'";
            return DataProvider.ExecuteQuery(query);
        }
        public DataTable getAll(string fDay, string lDay)
        {
            string query = "select LEFT(pdv.SoPhieuDV,6) AS [Ngày lập]   , TenDV AS [Tên dịch vụ] , TenBN AS [Tên bệnh nhân] , SoLuong AS [Số lượng] , Gia AS [Giá] , (Gia * SoLuong) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "'";
            string query1 = "select pdv.SoPhieuDV  , TenDV AS [Tên dịch vụ] , TenBN AS [Tên bệnh nhân] , SoLuong AS [Số lượng] , Gia AS [Giá] , (Gia * SoLuong) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "'";

            return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienAll(string fDay, string lDay)
        {
            string query = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "'";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable getTongTienTungDV(string fDay, string lDay, string tenDV)
        {
            string query = "select SUM(SoLuong*Gia) as ThanhTien\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "' and dv.TenDV = N'" + tenDV + "'\r\ngroup by TenDV";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable listDichVu()
        {
            string query = "select * from DICHVU";
            return DataProvider.ExecuteQuery(query);
        }
        public DataTable getTungDV(string fDay, string lDay)
        {
            string query = "select TenDV as [Tên dịch vụ] , SUM(SoLuong*Gia) as [Thành tiền]\r\nfrom ((PHIEUDICHVU as pdv join CT_DICHVU as ct on pdv.SoPhieuDV = ct.SoPhieuDV)join DICHVU as dv on dv.MaDV = ct.MaDV) join BENHNHAN as bn on bn.MaBN = pdv.MaBN\r\nwhere CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) >= '" + fDay + "' and  CONVERT(DATE,CONVERT(varchar(10),CONCAT(SUBSTRING(pdv.SoPhieuDV,5,2),SUBSTRING(pdv.SoPhieuDV,3,2),SUBSTRING(pdv.SoPhieuDV,1,2)))) <= '" + lDay + "'\r\ngroup by TenDV";
            return DataProvider.ExecuteQuery(query);
        }
    }
}
