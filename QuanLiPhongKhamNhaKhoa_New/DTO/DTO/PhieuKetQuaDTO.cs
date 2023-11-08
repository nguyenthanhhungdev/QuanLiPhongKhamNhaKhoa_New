using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class PhieuKetQuaDTO
    {
        private string SoPhieuKQ;
        private string KetLuan;
        private string SoPhieuDV;
        private string MaTK;

        public PhieuKetQuaDTO()
        {
        }

        public PhieuKetQuaDTO(string soPhieuKQ, string ketLuan, string soPhieuDV, string maTK)
        {
            SoPhieuKQ = soPhieuKQ;
            KetLuan = ketLuan;
            SoPhieuDV = soPhieuDV;
            MaTK = maTK;
        }

        public string SoPhieuKQ1 { get => SoPhieuKQ; set => SoPhieuKQ = value; }
        public string KetLuan1 { get => KetLuan; set => KetLuan = value; }
        public string SoPhieuDV1 { get => SoPhieuDV; set => SoPhieuDV = value; }
        public string MaTK1 { get => MaTK; set => MaTK = value; }
    }
}

