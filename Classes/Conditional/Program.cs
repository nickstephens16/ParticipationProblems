using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        //Create an application that helps the accounting department create a receipt for each sale that the company makes.Zigs sell for $60 and zags sell for $90. If a customer buys more than 20 total zigs and zags then they receive a discount rate of 20%. Sales tax is 6.25%. Create a console application that asks the user how many zigs and zags they are going to purchase. Calculate the total before and after the discount rate and tax is applied (if the discount rate applies). Store each receipt in a dictionary or list with a unique number that is able to be called on by the accounting department.
        static void Main(string[] args)
        {

            double zag = 90.00;

            double markup=1.15;
            double zig = 60.00;

            double discountrate = .20;

            double markup2 = 1.125;

            double salestax = .0625;




            Console.WriteLine("How many zig are you purchasing");

            int numberofzigs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many zags are you purchasing");

            int numberofzags = Convert.ToInt32(Console.ReadLine());




            double zigprice;

            double zagprice;




            zigprice = numberofzigs * zig;

            zagprice = numberofzags * zag;

            double total;

            total = zagprice + zigprice;

            double endtotal;

            int totalnumber = numberofzigs + numberofzags;

            string discountamount;







            if (totalnumber < 16)

            {

                endtotal = total * markup;

                discountamount = "15%";

            }

            else if (numberofzags > 10)

            {

                endtotal = total * markup2;

                discountamount = "12.5%";

            }

            else if (numberofzigs > 10)

            {

                endtotal = total * markup2;

                discountamount = "12.5%";

            }

            else

            {

                endtotal = total * markup2;

                discountamount = "12.5%";




            }




            Console.WriteLine($"End total before tax = {endtotal}");

            Console.WriteLine($"Markup = {discountamount}");

            double tax = endtotal * (1 + salestax);

            Console.WriteLine($"End total after tax {tax}");

            Console.ReadLine();

        }
    }
}
