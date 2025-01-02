namespace HiBanhMi_v1_2.UseControl
{
    partial class sinhnhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_sinhnhat = new System.Windows.Forms.Label();
            this.fpn_ngay = new System.Windows.Forms.FlowLayoutPanel();
            this.fpn_thang = new System.Windows.Forms.FlowLayoutPanel();
            this.fpn_nam = new System.Windows.Forms.FlowLayoutPanel();
            this.tgxuong = new System.Windows.Forms.Timer(this.components);
            this.tglen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ho va ten";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 2);
            this.label2.TabIndex = 4;
            // 
            // lb_sinhnhat
            // 
            this.lb_sinhnhat.BackColor = System.Drawing.Color.Transparent;
            this.lb_sinhnhat.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_sinhnhat.Location = new System.Drawing.Point(17, 26);
            this.lb_sinhnhat.Name = "lb_sinhnhat";
            this.lb_sinhnhat.Size = new System.Drawing.Size(209, 20);
            this.lb_sinhnhat.TabIndex = 5;
            this.lb_sinhnhat.Text = "dd-mm-yyyy";
            this.lb_sinhnhat.Click += new System.EventHandler(this.lb_sinhnhat_Click);
            // 
            // fpn_ngay
            // 
            this.fpn_ngay.AutoScroll = true;
            this.fpn_ngay.BackColor = System.Drawing.Color.White;
            this.fpn_ngay.Location = new System.Drawing.Point(0, 56);
            this.fpn_ngay.Name = "fpn_ngay";
            this.fpn_ngay.Size = new System.Drawing.Size(95, 144);
            this.fpn_ngay.TabIndex = 6;
            // 
            // fpn_thang
            // 
            this.fpn_thang.AutoScroll = true;
            this.fpn_thang.BackColor = System.Drawing.Color.White;
            this.fpn_thang.Location = new System.Drawing.Point(80, 56);
            this.fpn_thang.Name = "fpn_thang";
            this.fpn_thang.Size = new System.Drawing.Size(95, 144);
            this.fpn_thang.TabIndex = 6;
            // 
            // fpn_nam
            // 
            this.fpn_nam.AutoScroll = true;
            this.fpn_nam.BackColor = System.Drawing.Color.White;
            this.fpn_nam.Location = new System.Drawing.Point(160, 56);
            this.fpn_nam.Name = "fpn_nam";
            this.fpn_nam.Size = new System.Drawing.Size(95, 144);
            this.fpn_nam.TabIndex = 6;
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
            // sinhnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.fpn_nam);
            this.Controls.Add(this.fpn_thang);
            this.Controls.Add(this.fpn_ngay);
            this.Controls.Add(this.lb_sinhnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "sinhnhat";
            this.Size = new System.Drawing.Size(240, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_sinhnhat;
        private System.Windows.Forms.FlowLayoutPanel fpn_ngay;
        private System.Windows.Forms.FlowLayoutPanel fpn_thang;
        private System.Windows.Forms.FlowLayoutPanel fpn_nam;
        private System.Windows.Forms.Timer tgxuong;
        private System.Windows.Forms.Timer tglen;
    }
}
