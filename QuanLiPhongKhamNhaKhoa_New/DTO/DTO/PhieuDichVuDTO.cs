using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class PhieuDichVuDTO
    {
        private string SoPhieuDV;
        private float ThanhTien;
        private string MaBS;
        private string MaBN;
        private string SoPhieuKQ;

        public PhieuDichVuDTO()
        {
        }

        public PhieuDichVuDTO(string soPhieuDV, float thanhTien, string maBS, string maBN, string soPhieuKQ)
        {
            SoPhieuDV = soPhieuDV;
            ThanhTien = thanhTien;
            MaBS = maBS;
            MaBN = maBN;
            SoPhieuKQ = soPhieuKQ;
        }

        public string SoPhieuDV1 { get => SoPhieuDV; set => SoPhieuDV = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string MaBS1 { get => MaBS; set => MaBS = value; }
        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string SoPhieuKQ1 { get => SoPhieuKQ; set => SoPhieuKQ = value; }
    }
}
