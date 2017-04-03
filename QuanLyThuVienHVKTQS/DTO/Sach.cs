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
        private int _maloaisach;

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

        public int Maloaisach
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

        public Sach() { }

        public Sach (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Tensach = dr["tensach"].ToString();
            Maloaisach = int.Parse( dr["idloaisach"].ToString());
        }


    }
}
