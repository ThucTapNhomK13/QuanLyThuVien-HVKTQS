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

        List<LoaiSach> lsLoaiSach = LoaiSachBUL.Instance.ListLoaiSach();
        Sach book = new Sach();


        public fMain()
        {
            InitializeComponent();
            
        }

        
        private void LoadSach ()
        {
            dgvSach.DataSource = SachBUL.Instance.getAllSach();
            //dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadLoaiSach(cmbLoaiSach);
        }

        private void LoadLoaiSach (ComboBox cmb)
        {
            cmb.DataSource = lsLoaiSach;
            cmb.DisplayMember = "Tenloaisach";
            cmb.ValueMember = "Ma";
        }

        //private void getById (int id)
        //{
        //    var ls = (from n in lsLoaiSach where n.Ma == id select n).ToList();
        //    cmbLoaiSach.DataSource = ls;
        //    cmbLoaiSach.DisplayMember = "Tenloaisach";
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

            LoadSach();
            
            
        }
        private void ImenuThongTinTK_Click(object sender, EventArgs e)
        {
            
            using (fInformationUser frmInfoUser = new fInformationUser())
            {
                frmInfoUser.Nhansu = Session.User;
                frmInfoUser.ShowDialog();
            }
            
        }
        private void ImenuQuanLyNhanSu_Click(object sender, EventArgs e)
        {
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
        private void ImenuThanhVien_Click(object sender, EventArgs e)
        {

        }
        private void ImenuHelp_Click(object sender, EventArgs e)
        {

        }
        private void ImenuVersion_Click(object sender, EventArgs e)
        {

        }
        private Sach SetSach (Sach book)
        {
           
            
            book.Masach = txtMa.Text;
            book.Tensach = txtTen.Text;
            book.Tacgia = txtTacGia.Text;
            book.Gioithieu = txtGioiThieu.Text;

            bool noibo = ckbNoiBo.Checked;
            book.Noibo = (noibo) ? 1 : 0;

            book.Trangthai = cmbTinhTrang.Text;
            book.Maloaisach = (cmbLoaiSach.SelectedItem as LoaiSach).Ma;

            return book;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (SachBUL.Instance.InsertSach(SetSach(book)))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSach();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnTKSach_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = SachBUL.Instance.getByIdSach(txtTKSach.Text);
        }
        private void ImenuMuonTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fMuonTraSach frmMTS = new fMuonTraSach())
            {
               
                frmMTS.ShowDialog();
            }
            this.Show();
        }
        private void ImenuHome_Click(object sender, EventArgs e)
        {
            LoadSach();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvSach.SelectedRows[0].Index;
            int id = int.Parse(dgvSach["clId", selectIndex].Value.ToString());

            if (SachBUL.Instance.Delete(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSach();

            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = dgvSach.SelectedRows[0].Index;

            txtMa.Text = dgvSach["clMaSach", selectIndex].Value.ToString();
            txtTen.Text = dgvSach["clTen", selectIndex].Value.ToString();
            txtTacGia.Text = dgvSach["clTacGia", selectIndex].Value.ToString();

            int noibo = int.Parse(dgvSach["clNoiBo", selectIndex].Value.ToString());
            if (noibo == 1)
                ckbNoiBo.Checked = true;
            else
                ckbNoiBo.Checked = false;

            txtGioiThieu.Text = dgvSach["clGioiThieu", selectIndex].Value.ToString();

            int loaisach = int.Parse(dgvSach["clLoaiSach", selectIndex].Value.ToString());
            //if (cmbLoaiSach.ValueMember == loaisach.ToString())
            //    cmbLoaiSach.DisplayMember = cmbLoaiSach.SelectedItem[loaisach]
            //getById(loaisach);
        }
        private void btnSau_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvSach.SelectedRows[0].Index;
            book.Ma = int.Parse(dgvSach["clId", selectIndex].Value.ToString());

            if (SachBUL.Instance.UpdateSach(SetSach(book)))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSach();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtGioiThieu.Clear();
            txtMa.Clear();
            txtTen.Clear();
            txtTacGia.Clear();

            LoadLoaiSach(cmbLoaiSach);
        }
    }
}
