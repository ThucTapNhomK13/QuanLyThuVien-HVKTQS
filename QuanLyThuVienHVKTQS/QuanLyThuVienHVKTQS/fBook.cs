using BUL;
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
        SachBUL sachBUL = new SachBUL();
        public int Ma;
        public bool IsThemMoi = false;
        public fBook()
        {
            InitializeComponent();
        }

        public void LoadSach(Sach book)
        {
            txtTenSach.Text = book.Tensach;
            txtTacGia.Text = book.Tacgia;
            txtGioiThieu.Text = book.Gioithieu;
        }

        public void LoadMaLoaiSach()
        {
            cmbMaLoaiSach.DataSource = sachBUL.GetMaLoaiSach();
            cmbMaLoaiSach.DisplayMember = "id";
            cmbMaLoaiSach.ValueMember = "id";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
                this.Close();
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            Sach book = new Sach();
            if (IsThemMoi)
            {
                book.Maloaisach = int.Parse(cmbMaLoaiSach.Text.ToString());
                book.Tensach = txtTenSach.Text.ToString();
                book.Tacgia = txtTacGia.Text.ToString();
                book.Gioithieu = txtGioiThieu.Text.ToString();
                bool success = sachBUL.insertSach(book);
                if(success)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                book.Ma = Ma;
                book.Tensach = txtTenSach.Text.ToString();
                book.Tacgia = txtTacGia.Text.ToString();
                book.Gioithieu = txtGioiThieu.Text.ToString();
                bool success = sachBUL.updateSach(book);
                if (success)
                {
                    MessageBox.Show("Sửa thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void fBook_Load(object sender, EventArgs e)
        {
            LoadMaLoaiSach();
        }
    }
}
