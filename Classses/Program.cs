using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.Age = 4;
            cat.Color = "blue";
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Color);
            cat.Eat();
            cat.Move();

            //Dog object 
            Dog picaro = new Dog();
            picaro.Color = "black";
            picaro.Eat();
            picaro.name = "laxy";
            picaro.owner = "Liseth";
            Console.WriteLine(picaro.owner + " has a beutifull puppy named " + picaro.name);

            picaro.Move();
           
        }
    }
}
