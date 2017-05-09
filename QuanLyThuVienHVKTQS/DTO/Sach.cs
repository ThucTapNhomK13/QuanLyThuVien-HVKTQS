using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class Sach
    {
        private int _ma;
        private string _tensach;
        private int? _maloaisach;
        private int _noibo;
        private string _masach;
        private string _tacgia;
        private string _gioithieu;
        private string _trangthai;

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

        public string Tensach
        {
            get
            {
                return _tensach;
            }

            set
            {
                _tensach = value;
            }
        }

        public int? Maloaisach
        {
            get
            {
                return _maloaisach;
            }

            set
            {
                _maloaisach = value;
            }
        }

        public int Noibo
        {
            get
            {
                return _noibo;
            }

            set
            {
                _noibo = value;
            }
        }

        public string Masach
        {
            get
            {
                return _masach;
            }

            set
            {
                _masach = value;
            }
        }

        public string Tacgia
        {
            get
            {
                return _tacgia;
            }

            set
            {
                _tacgia = value;
            }
        }

        public string Gioithieu
        {
            get
            {
                return _gioithieu;
            }

            set
            {
                _gioithieu = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return _trangthai;
            }

            set
            {
                _trangthai = value;
            }
        }

        public Sach() { }

        public Sach (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Tensach = dr["tensach"].ToString();
            Maloaisach = int.Parse( dr["idloaisach"].ToString());
            Tacgia = dr["tacgia"].ToString();
            Gioithieu = dr["gioithieu"].ToString();
            Trangthai = dr["trangthai"].ToString();
            Masach = dr["masach"].ToString();
            Noibo = int.Parse(dr["noibo"].ToString());

        }


    }
}
