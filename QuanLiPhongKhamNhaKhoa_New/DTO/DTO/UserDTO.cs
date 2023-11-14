using System;

namespace DTO
{
    public class UserDTO
    {
        protected string Ma;
        protected string Ten;
        protected string DiaChi;
        protected DateTime NgSinh;
        protected string SDT;
        protected string Email;
        protected string GioiTinh;
        protected string MatKhau;

        public string Ma1
        {
            get => Ma;
            set => Ma = value;
        }

        public string Ten1
        {
            get => Ten;
            set => Ten = value;
        }

        public string DiaChi1
        {
            get => DiaChi;
            set => DiaChi = value;
        }

        public DateTime NgSinh1
        {
            get => NgSinh;
            set => NgSinh = value;
        }

        public string Sdt
        {
            get => SDT;
            set => SDT = value;
        }

        public string Email1
        {
            get => Email;
            set => Email = value;
        }

        public string GioiTinh1
        {
            get => GioiTinh;
            set => GioiTinh = value;
        }

        public string MatKhau1
        {
            get => MatKhau;
            set => MatKhau = value;
        }
    }
}