using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdma_folders_manager.models
{
    internal class DBFolder
    {
        public int ID { get; set; }
        public int num_police { get; set; }    
        public string reference { get; set; }
        public string ref_local { get; set; }
        public string dedicated_manager { get; set; }
        public string id_dossier_organisme { get; set; }
        public string nature_dossier { get; set; }
        public string intermediaire { get; set; }
        public string num_sinistre { get; set; }
        public string date_sinistre { get; set; }
        public string complement_information { get; set; }
        public string id_assurance { get; set; }
        public string id_adversaire { get; set; }
        public string id_modele { get; set; }
        public string id_marque { get; set; }
        public string id_garage { get; set; }
        public string used { get; set; }
        public string id_assure { get; set; }
        public string matricule { get; set; }
        public string id_categorie { get; set; }
        public string date_reception { get; set; }
        public string id_mode { get; set; }
        public string dossiercol { get; set; }
        public string date_expertise { get; set; }
        public string id_observation { get; set; }
        public string id_societe { get; set; }
        public string date_publication { get; set; }
        public string date_apres { get; set; }
        public string date_encours { get; set; }
        public string date_rapport { get; set; }
        public string date_accord { get; set; }
        public string date_facture { get; set; }
        public string date_devis { get; set; }
        public string date_pub_devis { get; set; }
        public string date_reparation_prevu { get; set; }
        public string etat_reparation_prevu { get; set; }
    }
}
