using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrowingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage;

            try
            {
                Divide();
            }
            catch(OverflowException ofEx)
            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);

            } catch( DivideByZeroException dEx)
            {
                errorMessage = dEx.Message;
                Console.WriteLine(errorMessage);
            } catch ( Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }


        }

        static void Divide()
        {
            int numerator;
            int denominator;
            int result;

            Console.WriteLine("Enter a numerator");
            numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a denominator");
            denominator = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                result = numerator / denominator;
                Console.WriteLine(); // add a extra empty line space 
                Console.WriteLine("The result is " + result);
            } catch(DivideByZeroException dEx)
            {
                throw new Exception("Division by zero please change the dominator", dEx.InnerException);
            }
        }
    }
}
