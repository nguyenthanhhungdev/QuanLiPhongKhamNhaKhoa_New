using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class LoaiDichVuDTO
    {
        private string MaLDV;
        private string TenLDV;

        public LoaiDichVuDTO()
        {
        }

        public LoaiDichVuDTO(string maLDV, string tenLDV)
        {
            MaLDV = maLDV;
            TenLDV = tenLDV;
        }

        public string MaLDV1 { get => MaLDV; set => MaLDV = value; }
        public string TenLDV1 { get => TenLDV; set => TenLDV = value; }
    }
}
