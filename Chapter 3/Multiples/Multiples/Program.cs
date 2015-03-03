using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an app that reads two integers, determines whether the first is a multiple
            of the second and displays the result. [Hint: Use the remainder operator.]*/
            int number1;
            int number2;

            Console.Write("Please enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 % number2 == 0)
                Console.WriteLine("Your first number is a multiple of the second");
            if (number1 % number2 != 0)
                Console.WriteLine("This is not a multiple situation");
            Console.ReadLine();
        }
    }
}
