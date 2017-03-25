using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnect
    {
        private static DBConnect instance;

        public static DBConnect Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnect();
                return DBConnect.instance;   
            }

            private set
            {
                instance = value;
            }
        }

        private DBConnect() {  }

        public DataTable Select (string query , Dictionary<string, object> paras = null)
        {
            using (SqlConnection con = new SqlConnection(ConnectStr.conStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        if (paras != null)
                            foreach (var item in paras)
                                cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                        cmd.CommandType = CommandType.Text;

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            return dt;
                        }

                            
                    }
                }
            }
        }

        public bool InsertUpdateDelete (string query , Dictionary<string, object> paras)
        {
            using (SqlConnection con = new SqlConnection(ConnectStr.conStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    foreach (var item in paras)
                        cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
