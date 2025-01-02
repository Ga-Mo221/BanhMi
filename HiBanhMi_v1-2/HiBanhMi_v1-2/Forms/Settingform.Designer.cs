namespace HiBanhMi_v1_2.Forms
{
    partial class Settingform
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_use = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ngonngu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_theme = new System.Windows.Forms.Label();
            this.pn_settingcon = new System.Windows.Forms.Panel();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 630);
            this.label1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_Title);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lb_use);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.lb_ngonngu);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.lb_theme);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 640);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_Title
            // 
            this.lb_Title.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(3, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(190, 69);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Cai Dat";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 5);
            this.label3.TabIndex = 1;
            // 
            // lb_use
            // 
            this.lb_use.BackColor = System.Drawing.Color.Transparent;
            this.lb_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_use.Location = new System.Drawing.Point(3, 74);
            this.lb_use.Name = "lb_use";
            this.lb_use.Size = new System.Drawing.Size(190, 33);
            this.lb_use.TabIndex = 2;
            this.lb_use.Text = "Tai khoan";
            this.lb_use.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_use.Click += new System.EventHandler(this.lb_use_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 1);
            this.label2.TabIndex = 3;
            // 
            // lb_ngonngu
            // 
            this.lb_ngonngu.BackColor = System.Drawing.Color.Transparent;
            this.lb_ngonngu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngonngu.Location = new System.Drawing.Point(3, 108);
            this.lb_ngonngu.Name = "lb_ngonngu";
            this.lb_ngonngu.Size = new System.Drawing.Size(190, 33);
            this.lb_ngonngu.TabIndex = 2;
            this.lb_ngonngu.Text = "ngon ngu";
            this.lb_ngonngu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ngonngu.Click += new System.EventHandler(this.lb_ngonngu_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 1);
            this.label4.TabIndex = 3;
            // 
            // lb_theme
            // 
            this.lb_theme.BackColor = System.Drawing.Color.Transparent;
            this.lb_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_theme.Location = new System.Drawing.Point(3, 142);
            this.lb_theme.Name = "lb_theme";
            this.lb_theme.Size = new System.Drawing.Size(190, 33);
            this.lb_theme.TabIndex = 2;
            this.lb_theme.Text = "chu de";
            this.lb_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_theme.Click += new System.EventHandler(this.lb_theme_Click);
            // 
            // pn_settingcon
            // 
            this.pn_settingcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_settingcon.Location = new System.Drawing.Point(253, 40);
            this.pn_settingcon.Margin = new System.Windows.Forms.Padding(0);
            this.pn_settingcon.Name = "pn_settingcon";
            this.pn_settingcon.Size = new System.Drawing.Size(787, 640);
            this.pn_settingcon.TabIndex = 2;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // Settingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pn_settingcon);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settingform";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "Settingform";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_settingcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_use;
        private System.Windows.Forms.Label lb_ngonngu;
        private System.Windows.Forms.Label lb_theme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}