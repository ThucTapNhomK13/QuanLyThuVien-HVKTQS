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

        public DataTable TKMuonSach (string tukhoa)
        {
            string query = "select * from MuonTra ";
            query += " where idthethuvien like '%'+@tukhoa+'%'";
            query += " union ";
            query += " select * from MuonTra ";
            query += " where idsach like '%'+@tukhoa+'%'";

            //int id = int.Parse(tukhoa);
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tukhoa", tukhoa);

            return DBConnect.Instance.Select(query, para);
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
