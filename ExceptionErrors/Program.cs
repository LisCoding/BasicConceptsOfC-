using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage;
            int numerator;
            int denominator;
            int result;
            Console.WriteLine("Enter the numerator");
            numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("enter a dominator");
            denominator = Int32.Parse(Console.ReadLine());
            try
            {
                result = numerator / denominator;
                Console.WriteLine("The result is " + result);
            }
            catch(OverflowException ofEx)

            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch(DivideByZeroException dEx)
            {
                errorMessage = dEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }
            finally
            {
                //clean up code goes here
            }


        }
    }
}
