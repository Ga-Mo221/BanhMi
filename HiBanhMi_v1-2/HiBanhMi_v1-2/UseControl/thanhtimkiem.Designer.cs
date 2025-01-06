namespace HiBanhMi_v1_2.UseControl
{
    partial class thanhtimkiem
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
            this.pictureBoxCustom1 = new CustomPictureBox.PictureBoxCustom();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tgtrai = new System.Windows.Forms.Timer(this.components);
            this.tgphai = new System.Windows.Forms.Timer(this.components);
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCustom1
            // 
            this.pictureBoxCustom1.BorderGradientBottom = System.Drawing.Color.Black;
            this.pictureBoxCustom1.BorderGradientTop = System.Drawing.Color.Black;
            this.pictureBoxCustom1.BorderRadius = 40;
            this.pictureBoxCustom1.BorderSize = 1;
            this.pictureBoxCustom1.GradientAngle = 90F;
            this.pictureBoxCustom1.Image = global::HiBanhMi_v1_2.Properties.Resources.timkiem;
            this.pictureBoxCustom1.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxCustom1.Name = "pictureBoxCustom1";
            this.pictureBoxCustom1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustom1.TabIndex = 0;
            this.pictureBoxCustom1.TabStop = false;
            this.pictureBoxCustom1.Click += new System.EventHandler(this.pictureBoxCustom1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(60, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tgtrai
            // 
            this.tgtrai.Interval = 1;
            this.tgtrai.Tick += new System.EventHandler(this.tgtrai_Tick);
            // 
            // tgphai
            // 
            this.tgphai.Interval = 1;
            this.tgphai.Tick += new System.EventHandler(this.tgphai_Tick);
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 60;
            this.bo_gocWinform1.TargetControl = this;
            // 
            // thanhtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxCustom1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "thanhtimkiem";
            this.Size = new System.Drawing.Size(60, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private CustomPictureBox.PictureBoxCustom pictureBoxCustom1;
        private System.Windows.Forms.Timer tgtrai;
        private System.Windows.Forms.Timer tgphai;
        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
    }
}
