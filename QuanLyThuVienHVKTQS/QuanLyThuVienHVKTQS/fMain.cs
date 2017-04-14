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
        public delegate void closeFormHandle();
        public closeFormHandle closeForm;


        //private NhanSu _nhansu;

        //private bool _quyen = false;

        //public bool Quyen
        //{
        //    get
        //    {
        //        return _quyen;
        //    }

        //    set
        //    {
        //        _quyen = value;
        //    }
        //}

        //public NhanSu Nhansu
        //{
        //    private get
        //    {
        //        return _nhansu;
        //    }

        //    set
        //    {
        //        _nhansu = value;
        //    }
        //}

        public fMain()
        {
            InitializeComponent();
            
        }

        //private void PhanQuyen ()
        //{
        //    if (int.Parse(Nhansu.Quanly.ToString()) == 1)
        //    {
        //        ImenuQuanLyNhanSu.Enabled = true;
        //        _quyen = true;
        //    }
        //    else
        //        ImenuQuanLyNhanSu.Enabled = false;
        //}


        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeForm != null)
            {
                closeForm();
            }
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
            
            using (fInformationUser frmInfoUser = new fInformationUser())
            {
                //frmInfoUser.Nhansu = Nhansu;
                frmInfoUser.Nhansu = Session.User;
                frmInfoUser.ShowDialog();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            //if (!Session.AllowUse("ADMIN,USER")) return;
            
            this.Hide();
            using (fBook frmBook = new fBook())
            {
                frmBook.ShowDialog();
            }
            this.Show();
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            if (!Session.AllowUse("ADMIN"))
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            using (fCard frmCard = new fCard())
            {
                frmCard.ShowDialog();
            }
            this.Show();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            //if (!Session.AllowUse("USER")) return;

            this.Hide();
            using (fLoanPayment frmLP = new fLoanPayment())
            {
                frmLP.ShowDialog();
            }
            this.Show();
        }

        private void ImenuQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            //PhanQuyen();
            //if (_quyen)
            //{
            //    this.Hide();
            //    using (fPersonnel frmNhanSu = new fPersonnel())
            //    {
            //        frmNhanSu.ShowDialog();
            //    }
            //    this.Show();
            //}

            if (!Session.AllowUse("USER"))
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            using (fPersonnel frmNhanSu = new fPersonnel())
            {
                frmNhanSu.ShowDialog();
            }
            this.Show();

        }

        private void btnKho_Click(object sender, EventArgs e)
        {

        }

        private void btnMuonTra_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTheThuVien_Click(object sender, EventArgs e)
        {
            if (!Session.AllowUse("USER"))
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            using (fCard frmCard = new fCard())
            {
                frmCard.ShowDialog();
            }
            this.Show();

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

        #region Move Form

        private bool _move = false;
        private int _x, _y;

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

        #endregion
    }
}
