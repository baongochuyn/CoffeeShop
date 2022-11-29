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
    public class CategoryController
    {
        private static CategoryController instance;

        public static CategoryController Instance
        {
            get { if (instance == null) instance = new CategoryController(); { return instance; } }
            set { instance = value; }
        }

        public List<Category> LoadCategory()
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\category.json";
            string jsonString = File.ReadAllText(fileName);
            List<Category> listCategory = JsonConvert.DeserializeObject<List<Category>>(jsonString);
            return listCategory;
        }
    }
}
