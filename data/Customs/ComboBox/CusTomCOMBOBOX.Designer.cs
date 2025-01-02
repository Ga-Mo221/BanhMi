namespace comboobox.cust_combobox
{
    partial class CusTomCOMBOBOX
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
            this.pn_hienthi = new ArtanComponent.PanelCustom();
            this.pn_listitem = new System.Windows.Forms.Panel();
            this.FLPItem = new System.Windows.Forms.FlowLayoutPanel();
            this.bo_gocWinform1 = new Bo_GocWinfrom.Bo_gocWinform();
            this.tgxuong = new System.Windows.Forms.Timer(this.components);
            this.tglen = new System.Windows.Forms.Timer(this.components);
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.pic_option = new System.Windows.Forms.PictureBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_luachon = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.pn_hienthi.SuspendLayout();
            this.pn_listitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_option)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_hienthi
            // 
            this.pn_hienthi.BackColor = System.Drawing.Color.Silver;
            this.pn_hienthi.BorderRadius1 = 20;
            this.pn_hienthi.Controls.Add(this.line);
            this.pn_hienthi.Controls.Add(this.lb_luachon);
            this.pn_hienthi.Controls.Add(this.lb_Title);
            this.pn_hienthi.Controls.Add(this.pic_option);
            this.pn_hienthi.Controls.Add(this.pic_icon);
            this.pn_hienthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_hienthi.ForeColor = System.Drawing.Color.Black;
            this.pn_hienthi.GradientAngle = 90F;
            this.pn_hienthi.GradientBottomColor1 = System.Drawing.Color.Silver;
            this.pn_hienthi.GradientTopColor = System.Drawing.Color.Silver;
            this.pn_hienthi.Location = new System.Drawing.Point(0, 0);
            this.pn_hienthi.Margin = new System.Windows.Forms.Padding(0);
            this.pn_hienthi.Name = "pn_hienthi";
            this.pn_hienthi.Size = new System.Drawing.Size(200, 50);
            this.pn_hienthi.TabIndex = 0;
            // 
            // pn_listitem
            // 
            this.pn_listitem.BackColor = System.Drawing.Color.Silver;
            this.pn_listitem.Controls.Add(this.FLPItem);
            this.pn_listitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_listitem.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_listitem.Location = new System.Drawing.Point(0, 50);
            this.pn_listitem.Margin = new System.Windows.Forms.Padding(5);
            this.pn_listitem.Name = "pn_listitem";
            this.pn_listitem.Size = new System.Drawing.Size(200, 0);
            this.pn_listitem.TabIndex = 1;
            // 
            // FLPItem
            // 
            this.FLPItem.AutoScroll = true;
            this.FLPItem.BackColor = System.Drawing.Color.Transparent;
            this.FLPItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPItem.Location = new System.Drawing.Point(0, 0);
            this.FLPItem.Name = "FLPItem";
            this.FLPItem.Size = new System.Drawing.Size(200, 0);
            this.FLPItem.TabIndex = 0;
            // 
            // bo_gocWinform1
            // 
            this.bo_gocWinform1.ConrnerRedius = 20;
            this.bo_gocWinform1.TargetControl = this.pn_listitem;
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
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.Location = new System.Drawing.Point(5, 10);
            this.pic_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(30, 30);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_icon.TabIndex = 0;
            this.pic_icon.TabStop = false;
            // 
            // pic_option
            // 
            this.pic_option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_option.BackColor = System.Drawing.Color.Transparent;
            this.pic_option.Location = new System.Drawing.Point(163, 10);
            this.pic_option.Margin = new System.Windows.Forms.Padding(0);
            this.pic_option.Name = "pic_option";
            this.pic_option.Size = new System.Drawing.Size(30, 30);
            this.pic_option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_option.TabIndex = 0;
            this.pic_option.TabStop = false;
            this.pic_option.Click += new System.EventHandler(this.pic_option_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(37, -1);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(60, 21);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Title";
            // 
            // lb_luachon
            // 
            this.lb_luachon.AutoSize = true;
            this.lb_luachon.BackColor = System.Drawing.Color.Transparent;
            this.lb_luachon.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luachon.Location = new System.Drawing.Point(52, 19);
            this.lb_luachon.Margin = new System.Windows.Forms.Padding(0);
            this.lb_luachon.Name = "lb_luachon";
            this.lb_luachon.Size = new System.Drawing.Size(48, 17);
            this.lb_luachon.TabIndex = 1;
            this.lb_luachon.Text = "Chọn ";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Cyan;
            this.line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line.ForeColor = System.Drawing.Color.Aqua;
            this.line.Location = new System.Drawing.Point(0, 45);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(200, 5);
            this.line.TabIndex = 0;
            // 
            // CusTomCOMBOBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pn_listitem);
            this.Controls.Add(this.pn_hienthi);
            this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CusTomCOMBOBOX";
            this.Size = new System.Drawing.Size(200, 50);
            this.pn_hienthi.ResumeLayout(false);
            this.pn_hienthi.PerformLayout();
            this.pn_listitem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_option)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.PanelCustom pn_hienthi;
        private System.Windows.Forms.Panel pn_listitem;
        private System.Windows.Forms.FlowLayoutPanel FLPItem;
        private Bo_GocWinfrom.Bo_gocWinform bo_gocWinform1;
        private System.Windows.Forms.Timer tgxuong;
        private System.Windows.Forms.Timer tglen;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pic_option;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label lb_luachon;
        private System.Windows.Forms.Label line;
    }
}
