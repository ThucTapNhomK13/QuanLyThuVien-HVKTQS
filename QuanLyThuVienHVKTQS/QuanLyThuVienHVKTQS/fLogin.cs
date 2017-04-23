using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUL;

namespace QuanLyThuVienHVKTQS
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseAction()
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (NhanSuBUL.Instance.checkTaiKhoan(txtUser.Text, txtPass.Text))
            {
                fMain frm = new fMain();
                //frm.Nhansu = NhanSuBUL.Instance.TaiKhoan(txtUser.Text, txtPass.Text);
                Session.User = NhanSuBUL.Instance.TaiKhoan(txtUser.Text, txtPass.Text);
                Session.UserRole = "USER";

                this.Hide();

                frm.closeForm += CloseAction;
                frm.Show();
            }
            //if (NhanSuBUL.Instance.checkTaiKhoan(txtUser.Text, txtPass.Text))
            //{
            //    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //this.Hide();
            //    fMain frmMain = new fMain();

            //        frmMain.Nhansu = NhanSuBUL.Instance.TaiKhoan(txtUser.Text, txtPass.Text);
            //        frmMain.closeForm += CloseAction;
            //        frmMain.Show();
            //        this.txtUser.Clear();
            //        this.txtPass.Clear();

            //    //this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        #region Move Form

        private bool mv;
        private int x;
        private int y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mv = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        #endregion

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
