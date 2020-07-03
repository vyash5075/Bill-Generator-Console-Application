using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Restaurant
    {
        private string name;
        private string address;
        private double gratuityrate;

        public string Name
        {
            get{ return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double GratuityRate
        {
            get { return gratuityrate; }
            set {
                if (value >=0)
                {
                    gratuityrate = value;
                }
              
            }
        }
        public Restaurant(string name,string address,double gratuityrate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityrate;

        }
        public void GenerateReceipt()
        {
            double price=0;
            double subtotal=0;
            double gratuityAmount=0;
            double grandtotal=0;
            int people=0;
            while (price!=-1)
            {
                subtotal += price;
                Console.WriteLine("Enter the  Price of Food Item:[-1 to quit]=  ");
                price =Convert.ToDouble(Console.ReadLine());
               
            }
            Console.WriteLine("----------------------------------------------");
            Console.Write("Enter the no. of peoples: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");
            if (people >= 6)
            {
                gratuityAmount = subtotal * gratuityrate;
            }
            grandtotal = subtotal + gratuityAmount;

            Console.WriteLine("subtotal: {0} ",subtotal);
            Console.WriteLine("{0} Gratuity: {1}",gratuityrate,gratuityAmount);
            Console.WriteLine("Grand Total: {0} ", grandtotal );
            Console.WriteLine("----------------------------------------------");

        }
    }


}
