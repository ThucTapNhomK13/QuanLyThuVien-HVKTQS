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
    public class NhanSuBUL
    {
        private static NhanSuBUL instance;

        public static NhanSuBUL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanSuBUL();
                return NhanSuBUL.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private NhanSuBUL() { }

        public DataTable getAllNhanSu ()
        {
            string query = "select * from NhanSu";

            return DBConnect.Instance.Select(query);
        }

        public bool checkTaiKhoan (string taikhoan, string matkhau)
        {
            string query = "select * from NhanSu ";
            query += " where taikhoan = @taikhoan and matkhau = @matkhau ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@taikhoan", taikhoan);
            paras.Add("@matkhau", matkhau);

            DataTable dt = DBConnect.Instance.Select(query, paras);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public NhanSu TaiKhoan (string taikhoan, string matkhau)
        {
            string query = "select * from NhanSu ";
            query += " where taikhoan = @taikhoan and matkhau = @matkhau ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@taikhoan", taikhoan);
            paras.Add("@matkhau", matkhau);

            DataTable dt = DBConnect.Instance.Select(query, paras);

            return new NhanSu(dt.Rows[0]);
        }
    }
}
