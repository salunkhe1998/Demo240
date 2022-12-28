using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Table
    {
        public static void TableOf()
        {
            
                Console.WriteLine("Enter the power value :-");
                int N = Convert.ToInt32(Console.ReadLine());
                if (0< = N && N < 31)
                {
                    for (int i = 0; i <= N; i++)
                    {
                        double a = Math.Pow(2, i);
                        Console.WriteLine(+a);
                    }
                }
                else
                {
                    Console.WriteLine("Enter the number less than 31.");
                }
            
        }
    }
}
