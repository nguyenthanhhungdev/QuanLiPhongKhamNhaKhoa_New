using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class CT_DichVuDTO
    {
        private string SoPhieuDV;
        private string MaDV;
        private int SoLuong;

        public CT_DichVuDTO()
        {
        }

        public CT_DichVuDTO(string soPhieuDV, string maDV, int soLuong)
        {
            SoPhieuDV = soPhieuDV;
            MaDV = maDV;
            SoLuong = soLuong;
        }

        public string SoPhieuDV1 { get => SoPhieuDV; set => SoPhieuDV = value; }
        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
