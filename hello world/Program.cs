using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("My name is " + name);
            Console.WriteLine("Enter the value of the a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            Console.ReadKey();


        }
    }
}
