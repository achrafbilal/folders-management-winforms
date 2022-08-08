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
    public partial class FullscreenImageScreen : UserControl,CustomUserControl
    {
        LocalService service = LocalService.getInstance();
        public FullscreenImageScreen()
        {
            InitializeComponent();
        }

        private void FullscreenImageScreen_Load(object sender, EventArgs e)
        {
            fullscreenBox.ImageLocation = service.fullScreenImage;
        }

        public  void refresh()
        {
            fullscreenBox.ImageLocation = service.fullScreenImage;
            //fullscreenBox.Refresh();
        }

        private void fullscreenBox_Click(object sender, EventArgs e)
        {

        }
    }
}
