        ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Concatenate("Ariel", "Sejas");
            string favHobby = Hobby("tennis");
            Console.WriteLine("Liseth loves "  + favHobby);

        }
        
        //create a function that concatenate a first name and last name of return type 
        //void
        static void Concatenate(string firstName, string  lastName)
        {
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
        }

        //This is method return a string
        static string Hobby(string favoriteHobby)
        {
            return favoriteHobby;
        }
    }
}
