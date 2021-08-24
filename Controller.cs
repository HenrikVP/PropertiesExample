using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;

namespace PropertiesExample
{
    class Controller
    {
        private List<CustomerModel> oldcustomerList = new List<CustomerModel>();
        private List<CustomerModel> newcustomerList = new List<CustomerModel>();

        public void Start()
        {
            PutData();
            IO ioclass = new IO();
            ioclass.WriteCSV(oldcustomerList);
            newcustomerList = ioclass.ReadCSV();
            ShowData();
        }

        void ShowData()
        {
            foreach (var c in newcustomerList)
            {
                Console.WriteLine($"Id: {c.Id} Navn: {c.Name}");
                Console.WriteLine("Accounts: ");
                foreach (var a in c.AccountList)
                {
                    Console.WriteLine($"Id: {a.Id} Balance {a.Balance}");
                }
            }
        }

        void PutData()
        {
            CustomerModel customer = new CustomerModel();
            customer.Id = 1;
            customer.Name = "Donald Duck";
            AccountModel account = new AccountModel() { Id = 1, Balance = 200 };
            customer.AccountList.Add(account);

            oldcustomerList.Add(customer);

            CustomerModel customer1 = new CustomerModel() { Id = 2, Name = "Hans Pilgaard" };
            oldcustomerList.Add(customer1);
        }


    }
}
