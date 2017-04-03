using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class NhanSu
    {
        private int _ma;
        private string _hoten;
        private DateTime _ngaysinh;
        private string _anhdaidien;
        private string _gioitinh;
        private string _taikhoan;
        private string _matkhau;
        private int _quanly;

        public int Ma
        {
            get
            {
                return _ma;
            }

            set
            {
                _ma = value;
            }
        }

        public string Hoten
        {
            get
            {
                return _hoten;
            }

            set
            {
                _hoten = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return _ngaysinh;
            }

            set
            {
                _ngaysinh = value;
            }
        }

        public string Anhdaidien
        {
            get
            {
                return _anhdaidien;
            }

            set
            {
                _anhdaidien = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }

        public string Taikhoan
        {
            get
            {
                return _taikhoan;
            }

            set
            {
                _taikhoan = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return _matkhau;
            }

            set
            {
                _matkhau = value;
            }
        }

        public int Quanly
        {
            get
            {
                return _quanly;
            }

            set
            {
                _quanly = value;
            }
        }

        public NhanSu() { }

        public NhanSu (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Hoten = dr["ten"].ToString();
            Ngaysinh = DateTime.Parse(dr["ngaysinh"].ToString());
            Anhdaidien = dr["anhdaidien"].ToString();
            Gioitinh = dr["gioitinh"].ToString();
            Taikhoan = dr["taikhoan"].ToString();
            Matkhau = dr["matkhau"].ToString();
            Quanly = int.Parse(dr["quanly"].ToString());
        }
    }
}
