using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFatorial
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            int fat(int x)
            {
                   if (x == 0 || x == 1)
                      return 1;
                   else
                      return fat(x - 1) * x;
        }
            Console.WriteLine("Fatorial");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            
            

            
        }
    }
}
