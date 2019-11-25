using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace caNumeroComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplexo z1 = new NumeroComplexo(3.0,4.0);
            NumeroComplexo z2 = new NumeroComplexo(5.7,6.8);
            NumeroComplexo z3 = new NumeroComplexo();

            z1.print();
            z2.print();
            Console.WriteLine("Módulo Z1: "+z1.modulo());
            Console.WriteLine("\nMódulo Z2: " + z2.modulo());
            z3=z1.soma(z2);
            Console.WriteLine("\nSoma Z1 + Z2: ");            
            z3.print();

            Console.Read();
        }
    }
}
