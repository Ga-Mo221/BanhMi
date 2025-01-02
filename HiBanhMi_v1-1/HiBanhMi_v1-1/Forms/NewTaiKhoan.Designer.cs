namespace HiBanhMi_v1_1.Forms
{
    partial class NewTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_iconuse = new System.Windows.Forms.PictureBox();
            this.pic_loimodau = new System.Windows.Forms.PictureBox();
            this.pic_diachi = new System.Windows.Forms.PictureBox();
            this.pic_dienthoai = new System.Windows.Forms.PictureBox();
            this.pic_chuyentiep = new System.Windows.Forms.PictureBox();
            this.tgchuyen = new System.Windows.Forms.Timer(this.components);
            this.bt_chuyentiep = new CustomButton.NutCustom();
            this.bt_sua = new CustomButton.NutCustom();
            this.pic_avatar = new CustomPictureBox.PictureBoxCustom();
            this.nutCustom1 = new CustomButton.NutCustom();
            this.tb_bietdanh = new HiBanhMi_v1_1.texboxcustom();
            this.tb_diachi = new HiBanhMi_v1_1.texboxcustom();
            this.tb_sdt = new HiBanhMi_v1_1.texboxcustom();
            this.tb_ten = new HiBanhMi_v1_1.texboxcustom();
            this.cbb_gioitinh = new comboobox.cust_combobox.CusTomCOMBOBOX();
            this.cbb_nam = new comboobox.cust_combobox.CusTomCOMBOBOX();
            this.cbb_thang = new comboobox.cust_combobox.CusTomCOMBOBOX();
            this.cbb_ngay = new comboobox.cust_combobox.CusTomCOMBOBOX();
            this.bt_exit_loimodau = new System.Windows.Forms.Button();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            ((System.ComponentModel.ISupportInitialize)(this.pic_iconuse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loimodau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_diachi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dienthoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chuyentiep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 84);
            this.label1.TabIndex = 5;
            this.label1.Text = "CẢM ƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hãy Thêm Một Vài Thông Tin Cần Thiết Nữa Là Xong Rồi!";
            // 
            // pic_iconuse
            // 
            this.pic_iconuse.BackColor = System.Drawing.Color.Silver;
            this.pic_iconuse.Image = global::HiBanhMi_v1_1.Properties.Resources.user;
            this.pic_iconuse.Location = new System.Drawing.Point(710, 262);
            this.pic_iconuse.Name = "pic_iconuse";
            this.pic_iconuse.Size = new System.Drawing.Size(37, 37);
            this.pic_iconuse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_iconuse.TabIndex = 8;
            this.pic_iconuse.TabStop = false;
            // 
            // pic_loimodau
            // 
            this.pic_loimodau.BackColor = System.Drawing.Color.Transparent;
            this.pic_loimodau.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.loimodau;
            this.pic_loimodau.Location = new System.Drawing.Point(0, 0);
            this.pic_loimodau.Name = "pic_loimodau";
            this.pic_loimodau.Size = new System.Drawing.Size(2800, 800);
            this.pic_loimodau.TabIndex = 7;
            this.pic_loimodau.TabStop = false;
            // 
            // pic_diachi
            // 
            this.pic_diachi.BackColor = System.Drawing.Color.Silver;
            this.pic_diachi.Image = global::HiBanhMi_v1_1.Properties.Resources.diachi;
            this.pic_diachi.Location = new System.Drawing.Point(1105, 262);
            this.pic_diachi.Name = "pic_diachi";
            this.pic_diachi.Size = new System.Drawing.Size(37, 37);
            this.pic_diachi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_diachi.TabIndex = 8;
            this.pic_diachi.TabStop = false;
            // 
            // pic_dienthoai
            // 
            this.pic_dienthoai.BackColor = System.Drawing.Color.Silver;
            this.pic_dienthoai.Image = global::HiBanhMi_v1_1.Properties.Resources.dienthoai;
            this.pic_dienthoai.Location = new System.Drawing.Point(715, 349);
            this.pic_dienthoai.Name = "pic_dienthoai";
            this.pic_dienthoai.Size = new System.Drawing.Size(32, 31);
            this.pic_dienthoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dienthoai.TabIndex = 8;
            this.pic_dienthoai.TabStop = false;
            // 
            // pic_chuyentiep
            // 
            this.pic_chuyentiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(206)))));
            this.pic_chuyentiep.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.tieptheo;
            this.pic_chuyentiep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_chuyentiep.Location = new System.Drawing.Point(1269, 330);
            this.pic_chuyentiep.Name = "pic_chuyentiep";
            this.pic_chuyentiep.Size = new System.Drawing.Size(61, 119);
            this.pic_chuyentiep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_chuyentiep.TabIndex = 9;
            this.pic_chuyentiep.TabStop = false;
            this.pic_chuyentiep.Click += new System.EventHandler(this.pic_chuyentiep_Click);
            // 
            // tgchuyen
            // 
            this.tgchuyen.Interval = 1;
            this.tgchuyen.Tick += new System.EventHandler(this.tgchuyen_Tick);
            // 
            // bt_chuyentiep
            // 
            this.bt_chuyentiep.BackColor = System.Drawing.Color.Black;
            this.bt_chuyentiep.BackgroundColor = System.Drawing.Color.Black;
            this.bt_chuyentiep.BorderColor = System.Drawing.Color.Black;
            this.bt_chuyentiep.BorderRadius = 47;
            this.bt_chuyentiep.BorderSize = 0;
            this.bt_chuyentiep.FlatAppearance.BorderSize = 0;
            this.bt_chuyentiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chuyentiep.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chuyentiep.ForeColor = System.Drawing.Color.White;
            this.bt_chuyentiep.Location = new System.Drawing.Point(2550, 675);
            this.bt_chuyentiep.Name = "bt_chuyentiep";
            this.bt_chuyentiep.Size = new System.Drawing.Size(163, 57);
            this.bt_chuyentiep.TabIndex = 10;
            this.bt_chuyentiep.Text = "TIẾP THEO";
            this.bt_chuyentiep.TextColor = System.Drawing.Color.White;
            this.bt_chuyentiep.UseVisualStyleBackColor = false;
            this.bt_chuyentiep.Click += new System.EventHandler(this.bt_chuyentiep_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.White;
            this.bt_sua.BackgroundColor = System.Drawing.Color.White;
            this.bt_sua.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.sua;
            this.bt_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_sua.BorderColor = System.Drawing.Color.Black;
            this.bt_sua.BorderRadius = 50;
            this.bt_sua.BorderSize = 5;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(361, 482);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(54, 55);
            this.bt_sua.TabIndex = 4;
            this.bt_sua.TextColor = System.Drawing.Color.White;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // pic_avatar
            // 
            this.pic_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_avatar.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.use;
            this.pic_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_avatar.BorderGradientBottom = System.Drawing.Color.Black;
            this.pic_avatar.BorderGradientTop = System.Drawing.Color.Black;
            this.pic_avatar.BorderRadius = 40;
            this.pic_avatar.BorderSize = 4;
            this.pic_avatar.GradientAngle = 90F;
            this.pic_avatar.Location = new System.Drawing.Point(123, 255);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(306, 306);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 3;
            this.pic_avatar.TabStop = false;
            // 
            // nutCustom1
            // 
            this.nutCustom1.BackColor = System.Drawing.Color.Black;
            this.nutCustom1.BackgroundColor = System.Drawing.Color.Black;
            this.nutCustom1.BorderColor = System.Drawing.Color.Black;
            this.nutCustom1.BorderRadius = 60;
            this.nutCustom1.BorderSize = 0;
            this.nutCustom1.FlatAppearance.BorderSize = 0;
            this.nutCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nutCustom1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutCustom1.ForeColor = System.Drawing.Color.White;
            this.nutCustom1.Location = new System.Drawing.Point(1078, 627);
            this.nutCustom1.Name = "nutCustom1";
            this.nutCustom1.Size = new System.Drawing.Size(173, 66);
            this.nutCustom1.TabIndex = 2;
            this.nutCustom1.Text = "HOÀN THÀNH";
            this.nutCustom1.TextColor = System.Drawing.Color.White;
            this.nutCustom1.UseVisualStyleBackColor = false;
            this.nutCustom1.Click += new System.EventHandler(this.nutCustom1_Click);
            // 
            // tb_bietdanh
            // 
            this.tb_bietdanh.BackColor = System.Drawing.Color.Transparent;
            this.tb_bietdanh.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bietdanh.HienThiMatKau = false;
            this.tb_bietdanh.Location = new System.Drawing.Point(474, 428);
            this.tb_bietdanh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bietdanh.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_bietdanh.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_bietdanh.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_bietdanh.Name = "tb_bietdanh";
            this.tb_bietdanh.Noidung = "";
            this.tb_bietdanh.Size = new System.Drawing.Size(280, 50);
            this.tb_bietdanh.TabIndex = 1;
            this.tb_bietdanh.TieuDe = "Biệt Danh";
            // 
            // tb_diachi
            // 
            this.tb_diachi.BackColor = System.Drawing.Color.Transparent;
            this.tb_diachi.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.HienThiMatKau = false;
            this.tb_diachi.Location = new System.Drawing.Point(871, 255);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_diachi.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_diachi.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_diachi.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Noidung = "";
            this.tb_diachi.Size = new System.Drawing.Size(280, 50);
            this.tb_diachi.TabIndex = 1;
            this.tb_diachi.TieuDe = "Địa Chỉ";
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.Color.Transparent;
            this.tb_sdt.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.HienThiMatKau = false;
            this.tb_sdt.Location = new System.Drawing.Point(474, 339);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sdt.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_sdt.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_sdt.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Noidung = "";
            this.tb_sdt.Size = new System.Drawing.Size(280, 50);
            this.tb_sdt.TabIndex = 1;
            this.tb_sdt.TieuDe = "Số Điện Thoại";
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.Color.Transparent;
            this.tb_ten.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.HienThiMatKau = false;
            this.tb_ten.Location = new System.Drawing.Point(474, 255);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ten.MauTexBoxduoi = System.Drawing.Color.Silver;
            this.tb_ten.MauTexBoxgiua = System.Drawing.Color.Silver;
            this.tb_ten.MauTexBoxtren = System.Drawing.Color.Silver;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Noidung = "";
            this.tb_ten.Size = new System.Drawing.Size(280, 50);
            this.tb_ten.TabIndex = 1;
            this.tb_ten.TieuDe = "Họ Và Tên";
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cbb_gioitinh.CHIEUDAICUATITEM = 138;
            this.cbb_gioitinh.CHIEUDAILIST = 125;
            this.cbb_gioitinh.DATAITEM = new string[] {
        "Nam",
        "Nữ",
        "Khác"};
            this.cbb_gioitinh.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioitinh.ICON = global::HiBanhMi_v1_1.Properties.Resources.gioitinh;
            this.cbb_gioitinh.ITEM = "Chọn ";
            this.cbb_gioitinh.Location = new System.Drawing.Point(545, 502);
            this.cbb_gioitinh.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.OPTION = global::HiBanhMi_v1_1.Properties.Resources.muitenxuong;
            this.cbb_gioitinh.Size = new System.Drawing.Size(138, 50);
            this.cbb_gioitinh.TabIndex = 0;
            this.cbb_gioitinh.TIEUDE = "Giới Tính";
            // 
            // cbb_nam
            // 
            this.cbb_nam.BackColor = System.Drawing.Color.Transparent;
            this.cbb_nam.CHIEUDAICUATITEM = 138;
            this.cbb_nam.CHIEUDAILIST = 250;
            this.cbb_nam.DATAITEM = new string[] {
        "1990",
        "1991",
        "1992",
        "1993",
        "1994",
        "1995",
        "1996",
        "1997",
        "1998",
        "1999",
        "2000",
        "2001",
        "2002",
        "2003",
        "2004",
        "2005",
        "2006",
        "2007",
        "2008",
        "2009",
        "2010",
        "2011",
        "2012",
        "2013",
        "2014",
        "2015",
        "2016",
        "2017",
        "2018",
        "2019",
        "2020",
        "2021",
        "2022",
        "2023",
        "2024",
        "2025"};
            this.cbb_nam.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nam.ICON = global::HiBanhMi_v1_1.Properties.Resources.list;
            this.cbb_nam.ITEM = "Chọn ";
            this.cbb_nam.Location = new System.Drawing.Point(1098, 339);
            this.cbb_nam.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.OPTION = global::HiBanhMi_v1_1.Properties.Resources.muitenxuong;
            this.cbb_nam.Size = new System.Drawing.Size(138, 50);
            this.cbb_nam.TabIndex = 0;
            this.cbb_nam.TIEUDE = "Năm";
            // 
            // cbb_thang
            // 
            this.cbb_thang.BackColor = System.Drawing.Color.Transparent;
            this.cbb_thang.CHIEUDAICUATITEM = 138;
            this.cbb_thang.CHIEUDAILIST = 250;
            this.cbb_thang.DATAITEM = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12"};
            this.cbb_thang.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_thang.ICON = global::HiBanhMi_v1_1.Properties.Resources.list;
            this.cbb_thang.ITEM = "Chọn ";
            this.cbb_thang.Location = new System.Drawing.Point(944, 339);
            this.cbb_thang.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.OPTION = global::HiBanhMi_v1_1.Properties.Resources.muitenxuong;
            this.cbb_thang.Size = new System.Drawing.Size(138, 50);
            this.cbb_thang.TabIndex = 0;
            this.cbb_thang.TIEUDE = "Tháng";
            // 
            // cbb_ngay
            // 
            this.cbb_ngay.BackColor = System.Drawing.Color.Transparent;
            this.cbb_ngay.CHIEUDAICUATITEM = 138;
            this.cbb_ngay.CHIEUDAILIST = 250;
            this.cbb_ngay.DATAITEM = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "32",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31"};
            this.cbb_ngay.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ngay.ICON = global::HiBanhMi_v1_1.Properties.Resources.list;
            this.cbb_ngay.ITEM = "Chọn ";
            this.cbb_ngay.Location = new System.Drawing.Point(792, 339);
            this.cbb_ngay.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_ngay.Name = "cbb_ngay";
            this.cbb_ngay.OPTION = global::HiBanhMi_v1_1.Properties.Resources.muitenxuong;
            this.cbb_ngay.Size = new System.Drawing.Size(138, 50);
            this.cbb_ngay.TabIndex = 0;
            this.cbb_ngay.TIEUDE = "Ngày";
            // 
            // bt_exit_loimodau
            // 
            this.bt_exit_loimodau.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.Exit;
            this.bt_exit_loimodau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_exit_loimodau.Location = new System.Drawing.Point(1336, 24);
            this.bt_exit_loimodau.Name = "bt_exit_loimodau";
            this.bt_exit_loimodau.Size = new System.Drawing.Size(37, 37);
            this.bt_exit_loimodau.TabIndex = 11;
            this.bt_exit_loimodau.UseVisualStyleBackColor = true;
            this.bt_exit_loimodau.Click += new System.EventHandler(this.bt_exit_loimodau_Click);
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // NewTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(206)))));
            this.BackgroundImage = global::HiBanhMi_v1_1.Properties.Resources.anhnenloimodau;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.bt_exit_loimodau);
            this.Controls.Add(this.bt_chuyentiep);
            this.Controls.Add(this.pic_chuyentiep);
            this.Controls.Add(this.pic_diachi);
            this.Controls.Add(this.pic_dienthoai);
            this.Controls.Add(this.pic_iconuse);
            this.Controls.Add(this.pic_loimodau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.pic_avatar);
            this.Controls.Add(this.nutCustom1);
            this.Controls.Add(this.tb_bietdanh);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.cbb_gioitinh);
            this.Controls.Add(this.cbb_nam);
            this.Controls.Add(this.cbb_thang);
            this.Controls.Add(this.cbb_ngay);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.pic_iconuse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loimodau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_diachi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dienthoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chuyentiep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private comboobox.cust_combobox.CusTomCOMBOBOX cbb_ngay;
        private comboobox.cust_combobox.CusTomCOMBOBOX cbb_thang;
        private comboobox.cust_combobox.CusTomCOMBOBOX cbb_nam;
        private texboxcustom tb_ten;
        private texboxcustom tb_sdt;
        private texboxcustom tb_diachi;
        private texboxcustom tb_bietdanh;
        private CustomButton.NutCustom nutCustom1;
        private CustomPictureBox.PictureBoxCustom pic_avatar;
        private CustomButton.NutCustom bt_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_loimodau;
        private System.Windows.Forms.PictureBox pic_iconuse;
        private System.Windows.Forms.PictureBox pic_diachi;
        private System.Windows.Forms.PictureBox pic_dienthoai;
        private comboobox.cust_combobox.CusTomCOMBOBOX cbb_gioitinh;
        private System.Windows.Forms.PictureBox pic_chuyentiep;
        private CustomButton.NutCustom bt_chuyentiep;
        private System.Windows.Forms.Timer tgchuyen;
        private System.Windows.Forms.Button bt_exit_loimodau;
        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
    }
}