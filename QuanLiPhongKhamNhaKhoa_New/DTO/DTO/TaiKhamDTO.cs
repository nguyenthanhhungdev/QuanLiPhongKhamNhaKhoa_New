using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TaiKhamDTO
    {
        private string MaTK;
        private DateTime NgayTK;
        private bool TinhTrang;
        private string SoPhieuKQ;

        public TaiKhamDTO()
        {
        }

        public TaiKhamDTO(string maTK, DateTime ngayTK, bool tinhTrang, string soPhieuKQ)
        {
            MaTK = maTK;
            NgayTK = ngayTK;
            TinhTrang = tinhTrang;
            SoPhieuKQ = soPhieuKQ;
        }

        public string MaTK1 { get => MaTK; set => MaTK = value; }
        public DateTime NgayTK1 { get => NgayTK; set => NgayTK = value; }
        public bool TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public string SoPhieuKQ1 { get => SoPhieuKQ; set => SoPhieuKQ = value; }
    }
}
