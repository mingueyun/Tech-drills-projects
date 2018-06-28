using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Package Express. Please follow the instruction below.");

            Console.WriteLine("what is the package weight?");

            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }

   
            Console.WriteLine("what is the package width?");
            int width = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("what is the package height?");
            int height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("what is the package length?");
            int length = Convert.ToInt32(Console.ReadLine());

            decimal dimen = (width * height * length) * weight / 100;

            if (width > 50 || length > 50 || height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: {0:c}", dimen);
                Console.WriteLine("Thank you");
                Console.ReadLine();

            }





         


            //int result = dimen * weight / 100;
            //string yo = Convert.ToString(result);
            //decimal cost = decimal.Parse(yo);
            //Console.WriteLine("Your estimated total for shipping this package is: {0:c}", cost);
            //Console.WriteLine("Thank you");

            //Console.WriteLine("what is the package weight?");
            //int weight = Convert.ToInt32(Console.ReadLine());
            //string overWeight = weight > 50 ?
            //    "Package too heavy to be shipped via Package Express. Have a good day." : "what is the package height?";

            //Console.WriteLine(overWeight);


            //int width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("what is the package height?");
            //int height = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("what is the package length?");
            //int length = Convert.ToInt32(Console.ReadLine());


            //if (width  > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express.");
            //}
            //if (height > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express.");
            //}
            //if (length > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express.");
            //}


            //else
            //{
            //    int dimen = width + height + length;
            //    int result =  dimen * weight / 100;
            //    string yo = Convert.ToString(result);
            //    decimal cost = decimal.Parse(yo);
            //    Console.WriteLine("Your estimated total for shipping this package is: {0:c}" , cost);
            //    Console.WriteLine("Thank you");
            //    Console.ReadLine();



        }
    }
}
