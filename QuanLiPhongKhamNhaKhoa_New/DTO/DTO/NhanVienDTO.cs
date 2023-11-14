using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhanVienDTO : UserDTO
    {
        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNV, string tenNV, string diaChi, DateTime ngSinh, string sDT, string email, string gioiTinh, string matKhau)
        {
            Ma = maNV;
            Ten = tenNV;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            SDT = sDT;
            Email = email;
            GioiTinh = gioiTinh;
            MatKhau = matKhau;
        }
    }
}
