namespace HiBanhMi_v1_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tb_DN_TaiKhoan = new HiBanhMi_v1_1.texboxcustom();
            this.tb_DN_MatKhau = new HiBanhMi_v1_1.texboxcustom();
            this.tb_DK_TaiKhoan = new HiBanhMi_v1_1.texboxcustom();
            this.tb_DK_Email = new HiBanhMi_v1_1.texboxcustom();
            this.tb_DK_MatKhau = new HiBanhMi_v1_1.texboxcustom();
            this.bt_DN_DangNhap = new CustomButton.NutCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_DK_ThongBao = new System.Windows.Forms.Label();
            this.lb_DN_ThongBao = new System.Windows.Forms.Label();
            this.bt_DK_DangKy = new CustomButton.NutCustom();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.time_DK = new System.Windows.Forms.Timer(this.components);
            this.time_DN = new System.Windows.Forms.Timer(this.components);
            this.pn_Chuyen = new System.Windows.Forms.Panel();
            this.bt_DangNhap = new CustomButton.NutCustom();
            this.bt_DangKy = new CustomButton.NutCustom();
            this.pic_porter = new System.Windows.Forms.PictureBox();
            this.bt_DN_showmk = new CustomPictureBox.PictureBoxCustom();
            this.bt_Exit = new CustomPictureBox.PictureBoxCustom();
            this.bt_DK_showmk = new CustomPictureBox.PictureBoxCustom();
            this.pn_Chuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_porter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_DN_showmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_DK_showmk)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_DN_TaiKhoan
            // 
            this.tb_DN_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.tb_DN_TaiKhoan.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DN_TaiKhoan.HienThiMatKau = false;
            this.tb_DN_TaiKhoan.Location = new System.Drawing.Point(110, 260);
            this.tb_DN_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DN_TaiKhoan.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_DN_TaiKhoan.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_DN_TaiKhoan.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_DN_TaiKhoan.Name = "tb_DN_TaiKhoan";
            this.tb_DN_TaiKhoan.Noidung = "";
            this.tb_DN_TaiKhoan.Size = new System.Drawing.Size(280, 50);
            this.tb_DN_TaiKhoan.TabIndex = 0;
            this.tb_DN_TaiKhoan.TieuDe = "Tài Khoản";
            // 
            // tb_DN_MatKhau
            // 
            this.tb_DN_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.tb_DN_MatKhau.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DN_MatKhau.HienThiMatKau = true;
            this.tb_DN_MatKhau.Location = new System.Drawing.Point(110, 330);
            this.tb_DN_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DN_MatKhau.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_DN_MatKhau.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_DN_MatKhau.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_DN_MatKhau.Name = "tb_DN_MatKhau";
            this.tb_DN_MatKhau.Noidung = "";
            this.tb_DN_MatKhau.Size = new System.Drawing.Size(280, 50);
            this.tb_DN_MatKhau.TabIndex = 1;
            this.tb_DN_MatKhau.TieuDe = "Mật Khẩu";
            // 
            // tb_DK_TaiKhoan
            // 
            this.tb_DK_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.tb_DK_TaiKhoan.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DK_TaiKhoan.HienThiMatKau = false;
            this.tb_DK_TaiKhoan.Location = new System.Drawing.Point(610, 185);
            this.tb_DK_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DK_TaiKhoan.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_DK_TaiKhoan.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_DK_TaiKhoan.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_DK_TaiKhoan.Name = "tb_DK_TaiKhoan";
            this.tb_DK_TaiKhoan.Noidung = "";
            this.tb_DK_TaiKhoan.Size = new System.Drawing.Size(280, 50);
            this.tb_DK_TaiKhoan.TabIndex = 2;
            this.tb_DK_TaiKhoan.TieuDe = "Tài Khoản";
            // 
            // tb_DK_Email
            // 
            this.tb_DK_Email.BackColor = System.Drawing.Color.Transparent;
            this.tb_DK_Email.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DK_Email.HienThiMatKau = false;
            this.tb_DK_Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_DK_Email.Location = new System.Drawing.Point(610, 255);
            this.tb_DK_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DK_Email.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_DK_Email.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_DK_Email.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_DK_Email.Name = "tb_DK_Email";
            this.tb_DK_Email.Noidung = "";
            this.tb_DK_Email.Size = new System.Drawing.Size(280, 50);
            this.tb_DK_Email.TabIndex = 3;
            this.tb_DK_Email.TieuDe = "Email";
            // 
            // tb_DK_MatKhau
            // 
            this.tb_DK_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.tb_DK_MatKhau.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DK_MatKhau.HienThiMatKau = true;
            this.tb_DK_MatKhau.Location = new System.Drawing.Point(610, 330);
            this.tb_DK_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DK_MatKhau.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_DK_MatKhau.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_DK_MatKhau.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_DK_MatKhau.Name = "tb_DK_MatKhau";
            this.tb_DK_MatKhau.Noidung = "";
            this.tb_DK_MatKhau.Size = new System.Drawing.Size(280, 50);
            this.tb_DK_MatKhau.TabIndex = 4;
            this.tb_DK_MatKhau.TieuDe = "Mật Khẩu";
            // 
            // bt_DN_DangNhap
            // 
            this.bt_DN_DangNhap.BackColor = System.Drawing.Color.Black;
            this.bt_DN_DangNhap.BackgroundColor = System.Drawing.Color.Black;
            this.bt_DN_DangNhap.BorderColor = System.Drawing.Color.Black;
            this.bt_DN_DangNhap.BorderRadius = 50;
            this.bt_DN_DangNhap.BorderSize = 0;
            this.bt_DN_DangNhap.FlatAppearance.BorderSize = 0;
            this.bt_DN_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DN_DangNhap.ForeColor = System.Drawing.Color.White;
            this.bt_DN_DangNhap.Location = new System.Drawing.Point(160, 400);
            this.bt_DN_DangNhap.Name = "bt_DN_DangNhap";
            this.bt_DN_DangNhap.Size = new System.Drawing.Size(180, 65);
            this.bt_DN_DangNhap.TabIndex = 5;
            this.bt_DN_DangNhap.Text = "ĐĂNG NHẬP";
            this.bt_DN_DangNhap.TextColor = System.Drawing.Color.White;
            this.bt_DN_DangNhap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "HI!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(627, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hãy Tạo Một Tài Khoản Mới Nào!";
            // 
            // lb_DK_ThongBao
            // 
            this.lb_DK_ThongBao.AutoSize = true;
            this.lb_DK_ThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lb_DK_ThongBao.Location = new System.Drawing.Point(615, 384);
            this.lb_DK_ThongBao.Name = "lb_DK_ThongBao";
            this.lb_DK_ThongBao.Size = new System.Drawing.Size(207, 16);
            this.lb_DK_ThongBao.TabIndex = 3;
            this.lb_DK_ThongBao.Text = "** Mật Khẩu trên 8 ký tự!";
            // 
            // lb_DN_ThongBao
            // 
            this.lb_DN_ThongBao.AutoSize = true;
            this.lb_DN_ThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lb_DN_ThongBao.Location = new System.Drawing.Point(120, 384);
            this.lb_DN_ThongBao.Name = "lb_DN_ThongBao";
            this.lb_DN_ThongBao.Size = new System.Drawing.Size(71, 16);
            this.lb_DN_ThongBao.TabIndex = 3;
            this.lb_DN_ThongBao.Text = "Welcome!";
            // 
            // bt_DK_DangKy
            // 
            this.bt_DK_DangKy.BackColor = System.Drawing.Color.Black;
            this.bt_DK_DangKy.BackgroundColor = System.Drawing.Color.Black;
            this.bt_DK_DangKy.BorderColor = System.Drawing.Color.Black;
            this.bt_DK_DangKy.BorderRadius = 50;
            this.bt_DK_DangKy.BorderSize = 0;
            this.bt_DK_DangKy.FlatAppearance.BorderSize = 0;
            this.bt_DK_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DK_DangKy.ForeColor = System.Drawing.Color.White;
            this.bt_DK_DangKy.Location = new System.Drawing.Point(660, 400);
            this.bt_DK_DangKy.Name = "bt_DK_DangKy";
            this.bt_DK_DangKy.Size = new System.Drawing.Size(180, 65);
            this.bt_DK_DangKy.TabIndex = 6;
            this.bt_DK_DangKy.Text = "ĐĂNG KÝ";
            this.bt_DK_DangKy.TextColor = System.Drawing.Color.White;
            this.bt_DK_DangKy.UseVisualStyleBackColor = false;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 30;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // time_DK
            // 
            this.time_DK.Interval = 1;
            this.time_DK.Tick += new System.EventHandler(this.time_DK_Tick);
            // 
            // time_DN
            // 
            this.time_DN.Interval = 1;
            this.time_DN.Tick += new System.EventHandler(this.time_DN_Tick);
            // 
            // pn_Chuyen
            // 
            this.pn_Chuyen.Controls.Add(this.bt_DangNhap);
            this.pn_Chuyen.Controls.Add(this.bt_DangKy);
            this.pn_Chuyen.Controls.Add(this.pic_porter);
            this.pn_Chuyen.Location = new System.Drawing.Point(500, 0);
            this.pn_Chuyen.Name = "pn_Chuyen";
            this.pn_Chuyen.Size = new System.Drawing.Size(500, 600);
            this.pn_Chuyen.TabIndex = 7;
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.BackColor = System.Drawing.Color.Black;
            this.bt_DangNhap.BackgroundColor = System.Drawing.Color.Black;
            this.bt_DangNhap.BorderColor = System.Drawing.Color.Black;
            this.bt_DangNhap.BorderRadius = 50;
            this.bt_DangNhap.BorderSize = 0;
            this.bt_DangNhap.FlatAppearance.BorderSize = 0;
            this.bt_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DangNhap.ForeColor = System.Drawing.Color.White;
            this.bt_DangNhap.Location = new System.Drawing.Point(-360, 400);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(200, 65);
            this.bt_DangNhap.TabIndex = 1;
            this.bt_DangNhap.Text = "ĐĂNG NHẬP";
            this.bt_DangNhap.TextColor = System.Drawing.Color.White;
            this.bt_DangNhap.UseVisualStyleBackColor = false;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // bt_DangKy
            // 
            this.bt_DangKy.BackColor = System.Drawing.Color.Black;
            this.bt_DangKy.BackgroundColor = System.Drawing.Color.Black;
            this.bt_DangKy.BorderColor = System.Drawing.Color.Black;
            this.bt_DangKy.BorderRadius = 50;
            this.bt_DangKy.BorderSize = 0;
            this.bt_DangKy.FlatAppearance.BorderSize = 0;
            this.bt_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DangKy.ForeColor = System.Drawing.Color.White;
            this.bt_DangKy.Location = new System.Drawing.Point(140, 400);
            this.bt_DangKy.Name = "bt_DangKy";
            this.bt_DangKy.Size = new System.Drawing.Size(200, 65);
            this.bt_DangKy.TabIndex = 1;
            this.bt_DangKy.Text = "ĐĂNG KÝ";
            this.bt_DangKy.TextColor = System.Drawing.Color.White;
            this.bt_DangKy.UseVisualStyleBackColor = false;
            this.bt_DangKy.Click += new System.EventHandler(this.bt_DangKy_Click);
            // 
            // pic_porter
            // 
            this.pic_porter.Image = global::HiBanhMi_v1_1.Properties.Resources.Porter;
            this.pic_porter.Location = new System.Drawing.Point(-500, 0);
            this.pic_porter.Name = "pic_porter";
            this.pic_porter.Size = new System.Drawing.Size(1000, 600);
            this.pic_porter.TabIndex = 0;
            this.pic_porter.TabStop = false;
            // 
            // bt_DN_showmk
            // 
            this.bt_DN_showmk.BackColor = System.Drawing.Color.Silver;
            this.bt_DN_showmk.BorderGradientBottom = System.Drawing.Color.Silver;
            this.bt_DN_showmk.BorderGradientTop = System.Drawing.Color.Silver;
            this.bt_DN_showmk.BorderRadius = 40;
            this.bt_DN_showmk.BorderSize = 0;
            this.bt_DN_showmk.GradientAngle = 90F;
            this.bt_DN_showmk.Image = global::HiBanhMi_v1_1.Properties.Resources.lichsu;
            this.bt_DN_showmk.Location = new System.Drawing.Point(347, 334);
            this.bt_DN_showmk.Name = "bt_DN_showmk";
            this.bt_DN_showmk.Size = new System.Drawing.Size(38, 38);
            this.bt_DN_showmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_DN_showmk.TabIndex = 8;
            this.bt_DN_showmk.TabStop = false;
            this.bt_DN_showmk.Click += new System.EventHandler(this.bt_DN_showmk_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.BorderGradientBottom = System.Drawing.Color.Black;
            this.bt_Exit.BorderGradientTop = System.Drawing.Color.Black;
            this.bt_Exit.BorderRadius = 40;
            this.bt_Exit.BorderSize = 2;
            this.bt_Exit.GradientAngle = 90F;
            this.bt_Exit.Image = global::HiBanhMi_v1_1.Properties.Resources.Exit;
            this.bt_Exit.Location = new System.Drawing.Point(943, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(45, 45);
            this.bt_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_DK_showmk
            // 
            this.bt_DK_showmk.BackColor = System.Drawing.Color.Silver;
            this.bt_DK_showmk.BorderGradientBottom = System.Drawing.Color.Silver;
            this.bt_DK_showmk.BorderGradientTop = System.Drawing.Color.Silver;
            this.bt_DK_showmk.BorderRadius = 40;
            this.bt_DK_showmk.BorderSize = 0;
            this.bt_DK_showmk.GradientAngle = 90F;
            this.bt_DK_showmk.Image = global::HiBanhMi_v1_1.Properties.Resources.lichsu;
            this.bt_DK_showmk.Location = new System.Drawing.Point(844, 336);
            this.bt_DK_showmk.Name = "bt_DK_showmk";
            this.bt_DK_showmk.Size = new System.Drawing.Size(38, 38);
            this.bt_DK_showmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_DK_showmk.TabIndex = 8;
            this.bt_DK_showmk.TabStop = false;
            this.bt_DK_showmk.Click += new System.EventHandler(this.bt_DK_showmk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.bt_DK_showmk);
            this.Controls.Add(this.bt_DN_showmk);
            this.Controls.Add(this.pn_Chuyen);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.lb_DN_ThongBao);
            this.Controls.Add(this.lb_DK_ThongBao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_DK_DangKy);
            this.Controls.Add(this.bt_DN_DangNhap);
            this.Controls.Add(this.tb_DK_MatKhau);
            this.Controls.Add(this.tb_DK_Email);
            this.Controls.Add(this.tb_DK_TaiKhoan);
            this.Controls.Add(this.tb_DN_MatKhau);
            this.Controls.Add(this.tb_DN_TaiKhoan);
            this.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.pn_Chuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_porter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_DN_showmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_DK_showmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private texboxcustom tb_DN_TaiKhoan;
        private texboxcustom tb_DN_MatKhau;
        private texboxcustom tb_DK_TaiKhoan;
        private texboxcustom tb_DK_Email;
        private texboxcustom tb_DK_MatKhau;
        private CustomButton.NutCustom bt_DN_DangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_DK_ThongBao;
        private System.Windows.Forms.Label lb_DN_ThongBao;
        private CustomButton.NutCustom bt_DK_DangKy;
        private CustomPictureBox.PictureBoxCustom bt_Exit;
        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.Panel pn_Chuyen;
        private System.Windows.Forms.PictureBox pic_porter;
        private System.Windows.Forms.Timer time_DK;
        private System.Windows.Forms.Timer time_DN;
        private CustomButton.NutCustom bt_DangKy;
        private CustomButton.NutCustom bt_DangNhap;
        private CustomPictureBox.PictureBoxCustom bt_DN_showmk;
        private CustomPictureBox.PictureBoxCustom bt_DK_showmk;
    }
}

