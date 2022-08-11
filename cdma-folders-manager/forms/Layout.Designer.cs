namespace cdma_folders_manager.forms
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_create_folder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlScreens = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 955F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlScreens, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 824);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btn_back);
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_create_folder);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 818);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_back.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.BorderRadius = 0;
            this.btn_back.ButtonText = "Retour";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledColor = System.Drawing.Color.Gray;
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_back.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_back.Iconimage")));
            this.btn_back.Iconimage_right = null;
            this.btn_back.Iconimage_right_Selected = null;
            this.btn_back.Iconimage_Selected = null;
            this.btn_back.IconMarginLeft = 0;
            this.btn_back.IconMarginRight = 0;
            this.btn_back.IconRightVisible = true;
            this.btn_back.IconRightZoom = 0D;
            this.btn_back.IconVisible = true;
            this.btn_back.IconZoom = 60D;
            this.btn_back.IsTab = false;
            this.btn_back.Location = new System.Drawing.Point(3, 109);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(46)))));
            this.btn_back.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(288, 65);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Retour";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Textcolor = System.Drawing.Color.Black;
            this.btn_back.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_home.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "Chercher un dossier";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 60D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(3, 180);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(15)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = false;
            this.btn_home.Size = new System.Drawing.Size(288, 65);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Chercher un dossier";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_home.Textcolor = System.Drawing.Color.Black;
            this.btn_home.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_create_folder
            // 
            this.btn_create_folder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btn_create_folder.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btn_create_folder.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create_folder.BorderRadius = 0;
            this.btn_create_folder.ButtonText = "Ajouter un dossier";
            this.btn_create_folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_folder.DisabledColor = System.Drawing.Color.Gray;
            this.btn_create_folder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_create_folder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create_folder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_create_folder.Iconimage")));
            this.btn_create_folder.Iconimage_right = null;
            this.btn_create_folder.Iconimage_right_Selected = null;
            this.btn_create_folder.Iconimage_Selected = null;
            this.btn_create_folder.IconMarginLeft = 0;
            this.btn_create_folder.IconMarginRight = 0;
            this.btn_create_folder.IconRightVisible = true;
            this.btn_create_folder.IconRightZoom = 0D;
            this.btn_create_folder.IconVisible = true;
            this.btn_create_folder.IconZoom = 60D;
            this.btn_create_folder.IsTab = false;
            this.btn_create_folder.Location = new System.Drawing.Point(3, 251);
            this.btn_create_folder.Name = "btn_create_folder";
            this.btn_create_folder.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_create_folder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(46)))));
            this.btn_create_folder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create_folder.selected = false;
            this.btn_create_folder.Size = new System.Drawing.Size(288, 65);
            this.btn_create_folder.TabIndex = 3;
            this.btn_create_folder.Text = "Ajouter un dossier";
            this.btn_create_folder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create_folder.Textcolor = System.Drawing.Color.Black;
            this.btn_create_folder.TextFont = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlScreens
            // 
            this.pnlScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreens.Location = new System.Drawing.Point(303, 3);
            this.pnlScreens.Name = "pnlScreens";
            this.pnlScreens.Size = new System.Drawing.Size(949, 818);
            this.pnlScreens.TabIndex = 1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(112)))), ((int)(((byte)(175)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1255, 824);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 824);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Layout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDMA Folders Managament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Layout_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private Bunifu.Framework.UI.BunifuFlatButton btn_home;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create_folder;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlScreens;
    }
}