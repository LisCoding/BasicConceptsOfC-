using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //numeric data types 
            int number = 2147383;
            sbyte signedByte = 127;
            byte onlyByte = 255;
            short aShort = 32767;
            long aLong = 9223377392992929;
            float aFloat = 105.56F;
            double aDouble = 105.567;
            decimal aDecimal = 105.6363663535353M;

            //character data types
            char character = 'L';
            string Word = " I love coding";

            //Boolean 
            bool happy = true;
            bool angry = false;
            Console.WriteLine(aDecimal);
            Console.WriteLine(aLong);
            Console.WriteLine(aFloat);
            Console.WriteLine(aShort);
            Console.WriteLine(Word);
            Console.WriteLine(aDecimal);
            Console.WriteLine("this is a char " + character);
            Console.WriteLine("this is a int data type" + number);

        }
    }
}
