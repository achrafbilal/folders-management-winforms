namespace cdma_folders_manager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlScreens = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btn_nav_new_folder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nav_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlContainer.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlScreens);
            this.pnlContainer.Controls.Add(this.pnlSidebar);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1047, 561);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlScreens
            // 
            this.pnlScreens.BackColor = System.Drawing.Color.White;
            this.pnlScreens.Location = new System.Drawing.Point(201, 0);
            this.pnlScreens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlScreens.Name = "pnlScreens";
            this.pnlScreens.Size = new System.Drawing.Size(845, 561);
            this.pnlScreens.TabIndex = 5;
            this.pnlScreens.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScreens_Paint_1);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btn_nav_new_folder);
            this.pnlSidebar.Controls.Add(this.btnBack);
            this.pnlSidebar.Controls.Add(this.btn_nav_home);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 4;
            // 
            // btn_nav_new_folder
            // 
            this.btn_nav_new_folder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_new_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_new_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nav_new_folder.BorderRadius = 0;
            this.btn_nav_new_folder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_nav_new_folder.ButtonText = "Search folders";
            this.btn_nav_new_folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nav_new_folder.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nav_new_folder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nav_new_folder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nav_new_folder.Iconimage")));
            this.btn_nav_new_folder.Iconimage_right = null;
            this.btn_nav_new_folder.Iconimage_right_Selected = null;
            this.btn_nav_new_folder.Iconimage_Selected = null;
            this.btn_nav_new_folder.IconMarginLeft = 0;
            this.btn_nav_new_folder.IconMarginRight = 0;
            this.btn_nav_new_folder.IconRightVisible = true;
            this.btn_nav_new_folder.IconRightZoom = 0D;
            this.btn_nav_new_folder.IconVisible = true;
            this.btn_nav_new_folder.IconZoom = 60D;
            this.btn_nav_new_folder.IsTab = false;
            this.btn_nav_new_folder.Location = new System.Drawing.Point(0, 176);
            this.btn_nav_new_folder.Name = "btn_nav_new_folder";
            this.btn_nav_new_folder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_new_folder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(15)))));
            this.btn_nav_new_folder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nav_new_folder.selected = false;
            this.btn_nav_new_folder.Size = new System.Drawing.Size(201, 66);
            this.btn_nav_new_folder.TabIndex = 0;
            this.btn_nav_new_folder.Text = "Search folders";
            this.btn_nav_new_folder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nav_new_folder.Textcolor = System.Drawing.Color.White;
            this.btn_nav_new_folder.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nav_new_folder.Click += new System.EventHandler(this.btn_nav_home_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnBack.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 60D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(133, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(15)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(67, 65);
            this.btnBack.TabIndex = 5;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_nav_home
            // 
            this.btn_nav_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_home.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btn_nav_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nav_home.BorderRadius = 0;
            this.btn_nav_home.ButtonText = "Search folders";
            this.btn_nav_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nav_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nav_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nav_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nav_home.Iconimage")));
            this.btn_nav_home.Iconimage_right = null;
            this.btn_nav_home.Iconimage_right_Selected = null;
            this.btn_nav_home.Iconimage_Selected = null;
            this.btn_nav_home.IconMarginLeft = 0;
            this.btn_nav_home.IconMarginRight = 0;
            this.btn_nav_home.IconRightVisible = true;
            this.btn_nav_home.IconRightZoom = 0D;
            this.btn_nav_home.IconVisible = true;
            this.btn_nav_home.IconZoom = 60D;
            this.btn_nav_home.IsTab = false;
            this.btn_nav_home.Location = new System.Drawing.Point(0, 110);
            this.btn_nav_home.Name = "btn_nav_home";
            this.btn_nav_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_nav_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(15)))));
            this.btn_nav_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nav_home.selected = false;
            this.btn_nav_home.Size = new System.Drawing.Size(200, 65);
            this.btn_nav_home.TabIndex = 0;
            this.btn_nav_home.Text = "Search folders";
            this.btn_nav_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nav_home.Textcolor = System.Drawing.Color.White;
            this.btn_nav_home.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nav_home.Click += new System.EventHandler(this.btn_nav_home_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 561);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDMA Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlScreens;
        private System.Windows.Forms.Panel pnlSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nav_home;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nav_new_folder;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}

