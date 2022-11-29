using coffeeshop.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace coffeeshop.Controller
{
    public class TableController
    {
        private static TableController instance;

        public static TableController Instance
        {
            get { if (instance == null) instance = new TableController(); { return instance; } }
            private set { instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        public List<Table> LoadTableController()
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\table.json";
            string jsonString = File.ReadAllText(fileName);
            List<Table> listTable = JsonConvert.DeserializeObject<List<Table>>(jsonString);
            return listTable;
        }
        public bool CheckTableDispo(int Id)
        {
            var isDispo = false;
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\table.json";
            string jsonString = File.ReadAllText(fileName);
            List<Table> listTable = JsonConvert.DeserializeObject<List<Table>>(jsonString);

            foreach(Table table in listTable)
            {
                if(table.Id.Equals(Id) && table.Status == "indispo")
                {
                    isDispo = true;
                    break;
                }
            }
            return isDispo;
        }
    }
}
