namespace HiBanhMi_v1_2.Forms
{
    partial class LichSuform
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
            this.lb_ten = new System.Windows.Forms.Label();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.SuspendLayout();
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 24F, System.Drawing.FontStyle.Bold);
            this.lb_ten.Location = new System.Drawing.Point(32, 19);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(152, 43);
            this.lb_ten.TabIndex = 0;
            this.lb_ten.Text = "Lich Su";
            // 
            // fpn
            // 
            this.fpn.AutoScroll = true;
            this.fpn.Location = new System.Drawing.Point(30, 91);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(1011, 585);
            this.fpn.TabIndex = 1;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // LichSuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.fpn);
            this.Controls.Add(this.lb_ten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichSuform";
            this.Text = "LichSuform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.FlowLayoutPanel fpn;
    }
}