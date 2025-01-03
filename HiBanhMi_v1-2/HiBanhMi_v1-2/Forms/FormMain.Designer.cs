namespace HiBanhMi_v1_2.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_giaohangnhanh = new System.Windows.Forms.Label();
            this.pn_chucnang = new System.Windows.Forms.Panel();
            this.tcn = new HiBanhMi_v1_2.UseControl.ThanhChucNang();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_hienthi = new System.Windows.Forms.Panel();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.diChuyeWindows2 = new CustomControMove.DiChuyeWindows();
            this.panel1.SuspendLayout();
            this.pn_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_giaohangnhanh);
            this.panel1.Controls.Add(this.pn_chucnang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // lb_giaohangnhanh
            // 
            this.lb_giaohangnhanh.BackColor = System.Drawing.Color.White;
            this.lb_giaohangnhanh.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giaohangnhanh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_giaohangnhanh.Location = new System.Drawing.Point(19, 633);
            this.lb_giaohangnhanh.Name = "lb_giaohangnhanh";
            this.lb_giaohangnhanh.Size = new System.Drawing.Size(166, 71);
            this.lb_giaohangnhanh.TabIndex = 2;
            this.lb_giaohangnhanh.Text = "Giao Hàng Nhanh!";
            // 
            // pn_chucnang
            // 
            this.pn_chucnang.BackColor = System.Drawing.Color.Transparent;
            this.pn_chucnang.Controls.Add(this.tcn);
            this.pn_chucnang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chucnang.Location = new System.Drawing.Point(0, 0);
            this.pn_chucnang.Margin = new System.Windows.Forms.Padding(0);
            this.pn_chucnang.Name = "pn_chucnang";
            this.pn_chucnang.Size = new System.Drawing.Size(200, 445);
            this.pn_chucnang.TabIndex = 1;
            // 
            // tcn
            // 
            this.tcn.AA_1homebg = System.Drawing.Color.Silver;
            this.tcn.AA_1homeicon = System.Drawing.Color.RosyBrown;
            this.tcn.AA_1hometext = "Trang Chu";
            this.tcn.AA_1homeTitle = System.Drawing.Color.Black;
            this.tcn.AA_2thucdonbg = System.Drawing.Color.Silver;
            this.tcn.AA_2thucdonicon = System.Drawing.Color.RosyBrown;
            this.tcn.AA_2thucdontext = "Trang Chu";
            this.tcn.AA_2thucdonTitle = System.Drawing.Color.Black;
            this.tcn.AA_3yeuthichbg = System.Drawing.Color.Silver;
            this.tcn.AA_3yeuthichicon = System.Drawing.Color.RosyBrown;
            this.tcn.AA_3yeuthichtext = "Trang Chu";
            this.tcn.AA_3yeuthichTitle = System.Drawing.Color.Black;
            this.tcn.AA_4lichsubg = System.Drawing.Color.Silver;
            this.tcn.AA_4lichsuicon = System.Drawing.Color.RosyBrown;
            this.tcn.AA_4lichsutext = "Trang Chu";
            this.tcn.AA_4lichsuTitle = System.Drawing.Color.Black;
            this.tcn.AA_5settingbg = System.Drawing.Color.Silver;
            this.tcn.AA_5settingicon = System.Drawing.Color.RosyBrown;
            this.tcn.AA_5settingtext = "Trang Chu";
            this.tcn.AA_5settingTitle = System.Drawing.Color.Black;
            this.tcn.AA_anhdaidien = null;
            this.tcn.AA_backgroundcolor = System.Drawing.Color.White;
            this.tcn.AA_ten = "nguyen van hau";
            this.tcn.BackColor = System.Drawing.Color.White;
            this.tcn.Location = new System.Drawing.Point(0, 0);
            this.tcn.Margin = new System.Windows.Forms.Padding(0);
            this.tcn.Name = "tcn";
            this.tcn.Size = new System.Drawing.Size(200, 445);
            this.tcn.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::HiBanhMi_v1_2.Properties.Resources.ashipper;
            this.pictureBox1.Location = new System.Drawing.Point(0, 445);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_hienthi
            // 
            this.pn_hienthi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_hienthi.Location = new System.Drawing.Point(280, 40);
            this.pn_hienthi.Margin = new System.Windows.Forms.Padding(0);
            this.pn_hienthi.Name = "pn_hienthi";
            this.pn_hienthi.Size = new System.Drawing.Size(1080, 720);
            this.pn_hienthi.TabIndex = 1;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // diChuyeWindows2
            // 
            this.diChuyeWindows2.SelectControlAratn = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pn_hienthi);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTaiKhoan";
            this.panel1.ResumeLayout(false);
            this.pn_chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_hienthi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_chucnang;
        private System.Windows.Forms.Label lb_giaohangnhanh;
        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private CustomControMove.DiChuyeWindows diChuyeWindows2;
        public UseControl.ThanhChucNang tcn;
    }
}