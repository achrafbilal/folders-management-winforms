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

        public List<DBFolder> Folders = new List<DBFolder>();

        public string SearchPath { get; set; }

        public string dataPath { get; set; }

        public string SearchField { get; set; }

        public string SearchTerm { get; set; }

        public int folderID { get; set; }

        public string fullScreenImage { get; set; }

        public bool isLoading { get; set; }

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

                instance.getData();
                
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

        public void getData(string path= @"C:\Users\Ach20\source\repos\cdma-folders-manager\cdma-folders-manager\sample.json")
        {
            string text=File.ReadAllText(path);
            string dataTxt = text.Replace('\n', ' ').Replace("\\"," ").Replace("'ref'","'reference'").Substring(text.IndexOf("{\"id_dossier")-3);
            List<DBFolder> result=  JsonConvert.DeserializeObject<List<DBFolder>>(dataTxt.Substring(0, dataTxt.Length - 4));
            File.WriteAllText("data.json", dataTxt.Substring(0, dataTxt.Length - 4));
            this.Folders = result;
            

        }

        public void getDataLocal()
        {
            if(File.Exists(this.dataPath))
            {
                this.Folders = JsonConvert.DeserializeObject<List<DBFolder>>(File.ReadAllText(this.dataPath));
            }
        }

    }
}
