using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class PhongKhamDTO
    {
        private string MaPhong;
        private string TenPhong;

        public PhongKhamDTO()
        {
        }

        public PhongKhamDTO(string maPhong, string tenPhong)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
        }

        public string MaPhong1 { get => MaPhong; set => MaPhong = value; }
        public string TenPhong1 { get => TenPhong; set => TenPhong = value; }
    }
}
