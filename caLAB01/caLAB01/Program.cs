using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D vetor1 = new Vetor2D();
            Vetor2D vetor2 = new Vetor2D();

            vetor1.setX(2);
            vetor1.setY(2);
            vetor2.setX(0);
            vetor2.setY(2);

            Console.WriteLine("Get X vetor 1: " + vetor1.getX());
            Console.WriteLine("Get Y vetor 1: " + vetor1.getY());
            Console.WriteLine("Get X vetor 2: " + vetor2.getX());    //getters        
            Console.WriteLine("Get Y vetor 2: " + vetor2.getY());

            Console.WriteLine("\n Prod. Escalar V1 com V2: " + vetor1.prodEscalar(vetor2));

            Console.WriteLine("\nModulo V1: " + vetor1.modulo());
            Console.WriteLine("\nModulo V2: " + vetor2.modulo());

            Console.WriteLine("\nAngulo entre V1 e V2: " + vetor1.angulo(vetor2));

            vetor1.vetorProjecao(vetor2);

            Console.ReadLine();

        }
    }
}
