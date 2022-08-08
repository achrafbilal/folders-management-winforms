namespace cdma_folders_manager.user_controls
{
    partial class FolderContentScreen
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
            this.pnlGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlGallery
            // 
            this.pnlGallery.AutoScroll = true;
            this.pnlGallery.BackColor = System.Drawing.Color.White;
            this.pnlGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGallery.Location = new System.Drawing.Point(0, 0);
            this.pnlGallery.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlGallery.Name = "pnlGallery";
            this.pnlGallery.Size = new System.Drawing.Size(1329, 917);
            this.pnlGallery.TabIndex = 0;
            this.pnlGallery.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGallery_Paint);
            // 
            // FolderContentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGallery);
            this.Name = "FolderContentScreen";
            this.Size = new System.Drawing.Size(1329, 917);
            this.Load += new System.EventHandler(this.FolderContentScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlGallery;
    }
}
