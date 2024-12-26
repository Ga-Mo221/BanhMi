namespace HiBanhMi
{
    partial class FormLogin
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
            this.timedangky = new System.Windows.Forms.Timer(this.components);
            this.timedangnhap = new System.Windows.Forms.Timer(this.components);
            this.pntaikhoan = new ArtanComponent.PanelCustom();
            this.testboxTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnmatkhau = new ArtanComponent.PanelCustom();
            this.textboxMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdangnhap = new CustomButton.NutCustom();
            this.picexittrai = new CustomPictureBox.PictureBoxCustom();
            this.picexitphai = new CustomPictureBox.PictureBoxCustom();
            this.piciconlogin = new CustomPictureBox.PictureBoxCustom();
            this.pnDKtendangnhap = new ArtanComponent.PanelCustom();
            this.testboxDKtendangnhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnDKemail = new ArtanComponent.PanelCustom();
            this.testboxDKEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnDKmatkhau = new ArtanComponent.PanelCustom();
            this.testboxDKmatkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btdangky = new CustomButton.NutCustom();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbthongbaodangnhap = new System.Windows.Forms.Label();
            this.lbthongbaodangky = new System.Windows.Forms.Label();
            this.pnchuyen = new System.Windows.Forms.Panel();
            this.btchuyendangnhap = new CustomButton.NutCustom();
            this.btchuyendangky = new CustomButton.NutCustom();
            this.picporter = new System.Windows.Forms.PictureBox();
            this.pntaikhoan.SuspendLayout();
            this.pnmatkhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picexittrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexitphai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piciconlogin)).BeginInit();
            this.pnDKtendangnhap.SuspendLayout();
            this.pnDKemail.SuspendLayout();
            this.pnDKmatkhau.SuspendLayout();
            this.pnchuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picporter)).BeginInit();
            this.SuspendLayout();
            // 
            // timedangky
            // 
            this.timedangky.Interval = 1;
            this.timedangky.Tick += new System.EventHandler(this.timedangky_Tick);
            // 
            // timedangnhap
            // 
            this.timedangnhap.Interval = 1;
            this.timedangnhap.Tick += new System.EventHandler(this.timedangnhap_Tick);
            // 
            // pntaikhoan
            // 
            this.pntaikhoan.BackColor = System.Drawing.Color.White;
            this.pntaikhoan.BorderRadius1 = 30;
            this.pntaikhoan.Controls.Add(this.testboxTaiKhoan);
            this.pntaikhoan.Controls.Add(this.label3);
            this.pntaikhoan.ForeColor = System.Drawing.Color.Black;
            this.pntaikhoan.GradientAngle = 90F;
            this.pntaikhoan.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pntaikhoan.GradientTopColor = System.Drawing.Color.Silver;
            this.pntaikhoan.Location = new System.Drawing.Point(108, 261);
            this.pntaikhoan.Name = "pntaikhoan";
            this.pntaikhoan.Size = new System.Drawing.Size(278, 46);
            this.pntaikhoan.TabIndex = 0;
            // 
            // testboxTaiKhoan
            // 
            this.testboxTaiKhoan.BackColor = System.Drawing.Color.Silver;
            this.testboxTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testboxTaiKhoan.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testboxTaiKhoan.Location = new System.Drawing.Point(19, 18);
            this.testboxTaiKhoan.Name = "testboxTaiKhoan";
            this.testboxTaiKhoan.Size = new System.Drawing.Size(241, 20);
            this.testboxTaiKhoan.TabIndex = 1;
            this.testboxTaiKhoan.TextChanged += new System.EventHandler(this.testboxTaiKhoan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // pnmatkhau
            // 
            this.pnmatkhau.BackColor = System.Drawing.Color.White;
            this.pnmatkhau.BorderRadius1 = 30;
            this.pnmatkhau.Controls.Add(this.textboxMatKhau);
            this.pnmatkhau.Controls.Add(this.label1);
            this.pnmatkhau.ForeColor = System.Drawing.Color.Black;
            this.pnmatkhau.GradientAngle = 90F;
            this.pnmatkhau.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pnmatkhau.GradientTopColor = System.Drawing.Color.Silver;
            this.pnmatkhau.Location = new System.Drawing.Point(108, 330);
            this.pnmatkhau.Name = "pnmatkhau";
            this.pnmatkhau.Size = new System.Drawing.Size(278, 46);
            this.pnmatkhau.TabIndex = 1;
            // 
            // textboxMatKhau
            // 
            this.textboxMatKhau.BackColor = System.Drawing.Color.Silver;
            this.textboxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxMatKhau.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMatKhau.Location = new System.Drawing.Point(20, 18);
            this.textboxMatKhau.Name = "textboxMatKhau";
            this.textboxMatKhau.Size = new System.Drawing.Size(241, 20);
            this.textboxMatKhau.TabIndex = 2;
            this.textboxMatKhau.UseSystemPasswordChar = true;
            this.textboxMatKhau.TextChanged += new System.EventHandler(this.textboxMatKhau_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mật Khẩu";
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangnhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangnhap.BorderRadius = 65;
            this.btdangnhap.BorderSize = 0;
            this.btdangnhap.FlatAppearance.BorderSize = 0;
            this.btdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdangnhap.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btdangnhap.ForeColor = System.Drawing.Color.White;
            this.btdangnhap.Location = new System.Drawing.Point(154, 402);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(189, 65);
            this.btdangnhap.TabIndex = 2;
            this.btdangnhap.Text = "ĐĂNG NHẬP";
            this.btdangnhap.TextColor = System.Drawing.Color.White;
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // picexittrai
            // 
            this.picexittrai.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.picexittrai.BorderGradientTop = System.Drawing.Color.Transparent;
            this.picexittrai.BorderRadius = 40;
            this.picexittrai.BorderSize = 2;
            this.picexittrai.GradientAngle = 90F;
            this.picexittrai.Location = new System.Drawing.Point(433, 12);
            this.picexittrai.Name = "picexittrai";
            this.picexittrai.Size = new System.Drawing.Size(55, 55);
            this.picexittrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexittrai.TabIndex = 4;
            this.picexittrai.TabStop = false;
            this.picexittrai.Click += new System.EventHandler(this.picexittrai_Click);
            // 
            // picexitphai
            // 
            this.picexitphai.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.picexitphai.BorderGradientTop = System.Drawing.Color.Transparent;
            this.picexitphai.BorderRadius = 40;
            this.picexitphai.BorderSize = 2;
            this.picexitphai.GradientAngle = 90F;
            this.picexitphai.Location = new System.Drawing.Point(913, 12);
            this.picexitphai.Name = "picexitphai";
            this.picexitphai.Size = new System.Drawing.Size(55, 55);
            this.picexitphai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexitphai.TabIndex = 4;
            this.picexitphai.TabStop = false;
            this.picexitphai.Click += new System.EventHandler(this.picexitphai_Click);
            // 
            // piciconlogin
            // 
            this.piciconlogin.BorderGradientBottom = System.Drawing.Color.Black;
            this.piciconlogin.BorderGradientTop = System.Drawing.Color.Black;
            this.piciconlogin.BorderRadius = 40;
            this.piciconlogin.BorderSize = 1;
            this.piciconlogin.GradientAngle = 90F;
            this.piciconlogin.Location = new System.Drawing.Point(163, 60);
            this.piciconlogin.Name = "piciconlogin";
            this.piciconlogin.Size = new System.Drawing.Size(170, 170);
            this.piciconlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piciconlogin.TabIndex = 5;
            this.piciconlogin.TabStop = false;
            // 
            // pnDKtendangnhap
            // 
            this.pnDKtendangnhap.BackColor = System.Drawing.Color.White;
            this.pnDKtendangnhap.BorderRadius1 = 30;
            this.pnDKtendangnhap.Controls.Add(this.testboxDKtendangnhap);
            this.pnDKtendangnhap.Controls.Add(this.label4);
            this.pnDKtendangnhap.ForeColor = System.Drawing.Color.Black;
            this.pnDKtendangnhap.GradientAngle = 90F;
            this.pnDKtendangnhap.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pnDKtendangnhap.GradientTopColor = System.Drawing.Color.Silver;
            this.pnDKtendangnhap.Location = new System.Drawing.Point(613, 184);
            this.pnDKtendangnhap.Name = "pnDKtendangnhap";
            this.pnDKtendangnhap.Size = new System.Drawing.Size(278, 46);
            this.pnDKtendangnhap.TabIndex = 3;
            // 
            // testboxDKtendangnhap
            // 
            this.testboxDKtendangnhap.BackColor = System.Drawing.Color.Silver;
            this.testboxDKtendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testboxDKtendangnhap.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testboxDKtendangnhap.Location = new System.Drawing.Point(19, 20);
            this.testboxDKtendangnhap.Name = "testboxDKtendangnhap";
            this.testboxDKtendangnhap.Size = new System.Drawing.Size(241, 20);
            this.testboxDKtendangnhap.TabIndex = 1;
            this.testboxDKtendangnhap.TextChanged += new System.EventHandler(this.testboxDKtendangnhap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // pnDKemail
            // 
            this.pnDKemail.BackColor = System.Drawing.Color.White;
            this.pnDKemail.BorderRadius1 = 30;
            this.pnDKemail.Controls.Add(this.testboxDKEmail);
            this.pnDKemail.Controls.Add(this.label5);
            this.pnDKemail.ForeColor = System.Drawing.Color.Black;
            this.pnDKemail.GradientAngle = 90F;
            this.pnDKemail.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pnDKemail.GradientTopColor = System.Drawing.Color.Silver;
            this.pnDKemail.Location = new System.Drawing.Point(613, 253);
            this.pnDKemail.Name = "pnDKemail";
            this.pnDKemail.Size = new System.Drawing.Size(278, 46);
            this.pnDKemail.TabIndex = 4;
            // 
            // testboxDKEmail
            // 
            this.testboxDKEmail.BackColor = System.Drawing.Color.Silver;
            this.testboxDKEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testboxDKEmail.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testboxDKEmail.Location = new System.Drawing.Point(19, 18);
            this.testboxDKEmail.Name = "testboxDKEmail";
            this.testboxDKEmail.Size = new System.Drawing.Size(241, 20);
            this.testboxDKEmail.TabIndex = 1;
            this.testboxDKEmail.TextChanged += new System.EventHandler(this.testboxDKEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // pnDKmatkhau
            // 
            this.pnDKmatkhau.BackColor = System.Drawing.Color.White;
            this.pnDKmatkhau.BorderRadius1 = 30;
            this.pnDKmatkhau.Controls.Add(this.testboxDKmatkhau);
            this.pnDKmatkhau.Controls.Add(this.label6);
            this.pnDKmatkhau.ForeColor = System.Drawing.Color.Black;
            this.pnDKmatkhau.GradientAngle = 90F;
            this.pnDKmatkhau.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pnDKmatkhau.GradientTopColor = System.Drawing.Color.Silver;
            this.pnDKmatkhau.Location = new System.Drawing.Point(613, 323);
            this.pnDKmatkhau.Name = "pnDKmatkhau";
            this.pnDKmatkhau.Size = new System.Drawing.Size(278, 46);
            this.pnDKmatkhau.TabIndex = 5;
            // 
            // testboxDKmatkhau
            // 
            this.testboxDKmatkhau.BackColor = System.Drawing.Color.Silver;
            this.testboxDKmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testboxDKmatkhau.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testboxDKmatkhau.Location = new System.Drawing.Point(19, 18);
            this.testboxDKmatkhau.Name = "testboxDKmatkhau";
            this.testboxDKmatkhau.Size = new System.Drawing.Size(241, 20);
            this.testboxDKmatkhau.TabIndex = 1;
            this.testboxDKmatkhau.UseSystemPasswordChar = true;
            this.testboxDKmatkhau.TextChanged += new System.EventHandler(this.testboxDKmatkhau_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật Khẩu";
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangky.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdangky.BorderRadius = 65;
            this.btdangky.BorderSize = 0;
            this.btdangky.FlatAppearance.BorderSize = 0;
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdangky.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btdangky.ForeColor = System.Drawing.Color.White;
            this.btdangky.Location = new System.Drawing.Point(663, 402);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(179, 65);
            this.btdangky.TabIndex = 6;
            this.btdangky.Text = "ĐĂNG KÝ";
            this.btdangky.TextColor = System.Drawing.Color.White;
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(682, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 84);
            this.label7.TabIndex = 6;
            this.label7.Text = "HI!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tạo Tài Khoản Mới";
            // 
            // lbthongbaodangnhap
            // 
            this.lbthongbaodangnhap.AutoSize = true;
            this.lbthongbaodangnhap.BackColor = System.Drawing.Color.Transparent;
            this.lbthongbaodangnhap.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 7F, System.Drawing.FontStyle.Bold);
            this.lbthongbaodangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbthongbaodangnhap.Location = new System.Drawing.Point(123, 383);
            this.lbthongbaodangnhap.Name = "lbthongbaodangnhap";
            this.lbthongbaodangnhap.Size = new System.Drawing.Size(63, 13);
            this.lbthongbaodangnhap.TabIndex = 8;
            this.lbthongbaodangnhap.Text = "welcome!";
            // 
            // lbthongbaodangky
            // 
            this.lbthongbaodangky.AutoSize = true;
            this.lbthongbaodangky.BackColor = System.Drawing.Color.Transparent;
            this.lbthongbaodangky.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 7F, System.Drawing.FontStyle.Bold);
            this.lbthongbaodangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbthongbaodangky.Location = new System.Drawing.Point(625, 384);
            this.lbthongbaodangky.Name = "lbthongbaodangky";
            this.lbthongbaodangky.Size = new System.Drawing.Size(224, 13);
            this.lbthongbaodangky.TabIndex = 9;
            this.lbthongbaodangky.Text = "*Mật khẩu phải dài hơn 8 ký tự.";
            // 
            // pnchuyen
            // 
            this.pnchuyen.Controls.Add(this.btchuyendangnhap);
            this.pnchuyen.Controls.Add(this.btchuyendangky);
            this.pnchuyen.Controls.Add(this.picporter);
            this.pnchuyen.Location = new System.Drawing.Point(49, 12);
            this.pnchuyen.Name = "pnchuyen";
            this.pnchuyen.Size = new System.Drawing.Size(499, 553);
            this.pnchuyen.TabIndex = 10;
            // 
            // btchuyendangnhap
            // 
            this.btchuyendangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangnhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangnhap.BorderRadius = 69;
            this.btchuyendangnhap.BorderSize = 0;
            this.btchuyendangnhap.FlatAppearance.BorderSize = 0;
            this.btchuyendangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchuyendangnhap.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchuyendangnhap.ForeColor = System.Drawing.Color.White;
            this.btchuyendangnhap.Location = new System.Drawing.Point(172, 244);
            this.btchuyendangnhap.Name = "btchuyendangnhap";
            this.btchuyendangnhap.Size = new System.Drawing.Size(210, 69);
            this.btchuyendangnhap.TabIndex = 1;
            this.btchuyendangnhap.Text = "ĐĂNG NHẬP";
            this.btchuyendangnhap.TextColor = System.Drawing.Color.White;
            this.btchuyendangnhap.UseVisualStyleBackColor = false;
            this.btchuyendangnhap.Click += new System.EventHandler(this.btchuyendangnhap_Click);
            // 
            // btchuyendangky
            // 
            this.btchuyendangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangky.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btchuyendangky.BorderRadius = 69;
            this.btchuyendangky.BorderSize = 0;
            this.btchuyendangky.FlatAppearance.BorderSize = 0;
            this.btchuyendangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchuyendangky.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchuyendangky.ForeColor = System.Drawing.Color.White;
            this.btchuyendangky.Location = new System.Drawing.Point(172, 351);
            this.btchuyendangky.Name = "btchuyendangky";
            this.btchuyendangky.Size = new System.Drawing.Size(210, 69);
            this.btchuyendangky.TabIndex = 1;
            this.btchuyendangky.Text = "ĐĂNG KÝ";
            this.btchuyendangky.TextColor = System.Drawing.Color.White;
            this.btchuyendangky.UseVisualStyleBackColor = false;
            this.btchuyendangky.Click += new System.EventHandler(this.btchuyendangky_Click);
            // 
            // picporter
            // 
            this.picporter.Location = new System.Drawing.Point(-481, 0);
            this.picporter.Name = "picporter";
            this.picporter.Size = new System.Drawing.Size(980, 553);
            this.picporter.TabIndex = 0;
            this.picporter.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 551);
            this.Controls.Add(this.pnchuyen);
            this.Controls.Add(this.lbthongbaodangky);
            this.Controls.Add(this.lbthongbaodangnhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.piciconlogin);
            this.Controls.Add(this.picexitphai);
            this.Controls.Add(this.picexittrai);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.pnmatkhau);
            this.Controls.Add(this.pnDKmatkhau);
            this.Controls.Add(this.pnDKemail);
            this.Controls.Add(this.pnDKtendangnhap);
            this.Controls.Add(this.pntaikhoan);
            this.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pntaikhoan.ResumeLayout(false);
            this.pntaikhoan.PerformLayout();
            this.pnmatkhau.ResumeLayout(false);
            this.pnmatkhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picexittrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexitphai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piciconlogin)).EndInit();
            this.pnDKtendangnhap.ResumeLayout(false);
            this.pnDKtendangnhap.PerformLayout();
            this.pnDKemail.ResumeLayout(false);
            this.pnDKemail.PerformLayout();
            this.pnDKmatkhau.ResumeLayout(false);
            this.pnDKmatkhau.PerformLayout();
            this.pnchuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picporter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timedangky;
        private System.Windows.Forms.Timer timedangnhap;
        private ArtanComponent.PanelCustom pntaikhoan;
        private ArtanComponent.PanelCustom pnmatkhau;
        private CustomButton.NutCustom btdangnhap;
        private CustomPictureBox.PictureBoxCustom picexittrai;
        private CustomPictureBox.PictureBoxCustom picexitphai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testboxTaiKhoan;
        private CustomPictureBox.PictureBoxCustom piciconlogin;
        private System.Windows.Forms.TextBox textboxMatKhau;
        private ArtanComponent.PanelCustom pnDKtendangnhap;
        private System.Windows.Forms.TextBox testboxDKtendangnhap;
        private System.Windows.Forms.Label label4;
        private ArtanComponent.PanelCustom pnDKemail;
        private System.Windows.Forms.TextBox testboxDKEmail;
        private System.Windows.Forms.Label label5;
        private ArtanComponent.PanelCustom pnDKmatkhau;
        private System.Windows.Forms.TextBox testboxDKmatkhau;
        private System.Windows.Forms.Label label6;
        private CustomButton.NutCustom btdangky;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbthongbaodangnhap;
        private System.Windows.Forms.Label lbthongbaodangky;
        private System.Windows.Forms.Panel pnchuyen;
        private CustomButton.NutCustom btchuyendangnhap;
        private CustomButton.NutCustom btchuyendangky;
        private System.Windows.Forms.PictureBox picporter;
    }
}

