using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        /*Write an app that reads an integer, then determines and displays whether
        it’s odd or even. [Hint: Use the remainder operator. An even number is a multiple of 2. Anymultiple
        of 2 leaves a remainder of 0 when divided by 2.]*/
        static void Main(string[] args)
        {
            int digit;
            Console.Write("Please enter an integer: ");
            digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (digit % 2 == 0)
            Console.Write("Your number is even");
            if (digit % 2 != 0)
                Console.WriteLine("Your number is odd");
            Console.ReadLine();
        }
    }
}
