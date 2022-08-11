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

        public List<FolderDisplay> Folders = new List<FolderDisplay>();

        public bool localDataLoaded = false;
        public bool dataLoaded = false;
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
                instance.dataPath = "";
                instance.SearchPath = "";
            }
            return instance;          
        }
        
        public string resolvePath(int id)
        {
            return $@"{SearchPath}\DOSS_{id}";
        }
        
        public string[] getImages()
        {
            string[] images = Directory.GetFiles(resolvePath(folderID), "*.*",SearchOption.TopDirectoryOnly);

            return images;
        }

        public void getData()
        {
            if (dataPath.Length > 0)
            {
                string text = File.ReadAllText(dataPath);
                string formattedText = text.Replace("\\", "").Replace("\"ref\"", "\"reference\"").Replace("\n", "").Replace(" ", "");
                int index = formattedText.IndexOf("\"data\"") + "\"data\":".Length;
                string dataTxt = formattedText.Substring(index);
                dataTxt = dataTxt.Substring(0, dataTxt.Length - 2);
                //System.Windows.Forms.MessageBox.Show(dataTxt);
                List<FolderDisplay> result = new List<FolderDisplay>();
                JsonConvert.DeserializeObject<List<DBFolder>>(dataTxt).ForEach(e =>
                    result.Add(new FolderDisplay(e))
                );
                File.WriteAllText("data.json", text);
                this.Folders = result;
                dataLoaded = true;
            }
            //else throw new Exception("Chemin de fichier de données invalide");
        }

        public void readLocalData()
        {
            if (!File.Exists("data/data.data"))
            {
                if (!Directory.Exists("data/"))
                    Directory.CreateDirectory("data/");
                   
                StreamWriter writer = File.CreateText("data/data.data");
                writer.WriteLine("#CDMA Folders Management");
                writer.Close();
                return;
            }
           
            string[] metaData=File.ReadAllLines("data/data.data");

            if (metaData[0].Equals("#CDMA Folders Management") && metaData.Length==3)
            {
                SearchPath=metaData[1];    
                dataPath=metaData[2];
                localDataLoaded = true;
            }
        }




    }
}
