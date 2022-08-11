using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cdma_folders_manager.models;
using cdma_folders_manager.services;
namespace cdma_folders_manager.user_controls
{
    public partial class ResultSearchScreen : UserControl,CustomUserControl
    {
        Home parent;
        LocalService service=LocalService.getInstance();
        
        BindingSource binding = new BindingSource();
        public ResultSearchScreen()
        {
            InitializeComponent();
        }

        private void ResultSearchScreen_Load(object sender, EventArgs e)
        {
            parent = (Home)Parent.Parent.Parent;
        }


        private void dgvFolders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (dgv.SelectedRows.Count > 0)
            {

                service.folderID=service.Folders[dgv.SelectedRows[0].Index].getID();
                parent.setScreen(2);
            }
        }

        

        public void refresh()
        {
            
            binding.DataSource = service.Folders;

            dgvFolders.DataSource = binding;

            dgvFolders.Refresh();
        }

        private void dgvFolders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
