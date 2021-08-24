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
        public const string PATH = @"c:\temp\";
        public List<CustomerModel> ReadCSV()
        {
            using (StreamReader sr = new StreamReader(PATH + "customers.csv"))
            {
                List<CustomerModel> customerList = new List<CustomerModel>();
                while (sr.Peek() >= 0)
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
