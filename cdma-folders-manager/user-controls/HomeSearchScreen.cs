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
            service.SearchPath = @"C:\Users\Ach20\Downloads\cdma";
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
            if (service.isValidSearchTerm(txtSearchTerm.Text.ToString())) 
                service.SearchTerm=(txtSearchTerm.Text.ToString());
        }

        private void btnPathDialogOpen_Click(object sender, EventArgs e)
        {
            if (pathChooser.ShowDialog() == DialogResult.OK)
            {
                service.SearchPath=(pathChooser.SelectedPath);
            }
        }

        public  void refresh()
        {
            txtSearchTerm.Text = "";
            rdbMatricule.Checked = rdbReference.Checked= rdbReferenceLocale.Checked= rdbSisnitre.Checked = false;
            pathChooser.SelectedPath = "";
        }

        

        private void txtSearchTerm_OnTextChange(object sender, EventArgs e)
        {
            if (service.isValidSearchTerm(txtSearchTerm.Text.ToString()))
                service.SearchTerm = (txtSearchTerm.Text.ToString());
            btnSearch.ButtonText = txtSearchTerm.text.ToString();
        }

        private void btnDataDialogOpen_Click(object sender, EventArgs e)
        {
            if (dataChooser.ShowDialog() == DialogResult.OK)
            {
                service.dataPath = (dataChooser.SelectedPath);
            }
        }
    }
}
