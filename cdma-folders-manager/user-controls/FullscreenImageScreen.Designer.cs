namespace cdma_folders_manager.user_controls
{
    partial class FullscreenImageScreen
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
            this.fullscreenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fullscreenBox
            // 
            this.fullscreenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullscreenBox.Location = new System.Drawing.Point(0, 0);
            this.fullscreenBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.fullscreenBox.Name = "fullscreenBox";
            this.fullscreenBox.Size = new System.Drawing.Size(1084, 686);
            this.fullscreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullscreenBox.TabIndex = 0;
            this.fullscreenBox.TabStop = false;
            this.fullscreenBox.Click += new System.EventHandler(this.fullscreenBox_Click);
            // 
            // FullscreenImageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fullscreenBox);
            this.Name = "FullscreenImageScreen";
            this.Size = new System.Drawing.Size(1084, 686);
            this.Load += new System.EventHandler(this.FullscreenImageScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fullscreenBox;
    }
}
