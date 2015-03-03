using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_of_Squares_and_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Using only the programming techniques you learned in this
            chapter, write an app that calculates the squares and cubes of the numbers from 0 to 10 and displays
            the resulting values in table format, as shown below. All calculations should be done in terms of a
            variable x. [Note: This app does not require any input from the user.]*/
            int zero = 0;
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int six = 6;
            int seven = 7;
            int eight = 8;
            int nine = 9;
            int ten = 10;

            Console.WriteLine("number\tsquare\tcube");
            Console.WriteLine("{0}\t{1}\t{2}", zero, Math.Pow(zero,2), Math.Pow(zero,3));
            Console.WriteLine("{0}\t{1}\t{2}", one, Math.Pow(one, 2), Math.Pow(one, 3));
            Console.WriteLine("{0}\t{1}\t{2}", two, Math.Pow(two, 2), Math.Pow(two, 3));
            Console.WriteLine("{0}\t{1}\t{2}", three, Math.Pow(three, 2), Math.Pow(three, 3));
            Console.WriteLine("{0}\t{1}\t{2}", four, Math.Pow(four, 2), Math.Pow(four, 3));
            Console.WriteLine("{0}\t{1}\t{2}", five, Math.Pow(five, 2), Math.Pow(five, 3));
            Console.WriteLine("{0}\t{1}\t{2}", six, Math.Pow(six, 2), Math.Pow(six, 3));
            Console.WriteLine("{0}\t{1}\t{2}", seven, Math.Pow(seven, 2), Math.Pow(seven, 3));
            Console.WriteLine("{0}\t{1}\t{2}", eight, Math.Pow(eight, 2), Math.Pow(eight, 3));
            Console.WriteLine("{0}\t{1}\t{2}", nine, Math.Pow(nine, 2), Math.Pow(nine, 3));
            Console.WriteLine("{0}\t{1}\t{2}", ten, Math.Pow(ten, 2), Math.Pow(ten, 3));
            Console.ReadLine();
        }
    }
}
