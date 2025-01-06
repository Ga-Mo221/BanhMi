namespace HiBanhMi_v1_2.Forms
{
    partial class giohang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_giohang = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_thanhtoan = new CustomButton.NutCustom();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_giohang);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 47);
            this.panel1.TabIndex = 0;
            // 
            // lb_giohang
            // 
            this.lb_giohang.AutoSize = true;
            this.lb_giohang.BackColor = System.Drawing.Color.Transparent;
            this.lb_giohang.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giohang.Location = new System.Drawing.Point(29, 9);
            this.lb_giohang.Name = "lb_giohang";
            this.lb_giohang.Size = new System.Drawing.Size(126, 31);
            this.lb_giohang.TabIndex = 3;
            this.lb_giohang.Text = "Gio Hang";
            // 
            // bt_exit
            // 
            this.bt_exit.BackgroundImage = global::HiBanhMi_v1_2.Properties.Resources.Exit;
            this.bt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Location = new System.Drawing.Point(527, 4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(46, 43);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // fpn
            // 
            this.fpn.AutoScroll = true;
            this.fpn.Location = new System.Drawing.Point(24, 53);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(549, 386);
            this.fpn.TabIndex = 1;
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_thanhtoan.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bt_thanhtoan.BorderColor = System.Drawing.Color.Transparent;
            this.bt_thanhtoan.BorderRadius = 43;
            this.bt_thanhtoan.BorderSize = 0;
            this.bt_thanhtoan.FlatAppearance.BorderSize = 0;
            this.bt_thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thanhtoan.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.bt_thanhtoan.Location = new System.Drawing.Point(381, 447);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(145, 43);
            this.bt_thanhtoan.TabIndex = 2;
            this.bt_thanhtoan.Text = "thanh toan";
            this.bt_thanhtoan.TextColor = System.Drawing.Color.White;
            this.bt_thanhtoan.UseVisualStyleBackColor = false;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 80;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.BackColor = System.Drawing.Color.Transparent;
            this.lb_tongtien.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.Location = new System.Drawing.Point(137, 453);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(90, 27);
            this.lb_tongtien.TabIndex = 3;
            this.lb_tongtien.Text = "150000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "VND";
            // 
            // giohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.bt_thanhtoan);
            this.Controls.Add(this.fpn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giohang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giohang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private CustomButton.NutCustom bt_thanhtoan;
        private System.Windows.Forms.FlowLayoutPanel fpn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_giohang;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tongtien;
    }
}