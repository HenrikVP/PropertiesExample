using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Creates a property of a List<AccountModel> type, which 
        //have to be created after the CustomerModel instance have been created.
        //public List<AccountModel> AccountList { get; set; }
        //Creates the list as the CustomerModel instance is being created
        public List<AccountModel> AccountList = new List<AccountModel>();

    }
}
