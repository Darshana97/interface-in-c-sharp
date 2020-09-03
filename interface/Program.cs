using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{

    interface ICustomer
    {
        void Print();
    }

    class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Interface Print method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Customer C1 = new Customer();
            C1.Print();
            Console.ReadLine();

        }
    }
}
