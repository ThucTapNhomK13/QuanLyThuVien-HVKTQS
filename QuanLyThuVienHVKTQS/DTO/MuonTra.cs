using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class MuonTra
    {
        private int _ma;
        private DateTime _ngaymuon;
        private DateTime? _hanmuon;
        private DateTime? _ngaytra;

        private int _manhansu;
        private int _thethuvien;
        private string _masach;

        public int Ma
        {
            get
            {
                return _ma;
            }

            set
            {
                _ma = value;
            }
        }

        public DateTime Ngaymuon
        {
            get
            {
                return _ngaymuon;
            }

            set
            {
                _ngaymuon = value;
            }
        }

        public DateTime? Hanmuon
        {
            get
            {
                return _hanmuon;
            }

            set
            {
                _hanmuon = value;
            }
        }

        public DateTime? Ngaytra
        {
            get
            {
                return _ngaytra;
            }

            set
            {
                _ngaytra = value;
            }
        }

        public int Manhansu
        {
            get
            {
                return _manhansu;
            }

            set
            {
                _manhansu = value;
            }
        }

        public int Thethuvien
        {
            get
            {
                return _thethuvien;
            }

            set
            {
                _thethuvien = value;
            }
        }

        public string Masach
        {
            get
            {
                return _masach;
            }

            set
            {
                _masach = value;
            }
        }

        public MuonTra() { }

        public MuonTra (DataRow dr)
        {
            Ma = int.Parse(dr["id"].ToString());
            Ngaymuon = DateTime.Parse(dr["ngaymuon"].ToString());

            string ngaytra = dr["ngaytra"].ToString();
            if (ngaytra != " " && !string.IsNullOrEmpty(ngaytra))
                Ngaytra = DateTime.Parse(dr["ngaytra"].ToString());

            string hanmuon = dr["hanmuon"].ToString();
            if (hanmuon != " " && !string.IsNullOrEmpty(hanmuon))
                Hanmuon = DateTime.Parse(dr["hanmuon"].ToString());

            Manhansu = int.Parse(dr["idnhansu"].ToString());
            Thethuvien = int.Parse(dr["idthethuvien"].ToString());
            Masach = dr["idsach"].ToString();
        }
    }
}
