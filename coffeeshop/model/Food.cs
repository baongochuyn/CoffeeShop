using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.model
{
    public class Food
    {
        public int IdFood { get; set; }
        public string FoodName { get; set; }
        public int IdCategory { get; set; }
        public int Price { get; set; }
    }
}
