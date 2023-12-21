using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Program
    {
        class indexers
        {
            private string[] namelist = new string[size];
            static public int size = 10;
            public indexers  ()
             {
                for (int i = 0; i < size; i++)
                {
                    namelist[i] = "N. A.";
                }
                
            }
            public string this[int index]
            {
                get
                {
                    string temp;
                    if(index>=0 && index <= size - 1)
                    {
                        temp = namelist[index];
                    }
                    else
                    {
                        temp = " ";
                    }
                    return temp;
                }
                set
                {
                    if (index >= 0 && index <= size - 1)
                    {
                        namelist[index] = value;
                    }
                }
            }

        }
        static void Main(string[] args)
        {


            indexers names=new indexers();
            names[0] = "hellow";
            names[1] = "my nam eis purshottam ";
            names[2] = "And i am from the sarlahi ";
            for(int i=0;i<indexers.size;i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();

        }
    }
}
