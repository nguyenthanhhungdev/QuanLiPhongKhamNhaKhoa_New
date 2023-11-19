using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhanVienDTO : UserDTO
    {
        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNV, string tenNV, string diaChi, DateTime ngSinh, string sDT, string email, string gioiTinh, string matKhau, string caLam): 
            base(maNV, tenNV, diaChi, ngSinh, sDT, email, gioiTinh, matKhau, caLam)
        {
            
        }
    }
}
