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

        public bool insertNhanSu(NhanSu ns)
        {
            string query = " insert into NhanSu ";
            query += " (ten, ngaysinh, anhdaidien, gioitinh, taikhoan, matkhau, quanly) ";
            query += " values (@ten, @ngaysinh, @anhdaidien, @gioitinh, @taikhoan, @matkhau, @quanly) ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@ten", ns.Hoten);
            paras.Add("@ngaysinh", ns.Ngaysinh);
            paras.Add("@anhdaidien", ns.Anhdaidien);
            paras.Add("@gioitinh", ns.Gioitinh);
            paras.Add("@taikhoan", ns.Taikhoan);
            paras.Add("@matkhau", ns.Matkhau);
            paras.Add("@quanly", ns.Quanly);

            return DBConnect.Instance.InsertUpdateDelete(query, paras);
        }

        public bool updateNhanSu (NhanSu ns)
        {
            string query = " update NhanSu ";
            query += " set ten = @ten, ngaysinh = @ngaysinh, anhdaidien = @anhdaidien,  ";
            query += " gioitinh = @gioitinh, taikhoan = @taikhoan, matkhau = @matkhau, quanly = @quanly ";
            query += " where id = @ma";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@ma", ns.Ma);
            paras.Add("@ten", ns.Hoten);
            paras.Add("@ngaysinh", ns.Ngaysinh);
            paras.Add("@anhdaidien", ns.Anhdaidien);
            paras.Add("@gioitinh", ns.Gioitinh);
            paras.Add("@taikhoan", ns.Taikhoan);
            paras.Add("@matkhau", ns.Matkhau);
            paras.Add("@quanly", ns.Quanly);

            return DBConnect.Instance.InsertUpdateDelete(query, paras);
        }

        //public DataTable searchNhanSu(string ns)
        //{
        //    string query = " select * from NhanSu ";
        //    query += " where id = @id ";
        //    query += " ";

        //    Dictionary<string, object> para = new Dictionary<string, object>();
        //    para.Add("@id", int.Parse(ns));
        //}

        public bool deleteNhanSu (string id)
        {
            string query = " delete NhanSu ";
            query += " where id = @id";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@id", id);

            return DBConnect.Instance.InsertUpdateDelete(query, para);
        }
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
