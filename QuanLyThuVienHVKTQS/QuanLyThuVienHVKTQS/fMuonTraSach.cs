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
using DTO;

namespace QuanLyThuVienHVKTQS
{
    public partial class fMuonTraSach : Form
    {
        public fMuonTraSach()
        {
            InitializeComponent();
        }

        private MuonTra getMuon ()
        {
            MuonTra mt = new MuonTra();
            mt.Masach = txtMSach.Text;
            mt.Manhansu = int.Parse(txtNVMuon.Text);
            mt.Thethuvien = int.Parse(txtNMMuon.Text);
            mt.Ngaymuon = dtpNgayMuon.Value;
            mt.Hanmuon = dtpHanMuon.Value;

            return mt;
        }

        private MuonTra getTra ()
        {
            MuonTra mt = new MuonTra();
            int select = dgvDSTra.SelectedRows[0].Index;

            mt.Ma = int.Parse(dgvDSTra["clTma", select].Value.ToString());
            mt.Ngaytra = dtpNgayTra.Value;

            return mt;
        }
        private void LoadMuon()
        {
            dgvDSMuon.DataSource = MuonTraBUL.Instance.getAllMuonTra();
        }
        private void LoadTra ()
        {
            dgvDSTra.DataSource = MuonTraBUL.Instance.getAllMuonTra();
        }
        private void fMuonTraSach_Load(object sender, EventArgs e)
        {
            LoadMuon();
            LoadTra();
        }
        
        private void dgvDSMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = dgvDSMuon.SelectedRows[0].Index;

            txtNMMuon.Text = dgvDSMuon["clnguoimuon", selectIndex].Value.ToString();
            txtNVMuon.Text = dgvDSMuon["clnhanvien", selectIndex].Value.ToString();
            txtMSach.Text = dgvDSMuon["clMSach", selectIndex].Value.ToString();
            dtpNgayMuon.Value = DateTime.Parse(dgvDSMuon["clngaymuon", selectIndex].Value.ToString());
            dtpHanMuon.Value = DateTime.Parse(dgvDSMuon["clhanmuon", selectIndex].Value.ToString());
        }

        private void dgvDSTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = dgvDSTra.SelectedRows[0].Index;

            txtTSach.Text = dgvDSTra["clTsach", selectIndex].Value.ToString();
            txtNMTra.Text = dgvDSTra["clTnguoimuon", selectIndex].Value.ToString();
            txtNVTra.Text = dgvDSTra["clTnhanvien", selectIndex].Value.ToString();

            string ngaytra = dgvDSTra["clTngaytra", selectIndex].Value.ToString();
            if (!string.IsNullOrEmpty(ngaytra) && ngaytra != " ")
                dtpNgayTra.Value = DateTime.Parse(dgvDSTra["clTngaytra", selectIndex].Value.ToString());
        }

        private void btnNLTra_Click(object sender, EventArgs e)
        {

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (MuonTraBUL.Instance.TraSach(getTra()))
            {
                MessageBox.Show("Đã trả sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTra();
                LoadMuon(); // Mượn sẽ không được update mới
            }
            else
                return;
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (MuonTraBUL.Instance.MuonSach(getMuon()))
            {
                MessageBox.Show("Hạn mượn: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMuon();
                LoadTra();  // Ở bên trả sách sẽ không xuất hiện khi thêm mới 1 dữ liệu
            }
            else
                return;
        }

        private void btnNLMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnTKMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnTKTra_Click(object sender, EventArgs e)
        {

        }

        private void txtTKMuon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKMuon.Text))
            {
                LoadMuon();
            }
            else
            {
                dgvDSMuon.DataSource = MuonTraBUL.Instance.TKMuonSach(txtTKMuon.Text.Trim());
            }
        }

        private void txtTKTra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKTra.Text))
            {
                LoadTra();
            }
            else
            {
                dgvDSTra.DataSource = MuonTraBUL.Instance.TKMuonSach(txtTKTra.Text.Trim());
            }
        }
    }
}
