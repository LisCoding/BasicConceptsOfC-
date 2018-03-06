using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            // here the error is handle one level stack avobe 
            string errorMessage;

            try
            {
                Divide();
            }
            catch(OverflowException ofEx)
            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
                    
             
            }
            catch (DivideByZeroException dEx)
            {
                errorMessage = dEx.Message;
                //errorMessage = "you are pretty";
                Console.WriteLine(errorMessage);

            }

            catch (Exception e)
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
            Console.WriteLine("Enter the numerator");
            numerator = Int32.Parse(Console.ReadLine());
           // Console.WriteLine(); Why do we need this line here??
            Console.WriteLine("Enter the Denominator");
             
            denominator = Int32.Parse(Console.ReadLine());
            result = numerator / denominator;
           // Console.WriteLine();
            Console.WriteLine("The result is: " + result);
               
      
        }
    }
}
