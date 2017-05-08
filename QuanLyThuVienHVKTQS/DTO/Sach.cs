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
        private int _id;
        private int _idloaisach;
        private string _tensach;
<<<<<<< HEAD
        private int? _maloaisach;
        private int _noibo;
        private string _masach;
        private string _tacgia;
        private string _gioithieu;
        private string _trangthai;
=======
        private string _tacgia;
        private string _gioithieu;
>>>>>>> origin/master

        public int Ma
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
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
                return _idloaisach;
            }

            set
            {
                _idloaisach = value;
            }
        }

<<<<<<< HEAD
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

=======
>>>>>>> origin/master
        public string Tacgia
        {
            get
            {
                return _tacgia;
            }
<<<<<<< HEAD

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
=======
>>>>>>> origin/master

            set
            {
                _tacgia = value;
            }
        }

        public string Gioithieu
        {
<<<<<<< HEAD
            Ma = int.Parse(dr["id"].ToString());
            Tensach = dr["tensach"].ToString();
            Maloaisach = int.Parse( dr["idloaisach"].ToString());
            Tacgia = dr["tacgia"].ToString();
            Gioithieu = dr["gioithieu"].ToString();
            Trangthai = dr["trangthai"].ToString();
            Masach = dr["masach"].ToString();
            Noibo = int.Parse(dr["noibo"].ToString());

=======
            get
            {
                return _gioithieu;
            }

            set
            {
                _gioithieu = value;
            }
>>>>>>> origin/master
        }

        public Sach() { }

        public Sach GetSach(DataRow dr)
        {
            Sach book = new Sach();
            book.Ma = int.Parse(dr["id"].ToString());
            book.Maloaisach = int.Parse(dr["idloaisach"].ToString());
            book.Tensach = dr["tensach"].ToString();
            book.Tacgia = dr["tacgia"].ToString();
            book.Gioithieu = dr["gioithieu"].ToString();

            return book;
        }
    }
}
