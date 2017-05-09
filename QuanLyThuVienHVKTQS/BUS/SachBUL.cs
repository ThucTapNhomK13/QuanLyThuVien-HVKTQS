<<<<<<< HEAD
﻿using System;
=======
<<<<<<< HEAD
﻿using System;
=======
﻿using DAO;
using DTO;
using System;
>>>>>>> origin/master
>>>>>>> origin/master
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master

using System.Data;
using System.Data.SqlClient;

using DAO;
using DTO;
<<<<<<< HEAD
=======
=======
using System.Data.SqlClient;
using System.Data;
>>>>>>> origin/master
>>>>>>> origin/master

namespace BUL
{
    public class SachBUL
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
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
<<<<<<< HEAD
=======
=======
        public bool insertSach(Sach book)
        {
            string query = " insert into Sach ";
            query += " (idloaisach, tensach, tacgia, gioithieu) ";
            query += " values (@idloaisach, @tensach, @tacgia, @gioithieu) ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@idloaisach", book.Maloaisach);
            paras.Add("@tensach", book.Tensach);
            paras.Add("@tacgia", book.Tacgia);
            paras.Add("@gioithieu", book.Gioithieu);

            return DBConnect.Instance.InsertUpdateDelete(query, paras);
        }

        public bool updateSach(Sach book)
        {
            string query = " update Sach ";
            query += " set tensach = @tensach, tacgia = @tacgia, gioithieu = @gioithieu ";
            query += " where id = @ma";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@ma", book.Ma);
            paras.Add("@tensach", book.Tensach);
            paras.Add("@tacgia", book.Tacgia);
            paras.Add("@gioithieu", book.Gioithieu);

            return DBConnect.Instance.InsertUpdateDelete(query, paras);
        }

        public bool deleteSach(string id)
        {
            string query = " delete Sach ";
            query += " where id = @id";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@id", id);

            return DBConnect.Instance.InsertUpdateDelete(query, para);
        }

        public DataTable GetAllBook()
        {
            string query = "select s.id, s.idloaisach, s.tensach, s.noibo, s.masach, s.tacgia, s.gioithieu, l.soluong, s.trangthai from Sach s inner join LoaiSach l on s.idloaisach = l.id";

            return DBConnect.Instance.Select(query, null);
        }

        public DataTable GetMaLoaiSach()
        {
            string query = "select l.id from LoaiSach l";
            return DBConnect.Instance.Select(query, null);
>>>>>>> origin/master
>>>>>>> origin/master
        }
    }
}
