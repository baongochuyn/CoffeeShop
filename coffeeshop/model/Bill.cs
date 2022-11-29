using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.model
{
    public class Bill
    {
        public int Id { get; set; }
        public int IdTable { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOUt { get; set; }
        public string Status { get; set; }
    }
}
