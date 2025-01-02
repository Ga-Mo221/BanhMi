namespace HiBanhMi_v1_1
{
    partial class texboxcustom
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
            this.body = new ArtanComponent.PanelCustom();
            this.NoiDung = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.BorderRadius1 = 20;
            this.body.Controls.Add(this.NoiDung);
            this.body.Controls.Add(this.line);
            this.body.Controls.Add(this.Title);
            this.body.ForeColor = System.Drawing.Color.Black;
            this.body.GradientAngle = 90F;
            this.body.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.body.GradientTopColor = System.Drawing.Color.Silver;
            this.body.Location = new System.Drawing.Point(18, 13);
            this.body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(327, 62);
            this.body.TabIndex = 0;
            // 
            // NoiDung
            // 
            this.NoiDung.BackColor = System.Drawing.Color.Silver;
            this.NoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoiDung.CausesValidation = false;
            this.NoiDung.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.Location = new System.Drawing.Point(12, 21);
            this.NoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(303, 22);
            this.NoiDung.TabIndex = 1;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Turquoise;
            this.line.Location = new System.Drawing.Point(12, 54);
            this.line.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(302, 12);
            this.line.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 11F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(8, 1);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(54, 19);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // texboxcustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.body);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "texboxcustom";
            this.Size = new System.Drawing.Size(327, 62);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.PanelCustom body;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox NoiDung;
    }
}
