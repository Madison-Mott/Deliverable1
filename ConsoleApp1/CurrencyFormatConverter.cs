using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Hello! My Name is Madison.");
            Console.WriteLine("\n");
            Console.WriteLine("I will be helping you with converting currency formats!");


            Console.WriteLine("Please enter your first amount:");
            string str = Console.ReadLine();
            double valueOne = double.Parse(str);


            Console.WriteLine("Please enter your second amount:");
            string str1 = Console.ReadLine();
            double valueTwo = double.Parse(str1);


            Console.WriteLine("Please enter your third amount:");
            string str2 = Console.ReadLine();
            double valueThree = double.Parse(str2);


            Console.WriteLine("\n");

            double valueTotal = valueOne + valueTwo + valueThree;
            double valueAverage = valueTotal / 3;
            double averageDecimal = Math.Round(valueAverage, 2);


            double[] myArray = new[] { valueOne, valueTwo, valueThree };
            double smallest = myArray.Min();
            double largest = myArray.Max();

            Console.WriteLine("The total amount you entered is " + valueTotal + ".");

            Console.WriteLine("The average of the amounts entered is " + averageDecimal + ".");

            Console.WriteLine("The smallest of the amounts entered is " + smallest + ".");

            Console.WriteLine("The largest of the amounts entered is " + largest + ".");

            Console.WriteLine("\n");

            Console.WriteLine("Now let's see the same total amount of " + valueTotal + " in US, Swedish, Japanese, and Thai currency formats.");
            Console.WriteLine("\n");
            Console.WriteLine("US: " + valueTotal.ToString("C", CultureInfo.CurrentCulture) + ".");
            Console.WriteLine("Swedish: " + valueTotal.ToString("c", CultureInfo.GetCultureInfo("sv-SE")) + ".");
            Console.WriteLine("Japanese: " + valueTotal.ToString("c", CultureInfo.GetCultureInfo("ja-JP")) + ".");
            Console.WriteLine("Thai: " + valueTotal.ToString("c", CultureInfo.GetCultureInfo("th-TH")) + ".");

            Console.WriteLine("\n");
            Console.WriteLine("Wasn't that fun?");
            Console.WriteLine("*cricket sounds*");
            Console.WriteLine("I guess it was just me then! Have a good day!");

            Console.ReadKey();





        }

    }

}