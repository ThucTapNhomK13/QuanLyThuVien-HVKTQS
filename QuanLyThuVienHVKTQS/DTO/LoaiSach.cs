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
        private int _noibo;
        private int _machude;

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

        public int Machude
        {
            get
            {
                return _machude;
            }

            set
            {
                _machude = value;
            }
        }

        public LoaiSach() { }

        public LoaiSach (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Soluong = int.Parse(dr["soluong"].ToString());
            Noibo = int.Parse(dr["noibo"].ToString());
            Machude = int.Parse(dr["idchude"].ToString());
        }
    }
}
