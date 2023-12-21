using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace size_of_the_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 45;
            Console.WriteLine("The size of the integer is " + sizeof(int));
            Console.WriteLine("The size of the float is " + sizeof(float));
            Console.WriteLine("The size of the double is " + sizeof(double));
            Console.ReadLine();
        }
    }
}

