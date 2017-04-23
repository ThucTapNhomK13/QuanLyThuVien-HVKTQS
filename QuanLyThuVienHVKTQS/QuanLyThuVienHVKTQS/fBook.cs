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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo);
            if(dialogresult==DialogResult.Yes)
                this.Close();
        }
    }
}
