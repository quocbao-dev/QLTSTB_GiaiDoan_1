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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void DieuChinhMauMenu(object sender)
        {
            Color màuCamNhạt = Color.FromArgb(255, 197, 120);
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.ForeColor = Color.White;
                }
            }
            Button btnHienTai = (Button)sender;
            btnHienTai.ForeColor = màuCamNhạt;
        }

        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDashBoard.Controls.Add(childForm);
            panelDashBoard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Button Thiết bị
        private void btnThietBi_Click_1(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmThietBi());
        }

        // Button Phòng ban
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmPhongBan());
        }

        // Button Loại thiết bị
        private void btnLoaiThietBi_Click(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmLoaiThietBi());
        }

        // Button Nhân viên
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmNhanVien());
        }

        // Button Cấp phát
        private void btnCapPhat_Click(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmCapPhat());
        }

        // Button Thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DieuChinhMauMenu(sender);
            OpenChildForm(new frmThongKe());
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            btnNhanVien.Visible = PhanQuyen.IsAdmin();
            btnPhongBan.Visible = PhanQuyen.IsAdmin();
            lblUser.Text = $"User: {PhanQuyen.CurrentUser} ({PhanQuyen.QuyenHan})";
        }
    }

}
