using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        //struct are created inside  a class
        struct Person
        {
            int age;
            string firstName;
            string lastName;
        }

        static void Main(string[] args)
        {
            //Variables 
            int personAge;
            personAge = 32;
            Console.WriteLine("I am " + personAge + " years old");

            personAge = 10;
            Console.WriteLine("Now Iam " + personAge + " years old");

            //constants 
            //constants has to be declared and initialize and the same time

            const int NUM_MONTHS = 12;
            Console.WriteLine("Iam constant and I cant change" + NUM_MONTHS)
    

        }
    }
}
