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
    public partial class fPersonnel : Form
    {
        private NhanSu _nhansu = new NhanSu();

        public NhanSu Nhansu
        {
            get
            {
                return _nhansu;
            }

            set
            {
                _nhansu = value;
            }
        }
        public fPersonnel()
        {
            InitializeComponent();
        }

        private void ResetText()
        {
            txtHoTenNV.Clear();
            txtTKNV.Clear();
            txtMKNV.Clear();


            //string urlAvata = TypeDTO.Instance.UrlAvata;
            //urlAvata += @"QuanLyThuVien-HVKTQS\QuanLyThuVienHVKTQS\QuanLyThuVienHVKTQS\Anh\";
            //urlAvata += "Person.png";

            //picAvata.Image = Image.FromFile(urlAvata);

            picNV.Image = new Bitmap(Application.StartupPath + "\\Anh\\Person.png");
        }

        private void SetNhanSu()
        {
            Nhansu.Hoten = txtHoTenNV.Text;
            Nhansu.Ngaysinh = DateTime.Parse(dtpNSNV.Text);

            if (ckbQLNV.Checked)
                Nhansu.Quanly = 1;
            else
                Nhansu.Quanly = 0;

            if (rdbNamNV.Checked)
                Nhansu.Gioitinh = "Nam";
            else
                Nhansu.Gioitinh = "Nữ";

            Nhansu.Taikhoan = txtTKNV.Text;
            Nhansu.Matkhau = txtMKNV.Text;

            //string[] urlAvata = picAvata.ImageLocation.Split('\\');
            //MessageBox.Show(picAvata.ImageLocation.ToString());
        }

        private void LoadNhanSu()
        {
            dgvDSNV.DataSource = NhanSuBUL.Instance.getAllNhanSu();
            dgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        SachBUL _sach = new SachBUL();
        private void LoadKhoSach()
        {
            dgvKhoSach.DataSource = _sach.GetAllBook();
        }

        private void fPersonnel_Load(object sender, EventArgs e)
        {
            LoadNhanSu();
            dgvDSNV.ClearSelection();
            LoadKhoSach();
            dgvKhoSach.ClearSelection();
        }


        private void btnAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFD = new OpenFileDialog();
            OpenFD.Filter = "Images only. |*.jpg; *.png";

            DialogResult dr = OpenFD.ShowDialog();

            picNV.ImageLocation = OpenFD.FileName;
            //picAvata.Image = Image.FromFile(OpenFD.FileName);

            string[] urlAvata = OpenFD.FileName.Split('\\');

            Nhansu.Anhdaidien = urlAvata[urlAvata.Length - 1];
        }

        private void btnNhapLaiNV_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void btnGhiNV_Click(object sender, EventArgs e)
        {
            SetNhanSu();
            if (NhanSuBUL.Instance.insertNhanSu(Nhansu))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanSu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            SetNhanSu();
            if (NhanSuBUL.Instance.updateNhanSu(Nhansu))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanSu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvDSNV.SelectedRows[0].Index;
            string id = dgvDSNV[0, selectIndex].Value.ToString();

            if (NhanSuBUL.Instance.deleteNhanSu(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanSu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDSNV.SelectedRows)
            {
                txtHoTenNV.Text = row.Cells["clHoTen"].Value.ToString();
                dtpNSNV.Text = row.Cells["clNgaySinh"].Value.ToString();

                string gt = row.Cells["clGioiTinh"].Value.ToString();
                if (gt == "Nam" || gt == "nam")
                    rdbNamNV.Checked = true;
                else
                    rdbNuNV.Checked = true;

                txtTKNV.Text = row.Cells["clTaiKhoan"].Value.ToString();
                txtMKNV.Text = row.Cells["clMatKhau"].Value.ToString();

                int ql = int.Parse(row.Cells["clQuanLy"].Value.ToString());
                if (ql == 1)
                    ckbQLNV.Checked = true;
                else
                    ckbQLNV.Checked = false;

                string anh = row.Cells["clAnh"].Value.ToString();
                if (!string.IsNullOrEmpty(anh) && anh != " ")
                    picNV.Image = new Bitmap(Application.StartupPath + "\\Anh\\" + anh);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            using (fBook frm = new fBook())
            {
                frm.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi để xóa!");
                return;
            }
            else
                foreach (DataGridViewRow dgr in dgvKhoSach.Rows)
                {
                    if (dgr.Selected)
                    {
                        DialogResult dialogresult = MessageBox.Show("Tựa sách " + dgr.Cells["tensach"].Value.ToString() + " sẽ bị xóa!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogresult == DialogResult.Yes)
                        {
                            if (_sach.deleteSach(dgr.Cells[0].Value.ToString()))
                            {
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                LoadKhoSach();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chọn bản ghi cần sửa!");
                return;
            }
            else
            {
                foreach (DataGridViewRow dgr in dgvKhoSach.SelectedRows)
                {
                    Sach book = new Sach();
                    book.Ma = int.Parse(dgr.Cells["id"].Value.ToString());
                    book.Maloaisach = int.Parse(dgr.Cells["idloaisach"].Value.ToString());
                    book.Tensach = dgr.Cells["tensach"].Value.ToString();
                    book.Tacgia = dgr.Cells["tacgia"].Value.ToString();
                    book.Gioithieu = dgr.Cells["gioithieu"].Value.ToString();
                    book.Noibo = dgr.Cells["noibo"].Value.ToString();
                    book.Soluong = int.Parse(dgr.Cells["soluong"].Value.ToString());
                    book.Trangthai = dgr.Cells["trangthai"].Value.ToString();
                    fBook frmBook = new fBook();
                    frmBook.LoadSach(book);
                    frmBook.ShowDialog();
                }
            }
        }

        private void tabQuanLi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabQuanLi.SelectedIndex == 0)
            {
                LoadNhanSu();
                dgvDSNV.ClearSelection();
            }
            if (tabQuanLi.SelectedIndex == 1)
            {
                LoadKhoSach();
                dgvKhoSach.ClearSelection();
            }
        }
    }
}
