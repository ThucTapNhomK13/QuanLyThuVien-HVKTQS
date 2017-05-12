using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;

namespace QuanLyThuVienHVKTQS
{
    public partial class fInformationUser : Form
    {
        private NhanSu _nhansu;

        public NhanSu Nhansu
        {
            private get
            {
                return _nhansu;
            }

            set
            {
                _nhansu = value;
            }
        }

        public fInformationUser()
        {
            InitializeComponent();
        }

        private void LoadUser ()
        {
            lblMa.Text = Nhansu.Ma.ToString();
            lblHoTen.Text = Nhansu.Hoten.ToString();
            lblNgaySinh.Text = string.Format("{0:dd/MM/yyyy}",Nhansu.Ngaysinh);

            lblGioiTinh.Text = Nhansu.Gioitinh;

            string Name = Nhansu.Anhdaidien.ToString();
            if (!string.IsNullOrEmpty(Name))
            {
                // Cách 1
                //string url = TypeDTO.Instance.UrlAvata + @"QuanLyThuVien-HVKTQS\QuanLyThuVienHVKTQS\QuanLyThuVienHVKTQS\Anh\";
                //string urlAvata = url + Name;
                //picAvata.Image = Image.FromFile(urlAvata);

                // Cách 2
                picAvata.Image = new Bitmap(Application.StartupPath + "\\Anh\\" + Name);
            }

        }
        private void fInformationUser_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
