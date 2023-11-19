using System;

namespace DTO
{
    public class UserDTO
    {
        public string Ma;
        public string Ten;
        public string DiaChi;
        public DateTime NgSinh;
        public string Sdt;
        public string Email;
        public string GioiTinh;
        public string MatKhau;
        public string CaLam;
        public UserDTO()
        {
        }

        public UserDTO(string ma, string ten, string diaChi, DateTime ngSinh, string sdt, string email, string gioiTinh, string matKhau, string caLam)
        {
            Ma = ma;
            Ten = ten;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            Sdt = sdt;
            Email = email;
            GioiTinh = gioiTinh;
            MatKhau = matKhau;
            CaLam = caLam;
        }
    }
}