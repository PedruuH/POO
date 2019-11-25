using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret_1 = new Retangulo();
            Retangulo ret_2 = new Retangulo(6,8);

            ret_1.setAltura(5);
            ret_1.setBase(4);


            Console.WriteLine("Ret 1 \nbase: " + ret_1.getBase());
            Console.WriteLine("altura: " + ret_1.getAltura());

            Console.WriteLine("\nRet 2\nbase: " + ret_2.getBase());
            Console.WriteLine("altura: " + ret_2.getAltura());
            Console.WriteLine("\nRet 1 area: " + ret_1.area());
            Console.WriteLine("Ret 1 perimetro: " + ret_1.perimetro());
            Console.WriteLine("Ret 2 area: " + ret_2.area());
            Console.WriteLine("Ret 2 perimetro: " + ret_2.perimetro());
           

            Console.ReadLine();
            
        }

    }
}
