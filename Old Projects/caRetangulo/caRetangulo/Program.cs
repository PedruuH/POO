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
            Console.WriteLine("Bem Vindo a poo");
            
            //instanciando objeto da classe retangulo
            Retangulo r1 = new Retangulo();
            //r1.setBase(4.0); Tem construtor agora
            //r1.setAltura(5.0);
            double area = r1.calculaArea();
            Console.WriteLine("\n Area do r1= " + area);
            Console.WriteLine("\n O Perimetro do r1= " + r1.perimetro());
            
            Retangulo r2 = new Retangulo(7.0, 8.0);
            Console.WriteLine("\n Area do r2= " + r2.calculaArea());
            
             



            Console.Read();

        }
    }
}
