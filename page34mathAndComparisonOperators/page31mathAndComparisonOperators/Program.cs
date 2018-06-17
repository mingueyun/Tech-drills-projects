using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page31mathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        
        {

            Console.WriteLine("Anonymous Income Comparison Program\n\n" + "Person 1\n" + "Hourly Rate?");
            string fHourly = Console.ReadLine();
            decimal hourlyRate = Convert.ToDecimal(fHourly);
          
            Console.WriteLine("Hours worked per week?");
            string fWork = Console.ReadLine();
            float workHours = float.Parse(fWork);


            Console.WriteLine("Person 2\n" + "Hourly Rate?");
            string sHourly = Console.ReadLine();
            decimal sRate = Convert.ToDecimal(sHourly);


            Console.WriteLine("Hours worked per week?");
            string sWork = Console.ReadLine();
            float sWorkHours = float.Parse(sWork);
           

            Console.WriteLine("Annual salary of Person 1:");
            decimal salOne =  hourlyRate * (decimal)workHours; 
            Console.WriteLine(salOne);
            // ** I tried to format the salary to money and I kept getting error cannot convert
            // to string
            //decimal salaryPersonOne = Decimal.Parse(salOne);
            //Console.WriteLine(" my salary is = { 0:c}", salaryPersonOne);


            Console.WriteLine("Annual salary of Person 2:");
            decimal salTwo = sRate * (decimal)sWorkHours;
            Console.WriteLine(salTwo);

            Console.WriteLine("Does Person 1 make more money then Person 2?");
            bool moreMoney = salOne > salTwo;
            Console.WriteLine(moreMoney);
            Console.ReadLine();


            //Console.WriteLine("give me a number");
            //string bNumber = Console.ReadLine();
            //decimal aNumber = Convert.ToDecimal(bNumber);
            //decimal multiply = aNumber * 50;
            //Console.WriteLine(multiply.ToString("N3"));
            //Console.ReadLine();


            //Console.WriteLine("give me a number");
            //string number = Console.ReadLine();
            //int add = Convert.ToInt32(number);
            //int total = add + 25;
            //Console.WriteLine(total);
            //Console.ReadLine();

            //Console.WriteLine("give me a number");
            //string dNumber = Console.ReadLine();
            //double divide = Convert.ToDouble(dNumber);
            //double fTotal = divide / 12.5;
            //Console.WriteLine(fTotal);
            //Console.ReadLine();

            //Console.WriteLine("give me a number");
            //string hNumber = Console.ReadLine();
            //double greaterThen = Convert.ToDouble(hNumber);
            //bool gThen = greaterThen > 50;
            //Console.WriteLine(g);
            //Console.ReadLine();

            //Console.WriteLine("give me a number");
            //string jNumber = Console.ReadLine();
            //double remainder = Convert.ToDouble(jNumber);
            //double nRemainder = remainder % 7;
            //Console.WriteLine(nRemainder);
            //Console.ReadLine();




        }
    }
}
