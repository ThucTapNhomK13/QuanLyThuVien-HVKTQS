using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DAO;
using DTO;

namespace BUL
{
    public class LoaiSachBUL
    {
        private static LoaiSachBUL instance;

        public static LoaiSachBUL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiSachBUL();
                return LoaiSachBUL.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LoaiSachBUL() { }

        public DataTable getAllLoaiSach()
        {
            string query = "select * from LoaiSach";
            return DBConnect.Instance.Select(query);
        }

        public List<LoaiSach> ListLoaiSach ()
        {
            List<LoaiSach> lsLS = new List<LoaiSach>();

            DataTable dt = getAllLoaiSach();

            foreach(DataRow item in dt.Rows)
            {
                lsLS.Add(new LoaiSach(item));
            }

            return lsLS;
        }
    }
}
