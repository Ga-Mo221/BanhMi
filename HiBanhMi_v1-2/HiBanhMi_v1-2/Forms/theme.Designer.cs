namespace HiBanhMi_v1_2.Forms
{
    partial class theme
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
            this.lb_chude = new System.Windows.Forms.Label();
            this.lb_chon = new System.Windows.Forms.Label();
            this.fpn_chude = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_themdachon = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_xacnhan = new CustomButton.NutCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_chude
            // 
            this.lb_chude.AutoSize = true;
            this.lb_chude.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chude.Location = new System.Drawing.Point(51, 57);
            this.lb_chude.Name = "lb_chude";
            this.lb_chude.Size = new System.Drawing.Size(154, 49);
            this.lb_chude.TabIndex = 0;
            this.lb_chude.Text = "Chu De";
            // 
            // lb_chon
            // 
            this.lb_chon.AutoSize = true;
            this.lb_chon.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chon.Location = new System.Drawing.Point(180, 136);
            this.lb_chon.Name = "lb_chon";
            this.lb_chon.Size = new System.Drawing.Size(133, 25);
            this.lb_chon.TabIndex = 0;
            this.lb_chon.Text = "Chon Chu De";
            // 
            // fpn_chude
            // 
            this.fpn_chude.Location = new System.Drawing.Point(394, 136);
            this.fpn_chude.Name = "fpn_chude";
            this.fpn_chude.Size = new System.Drawing.Size(258, 347);
            this.fpn_chude.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(358, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 380);
            this.label4.TabIndex = 0;
            // 
            // lb_themdachon
            // 
            this.lb_themdachon.AutoSize = true;
            this.lb_themdachon.Location = new System.Drawing.Point(112, 0);
            this.lb_themdachon.Name = "lb_themdachon";
            this.lb_themdachon.Size = new System.Drawing.Size(55, 13);
            this.lb_themdachon.TabIndex = 9;
            this.lb_themdachon.Text = "hi banh mi";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(3, 0);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(103, 13);
            this.lb_thongbao.TabIndex = 10;
            this.lb_thongbao.Text = "ban da chon chu de";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_thongbao);
            this.flowLayoutPanel1.Controls.Add(this.lb_themdachon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 612);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 16);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.bt_xacnhan.TabIndex = 2;
            this.bt_xacnhan.Text = "nutCustom1";
            this.bt_xacnhan.TextColor = System.Drawing.Color.Black;
            this.bt_xacnhan.UseVisualStyleBackColor = false;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(787, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.fpn_chude);
            this.Controls.Add(this.lb_chon);
            this.Controls.Add(this.lb_chude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "theme";
            this.Text = "hi banh mi";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_chude;
        private System.Windows.Forms.Label lb_chon;
        private System.Windows.Forms.FlowLayoutPanel fpn_chude;
        private System.Windows.Forms.Label label4;
        private CustomButton.NutCustom bt_xacnhan;
        private System.Windows.Forms.Label lb_themdachon;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}