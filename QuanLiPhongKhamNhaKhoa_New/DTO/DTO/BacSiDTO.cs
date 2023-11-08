using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    internal class BacSiDTO
    {
        private string MaBS;
        private string TenBS;
        private string DiaChi;
        private DateTime NgSinh;
        private string SDT;
        private string Email;
        private string GioiTinh;
        private string CaLam;
        private string MatKhau;
        private string MaPhong;
            
        public BacSiDTO()
        {
        }

        public BacSiDTO(string maBS, string tenBS, string diaChi, DateTime ngSinh, string sDT, string email, string gioiTinh, string caLam, string matKhau, string maPhong)
        {
            MaBS = maBS;
            TenBS = tenBS;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            SDT1= sDT;
            Email= email;
            GioiTinh = gioiTinh;
            CaLam = caLam;
            MatKhau = matKhau;
            MaPhong = maPhong;
        }

        public string MaBS1 { get => MaBS; set => MaBS = value; }
        public string TenBS1 { get => TenBS; set => TenBS = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public DateTime NgSinh1 { get => NgSinh; set => NgSinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string CaLam1 { get => CaLam; set => CaLam = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string MaPhong1 { get => MaPhong; set => MaPhong = value; }

    }
}
