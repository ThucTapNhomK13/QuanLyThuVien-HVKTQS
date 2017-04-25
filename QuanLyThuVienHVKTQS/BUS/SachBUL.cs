using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUL
{
    public class SachBUL
    {
        public bool insertSach(Sach book)
        {
            string query = " insert into Sach ";
            query += " (id, idloaisach, tacgia, gioithieu) ";
            query += " values (@id, @idloaisach, @tacgia, @gioithieu) ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@id", book.Ma);
            paras.Add("@idloaisach", book.Maloaisach);
            paras.Add("@tacgia", book.Tacgia);
            paras.Add("@gioithieu", book.Gioithieu);

            return DBConnect.Instance.InsertUpdateDelete(query, paras);
        }

        public bool updateSach(Sach book)
        {
            string query = " update Sach ";
            query += " set tensach = @tensach, tacgia = @tacgia, gioithieu = @gioithieu,  ";
            query += " trangthai = @trangthai ";
            query += " where id = @ma";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@ma", book.Ma);
            paras.Add("@tensach", book.Tensach);
            paras.Add("@tacgia", book.Tacgia);
            paras.Add("@gioithieu", book.Gioithieu);
            paras.Add("@trangthai", book.Trangthai);

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
    }
}
