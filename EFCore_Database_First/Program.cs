using EFCore_Database_First.Models;
using System;
using System.Text;

namespace EFCore_Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine(System.Text.Encoding.GetEncoding("GB2312"));

            using (var db = new OnlineFruit_Upgrade_V2Context())
            {
                // Retrieving and displaying data
                Console.WriteLine("All Products in the database:");
                foreach (var product in db.ProductLibrary)
                {
                    Console.WriteLine("{0} | {1}", product.ProductName, product.Price);
                }
            }

            Console.ReadKey();

        }
    }
}