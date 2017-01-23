using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicHateBall
{
    public class Magic
    {


        public static void RunMagicHateBall()
        {
            bool runAgain = true;
            Random rng = new Random();
            int r = rng.Next(1, 4);
            while (runAgain == true)
            {
                Console.WriteLine("Enter Your Question");
                string tmp = Console.ReadLine();
                var happy = new Happy();
                var sad = new Sad();
                var robot = new Robot();
                if (r == 1)
                {
                    Console.WriteLine(happy.Answer());
                }
                else if (r == 2)
                {
                    Console.WriteLine(sad.Answer());
                }
                else
                {
                    Console.WriteLine(robot.Answer());
                }
                Console.WriteLine("Would you like to run again? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer.Equals("N"))
                {
                    runAgain = false;
                }
            }
        }

    }
}
