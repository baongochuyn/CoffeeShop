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
    public class BillInfoController
    {
        private static BillInfoController instance;
        public static BillInfoController Instance
        {
            get { if(instance == null) instance = new BillInfoController(); return instance; }
            set { instance = value; }
        }

        public List<BillInfo> GetListBillInfo()
        {
           //List<BillInfo> listBillInfo = new List<BillInfo>();

            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            string fileName = path + "\\json\\billInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> listBillInfo = JsonConvert.DeserializeObject<List<BillInfo>>(jsonString);

            return listBillInfo;
        }
        
    }
}
