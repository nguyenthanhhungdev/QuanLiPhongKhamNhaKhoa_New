using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class BenhNhanDTO
    {
        private string MaBN;
        private string TenBN;
        private string CMND;
        private string DiaChi;
        private DateTime NgSinh;
        private string SDT;
        private string BenhLy;
        private string GioiTinh;
        private string SoPhieuDV;

        public BenhNhanDTO()
        {
        }

        public BenhNhanDTO(string maBN, string tenBN, string cMND, string diaChi, DateTime ngSinh, string sDT, string benhLy, string gioiTinh, string soPhieuDV)
        {
            MaBN = maBN;
            TenBN = tenBN;
            CMND = cMND;
            DiaChi = diaChi;
            NgSinh = ngSinh;
            SDT = sDT;
            BenhLy = benhLy;
            GioiTinh = gioiTinh;
            SoPhieuDV = soPhieuDV;
        }

        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string TenBN1 { get => TenBN; set => TenBN = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public DateTime NgSinh1 { get => NgSinh; set => NgSinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string BenhLy1 { get => BenhLy; set => BenhLy = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SoPhieuDV1 { get => SoPhieuDV; set => SoPhieuDV = value; }
    }
}
