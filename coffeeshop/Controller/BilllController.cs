using coffeeshop.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.Controller
{
    public class BillController
    {
        private static BillController instance;
        public static BillController Instance
        {
            get { if (instance == null) instance = new BillController(); { return instance; } }
            set { instance = value; }
        }

        public int GetUncheckBillByTableId(int id)
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> listBill = JsonConvert.DeserializeObject<List<Bill>>(jsonString);

            foreach (Bill elm in listBill)
            {
                if (elm.IdTable.Equals(id))
                {
                    return elm.Id;
                }
            }
            return -1;
        }

        internal void GetUncheckBillByTableId()
        {
            throw new NotImplementedException();
        }
    }


}
