using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoBUL
    {
        private static KhoBUL instance;

        public static KhoBUL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoBUL();
                return KhoBUL.instance;
            }

            private set
            {
                instance = value;
            }
        }

        public KhoBUL() { }

        public DataTable getAll()
        {
            string query = "select * from Kho ";
            return DBConnect.Instance.Select(query);
        }

        public DataTable getByName(string tenkho)
        {
            string query = "select * from Kho where tenkho = @tenkho";
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@tenkho", tenkho);

            return DBConnect.Instance.Select(query, paras);
        }

        public bool InsertKho(Kho _kho)
        {
            string query = "insert into Kho (tenkho, vitri) ";
            query += "values (@tenkho, @vitri) ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tenkho", _kho.Tenkho);
            para.Add("@vitri", _kho.Vitri);

            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }

        public bool UpdateKho(Kho _kho)
        {
            string query = " update kho ";
            query += " set vitri = @vitri";
            query += " where tenkho = @tenkho";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tenkho", _kho.Tenkho);
            para.Add("@vitri", _kho.Vitri);
            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }

        public bool Delete(string tenkho)
        {
            string query = " delete Kho ";
            query += " where tenkho = @tenkho";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tenkho", tenkho);

            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }
    }
}
