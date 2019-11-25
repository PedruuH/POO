using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO1
{
    class Program
    {
        static void Main(string[] args)
        {
            double _r1, _r2, _p1, _p2;
            Console.WriteLine("Resistencia do Resistor R1: ");
            _r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Potencia do Resistor R1: ");
            _p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nResistencia do Resistor R2: ");
            _r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Potencia do Resistor R2: ");
            _p2 = double.Parse(Console.ReadLine());

            Resistor r1 = new Resistor(_r1,_p1);
            Resistor r2 = new Resistor(_r2,_p2);

            Resistor equiSerie = r1.resistorSerie(r2);
            Resistor equiParalelo = r1.resistorParalelo(r2);

            Console.WriteLine("\nDados do Resistor R1 e R2:");
            r1.imprimeResistor();
            r2.imprimeResistor();
            Console.WriteLine("\nDados do Resistor Equivalente Serie:");
            equiSerie.imprimeResistor();
            Console.WriteLine("\nDados do Resistor Equivalente Paralelo:");
            equiParalelo.imprimeResistor();        
            

            Console.ReadLine();

        }
    }
}
