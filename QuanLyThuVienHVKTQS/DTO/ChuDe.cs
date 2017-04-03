using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class ChuDe
    {
        private int _ma;
        private string _tenchude;
        private int _soluong;
        private int _makho;
        

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

        public string Tenchude
        {
            get
            {
                return _tenchude;
            }

            set
            {
                _tenchude = value;
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

        public int Makho
        {
            get
            {
                return _makho;
            }

            set
            {
                _makho = value;
            }
        }

        public ChuDe() { }

        public ChuDe(DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Tenchude = dr["tenchude"].ToString();
            Soluong = int.Parse(dr["soluong"].ToString());
            Makho = int.Parse(dr["idkhoa"].ToString());
        }


    }
}
