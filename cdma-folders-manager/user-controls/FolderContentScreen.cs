using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cdma_folders_manager.services;

namespace cdma_folders_manager.user_controls
{
    public partial class FolderContentScreen : UserControl,CustomUserControl
    {
        Home parent;
        Panel subParent;
        LocalService service = LocalService.getInstance();
        public FolderContentScreen()
        {
            InitializeComponent();
        }

        private void FolderContentScreen_Load(object sender, EventArgs e)
        {
            subParent = (Panel)Parent;
            parent = (Home)Parent.Parent.Parent;
            
            
        }

        private void image_Click(object sender,EventArgs e)
        {
            service.fullScreenImage = ((PictureBox)sender).ImageLocation;
            parent.setScreen(3);
        }

        private void pnlGallery_Paint(object sender, PaintEventArgs e)
        {

        }
        public  void refresh()
        {
            pnlGallery.Controls.Clear();
            int colWidth = (subParent.Width / 3) - (40 * 2);
            int rowHeight = (subParent.Height / 4) - (10 * 4);
            pnlGallery.Margin = new Padding(0, 30, 0, 0);
            pnlGallery.BackColor = (Color)ColorTranslator.FromHtml("#D1D0D6");
            int index = 1;
            pnlGallery.Visible = false;
            foreach (var item in service.getImages())
            {
                Bunifu.Framework.UI.BunifuCards imageContainer = new Bunifu.Framework.UI.BunifuCards();
                imageContainer.Width = colWidth;
                imageContainer.Height = rowHeight;
                imageContainer.BorderStyle = BorderStyle.FixedSingle;
                int right = index % 3 != 0 ? 40 : 0;
                imageContainer.Margin = new Padding(20, 20, right, 20);
                //imageContainer.BackColor = Color.White;
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = item;
                pictureBox.Height = imageContainer.Height;
                pictureBox.Width = imageContainer.Width;
                //pictureBox.Location = new Point((imageContainer.Width / 4) , (imageContainer.Height/4));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                //imageContainer.Margin = new Padding(0, 0, 30, 30);

                imageContainer.Controls.Add(pictureBox);
                pnlGallery.Controls.Add(imageContainer);
                pictureBox.Click += new EventHandler(image_Click);
                index++;
            }
            pnlGallery.Visible = true;  
        }
    }
}
