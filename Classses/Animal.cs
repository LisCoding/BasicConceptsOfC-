using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    { 
        // we declar the atributes as private to avoid invalid inputs
        // We apply the concept of Encapsulation were the implemantion is hidden.
        private string color;
        private string height;
        private string weight;
        private int age;
        private int numOfLegs;
        private string trick;


        // Setters and Getters
        public int Age
        {
            get
            {
               
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age can not be negative");
                }
                else
                {
                    this.age = value;
                }
               
            }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public virtual void Move()
        {
             Console.WriteLine("Animal moved");
        }
        public virtual void Eat()
        {
            Console.WriteLine("I eat bananas ");
    }   }
}
