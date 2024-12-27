namespace HiBanhMi
{
    partial class FormMain
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
            this.btAn = new CustomButton.NutCustom();
            this.btScale = new CustomButton.NutCustom();
            this.btExit = new CustomButton.NutCustom();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnESA = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.pnESA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAn
            // 
            this.btAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAn.BackColor = System.Drawing.Color.Transparent;
            this.btAn.BackgroundColor = System.Drawing.Color.Transparent;
            this.btAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAn.BorderColor = System.Drawing.Color.Transparent;
            this.btAn.BorderRadius = 0;
            this.btAn.BorderSize = 0;
            this.btAn.FlatAppearance.BorderSize = 0;
            this.btAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAn.ForeColor = System.Drawing.Color.White;
            this.btAn.Location = new System.Drawing.Point(15, 3);
            this.btAn.Name = "btAn";
            this.btAn.Size = new System.Drawing.Size(38, 30);
            this.btAn.TabIndex = 0;
            this.btAn.TextColor = System.Drawing.Color.White;
            this.btAn.UseVisualStyleBackColor = false;
            this.btAn.Click += new System.EventHandler(this.btAn_Click);
            // 
            // btScale
            // 
            this.btScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btScale.BackColor = System.Drawing.Color.Transparent;
            this.btScale.BackgroundColor = System.Drawing.Color.Transparent;
            this.btScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btScale.BorderColor = System.Drawing.Color.Transparent;
            this.btScale.BorderRadius = 0;
            this.btScale.BorderSize = 0;
            this.btScale.FlatAppearance.BorderSize = 0;
            this.btScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScale.ForeColor = System.Drawing.Color.White;
            this.btScale.Location = new System.Drawing.Point(75, 3);
            this.btScale.Name = "btScale";
            this.btScale.Size = new System.Drawing.Size(38, 30);
            this.btScale.TabIndex = 0;
            this.btScale.TextColor = System.Drawing.Color.White;
            this.btScale.UseVisualStyleBackColor = false;
            this.btScale.Click += new System.EventHandler(this.btScale_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExit.BorderColor = System.Drawing.Color.Transparent;
            this.btExit.BorderRadius = 0;
            this.btExit.BorderSize = 0;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(152, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(38, 30);
            this.btExit.TabIndex = 0;
            this.btExit.TextColor = System.Drawing.Color.White;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.pnESA);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1000, 525);
            this.pnMain.TabIndex = 1;
            // 
            // pnESA
            // 
            this.pnESA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnESA.Controls.Add(this.btAn);
            this.pnESA.Controls.Add(this.btExit);
            this.pnESA.Controls.Add(this.btScale);
            this.pnESA.Location = new System.Drawing.Point(794, 3);
            this.pnESA.Name = "pnESA";
            this.pnESA.Size = new System.Drawing.Size(203, 54);
            this.pnESA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.pnMain.ResumeLayout(false);
            this.pnESA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private CustomButton.NutCustom btExit;
        private CustomButton.NutCustom btAn;
        private CustomButton.NutCustom btScale;
        private System.Windows.Forms.Panel pnESA;
    }
}