using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {

            int tailCount = 0;
            int headCount = 0;
            double headPercentage = 0.0;
            double tailPercentage = 0.0;

            Console.WriteLine("Please enter the value for number of flips");
            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random obje = new Random();
                    int number = obje.Next(2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailCount++;
                    }
                    else
                    {
                        headCount++;
                    }
                }
                Console.WriteLine("The TailCount is" + tailCount);
                Console.WriteLine("The HeadCount is" + headCount);

                headPercentage = (headCount * 100) / flip;
                tailPercentage = (tailCount * 100) / flip;

                Console.WriteLine("The tailPercentage is" + tailPercentage);
                Console.WriteLine("The hailPercentage is" + tailPercentage);

            }
            else
            {
                Console.WriteLine("Please enter the correct number");
            }
        }
       
        }
}
