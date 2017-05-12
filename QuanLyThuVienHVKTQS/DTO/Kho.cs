using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class Kho
    {
        private string _tenkho;
        private string _vitri;

        public string Tenkho
        {
            get
            {
                return _tenkho;
            }

            set
            {
                _tenkho = value;
            }
        }

        public string Vitri
        {
            get
            {
                return _vitri;
            }

            set
            {
                _vitri = value;
            }
        }


        public Kho() { }
        public Kho(DataRow dr)
        {
            Tenkho = dr["tenkho"].ToString();
            Vitri = dr["vitri"].ToString();
        }

    }
}
