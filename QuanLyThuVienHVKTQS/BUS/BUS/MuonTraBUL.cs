using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DTO;
using DAO;

namespace BUL
{
    public class MuonTraBUL
    {
        private static MuonTraBUL instance;

        public static MuonTraBUL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MuonTraBUL();
                return MuonTraBUL.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private MuonTraBUL() { }

        public DataTable getAllMuonTra ()
        {
            string query = "select * from MuonTra";
            return DBConnect.Instance.Select(query);
        }

        private DataTable DataByIdMuon (string nguoimuon)
        {
            string query = "select * from MuonTra where idthethuvien = @nguoimuon ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@nguoimuon", nguoimuon);

            return DBConnect.Instance.Select(query, para);
        }

        public List<MuonTra> ModelByIdMuon (string idthethuvien)
        {
            List<MuonTra> ls = new List<MuonTra>();
            DataTable dt = DataByIdMuon(idthethuvien);
            foreach(DataRow row in dt.Rows)
            {
                MuonTra item = new MuonTra(row);
                ls.Add(item);
            }
            return ls;
        }

        public bool MuonSach (MuonTra mt)
        {
            string query = "insert into MuonTra (ngaymuon, hanmuon, idnhansu, idthethuvien, idsach) ";
            query += " values (@ngaymuon, @hanmuon, @idnhansu, @idthethuvien, @idsach )";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@ngaymuon", mt.Ngaymuon);
            paras.Add("@hanmuon", mt.Hanmuon);
            paras.Add("@idnhansu", mt.Manhansu);
            paras.Add("@idthethuvien", mt.Thethuvien);
            paras.Add("@idsach", mt.Masach);

            if (DBConnect.Instance.InsertUpdateDelete(query, paras))
                return true;
            return false;
        }

        public bool TraSach (MuonTra mt)
        {
            string query = "update MuonTra ";
            query += " set ngaytra = @ngaytra ";
            query += "where id = @id ";

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@id", mt.Ma);
            paras.Add("@ngaytra", mt.Ngaytra);
            

            if (DBConnect.Instance.InsertUpdateDelete(query, paras))
                return true;
            return false;
        }
    }
}
