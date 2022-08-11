using cdma_folders_manager.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cdma_folders_manager.forms
{
    public partial class Layout : Form
    {
        private static Layout instance;


        public static Layout getInstance()
        {
            if (instance == null)
               instance = new Layout();
            return instance;
        }
        private Dictionary<int, UserControl> screens = new Dictionary<int, UserControl> { 
            { 0,new HomeScreen() },
            { 1,new ResultSearchScreen() },
            { 2,new FolderContentScreen() },
            { 3,new FullscreenImageScreen() },
        };
        private int activeScreenKey=0;
        public Layout()
        {
            InitializeComponent();
        }

        public void setScreen(int screen)
        {
            if (screens.ContainsKey(screen))
            {
                pnlScreens.Controls.Clear();
                pnlScreens.Controls.Add(screens[screen]);
                activeScreenKey = screen;
            }
        }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setScreen(0);
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            foreach (var screen in screens)
            {
                screen.Value.Dock = DockStyle.Fill;
                screen.Value.Anchor = AnchorStyles.None;
                screen.Value.BackColor = Color.Transparent;
            }
            setScreen(0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            setScreen(activeScreenKey - 1);
        }
    }
}
