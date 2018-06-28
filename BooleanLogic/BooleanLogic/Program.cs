using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int nAge = Convert.ToInt32(age);

            Console.WriteLine("have you ever had a dui? answer in false or true");
            string dui = Console.ReadLine();
            bool yesOrNo = dui == "true";



            Console.WriteLine("how many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int nticket = Convert.ToInt32(ticket);



            bool qual = nAge >= 15 && yesOrNo == false && nticket < 3 ?

            true : false;
            Console.WriteLine("Qualified?\n" + qual);
            Console.ReadLine();

        }
    }
}
