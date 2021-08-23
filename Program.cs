using System;
using System.Collections.Generic;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<CustomerModel> customerList = new List<CustomerModel>();

            CustomerModel customer= new CustomerModel();
            customer.Id = 1;
            customer.Name = "Donald Duck";
            customer.AccountList = new List<AccountModel> { };
            AccountModel account = new AccountModel() {Id = 1, Balance = 200 };
            customer.AccountList.Add(account);

            customerList.Add(customer);

            CustomerModel customer1 = new CustomerModel() {Id = 2, Name = "Hans Pilgaard" };
            customerList.Add(customer1);

            

            foreach (var c in customerList)
            {
                Console.WriteLine($"Id: {c.Id} Navnet: {c.Name}");
                Console.WriteLine("Accounts: ");
                foreach (var a in c.AccountList)
                {
                    Console.WriteLine($"Id: {a.Id} Balance {a.Balance}");
                }
            }
        }
    }
}
