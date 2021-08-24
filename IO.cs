using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class IO
    {
        //public const string PATH = @"c:\temp\"; //Environment.SpecialFolder.CommonAppData

        //C:\Users\[user]\AppData\Roaming
        public string PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //C:\Users\[user]\AppData\Local
        public string PATH1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //C:\Users\[user]
        public string PATH2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public List<CustomerModel> ReadCSV()
        {
            Console.WriteLine(PATH);
            Console.WriteLine(PATH1);
            Console.WriteLine(PATH2);
            using (StreamReader sr = new StreamReader(PATH + "customers.csv"))
            {
                List<CustomerModel> customerList = new List<CustomerModel>();
                while (!sr.EndOfStream)
                {
                    //Console.WriteLine(sr.ReadLine());
                    string[] sa = sr.ReadLine().Split(";");
                    CustomerModel cm = new CustomerModel()
                    { Id = int.Parse(sa[0]), Name = sa[1] };

                    customerList.Add(cm);
                }
                return customerList;
            }
        }

        public void WriteCSV(List<CustomerModel> customerList)
        {
            if (!File.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }
            //string path = txtFilePath.Text;
            using (StreamWriter sw = File.AppendText($@"{PATH}customers.csv"))
            {
                foreach (var c in customerList)
                {
                    sw.WriteLine($"{c.Id};{c.Name}");
                }
            }
        }

    }
}
