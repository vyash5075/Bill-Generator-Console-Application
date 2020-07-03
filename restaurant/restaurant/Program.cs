using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class restaurant
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("----------------------------------------------");
            Restaurant res = new Restaurant("yash", "chandigarh", .15);
            res.GenerateReceipt();
            Console.ReadLine();

        }
    }
}
