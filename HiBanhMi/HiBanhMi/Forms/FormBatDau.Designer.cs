namespace HiBanhMi.Forms
{
    partial class FormBatDau
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
            this.pnchon = new System.Windows.Forms.Panel();
            this.thanhchonchucnang1 = new HiBanhMi.customs.thanhchonchucnang();
            this.pnxuatchon = new System.Windows.Forms.Panel();
            this.pnchon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnchon
            // 
            this.pnchon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnchon.Controls.Add(this.thanhchonchucnang1);
            this.pnchon.Location = new System.Drawing.Point(0, 0);
            this.pnchon.Name = "pnchon";
            this.pnchon.Size = new System.Drawing.Size(77, 484);
            this.pnchon.TabIndex = 0;
            // 
            // thanhchonchucnang1
            // 
            this.thanhchonchucnang1.BackColor = System.Drawing.Color.RosyBrown;
            this.thanhchonchucnang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thanhchonchucnang1.Location = new System.Drawing.Point(0, 0);
            this.thanhchonchucnang1.Margin = new System.Windows.Forms.Padding(0);
            this.thanhchonchucnang1.Name = "thanhchonchucnang1";
            this.thanhchonchucnang1.Size = new System.Drawing.Size(62, 387);
            this.thanhchonchucnang1.TabIndex = 0;
            // 
            // pnxuatchon
            // 
            this.pnxuatchon.BackColor = System.Drawing.Color.White;
            this.pnxuatchon.Location = new System.Drawing.Point(83, 0);
            this.pnxuatchon.Name = "pnxuatchon";
            this.pnxuatchon.Size = new System.Drawing.Size(899, 484);
            this.pnxuatchon.TabIndex = 1;
            // 
            // FormBatDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 483);
            this.Controls.Add(this.pnxuatchon);
            this.Controls.Add(this.pnchon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBatDau";
            this.Text = "FormBatDau";
            this.pnchon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnxuatchon;
        private customs.thanhchonchucnang thanhchonchucnang1;
        public System.Windows.Forms.Panel pnchon;
    }
}