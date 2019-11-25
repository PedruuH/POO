using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecao2
{
    class Program
    {
         public static int quociente(int num, int den)
        {
            return (num / den);
        }
        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    int numerador, denominador;

                    Console.WriteLine("Numerador:");
                    numerador = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Denominador:");
                    denominador = Convert.ToInt32(Console.ReadLine());

                    double result = quociente(numerador, denominador);


                    Console.WriteLine("Resultado: " + result);


                    Console.ReadLine();

                    continueLoop = false;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Numero inteiro");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine("Exception: " + divideByZeroException.Message);
                }


            } while (continueLoop);
               


        }
    }
}
