namespace HiBanhMi_v1_2.Forms
{
    partial class YeuThichform
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
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.fpn_yeuthich = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 50;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // fpn_yeuthich
            // 
            this.fpn_yeuthich.AutoScroll = true;
            this.fpn_yeuthich.Location = new System.Drawing.Point(30, 96);
            this.fpn_yeuthich.Name = "fpn_yeuthich";
            this.fpn_yeuthich.Size = new System.Drawing.Size(1016, 596);
            this.fpn_yeuthich.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sach yeu thich";
            // 
            // YeuThichform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fpn_yeuthich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeuThichform";
            this.Text = "YeuThichform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.FlowLayoutPanel fpn_yeuthich;
        private System.Windows.Forms.Label label1;
    }
}