namespace HiBanhMi_v1_2.UseControl
{
    partial class item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_admin = new System.Windows.Forms.PictureBox();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_giamgia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_chon = new ArtanComponent.PanelCustom();
            this.bt_sua = new CustomButton.NutCustom();
            this.bt_xoa = new CustomButton.NutCustom();
            this.pic_avata = new CustomPictureBox.PictureBoxCustom();
            this.pn_bg = new ArtanComponent.PanelCustom();
            this.lb_masp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_them = new CustomButton.NutCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_daban = new System.Windows.Forms.Label();
            this.lb_danhgia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).BeginInit();
            this.fpn.SuspendLayout();
            this.pn_chon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avata)).BeginInit();
            this.pn_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_admin
            // 
            this.pic_admin.Image = global::HiBanhMi_v1_2.Properties.Resources._3cham;
            this.pic_admin.Location = new System.Drawing.Point(168, 0);
            this.pic_admin.Name = "pic_admin";
            this.pic_admin.Size = new System.Drawing.Size(26, 28);
            this.pic_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_admin.TabIndex = 2;
            this.pic_admin.TabStop = false;
            this.pic_admin.Click += new System.EventHandler(this.pic_admin_Click);
            // 
            // fpn
            // 
            this.fpn.BackColor = System.Drawing.Color.Red;
            this.fpn.Controls.Add(this.lb_giamgia);
            this.fpn.Controls.Add(this.label1);
            this.fpn.Location = new System.Drawing.Point(11, 10);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(67, 24);
            this.fpn.TabIndex = 3;
            // 
            // lb_giamgia
            // 
            this.lb_giamgia.AutoSize = true;
            this.lb_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giamgia.Location = new System.Drawing.Point(3, 0);
            this.lb_giamgia.Name = "lb_giamgia";
            this.lb_giamgia.Size = new System.Drawing.Size(26, 18);
            this.lb_giamgia.TabIndex = 0;
            this.lb_giamgia.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "%";
            // 
            // pn_chon
            // 
            this.pn_chon.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_chon.BorderRadius1 = 30;
            this.pn_chon.Controls.Add(this.bt_sua);
            this.pn_chon.Controls.Add(this.bt_xoa);
            this.pn_chon.ForeColor = System.Drawing.Color.Black;
            this.pn_chon.GradientAngle = 90F;
            this.pn_chon.GradientBottomColor1 = System.Drawing.Color.Transparent;
            this.pn_chon.GradientTopColor = System.Drawing.Color.Transparent;
            this.pn_chon.Location = new System.Drawing.Point(70, 40);
            this.pn_chon.Name = "pn_chon";
            this.pn_chon.Size = new System.Drawing.Size(102, 110);
            this.pn_chon.TabIndex = 4;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.SlateGray;
            this.bt_sua.BackgroundColor = System.Drawing.Color.SlateGray;
            this.bt_sua.BorderColor = System.Drawing.Color.Transparent;
            this.bt_sua.BorderRadius = 32;
            this.bt_sua.BorderSize = -1;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.Location = new System.Drawing.Point(11, 58);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(76, 32);
            this.bt_sua.TabIndex = 0;
            this.bt_sua.Text = "xoa";
            this.bt_sua.TextColor = System.Drawing.Color.Black;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.SlateGray;
            this.bt_xoa.BackgroundColor = System.Drawing.Color.SlateGray;
            this.bt_xoa.BorderColor = System.Drawing.Color.Transparent;
            this.bt_xoa.BorderRadius = 32;
            this.bt_xoa.BorderSize = -1;
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Black;
            this.bt_xoa.Location = new System.Drawing.Point(11, 20);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(76, 32);
            this.bt_xoa.TabIndex = 0;
            this.bt_xoa.Text = "xoa";
            this.bt_xoa.TextColor = System.Drawing.Color.Black;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // pic_avata
            // 
            this.pic_avata.BorderGradientBottom = System.Drawing.Color.CadetBlue;
            this.pic_avata.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.pic_avata.BorderRadius = 40;
            this.pic_avata.BorderSize = -1;
            this.pic_avata.GradientAngle = 90F;
            this.pic_avata.Location = new System.Drawing.Point(25, 0);
            this.pic_avata.Name = "pic_avata";
            this.pic_avata.Size = new System.Drawing.Size(137, 137);
            this.pic_avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avata.TabIndex = 1;
            this.pic_avata.TabStop = false;
            // 
            // pn_bg
            // 
            this.pn_bg.BackColor = System.Drawing.Color.White;
            this.pn_bg.BorderRadius1 = 30;
            this.pn_bg.Controls.Add(this.lb_masp);
            this.pn_bg.Controls.Add(this.pictureBox2);
            this.pn_bg.Controls.Add(this.bt_them);
            this.pn_bg.Controls.Add(this.label3);
            this.pn_bg.Controls.Add(this.lb_daban);
            this.pn_bg.Controls.Add(this.lb_danhgia);
            this.pn_bg.Controls.Add(this.label2);
            this.pn_bg.Controls.Add(this.lb_ten);
            this.pn_bg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_bg.ForeColor = System.Drawing.Color.Black;
            this.pn_bg.GradientAngle = 90F;
            this.pn_bg.GradientBottomColor1 = System.Drawing.Color.Transparent;
            this.pn_bg.GradientTopColor = System.Drawing.Color.Transparent;
            this.pn_bg.Location = new System.Drawing.Point(0, 55);
            this.pn_bg.Name = "pn_bg";
            this.pn_bg.Size = new System.Drawing.Size(190, 180);
            this.pn_bg.TabIndex = 0;
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.BackColor = System.Drawing.Color.Transparent;
            this.lb_masp.ForeColor = System.Drawing.Color.Transparent;
            this.lb_masp.Location = new System.Drawing.Point(8, 162);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(35, 13);
            this.lb_masp.TabIndex = 3;
            this.lb_masp.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::HiBanhMi_v1_2.Properties.Resources.danhgiavang;
            this.pictureBox2.Location = new System.Drawing.Point(96, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_them.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.bt_them.BackgroundImage = global::HiBanhMi_v1_2.Properties.Resources.add;
            this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_them.BorderColor = System.Drawing.Color.Transparent;
            this.bt_them.BorderRadius = 38;
            this.bt_them.BorderSize = -1;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_them.Location = new System.Drawing.Point(131, 122);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(50, 50);
            this.bt_them.TabIndex = 2;
            this.bt_them.TextColor = System.Drawing.SystemColors.Window;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "đã bán";
            // 
            // lb_daban
            // 
            this.lb_daban.AutoSize = true;
            this.lb_daban.BackColor = System.Drawing.Color.Transparent;
            this.lb_daban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_daban.Location = new System.Drawing.Point(60, 140);
            this.lb_daban.Name = "lb_daban";
            this.lb_daban.Size = new System.Drawing.Size(27, 15);
            this.lb_daban.TabIndex = 1;
            this.lb_daban.Text = "5.0";
            // 
            // lb_danhgia
            // 
            this.lb_danhgia.AutoSize = true;
            this.lb_danhgia.BackColor = System.Drawing.Color.Transparent;
            this.lb_danhgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhgia.Location = new System.Drawing.Point(67, 125);
            this.lb_danhgia.Name = "lb_danhgia";
            this.lb_danhgia.Size = new System.Drawing.Size(27, 15);
            this.lb_danhgia.TabIndex = 1;
            this.lb_danhgia.Text = "5.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "đánh giá";
            // 
            // lb_ten
            // 
            this.lb_ten.BackColor = System.Drawing.Color.Transparent;
            this.lb_ten.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(21, 85);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(141, 41);
            this.lb_ten.TabIndex = 0;
            this.lb_ten.Text = "Bánh mì thịt nướng";
            this.lb_ten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.fpn);
            this.Controls.Add(this.pn_chon);
            this.Controls.Add(this.pic_admin);
            this.Controls.Add(this.pic_avata);
            this.Controls.Add(this.pn_bg);
            this.Name = "item";
            this.Size = new System.Drawing.Size(190, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).EndInit();
            this.fpn.ResumeLayout(false);
            this.fpn.PerformLayout();
            this.pn_chon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avata)).EndInit();
            this.pn_bg.ResumeLayout(false);
            this.pn_bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.PanelCustom pn_bg;
        private CustomPictureBox.PictureBoxCustom pic_avata;
        private CustomButton.NutCustom bt_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_admin;
        private System.Windows.Forms.Label lb_daban;
        private System.Windows.Forms.Label lb_danhgia;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.FlowLayoutPanel fpn;
        private System.Windows.Forms.Label lb_giamgia;
        private System.Windows.Forms.Label label1;
        private ArtanComponent.PanelCustom pn_chon;
        private CustomButton.NutCustom bt_xoa;
        private CustomButton.NutCustom bt_sua;
    }
}
