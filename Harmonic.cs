using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Harmonic
    {
        public static void HarmonicToN()
        {
            Console.WriteLine("Enter the power value:-");
            int N = Convert.ToInt32(Console.ReadLine());
            if(N >0)
            {
                for(int i=1; i<=N; i++)
                {
                    Console.Write("1/" + i + i+"+");
                }
            }
            else
            {
                Console.WriteLine("Enter number greater than 0.");
            }
        }
    }
}
