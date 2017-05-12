using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class LoaiSach
    {
        private int _ma;
        private int _soluong;
        private string _idkho;
        private string _tenloaisach;

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

        public int Soluong
        {
            get
            {
                return _soluong;
            }

            set
            {
                _soluong = value;
            }
        }

        public string Idkho
        {
            get
            {
                return _idkho;
            }

            set
            {
                _idkho = value;
            }
        }

        public string Tenloaisach
        {
            get
            {
                return _tenloaisach;
            }

            set
            {
                _tenloaisach = value;
            }
        }

        public LoaiSach() { }

        public LoaiSach (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Soluong = int.Parse(dr["soluong"].ToString());
            Idkho = dr["idkho"].ToString();
            Tenloaisach = dr["loaisach"].ToString();
        }


    }
}
