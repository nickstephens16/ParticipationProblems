using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        //Create for loop that will keep prompting the user to input prices of items, add their input to an accumulator and then ask the user if they have another price to enter, and repeat the process until they say they are done(case insensitive).  Once they say no, display the average of all of the prices in currency format.
        static void Main(string[] args)
        {
            double price, average, total = 0;
            string question;
            int numitems = 0;

            do
            {
                Console.WriteLine("Please enter the price of your item.");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to enter another item price? Please enter 'yes' if so.");
                question = Convert.ToString(Console.ReadLine());
                total = total + price;
                numitems++;
            }
            while (question.ToLower() == "yes");

            average = (total / (numitems * 100));
            Console.WriteLine($"After {numitems} items, your average price is {average:C}.");
            Console.ReadLine();

        }
    }
}
