using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    class Icertiesprogram
    {
        public void ProcessData(string txtfilepath)
        {
            List<Product> list = new List<Product>();
            using (StreamReader sr = new StreamReader(txtfilepath))
            {
                Product product = null;
                
                while (!sr.EndOfStream)
                {
                    product = new Product();
                    string tempLine = sr.ReadLine();
                    string[] arrproduct = tempLine.Split(',');                    
                    if (arrproduct.Length > 0)
                    {
                        product.CustName = Convert.ToString(arrproduct[0]);
                        product.Location = Convert.ToString(arrproduct[1]);
                        product.date = Convert.ToString(arrproduct[2]);
                        product.ProductName = Convert.ToString(arrproduct[3]);
                        string price= Convert.ToString(arrproduct[4]);
                        price = price.Replace("Rs ", "");
                        product.Price = Convert.ToInt32(price);
                        product.PayType = Convert.ToString(arrproduct[5]);
                    }
                    list.Add(product);
                }
            }

            var cheapestProduct = list.OrderBy(p => p.Price).GroupBy(p => p.Location);
            
                    
            var mostExpensiveProduct = list.OrderByDescending(p => p.Price).FirstOrDefault();

        }
        static int f2()
        {
            String s = "Hello\0world";
            return s.Length;
        }

        static String f2(bool x)
        {
            int i = 2;
            //if (x)
            //{
            //    int i= 3;
            //}
            //else
            //{
            //    int i= 4;
            //}
            return i.ToString();
        }
        static void Main()
        {
            int len = Icertiesprogram.f2();
            Icertiesprogram icertiesprogram = new Icertiesprogram();
            icertiesprogram.ProcessData(@"D:\Demo-Projects\Icertics program\TextFile1.txt");
            Console.ReadLine();
        }
    }
    public class Product
    {
        public string CustName { get; set; }
        public string Location { get; set; }
        public string date { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string PayType { get; set; }

    }
}
