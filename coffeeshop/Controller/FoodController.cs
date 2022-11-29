using coffeeshop.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.Controller
{
    public class FoodController
    {
        private static FoodController instance;

        public static FoodController Instance 
        { 
            get { if (instance == null) instance = new FoodController();{ return instance; } }
            set { instance = value; }
        }
        
        public List<Food> LoadFood()
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\Food.json";
            string jsonString = File.ReadAllText(fileName);
            List<Food> listFood = JsonConvert.DeserializeObject<List<Food>>(jsonString);
            return listFood;
        }
    }
}
