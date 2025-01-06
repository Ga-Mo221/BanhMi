namespace HiBanhMi_v1_2.Forms
{
    partial class ThucDonform
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
            this.fpn_sp = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_tieude1 = new System.Windows.Forms.Label();
            this.lb_tieude2 = new System.Windows.Forms.Label();
            this.thanhchonsp = new HiBanhMi_v1_2.UseControl.thanhchonsp();
            this.pn_giohang = new ArtanComponent.PanelCustom();
            this.bt_thanhtoan = new CustomButton.NutCustom();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tong = new System.Windows.Forms.Label();
            this.lb_giohang = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fpn_sanpham = new System.Windows.Forms.FlowLayoutPanel();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.thanhtimkiem = new HiBanhMi_v1_2.UseControl.thanhtimkiem();
            this.pn_giohang.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpn_sp
            // 
            this.fpn_sp.AutoScroll = true;
            this.fpn_sp.BackColor = System.Drawing.Color.Transparent;
            this.fpn_sp.Location = new System.Drawing.Point(12, 160);
            this.fpn_sp.Name = "fpn_sp";
            this.fpn_sp.Size = new System.Drawing.Size(807, 521);
            this.fpn_sp.TabIndex = 0;
            // 
            // lb_tieude1
            // 
            this.lb_tieude1.AutoSize = true;
            this.lb_tieude1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude1.Location = new System.Drawing.Point(12, 9);
            this.lb_tieude1.Name = "lb_tieude1";
            this.lb_tieude1.Size = new System.Drawing.Size(188, 47);
            this.lb_tieude1.TabIndex = 3;
            this.lb_tieude1.Text = "Thuc don";
            // 
            // lb_tieude2
            // 
            this.lb_tieude2.AutoSize = true;
            this.lb_tieude2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude2.Location = new System.Drawing.Point(24, 56);
            this.lb_tieude2.Name = "lb_tieude2";
            this.lb_tieude2.Size = new System.Drawing.Size(142, 24);
            this.lb_tieude2.TabIndex = 4;
            this.lb_tieude2.Text = "hôm nay có gì";
            // 
            // thanhchonsp
            // 
            this.thanhchonsp.AA_banhmi = "tat ca";
            this.thanhchonsp.AA_bg = System.Drawing.Color.White;
            this.thanhchonsp.AA_caphe = "tat ca";
            this.thanhchonsp.AA_chucnang = null;
            this.thanhchonsp.AA_giaikhat = "tat ca";
            this.thanhchonsp.AA_maubm = System.Drawing.Color.DodgerBlue;
            this.thanhchonsp.AA_maucp = System.Drawing.Color.DodgerBlue;
            this.thanhchonsp.AA_maugk = System.Drawing.Color.DodgerBlue;
            this.thanhchonsp.AA_mautc = System.Drawing.Color.DodgerBlue;
            this.thanhchonsp.AA_tatca = "tat ca";
            this.thanhchonsp.BackColor = System.Drawing.Color.Transparent;
            this.thanhchonsp.Location = new System.Drawing.Point(12, 93);
            this.thanhchonsp.Margin = new System.Windows.Forms.Padding(0);
            this.thanhchonsp.Name = "thanhchonsp";
            this.thanhchonsp.Size = new System.Drawing.Size(807, 60);
            this.thanhchonsp.TabIndex = 2;
            // 
            // pn_giohang
            // 
            this.pn_giohang.BackColor = System.Drawing.Color.White;
            this.pn_giohang.BorderRadius1 = 50;
            this.pn_giohang.Controls.Add(this.bt_thanhtoan);
            this.pn_giohang.Controls.Add(this.label5);
            this.pn_giohang.Controls.Add(this.label3);
            this.pn_giohang.Controls.Add(this.lb_tong);
            this.pn_giohang.Controls.Add(this.lb_giohang);
            this.pn_giohang.Controls.Add(this.flowLayoutPanel3);
            this.pn_giohang.Controls.Add(this.fpn_sanpham);
            this.pn_giohang.ForeColor = System.Drawing.Color.Black;
            this.pn_giohang.GradientAngle = 90F;
            this.pn_giohang.GradientBottomColor1 = System.Drawing.Color.Transparent;
            this.pn_giohang.GradientTopColor = System.Drawing.Color.Transparent;
            this.pn_giohang.Location = new System.Drawing.Point(825, 38);
            this.pn_giohang.Name = "pn_giohang";
            this.pn_giohang.Size = new System.Drawing.Size(234, 646);
            this.pn_giohang.TabIndex = 1;
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.BackColor = System.Drawing.Color.Gray;
            this.bt_thanhtoan.BackgroundColor = System.Drawing.Color.Gray;
            this.bt_thanhtoan.BorderColor = System.Drawing.Color.Transparent;
            this.bt_thanhtoan.BorderRadius = 48;
            this.bt_thanhtoan.BorderSize = 0;
            this.bt_thanhtoan.FlatAppearance.BorderSize = 0;
            this.bt_thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.bt_thanhtoan.Location = new System.Drawing.Point(43, 571);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(151, 48);
            this.bt_thanhtoan.TabIndex = 2;
            this.bt_thanhtoan.Text = "Thanh Toán";
            this.bt_thanhtoan.TextColor = System.Drawing.Color.White;
            this.bt_thanhtoan.UseVisualStyleBackColor = false;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-29, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 3);
            this.label5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-29, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 3);
            this.label3.TabIndex = 1;
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.BackColor = System.Drawing.Color.Transparent;
            this.lb_tong.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong.Location = new System.Drawing.Point(3, 477);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(159, 36);
            this.lb_tong.TabIndex = 1;
            this.lb_tong.Text = "Tong Tien";
            // 
            // lb_giohang
            // 
            this.lb_giohang.AutoSize = true;
            this.lb_giohang.BackColor = System.Drawing.Color.Transparent;
            this.lb_giohang.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giohang.Location = new System.Drawing.Point(4, 30);
            this.lb_giohang.Name = "lb_giohang";
            this.lb_giohang.Size = new System.Drawing.Size(143, 36);
            this.lb_giohang.TabIndex = 1;
            this.lb_giohang.Text = "Gio Hang";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lb_tongtien);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(43, 516);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(168, 30);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.BackColor = System.Drawing.Color.Transparent;
            this.lb_tongtien.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.Location = new System.Drawing.Point(3, 0);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(90, 30);
            this.lb_tongtien.TabIndex = 1;
            this.lb_tongtien.Text = "100000";
            this.lb_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "VND";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpn_sanpham
            // 
            this.fpn_sanpham.AutoScroll = true;
            this.fpn_sanpham.BackColor = System.Drawing.Color.Transparent;
            this.fpn_sanpham.Location = new System.Drawing.Point(10, 87);
            this.fpn_sanpham.Margin = new System.Windows.Forms.Padding(0);
            this.fpn_sanpham.Name = "fpn_sanpham";
            this.fpn_sanpham.Size = new System.Drawing.Size(212, 377);
            this.fpn_sanpham.TabIndex = 0;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // thanhtimkiem
            // 
            this.thanhtimkiem.AA_content = "";
            this.thanhtimkiem.AA_mau = System.Drawing.Color.White;
            this.thanhtimkiem.BackColor = System.Drawing.Color.White;
            this.thanhtimkiem.Location = new System.Drawing.Point(232, 22);
            this.thanhtimkiem.Margin = new System.Windows.Forms.Padding(0);
            this.thanhtimkiem.Name = "thanhtimkiem";
            this.thanhtimkiem.Size = new System.Drawing.Size(60, 58);
            this.thanhtimkiem.TabIndex = 5;
            // 
            // ThucDonform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.thanhtimkiem);
            this.Controls.Add(this.lb_tieude2);
            this.Controls.Add(this.lb_tieude1);
            this.Controls.Add(this.thanhchonsp);
            this.Controls.Add(this.pn_giohang);
            this.Controls.Add(this.fpn_sp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThucDonform";
            this.Text = "ThucDonform";
            this.pn_giohang.ResumeLayout(false);
            this.pn_giohang.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.FlowLayoutPanel fpn_sp;
        private ArtanComponent.PanelCustom pn_giohang;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Label lb_giohang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private CustomButton.NutCustom bt_thanhtoan;
        private UseControl.thanhchonsp thanhchonsp;
        private System.Windows.Forms.Label lb_tieude2;
        private System.Windows.Forms.Label lb_tieude1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private UseControl.thanhtimkiem thanhtimkiem;
        private System.Windows.Forms.FlowLayoutPanel fpn_sanpham;
        private System.Windows.Forms.Label label1;
    }
}