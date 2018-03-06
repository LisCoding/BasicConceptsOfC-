using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desicionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //If statements 
            string name = "Lis";
            string lastName = "Cardozo";
            if(name == "Liseth")
            {
                Console.WriteLine("this is true");
            } else if(lastName == "Cardozo")
            {
                Console.WriteLine("Yeahhh!!!");
            
            }
            else
            {
                Console.WriteLine("This is false");
            }

            //Switch statement 
            int value = 5;
            switch (value)
            {
                case 0:
                    Console.WriteLine("Value is 0");
                    break;
                case 1:
                    Console.WriteLine("Vale is 1");
                    break;
                default:
                    {
                        Console.WriteLine("Value is somethins else");
                    }
                    break;
            }

        }
    }
}
