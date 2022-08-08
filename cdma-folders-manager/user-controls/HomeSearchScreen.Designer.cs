namespace cdma_folders_manager.user_controls
{
    partial class HomeSearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSearchScreen));
            this.rdbReference = new System.Windows.Forms.RadioButton();
            this.rdbMatricule = new System.Windows.Forms.RadioButton();
            this.rdbReferenceLocale = new System.Windows.Forms.RadioButton();
            this.rdbSisnitre = new System.Windows.Forms.RadioButton();
            this.logoContainer = new System.Windows.Forms.PictureBox();
            this.pathChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSearchTerm = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnPathDialogOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDataDialogOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataChooser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbReference
            // 
            this.rdbReference.AutoSize = true;
            this.rdbReference.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReference.Location = new System.Drawing.Point(723, 1003);
            this.rdbReference.Name = "rdbReference";
            this.rdbReference.Size = new System.Drawing.Size(157, 33);
            this.rdbReference.TabIndex = 2;
            this.rdbReference.TabStop = true;
            this.rdbReference.Text = "Référence";
            this.rdbReference.UseVisualStyleBackColor = true;
            this.rdbReference.CheckedChanged += new System.EventHandler(this.searchFieldChange);
            // 
            // rdbMatricule
            // 
            this.rdbMatricule.AutoSize = true;
            this.rdbMatricule.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMatricule.Location = new System.Drawing.Point(1469, 1003);
            this.rdbMatricule.Name = "rdbMatricule";
            this.rdbMatricule.Size = new System.Drawing.Size(145, 33);
            this.rdbMatricule.TabIndex = 2;
            this.rdbMatricule.TabStop = true;
            this.rdbMatricule.Text = "Matricule";
            this.rdbMatricule.UseVisualStyleBackColor = true;
            this.rdbMatricule.CheckedChanged += new System.EventHandler(this.searchFieldChange);
            // 
            // rdbReferenceLocale
            // 
            this.rdbReferenceLocale.AutoSize = true;
            this.rdbReferenceLocale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReferenceLocale.Location = new System.Drawing.Point(954, 1003);
            this.rdbReferenceLocale.Name = "rdbReferenceLocale";
            this.rdbReferenceLocale.Size = new System.Drawing.Size(240, 33);
            this.rdbReferenceLocale.TabIndex = 2;
            this.rdbReferenceLocale.TabStop = true;
            this.rdbReferenceLocale.Text = "Référence Locale";
            this.rdbReferenceLocale.UseVisualStyleBackColor = true;
            this.rdbReferenceLocale.CheckedChanged += new System.EventHandler(this.searchFieldChange);
            // 
            // rdbSisnitre
            // 
            this.rdbSisnitre.AutoSize = true;
            this.rdbSisnitre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSisnitre.Location = new System.Drawing.Point(1268, 1003);
            this.rdbSisnitre.Name = "rdbSisnitre";
            this.rdbSisnitre.Size = new System.Drawing.Size(127, 33);
            this.rdbSisnitre.TabIndex = 2;
            this.rdbSisnitre.TabStop = true;
            this.rdbSisnitre.Text = "Sinistre";
            this.rdbSisnitre.UseVisualStyleBackColor = true;
            this.rdbSisnitre.CheckedChanged += new System.EventHandler(this.searchFieldChange);
            // 
            // logoContainer
            // 
            this.logoContainer.BackColor = System.Drawing.Color.Transparent;
            this.logoContainer.Image = ((System.Drawing.Image)(resources.GetObject("logoContainer.Image")));
            this.logoContainer.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoContainer.InitialImage")));
            this.logoContainer.Location = new System.Drawing.Point(723, 549);
            this.logoContainer.Name = "logoContainer";
            this.logoContainer.Size = new System.Drawing.Size(892, 281);
            this.logoContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoContainer.TabIndex = 6;
            this.logoContainer.TabStop = false;
            // 
            // pathChooser
            // 
            this.pathChooser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.pathChooser.ShowNewFolderButton = false;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 40;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnSearch.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.btnSearch.Location = new System.Drawing.Point(1052, 1309);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(247, 89);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.BackColor = System.Drawing.Color.White;
            this.txtSearchTerm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchTerm.BackgroundImage")));
            this.txtSearchTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.txtSearchTerm.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchTerm.Icon")));
            this.txtSearchTerm.Location = new System.Drawing.Point(723, 1119);
            this.txtSearchTerm.Margin = new System.Windows.Forms.Padding(7);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(892, 117);
            this.txtSearchTerm.TabIndex = 18;
            this.txtSearchTerm.text = "dqsdsqdqs";
            this.txtSearchTerm.OnTextChange += new System.EventHandler(this.txtSearchTerm_OnTextChange);
            // 
            // btnPathDialogOpen
            // 
            this.btnPathDialogOpen.Activecolor = System.Drawing.Color.White;
            this.btnPathDialogOpen.BackColor = System.Drawing.Color.White;
            this.btnPathDialogOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPathDialogOpen.BorderRadius = 0;
            this.btnPathDialogOpen.ButtonText = "";
            this.btnPathDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathDialogOpen.DisabledColor = System.Drawing.Color.Gray;
            this.btnPathDialogOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPathDialogOpen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPathDialogOpen.Iconimage")));
            this.btnPathDialogOpen.Iconimage_right = null;
            this.btnPathDialogOpen.Iconimage_right_Selected = null;
            this.btnPathDialogOpen.Iconimage_Selected = null;
            this.btnPathDialogOpen.IconMarginLeft = 0;
            this.btnPathDialogOpen.IconMarginRight = 0;
            this.btnPathDialogOpen.IconRightVisible = false;
            this.btnPathDialogOpen.IconRightZoom = 0D;
            this.btnPathDialogOpen.IconVisible = true;
            this.btnPathDialogOpen.IconZoom = 90D;
            this.btnPathDialogOpen.IsTab = false;
            this.btnPathDialogOpen.Location = new System.Drawing.Point(1983, 242);
            this.btnPathDialogOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPathDialogOpen.Name = "btnPathDialogOpen";
            this.btnPathDialogOpen.Normalcolor = System.Drawing.Color.White;
            this.btnPathDialogOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.btnPathDialogOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPathDialogOpen.selected = false;
            this.btnPathDialogOpen.Size = new System.Drawing.Size(110, 110);
            this.btnPathDialogOpen.TabIndex = 19;
            this.btnPathDialogOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPathDialogOpen.Textcolor = System.Drawing.Color.White;
            this.btnPathDialogOpen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathDialogOpen.Click += new System.EventHandler(this.btnPathDialogOpen_Click);
            // 
            // btnDataDialogOpen
            // 
            this.btnDataDialogOpen.Activecolor = System.Drawing.Color.White;
            this.btnDataDialogOpen.BackColor = System.Drawing.Color.White;
            this.btnDataDialogOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDataDialogOpen.BorderRadius = 0;
            this.btnDataDialogOpen.ButtonText = "";
            this.btnDataDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataDialogOpen.DisabledColor = System.Drawing.Color.Gray;
            this.btnDataDialogOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDataDialogOpen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDataDialogOpen.Iconimage")));
            this.btnDataDialogOpen.Iconimage_right = null;
            this.btnDataDialogOpen.Iconimage_right_Selected = null;
            this.btnDataDialogOpen.Iconimage_Selected = null;
            this.btnDataDialogOpen.IconMarginLeft = 0;
            this.btnDataDialogOpen.IconMarginRight = 0;
            this.btnDataDialogOpen.IconRightVisible = false;
            this.btnDataDialogOpen.IconRightZoom = 0D;
            this.btnDataDialogOpen.IconVisible = true;
            this.btnDataDialogOpen.IconZoom = 90D;
            this.btnDataDialogOpen.IsTab = false;
            this.btnDataDialogOpen.Location = new System.Drawing.Point(2116, 242);
            this.btnDataDialogOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDataDialogOpen.Name = "btnDataDialogOpen";
            this.btnDataDialogOpen.Normalcolor = System.Drawing.Color.White;
            this.btnDataDialogOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.btnDataDialogOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDataDialogOpen.selected = false;
            this.btnDataDialogOpen.Size = new System.Drawing.Size(110, 110);
            this.btnDataDialogOpen.TabIndex = 20;
            this.btnDataDialogOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataDialogOpen.Textcolor = System.Drawing.Color.White;
            this.btnDataDialogOpen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataDialogOpen.Click += new System.EventHandler(this.btnDataDialogOpen_Click);
            // 
            // dataChooser
            // 
            this.dataChooser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dataChooser.ShowNewFolderButton = false;
            // 
            // HomeSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDataDialogOpen);
            this.Controls.Add(this.btnPathDialogOpen);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbReference);
            this.Controls.Add(this.rdbMatricule);
            this.Controls.Add(this.rdbReferenceLocale);
            this.Controls.Add(this.rdbSisnitre);
            this.Controls.Add(this.logoContainer);
            this.Name = "HomeSearchScreen";
            this.Size = new System.Drawing.Size(2501, 1628);
            this.Load += new System.EventHandler(this.HomeSearchScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbReference;
        private System.Windows.Forms.RadioButton rdbMatricule;
        private System.Windows.Forms.RadioButton rdbReferenceLocale;
        private System.Windows.Forms.RadioButton rdbSisnitre;
        private System.Windows.Forms.PictureBox logoContainer;
        private System.Windows.Forms.FolderBrowserDialog pathChooser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchTerm;
        private Bunifu.Framework.UI.BunifuFlatButton btnPathDialogOpen;
        private Bunifu.Framework.UI.BunifuFlatButton btnDataDialogOpen;
        private System.Windows.Forms.FolderBrowserDialog dataChooser;
    }
}
