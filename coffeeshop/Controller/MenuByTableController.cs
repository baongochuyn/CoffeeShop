using coffeeshop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.Controller
{
    public class MenuByTableController
    {
        private static MenuByTableController instance;  
        public static MenuByTableController Instance
        {
            get { if (instance == null) instance = new MenuByTableController(); return instance; }
            private set { instance = value; }
        }

        public List<BillInfoByTable> GetListMenuByTable()
        {
            List<BillInfoByTable> ListMenu = new List<BillInfoByTable>();

            return ListMenu;
        }
    }
}
