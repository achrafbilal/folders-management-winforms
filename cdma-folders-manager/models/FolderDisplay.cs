using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdma_folders_manager.models
{
    internal class FolderDisplay
    {

        private int id_dossier;
        [DisplayName("Nom de dossier")]
        public string folder_name { get; set; }

        [DisplayName("Référence")]
        public string reference { get; set; }

        [DisplayName("Référence Locale")]
        public string reference_locale { get; set; }

        [DisplayName("Numéro de sinistre")]
        public string num_sinistre { get; set; }

        [DisplayName("Matricule")]
        public string matricule { get; set; }
        public int getID()
        {
            return this.id_dossier;
        }
        public FolderDisplay(DBFolder folder)
        {
            this.num_sinistre = folder.num_sinistre;
            this.reference= folder.reference;
            this.reference_locale = folder.ref_local;
            this.matricule = folder.matricule;
            this.id_dossier=folder.id_dossier;
            this.folder_name = $"DOSS_{this.id_dossier}";
        }
    }
}
