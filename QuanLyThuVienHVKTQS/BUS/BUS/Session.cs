using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;

namespace BUL
{
    public class Session
    {
        public static NhanSu User { get; set; }
        public static string UserRole { get; set; }
        public static bool AllowUse(string role)
        {
            var arrQuyen = role.Split(',');

            if (User!=null)
            {
                
                if (arrQuyen.Contains(UserRole))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
