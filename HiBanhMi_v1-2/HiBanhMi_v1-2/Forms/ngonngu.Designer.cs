namespace HiBanhMi_v1_2.Forms
{
    partial class ngonngu
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
            this.bt_xacnhan = new CustomButton.NutCustom();
            this.label4 = new System.Windows.Forms.Label();
            this.fpn_ngonngu = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_chon = new System.Windows.Forms.Label();
            this.lb_ngonngu = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.lb_ngonngudachon = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_xacnhan.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bt_xacnhan.BorderColor = System.Drawing.Color.Transparent;
            this.bt_xacnhan.BorderRadius = 50;
            this.bt_xacnhan.BorderSize = -1;
            this.bt_xacnhan.FlatAppearance.BorderSize = 0;
            this.bt_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xacnhan.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xacnhan.ForeColor = System.Drawing.Color.Black;
            this.bt_xacnhan.Location = new System.Drawing.Point(577, 553);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(135, 56);
            this.bt_xacnhan.TabIndex = 7;
            this.bt_xacnhan.Text = "nutCustom1";
            this.bt_xacnhan.TextColor = System.Drawing.Color.Black;
            this.bt_xacnhan.UseVisualStyleBackColor = false;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(358, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 380);
            this.label4.TabIndex = 3;
            // 
            // fpn_ngonngu
            // 
            this.fpn_ngonngu.Location = new System.Drawing.Point(394, 136);
            this.fpn_ngonngu.Name = "fpn_ngonngu";
            this.fpn_ngonngu.Size = new System.Drawing.Size(258, 347);
            this.fpn_ngonngu.TabIndex = 6;
            // 
            // lb_chon
            // 
            this.lb_chon.AutoSize = true;
            this.lb_chon.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chon.Location = new System.Drawing.Point(181, 136);
            this.lb_chon.Name = "lb_chon";
            this.lb_chon.Size = new System.Drawing.Size(133, 25);
            this.lb_chon.TabIndex = 4;
            this.lb_chon.Text = "Chon Chu De";
            // 
            // lb_ngonngu
            // 
            this.lb_ngonngu.AutoSize = true;
            this.lb_ngonngu.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngonngu.Location = new System.Drawing.Point(51, 57);
            this.lb_ngonngu.Name = "lb_ngonngu";
            this.lb_ngonngu.Size = new System.Drawing.Size(154, 49);
            this.lb_ngonngu.TabIndex = 5;
            this.lb_ngonngu.Text = "Chu De";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(3, 0);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(118, 13);
            this.lb_thongbao.TabIndex = 8;
            this.lb_thongbao.Text = "ban da chon ngon ngu ";
            // 
            // lb_ngonngudachon
            // 
            this.lb_ngonngudachon.AutoSize = true;
            this.lb_ngonngudachon.Location = new System.Drawing.Point(127, 0);
            this.lb_ngonngudachon.Name = "lb_ngonngudachon";
            this.lb_ngonngudachon.Size = new System.Drawing.Size(50, 13);
            this.lb_ngonngudachon.TabIndex = 8;
            this.lb_ngonngudachon.Text = "tieng viet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_thongbao);
            this.flowLayoutPanel1.Controls.Add(this.lb_ngonngudachon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 606);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 22);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ngonngu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 640);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.fpn_ngonngu);
            this.Controls.Add(this.lb_chon);
            this.Controls.Add(this.lb_ngonngu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ngonngu";
            this.Text = "ngonngu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.NutCustom bt_xacnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel fpn_ngonngu;
        private System.Windows.Forms.Label lb_chon;
        private System.Windows.Forms.Label lb_ngonngu;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Label lb_ngonngudachon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}