using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops 
            for(int x= 0; x < 10; x++)
            {
                Console.WriteLine("the values of x is " + x);
            }
            //foreach loops most used with array or collections
            int[] numbers = new int[] { 3, 4, 5, 6, 7, 8 };
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                Console.WriteLine(num * 2);
          
            }

            //While loops 
            int counter = 5; 
            while(counter > 0)
            {
                Console.WriteLine(counter);
                Console.WriteLine("I am awesome");
                counter--;
            }
            //Do ...while  loops 
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            int j = 10;
            do
            {
                Console.WriteLine("This is code will excute even though the condition is false");
                Console.WriteLine(j);
                j++;
            } while (j < 10);
        }
    }
}
