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
    public class UserController
    {
        private static UserController instance;

        public static UserController Instance
        {
            get { if (instance == null) instance = new UserController(); { return instance; } }
            private set { instance = value; }
        }

        public bool CheckPassword(string name,string pass)
        {
            string jsonString = File.ReadAllText("C:\\STUDY\\IT\\s03\\coffeeshop\\coffeeshop\\json\\user.json");

            List<User> listUser = JsonConvert.DeserializeObject<List<User>>(jsonString);
            foreach (User user in listUser)
            {
                if(user.username.Equals(name) && user.password.Equals(pass))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
