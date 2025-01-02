namespace HiBanhMi_v1_2.UseControl
{
    partial class gioitinh
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_nam = new System.Windows.Forms.Label();
            this.lb_nu = new System.Windows.Forms.Label();
            this.lb_khac = new System.Windows.Forms.Label();
            this.tgxuong = new System.Windows.Forms.Timer(this.components);
            this.tglen = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 2);
            this.label2.TabIndex = 4;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(2, 1);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(35, 15);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Title";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "choice";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lb_nam);
            this.flowLayoutPanel1.Controls.Add(this.lb_nu);
            this.flowLayoutPanel1.Controls.Add(this.lb_khac);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 75);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lb_nam
            // 
            this.lb_nam.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_nam.Location = new System.Drawing.Point(3, 0);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(119, 25);
            this.lb_nam.TabIndex = 0;
            this.lb_nam.Text = "Nam";
            this.lb_nam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_nam.Click += new System.EventHandler(this.lb_nam_Click);
            // 
            // lb_nu
            // 
            this.lb_nu.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_nu.Location = new System.Drawing.Point(3, 25);
            this.lb_nu.Name = "lb_nu";
            this.lb_nu.Size = new System.Drawing.Size(119, 25);
            this.lb_nu.TabIndex = 0;
            this.lb_nu.Text = "Nữ";
            this.lb_nu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_nu.Click += new System.EventHandler(this.lb_nu_Click);
            // 
            // lb_khac
            // 
            this.lb_khac.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_khac.Location = new System.Drawing.Point(3, 50);
            this.lb_khac.Name = "lb_khac";
            this.lb_khac.Size = new System.Drawing.Size(119, 25);
            this.lb_khac.TabIndex = 0;
            this.lb_khac.Text = "Khác";
            this.lb_khac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_khac.Click += new System.EventHandler(this.lb_khac_Click);
            // 
            // tgxuong
            // 
            this.tgxuong.Interval = 1;
            this.tgxuong.Tick += new System.EventHandler(this.tgxuong_Tick);
            // 
            // tglen
            // 
            this.tglen.Interval = 1;
            this.tglen.Tick += new System.EventHandler(this.tglen_Tick);
            // 
            // gioitinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "gioitinh";
            this.Size = new System.Drawing.Size(125, 50);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.Label lb_nu;
        private System.Windows.Forms.Label lb_khac;
        private System.Windows.Forms.Timer tgxuong;
        private System.Windows.Forms.Timer tglen;
    }
}
