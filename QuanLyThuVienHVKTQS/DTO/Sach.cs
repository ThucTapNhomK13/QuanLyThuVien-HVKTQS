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
        private string _tacgia;
        private string _gioithieu;

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

        public int Maloaisach
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
