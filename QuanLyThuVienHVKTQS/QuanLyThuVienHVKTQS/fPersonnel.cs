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
using BUS;

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
            int selectIndex = dgvDSNV.SelectedRows[0].Index;
            int id = int.Parse(dgvDSNV[0, selectIndex].Value.ToString());
            Nhansu.Ma = id;

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

            //int selectIndex = dgvDSNV.SelectedRows[0].Index;
            //string anh = dgvDSNV["clAnh", selectIndex].Value.ToString();
            //if (!string.IsNullOrEmpty(anh) && anh != " ")
            //    picNV.Image = new Bitmap(Application.StartupPath + "\\Anh\\" + anh);

        }

        private void LoadNhanSu()
        {
            dgvDSNV.DataSource = NhanSuBUL.Instance.getAllNhanSu();
            dgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        KhoBUL _kho = new KhoBUL();
        private void LoadKhoSach()
        {
            dgvKhoSach.DataSource = _kho.getAll();
            dgvKhoSach.ClearSelection();
        }


        private void fPersonnel_Load(object sender, EventArgs e)
        {
            LoadNhanSu();
            LoadKhoSach();
            btnThem.Enabled = false;
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

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {

            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKho.Text=="")
            {
                MessageBox.Show("Chưa nhập tên kho!");
                txtTenKho.Focus();
            }
            else if(txtViTri.Text=="")
            {
                MessageBox.Show("Chưa nhập vị trí!");
                txtViTri.Focus();
            }
            else
            {
                Kho _kho = new Kho { Tenkho = txtTenKho.Text, Vitri = txtViTri.Text };
                if (KhoBUL.Instance.InsertKho(_kho))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhoSach();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Kho _kho = new Kho { Tenkho = txtTenKho.Text, Vitri = txtViTri.Text };
                if (KhoBUL.Instance.UpdateKho(_kho))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhoSach();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        DialogResult dialogresult = MessageBox.Show("Kho sách " + dgr.Cells["tenkho"].Value.ToString() + " sẽ bị xóa!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogresult == DialogResult.Yes)
                        {
                            if (KhoBUL.Instance.Delete(dgr.Cells[0].Value.ToString()))
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

        private void dgvKhoSach_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvKhoSach.SelectedRows)
            {
                txtTenKho.Text = row.Cells["tenkho"].Value.ToString();
                txtTenKho.Enabled = false;
                txtViTri.Text = row.Cells["vitri"].Value.ToString();
                btnThem.Enabled = false;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtTenKho.Enabled = true;
            txtTenKho.Clear();
            txtViTri.Clear();
            txtTenKho.Focus();
        }

        private void txtTKNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKNhanVien.Text))
            {
                LoadNhanSu();
            }
            else
            {
                dgvDSNV.DataSource = NhanSuBUL.Instance.getByIdNS(txtTKNhanVien.Text);
            }
            
        }
    }
}
