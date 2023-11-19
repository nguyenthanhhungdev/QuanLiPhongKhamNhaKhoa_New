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
        public string MaPhong;

        public BacSiDTO()
        {
        }

        public BacSiDTO(string ma, string ten, string diaChi, DateTime ngSinh, string sDT, string email,
            string gioiTinh, string caLam, string matKhau, string maPhong) :
            base(ma, ten, diaChi, ngSinh, sDT, email, gioiTinh, matKhau, caLam)
        {
            MaPhong = maPhong;
        }
    }
}