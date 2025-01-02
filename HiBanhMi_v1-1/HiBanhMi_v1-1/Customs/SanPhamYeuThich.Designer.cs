namespace luotdanhgiasanpham.chinh
{
    partial class SanPhamYeuThich
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
            this.pn_background = new ArtanComponent.PanelCustom();
            this.lb_luotthich = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.pn_anhsp = new ArtanComponent.PanelCustom();
            this.pic_timhong = new System.Windows.Forms.PictureBox();
            this.pn_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_timhong)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_background
            // 
            this.pn_background.BackColor = System.Drawing.Color.White;
            this.pn_background.BorderRadius1 = 40;
            this.pn_background.Controls.Add(this.lb_luotthich);
            this.pn_background.Controls.Add(this.pic_timhong);
            this.pn_background.Controls.Add(this.label2);
            this.pn_background.Controls.Add(this.lb_tensp);
            this.pn_background.Controls.Add(this.pn_anhsp);
            this.pn_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_background.ForeColor = System.Drawing.Color.Black;
            this.pn_background.GradientAngle = 90F;
            this.pn_background.GradientBottomColor1 = System.Drawing.Color.Transparent;
            this.pn_background.GradientTopColor = System.Drawing.Color.Transparent;
            this.pn_background.Location = new System.Drawing.Point(0, 0);
            this.pn_background.Name = "pn_background";
            this.pn_background.Size = new System.Drawing.Size(360, 160);
            this.pn_background.TabIndex = 0;
            // 
            // lb_luotthich
            // 
            this.lb_luotthich.AutoSize = true;
            this.lb_luotthich.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luotthich.Location = new System.Drawing.Point(235, 100);
            this.lb_luotthich.Name = "lb_luotthich";
            this.lb_luotthich.Size = new System.Drawing.Size(51, 39);
            this.lb_luotthich.TabIndex = 4;
            this.lb_luotthich.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sản Phẩm Được";
            // 
            // lb_tensp
            // 
            this.lb_tensp.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tensp.Location = new System.Drawing.Point(153, 14);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(194, 63);
            this.lb_tensp.TabIndex = 1;
            this.lb_tensp.Text = "TÊN SẢN PHẨM Ở ĐÂY";
            // 
            // pn_anhsp
            // 
            this.pn_anhsp.BackColor = System.Drawing.Color.Silver;
            this.pn_anhsp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_anhsp.BorderRadius1 = 30;
            this.pn_anhsp.ForeColor = System.Drawing.Color.Black;
            this.pn_anhsp.GradientAngle = 90F;
            this.pn_anhsp.GradientBottomColor1 = System.Drawing.Color.Transparent;
            this.pn_anhsp.GradientTopColor = System.Drawing.Color.Transparent;
            this.pn_anhsp.Location = new System.Drawing.Point(14, 14);
            this.pn_anhsp.Name = "pn_anhsp";
            this.pn_anhsp.Size = new System.Drawing.Size(133, 133);
            this.pn_anhsp.TabIndex = 0;
            // 
            // pic_timhong
            // 
            this.pic_timhong.Location = new System.Drawing.Point(197, 103);
            this.pic_timhong.Name = "pic_timhong";
            this.pic_timhong.Size = new System.Drawing.Size(35, 35);
            this.pic_timhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_timhong.TabIndex = 3;
            this.pic_timhong.TabStop = false;
            // 
            // SanPhamYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pn_background);
            this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SanPhamYeuThich";
            this.Size = new System.Drawing.Size(360, 160);
            this.pn_background.ResumeLayout(false);
            this.pn_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_timhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.PanelCustom pn_background;
        private System.Windows.Forms.Label lb_tensp;
        private ArtanComponent.PanelCustom pn_anhsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_luotthich;
        private System.Windows.Forms.PictureBox pic_timhong;
    }
}
