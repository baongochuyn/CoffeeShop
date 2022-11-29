using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.model
{
    public class BillInfoByTable
    {
        public BillInfoByTable()
        {
        }

        public BillInfoByTable(string foodName, float price, float totalPrice, int count)
        {
            this.FoodName = foodName;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.Count = count;
        }

        private string FoodName { get; set; }
        private float Price { get; set; }
        private float TotalPrice { get; set; }
        private int Count { get; set; }  

    }
}
