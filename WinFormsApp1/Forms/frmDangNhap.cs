using QLTSTB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTB.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (PhanQuyen.Login(txtTenDN.Text, txtMatKhau.Text))
            {
                MessageBox.Show($"Đăng nhập thành công! {PhanQuyen.CurrentUser}");
                new frmDashBoard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản/mật khẩu!");
            }
        }
    }
}
