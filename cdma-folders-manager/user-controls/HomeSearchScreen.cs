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
using cdma_folders_manager.services;

namespace cdma_folders_manager.user_controls
{
    public partial class HomeSearchScreen : UserControl,CustomUserControl
    {

        LocalService service = LocalService.getInstance();
        Home parentForm = null;
        string searchField = "reference";
        public HomeSearchScreen()
        {
            InitializeComponent();
        }

        private void roundButton(ref Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width, btn.Height);
            btn.Region = new Region(p);
        }
        private void HomeSearchScreen_Load(object sender, EventArgs e)
        {
            parentForm = (Home)Parent.Parent.Parent; 
            rdbReference.Checked = true;
            roundButton(ref btnPathDialogOpen);
            roundButton(ref btnDataDialogOpen);
            service.getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //service.SearchPath = @"C:\Users\CDMA_PC2\Downloads\cdma";
            parentForm.setScreen(1);
        }

       

        private void searchFieldChange(object sender, EventArgs e)
        {
            string searchFieldName = "reference";
            RadioButton radioButton = (RadioButton)sender; 
            switch(radioButton.Name)
            {
                case "":
                    radioButton.Checked = true;
                    break;
            }
            service.SearchField=(searchFieldName);
        }

        private void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            //if (service.isValidSearchTerm(txtSearchTerm.Text.ToString())) 
            //    service.SearchTerm=(txtSearchTerm.Text.ToString());
        }
        private void txtSearchTerm_OnTextChange(object sender, EventArgs e)
        {
            //if (service.isValidSearchTerm(txtSearchTerm.Text.ToString()))
            //    service.SearchTerm = (txtSearchTerm.Text.ToString());
        }

        private void btnPathDialogOpen_Click(object sender, EventArgs e)
        {
            if (pathChooser.ShowDialog() == DialogResult.OK)
            {
                service.SearchPath=(pathChooser.SelectedPath);
            }
        }

        private void btnDataDialogOpen_Click(object sender, EventArgs e)
        {
            if (dataChooser.ShowDialog() == DialogResult.OK)
            {
                service.dataPath = (dataChooser.FileName);
                service.getData();
            }
        }  
        
        public  void refresh()
        {
            int margintop = 30;
            //txtSearchTerm.Text = "";
            rdbMatricule.Checked =  rdbReferenceLocale.Checked= rdbSisnitre.Checked = false;
            rdbReference.Checked = true;
            pathChooser.SelectedPath = "";
            pnlView.Height = this.Height;

            pnlView.Location = new Point(this.Size.Width / 2 - pnlView.Width / 2, this.Size.Height / 2 - pnlView.Height / 2);
            logoContainer.Location = new Point(pnlView.Width / 2 - logoContainer.Width / 2,     (pnlView.Height / 3) - (logoContainer.Height / 2)+margintop);
            pnlRdb.Location = new Point(pnlView.Width / 2 - pnlRdb.Width / 2,                   logoContainer.Location.Y+ logoContainer.Height+20 + margintop);
            //txtSearchTerm.Location = new Point(pnlView.Width / 2 - txtSearchTerm.Width / 2,     pnlRdb.Location.Y + pnlRdb.Height + 20 + margintop);
            //btnSearch.Location= new Point(pnlView.Width / 2 - btnSearch.Width / 2, txtSearchTerm.Location.Y + txtSearchTerm.Height + 20 + margintop);
            btnPathDialogOpen.Location = new Point(pnlView.Width - pnlView.Width / 5, pnlView.Height / 8);
            btnDataDialogOpen.Location = new Point(btnPathDialogOpen.Width+btnPathDialogOpen.Location.X, pnlView.Height / 8);
        }
    }
}
