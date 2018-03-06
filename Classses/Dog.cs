using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{   
    // Class Dog inherance from Animal class
    class Dog : Animal
    {   
        //aply polymorphism
        public string name; 
        public string owner;
        

        // this functon override the move function in the parent class
        public override void Move()
        {
            Console.WriteLine("I am running");
           
        }
       
    }
}
