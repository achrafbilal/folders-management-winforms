using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using cdma_folders_manager.models;
using System.IO;
using Newtonsoft.Json;

namespace cdma_folders_manager.services
{
    internal class LocalService
    {

        private static LocalService instance = null;

        Regex pathRegex = new Regex(@"^[A-Za-z]{1}:\\(([A-Za-z0-9_-]|\s){1,}\\){1,}$");

        Regex termRegex = new Regex(@"^([A-Za-z]\s){0,100}$");

        public List<Folder> Folders = new List<Folder>();

        public string SearchPath { get; set; }

        public string dataPath { get; set; }

        public string SearchField { get; set; }

        public string SearchTerm { get; set; }

        public int folderID { get; set; }

        public string fullScreenImage { get; set; }



        public bool isValidSearchPath(string path)
        {
            return pathRegex.IsMatch(path);
        }
        
        public bool isValidSearchTerm(string term)
        {
            return termRegex.IsMatch(term);
        }
        
        public static LocalService getInstance()
        {
            if( instance == null )
            {
                instance = new LocalService();

                for (int i = 1; i <= 7; i++)
                {
                    instance.Folders.Add(
                        new Folder()
                        {
                            ID = i,
                            Name = $"DOSS_{i}",
                            Reference = $"Rérérence {i}",
                            ReferenceLocale = $"Reférence Locale {i}",
                            Sinistre = $"Sinistre {i}",
                            Matricule = $"Matricule {i}"
                        }
                    );
                }
                
            }
            return instance;          
        }
        
        public string resolvePath(int id)
        {
            return $@"{SearchPath}\DOSS_{id}";
        }
        
        public string[] getImages()
        {
            string[] images = System.IO.Directory.GetFiles(resolvePath(folderID), "*", System.IO.SearchOption.TopDirectoryOnly);

            return images;
        }

        public void getData()
        {
            string text=File.ReadAllText(@"C:\Users\Ach20\source\repos\cdma-folders-manager\cdma-folders-manager\sample.json");
            //System.Windows.Forms.MessageBox.Show(text.IndexOf("{\"id_dossier") + "");
            string dataTxt = text.Replace('\n', ' ').Replace("\"","'").Substring(text.IndexOf("{\"id_dossier"));
            List<DBFolder> result=  JsonConvert.DeserializeObject<List<DBFolder>>(dataTxt.Substring(0, dataTxt.Length - 4));
            
            System.Windows.Forms.MessageBox.Show(result.Count+" ");

        }

    }
}
