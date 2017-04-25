using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienHVKTQS
{
    public partial class fBook : Form
    {
        public fBook()
        {
            InitializeComponent();
        }

        public void LoadSach(Sach book)
        {
            txtTenSach.Text = book.Tensach;
            txtTacGia.Text = book.Tacgia;
            txtGioiThieu.Text = book.Gioithieu;
            txtNoiBo.Text = book.Noibo;
            txtSoLuong.Text = book.Soluong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogresult==DialogResult.Yes)
                this.Close();
        }
    }
}
