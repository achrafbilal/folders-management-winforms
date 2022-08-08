using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdma_folders_manager.models
{
    internal class Folder
    {
        public int ID { get; set; } 
        public string Name { get; set; }    
        public string Reference { get; set; }   
        public string ReferenceLocale { get; set; } 
        public string Sinistre { get; set; }    
        public string Matricule     { get; set; }
    }
}
