﻿using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAO
{
    internal class PhongKhamDAO
    {
        private readonly Database database = new Database();
        public DataTable LayTenPhongKham()
        {
            string query = "SELECT * FROM PHONGKHAM";
            return database.Execute(query);
        }
        public DataTable LayDuLieuPhongKham()
        {
            string query = "SELECT PHONGKHAM.MaPhong, PHONGKHAM.TenPhong, BACSI.TenBS, BACSI.CaLam " +
                   "FROM PHONGKHAM " +
                   "LEFT JOIN BACSI ON PHONGKHAM.MaPhong = BACSI.MaPhong " ;
            return database.Execute(query);
        }

        public void ThemPhongKham(string maP, string tenP)
        {
            string sql = string.Format("INSERT INTO PHONGKHAM VALUES('{0}', N'{1}')", maP, tenP);
            database.ExecuteNonQuery(sql);

        }
        public void SuaPhongKham(string maP, string tenP)
        {
            string sql = string.Format("UPDATE PHONGKHAM SET TenPhong = N'{0}' WHERE MaPhong = '{1}'", tenP, maP);
            database.ExecuteNonQuery(sql);
        }
        public void XoaPhongKham(string maP)
        {
            string sql = string.Format("DELETE FROM PHONGKHAM WHERE MaPhong = '{0}'", maP);
            database.ExecuteNonQuery(sql);
        }
        public int LayTongPK()
        {
            string sql = "SELECT COUNT(MaPhong) FROM PHONGKHAM";
            int i = database.ExecuteScalar(sql);
            return i;
        }

        //Lấy danh sách phòng trống
        public DataTable LayDSPhongTrong(string caLam)
        {
            string sql = "SELECT PHONGKHAM.MaPhong, TenPhong, MaBS FROM BACSI  JOIN PHONGKHAM ON  BACSI.MaPhong = PHONGKHAM.MaPhong " +
                " WHERE CaLam = N'"+caLam+"' AND TenPhong NOT IN " +
                " (SELECT DISTINCT TenPhong AS SoLuongBN FROM PHONGKHAM LEFT JOIN TIEPDONBN " +
                " ON PHONGKHAM.MaPhong = TIEPDONBN.MaPhong " +
                " WHERE DAY(NgayKham) = DAY(GETDATE()) AND (TinhTrang = N'Tái Khám' OR TinhTrang = N'Khám') " +
                " GROUP BY TenPhong, NgayKham " +
                " HAVING COUNT(MaBN) >= 4)";
            //MessageBox.Show(sql);
            DataTable dt = database.Execute(sql);
            return dt;
        }
    }
}
