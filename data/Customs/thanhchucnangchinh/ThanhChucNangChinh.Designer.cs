namespace ThanhChucNangChinh.chinh
{
    partial class ThanhChucNangChinh
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
            this.tgHome = new System.Windows.Forms.Timer(this.components);
            this.tgMenu = new System.Windows.Forms.Timer(this.components);
            this.tgYeuThich = new System.Windows.Forms.Timer(this.components);
            this.tgLichSu = new System.Windows.Forms.Timer(this.components);
            this.tgSetting = new System.Windows.Forms.Timer(this.components);
            this.pn_main = new ArtanComponent.PanelCustom();
            this.pic_setting = new CustomPictureBox.PictureBoxCustom();
            this.pic_lichsu = new CustomPictureBox.PictureBoxCustom();
            this.pic_yeuthich = new CustomPictureBox.PictureBoxCustom();
            this.pic_menu = new CustomPictureBox.PictureBoxCustom();
            this.pic_home = new CustomPictureBox.PictureBoxCustom();
            this.pic_chuyen = new System.Windows.Forms.PictureBox();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lichsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yeuthich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tgHome
            // 
            this.tgHome.Interval = 1;
            this.tgHome.Tick += new System.EventHandler(this.tgHome_Tick);
            // 
            // tgMenu
            // 
            this.tgMenu.Interval = 1;
            this.tgMenu.Tick += new System.EventHandler(this.tgMenu_Tick);
            // 
            // tgYeuThich
            // 
            this.tgYeuThich.Interval = 1;
            this.tgYeuThich.Tick += new System.EventHandler(this.tgYeuThich_Tick);
            // 
            // tgLichSu
            // 
            this.tgLichSu.Interval = 1;
            this.tgLichSu.Tick += new System.EventHandler(this.tgLichSu_Tick);
            // 
            // tgSetting
            // 
            this.tgSetting.Interval = 1;
            this.tgSetting.Tick += new System.EventHandler(this.tgSetting_Tick);
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.BorderRadius1 = 90;
            this.pn_main.Controls.Add(this.pic_setting);
            this.pn_main.Controls.Add(this.pic_lichsu);
            this.pn_main.Controls.Add(this.pic_yeuthich);
            this.pn_main.Controls.Add(this.pic_menu);
            this.pn_main.Controls.Add(this.pic_home);
            this.pn_main.Controls.Add(this.pic_chuyen);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.ForeColor = System.Drawing.Color.Black;
            this.pn_main.GradientAngle = 90F;
            this.pn_main.GradientBottomColor1 = System.Drawing.Color.Black;
            this.pn_main.GradientTopColor = System.Drawing.Color.Black;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Margin = new System.Windows.Forms.Padding(0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(90, 580);
            this.pn_main.TabIndex = 0;
            // 
            // pic_setting
            // 
            this.pic_setting.BackColor = System.Drawing.Color.Transparent;
            this.pic_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_setting.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.pic_setting.BorderGradientTop = System.Drawing.Color.Transparent;
            this.pic_setting.BorderRadius = 40;
            this.pic_setting.BorderSize = -1;
            this.pic_setting.GradientAngle = 90F;
            this.pic_setting.Location = new System.Drawing.Point(18, 440);
            this.pic_setting.Name = "pic_setting";
            this.pic_setting.Size = new System.Drawing.Size(55, 55);
            this.pic_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_setting.TabIndex = 1;
            this.pic_setting.TabStop = false;
            this.pic_setting.Click += new System.EventHandler(this.pic_setting_Click);
            // 
            // pic_lichsu
            // 
            this.pic_lichsu.BackColor = System.Drawing.Color.Transparent;
            this.pic_lichsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_lichsu.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.pic_lichsu.BorderGradientTop = System.Drawing.Color.Transparent;
            this.pic_lichsu.BorderRadius = 40;
            this.pic_lichsu.BorderSize = -1;
            this.pic_lichsu.GradientAngle = 90F;
            this.pic_lichsu.Location = new System.Drawing.Point(18, 299);
            this.pic_lichsu.Name = "pic_lichsu";
            this.pic_lichsu.Size = new System.Drawing.Size(55, 55);
            this.pic_lichsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_lichsu.TabIndex = 1;
            this.pic_lichsu.TabStop = false;
            this.pic_lichsu.Click += new System.EventHandler(this.pic_lichsu_Click);
            // 
            // pic_yeuthich
            // 
            this.pic_yeuthich.BackColor = System.Drawing.Color.Transparent;
            this.pic_yeuthich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_yeuthich.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.pic_yeuthich.BorderGradientTop = System.Drawing.Color.Transparent;
            this.pic_yeuthich.BorderRadius = 40;
            this.pic_yeuthich.BorderSize = -1;
            this.pic_yeuthich.GradientAngle = 90F;
            this.pic_yeuthich.Location = new System.Drawing.Point(18, 230);
            this.pic_yeuthich.Name = "pic_yeuthich";
            this.pic_yeuthich.Size = new System.Drawing.Size(55, 55);
            this.pic_yeuthich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_yeuthich.TabIndex = 1;
            this.pic_yeuthich.TabStop = false;
            this.pic_yeuthich.Click += new System.EventHandler(this.pic_yeuthich_Click);
            // 
            // pic_menu
            // 
            this.pic_menu.BackColor = System.Drawing.Color.Transparent;
            this.pic_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_menu.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.pic_menu.BorderGradientTop = System.Drawing.Color.Transparent;
            this.pic_menu.BorderRadius = 40;
            this.pic_menu.BorderSize = -1;
            this.pic_menu.GradientAngle = 90F;
            this.pic_menu.Location = new System.Drawing.Point(18, 160);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(55, 55);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_menu.TabIndex = 1;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pic_menu_Click);
            // 
            // pic_home
            // 
            this.pic_home.BackColor = System.Drawing.Color.Transparent;
            this.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_home.BorderGradientBottom = System.Drawing.Color.Transparent;
            this.pic_home.BorderGradientTop = System.Drawing.Color.Transparent;
            this.pic_home.BorderRadius = 40;
            this.pic_home.BorderSize = -1;
            this.pic_home.GradientAngle = 90F;
            this.pic_home.Location = new System.Drawing.Point(18, 89);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(55, 55);
            this.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_home.TabIndex = 1;
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // pic_chuyen
            // 
            this.pic_chuyen.BackColor = System.Drawing.Color.Transparent;
            this.pic_chuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_chuyen.Location = new System.Drawing.Point(0, 250);
            this.pic_chuyen.Margin = new System.Windows.Forms.Padding(0);
            this.pic_chuyen.Name = "pic_chuyen";
            this.pic_chuyen.Size = new System.Drawing.Size(90, 153);
            this.pic_chuyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_chuyen.TabIndex = 0;
            this.pic_chuyen.TabStop = false;
            // 
            // ThanhChucNangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pn_main);
            this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThanhChucNangChinh";
            this.Size = new System.Drawing.Size(90, 580);
            this.pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lichsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yeuthich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.PanelCustom pn_main;
        private System.Windows.Forms.PictureBox pic_chuyen;
        private CustomPictureBox.PictureBoxCustom pic_lichsu;
        private CustomPictureBox.PictureBoxCustom pic_yeuthich;
        private CustomPictureBox.PictureBoxCustom pic_menu;
        private CustomPictureBox.PictureBoxCustom pic_home;
        private CustomPictureBox.PictureBoxCustom pic_setting;
        private System.Windows.Forms.Timer tgHome;
        private System.Windows.Forms.Timer tgMenu;
        private System.Windows.Forms.Timer tgYeuThich;
        private System.Windows.Forms.Timer tgLichSu;
        private System.Windows.Forms.Timer tgSetting;
    }
}
