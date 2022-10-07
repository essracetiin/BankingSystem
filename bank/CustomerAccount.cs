using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class CustomerAccount
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public int CustomerNo { get; set; }
        public void Users(string username, int password, int customerNo)
        {
            this.Username = username;
            this.Password = password;
            this.CustomerNo = customerNo;
        }
        


    }
}
