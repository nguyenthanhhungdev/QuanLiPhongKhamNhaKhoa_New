using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DichVuDTO
    {
        private string MaDV;
        private string TenDV;
        private float Gia;
        private string MaLDV;

        public DichVuDTO()
        {
        }

        public DichVuDTO(string maDV, string tenDV, float gia, string maLDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            Gia = gia;
            MaLDV = maLDV;
        }

        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public string TenDV1 { get => TenDV; set => TenDV = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
        public string MaLDV1 { get => MaLDV; set => MaLDV = value; }
    }
}
