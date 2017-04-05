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
using BUL;

namespace QuanLyThuVienHVKTQS
{
    public partial class fMain : Form
    {
        private bool _move = false;
        private int _x, _y;
        private bool _quyen = false;
        private NhanSu ns;

        public bool Quyen
        {
            get
            {
                return _quyen;
            }

            set
            {
                _quyen = value;
            }
        }

        public NhanSu Ns
        {
            get
            {
                return ns;
            }

            set
            {
                ns = value;
            }
        }

        public fMain()
        {
            InitializeComponent();
        }

        private void PhanQuyen ()
        {
            if (int.Parse(Ns.Quanly.ToString()) == 1)
            {
                ImenuQuanLyNhanSu.Enabled = true;
                _quyen = true;
            }
            else
                ImenuQuanLyNhanSu.Enabled = false;
        }
        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //PhanQuyen();
        }

        private void ImenuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImenuThongTinTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fInformationUser frmInfoUser = new fInformationUser())
            {
                frmInfoUser.ShowDialog();
            }
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fBook frmBook = new fBook())
            {
                frmBook.ShowDialog();
            }
            this.Show();
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fCard frmCard = new fCard())
            {
                frmCard.ShowDialog();
            }
            this.Show();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fLoanPayment frmLP = new fLoanPayment())
            {
                frmLP.ShowDialog();
            }
            this.Show();
        }

        private void ImenuQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            PhanQuyen();
            if (_quyen)
            {
                this.Hide();
                using (fNhanSu frmNhanSu = new fNhanSu())
                {
                    frmNhanSu.ShowDialog();
                }
                this.Show();
            }
        }

        private void ImenuThanhVien_Click(object sender, EventArgs e)
        {

        }

        private void ImenuHelp_Click(object sender, EventArgs e)
        {

        }

        private void ImenuVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _move = true;
            _x = e.X;
            _y = e.Y;
        }

        private void fMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move)
                SetDesktopLocation(Cursor.Position.X - _x, Cursor.Position.Y - _y);
        }

        private void fMain_MouseUp(object sender, MouseEventArgs e)
        {
            _move = false;
        }

        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            _move = true;
            _x = e.X;
            _y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move)
                SetDesktopLocation(Cursor.Position.X - _x, Cursor.Position.Y - _y);
        }
    }
}
