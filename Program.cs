using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            //string a, b;
            Console.WriteLine("Addition");
            Console.Write("Enter your First Number: ");
            //a = Console.ReadLine();
            //return int.TryParse(a, out x);

            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Second Number: ");
            y =Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Addition of " + x + " + " + y + " = " + z);
            Console.ReadLine();



        }
    }
}
