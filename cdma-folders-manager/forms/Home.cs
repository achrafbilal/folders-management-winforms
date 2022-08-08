using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cdma_folders_manager.user_controls;

namespace cdma_folders_manager
{
    public partial class Home : Form
    {
        private Dictionary<int, UserControl> screens = new Dictionary<int, UserControl>
        {
            { 0, new HomeSearchScreen() },
            { 1, new ResultSearchScreen() },
            { 2, new FolderContentScreen() },
            { 3, new FullscreenImageScreen() }
        };
        private List<Bunifu.Framework.UI.BunifuFlatButton> nav_buttons;
        private int activeScreen = 0;
        public Home()
        {

            InitializeComponent();

            // logoContainer.Image = Properties.Resources.cdma_solutions_logo;
        }

        public void setScreen(int index)
        {
            if (screens.ContainsKey(index))
            {
                btnBack.Visible = index > 0;
                UserControl control = screens[index];
                control.Width = pnlScreens.Width;
                control.Height = pnlScreens.Height;
                pnlScreens.Controls.Clear();
                pnlScreens.Controls.Add(control);
                activeScreen = index;
                ((CustomUserControl)screens[index]).refresh();

            }
            else throw new Exception("Key not found in screens");
        }

        private void btn_nav_home_Click(object sender, EventArgs e)
        {
            
            setScreen(0);
        }

        private void pnlScreens_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            pnlContainer.Width = this.Width;
            pnlContainer.Height = this.Height;
            pnlSidebar.Height = ((Home)this).Height;
            pnlScreens.Height = ((Home)this).Height;

            //pnlSidebar.Width = 300;
            pnlScreens.Width = ((Home)this).Width - (pnlSidebar.Width );

            
            nav_buttons = new List<Bunifu.Framework.UI.BunifuFlatButton> { btn_nav_home,btn_nav_new_folder};
            roundButton(ref btnBack);
            btn_nav_new_folder.Visible = false;
            setScreen(0);
        }
        private void roundButton(ref Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width , btn.Height );
            btn.Region = new Region(p);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.FromArgb(233, 95, 30);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (activeScreen > 0)
                setScreen(activeScreen - 1);
        }

        private void btn_nav_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pnlScreens_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
