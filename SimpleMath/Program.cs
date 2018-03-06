using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)

        {
            int num1 = 2;
            int num2 = 6;
            Console.WriteLine(Addition(num1, num2));
            Console.WriteLine(Substraction(2, 4));
            Console.WriteLine(Multiplication(2, 4));
            Console.WriteLine(Player("Liseth"));
        }
        static int Addition(int num1, int  num2)
        {
            return num1 + num2;
        }
        static int Substraction(int num1, int num2)
        {
            return num2 - num1;
        }
        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        static string Player(string playerName){
            string sentence = "you are awesome " + playerName;
            return sentence;
        }

    }
}
