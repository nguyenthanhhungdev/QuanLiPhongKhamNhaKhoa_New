using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhanVienDTO
    {
        private string MaNV;
        private string TenNV;
        private string DiaChi;
        private DateTime NgSinh;
        private string SDT;
        private string Email;
        private string GioiTinh;
        private string MatKhau;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNV, string tenNV, string diaChi, DateTime ngSinh, string sDT, string email, string gioiTinh, string matKhau)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            SDT = sDT;
            Email = email;
            GioiTinh = gioiTinh;
            MatKhau = matKhau;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public DateTime NgSinh1 { get => NgSinh; set => NgSinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
