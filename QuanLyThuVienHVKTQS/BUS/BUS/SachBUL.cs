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
    public class SachBUL
    {
        private static SachBUL instance;

        public static SachBUL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachBUL();
                return SachBUL.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private SachBUL() { }

        public DataTable getAllSach ()
        {
            string query = "select * from Sach ";
            return DBConnect.Instance.Select(query);
        }

        public DataTable getByIdSach (string id)
        {
            string query = "select * from Sach where masach like '%'+@id+'%'";
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@id", id);

            return DBConnect.Instance.Select(query, paras);
        }

        public bool InsertSach (Sach book)
        {
            string query = "insert into Sach (tensach, idloaisach, noibo, masach, tacgia, gioithieu, trangthai) ";
            query += "values (@tensach, @loaisach, @noibo, @masach, @tacgia, @gioithieu, @trangthai) ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tensach", book.Tensach);
            para.Add("@loaisach", book.Maloaisach);
            para.Add("@noibo", book.Noibo);
            para.Add("@masach", book.Masach);
            para.Add("@tacgia", book.Tacgia);
            para.Add("@gioithieu", book.Gioithieu);
            para.Add("@trangthai", book.Trangthai);

            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }

        public bool UpdateSach (Sach book)
        {
            string query = " update Sach ";
            query += " set tensach = @tensach, idloaisach = @loaisach, noibo = @noibo,";
            query += " masach = @masach, tacgia = @tacgia, gioithieu = @gioithieu, trangthai = @trangthai";
            query += " where id = @id";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@id", book.Ma);
            para.Add("@tensach", book.Tensach);
            para.Add("@loaisach", book.Maloaisach);
            para.Add("@noibo", book.Noibo);
            para.Add("@masach", book.Masach);
            para.Add("@tacgia", book.Tacgia);
            para.Add("@gioithieu", book.Gioithieu);
            para.Add("@trangthai", book.Trangthai);

            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }

        public bool Delete (int id)
        {
            string query = " delete Sach ";
            query += " where id = @id";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@id", id);

            if (DBConnect.Instance.InsertUpdateDelete(query, para))
                return true;
            return false;
        }
    }
}
