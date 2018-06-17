using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharPg29exerciseVariablesAndDataTypes
{
    
    class Program
        
    {
        
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n" + "Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("Your current class is: " + course);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pNumber = Convert.ToInt32(page);
            Console.WriteLine("Your current page is: " + pNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpNoHelp = Console.ReadLine();
            bool help = helpNoHelp == "true";
            Console.WriteLine("You answered that you do need assitance: " + help);
            


            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();

            Console.WriteLine("Do you need more things to say ? Please answer \"true\" or \"false\"");
            string moreText = "true";

            string needMore = Console.ReadLine();
            if (needMore == moreText)
            {
                string whatNow = Console.ReadLine();
                Console.WriteLine(experience + " " + whatNow);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your response to your experience were: " + experience);
                Console.ReadLine();
            }


            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            String feedback = Console.ReadLine();
            Console.WriteLine("Your feedback was : " + feedback);
            Console.ReadLine();

            Console.WriteLine("how many hours did you study today?");
            string study = Console.ReadLine();
            double hourStudy = Convert.ToDouble(study);
            Console.WriteLine("Your time spent was : " + hourStudy + " hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
