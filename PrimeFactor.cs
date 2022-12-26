using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class PrimeFactor
    {
        public static void PrimeFact()
        {
            Console.WriteLine("Enter the Number:-");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num>0)
            {
                for (int i=2; i<Num;i++)
                {
                    while (Num % i==0)
                    {
                        Console.Write(i + "and");
                        Num = Num / i;
                    }
                }
                if(Num>2)
                {
                    Console.Write(Num);
                }
            }
            else
            {
                Console.WriteLine("Enter number greater than 0.");
            }
        }
    }
}
