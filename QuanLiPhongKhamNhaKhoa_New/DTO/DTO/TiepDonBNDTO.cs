using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TiepDonBNDTO
    {
        private string MaNV;
        private string MaBN;
        private string MaPhong;
        private DateTime NgayKham;

        public TiepDonBNDTO()
        {
        }

        public TiepDonBNDTO(string maNV, string maBN, string maPhong, DateTime ngayKham)
        {
            MaNV = maNV;
            MaBN = maBN;
            MaPhong = maPhong;
            NgayKham = ngayKham;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string MaPhong1 { get => MaPhong; set => MaPhong = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
    }
}
