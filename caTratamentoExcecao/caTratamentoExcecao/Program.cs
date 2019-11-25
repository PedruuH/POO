using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecao
{
    class Program
    {
        public static int quociente(int num, int den)
        {
            return (num / den);
        }
        static void Main(string[] args)
        {
            int numerador, denominador;

            Console.WriteLine("Numerador:");
            numerador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Denominador:");
            denominador = Convert.ToInt32(Console.ReadLine());

            double result = quociente(numerador, denominador);
            

            Console.WriteLine("Resultado: "+result);


            Console.ReadLine();


        }
    }
}
