using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    internal class BacSiDTO : UserDTO
    {
        private string MaPhong;
        private string CaLam;

        public BacSiDTO()
        {
        }

        public BacSiDTO(string ma, string ten, string diaChi, DateTime ngSinh, string sDT, string email, string gioiTinh, string caLam, string matKhau, string maPhong)
        {
            Ma = ma;
            Ten = ten;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            SDT= sDT;
            Email= email;
            GioiTinh = gioiTinh;
            CaLam = caLam;
            MatKhau = matKhau;
            MaPhong = maPhong;
        }

        public string MaPhong1
        {
            get => MaPhong;
            set => MaPhong = value;
        }

        public string CaLam1
        {
            get => CaLam;
            set => CaLam = value;
        }
    }
}
