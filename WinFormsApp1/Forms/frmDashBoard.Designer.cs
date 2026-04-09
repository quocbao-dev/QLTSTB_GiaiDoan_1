namespace QLTSTB.Forms
{
    partial class frmDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnCapPhat = new Button();
            btnPhongBan = new Button();
            btnLoaiThietBi = new Button();
            btnNhanVien = new Button();
            btnThietBi = new Button();
            button1 = new Button();
            panelDashBoard = new Panel();
            lblUser = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 77, 87);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnCapPhat);
            panel1.Controls.Add(btnPhongBan);
            panel1.Controls.Add(btnLoaiThietBi);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(btnThietBi);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 720);
            panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(34, 451);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(124, 29);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(31, 390);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(124, 29);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnCapPhat
            // 
            btnCapPhat.FlatAppearance.BorderSize = 0;
            btnCapPhat.FlatStyle = FlatStyle.Flat;
            btnCapPhat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapPhat.Location = new Point(31, 335);
            btnCapPhat.Name = "btnCapPhat";
            btnCapPhat.Size = new Size(124, 29);
            btnCapPhat.TabIndex = 6;
            btnCapPhat.Text = "Cấp Phát";
            btnCapPhat.UseVisualStyleBackColor = true;
            btnCapPhat.Click += btnCapPhat_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.FlatAppearance.BorderSize = 0;
            btnPhongBan.FlatStyle = FlatStyle.Flat;
            btnPhongBan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhongBan.Location = new Point(34, 166);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Size = new Size(124, 29);
            btnPhongBan.TabIndex = 5;
            btnPhongBan.Text = "Phòng Ban";
            btnPhongBan.UseVisualStyleBackColor = true;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // btnLoaiThietBi
            // 
            btnLoaiThietBi.FlatAppearance.BorderSize = 0;
            btnLoaiThietBi.FlatStyle = FlatStyle.Flat;
            btnLoaiThietBi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiThietBi.Location = new Point(46, 226);
            btnLoaiThietBi.Name = "btnLoaiThietBi";
            btnLoaiThietBi.Size = new Size(124, 29);
            btnLoaiThietBi.TabIndex = 4;
            btnLoaiThietBi.Text = "Loại Thiết Bị";
            btnLoaiThietBi.UseVisualStyleBackColor = true;
            btnLoaiThietBi.Click += btnLoaiThietBi_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhanVien.Location = new Point(40, 280);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(115, 29);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.FlatAppearance.BorderSize = 0;
            btnThietBi.FlatStyle = FlatStyle.Flat;
            btnThietBi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThietBi.Location = new Point(40, 112);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(94, 29);
            btnThietBi.TabIndex = 1;
            btnThietBi.Text = "Thiết Bị";
            btnThietBi.UseVisualStyleBackColor = true;
            btnThietBi.Click += btnThietBi_Click_1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(204, 94);
            button1.TabIndex = 2;
            button1.Text = "DashBoard";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelDashBoard
            // 
            panelDashBoard.Location = new Point(211, 0);
            panelDashBoard.Name = "panelDashBoard";
            panelDashBoard.Size = new Size(1203, 720);
            panelDashBoard.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(2, 694);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 17);
            lblUser.TabIndex = 0;
            lblUser.Text = "Admin";
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 718);
            Controls.Add(panelDashBoard);
            Controls.Add(panel1);
            Name = "frmDashBoard";
            Text = "DashBoard";
            Load += frmDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnThietBi;
        private Button btnPhongBan;
        private Button btnLoaiThietBi;
        private Button btnNhanVien;
        private Button btnDangXuat;
        private Button btnThongKe;
        private Button btnCapPhat;
        private Panel panelDashBoard;
        private Label lblUser;
    }
}