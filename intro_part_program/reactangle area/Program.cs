
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactangle_are
{

    class reactangle
    {
        int length;
        int breadth;
        public void getdata()
        {
            Console.WriteLine("Enter the value of the length AND breadth ");
            length = 4;
            breadth = 5;

        }
        public double calculate()
        {
            return length * breadth;
        }
        public void display()
        {
            Console.WriteLine("The length is " + length);
            Console.WriteLine("The breadth is " + breadth);
            Console.WriteLine("The area is is " + (length * breadth));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int breadth = 5;
            Console.WriteLine("The area is " + (length * breadth));

            reactangle r1 = new reactangle();
            r1.getdata();
            r1.calculate();
            r1.display();
            Console.ReadLine();
        }
    }
}
