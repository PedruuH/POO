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
             //inicializa o default
            Vetor2d v1 = new Vetor2d(); 
            Vetor2d v2 = new Vetor2d();
            //funções
            v1.setX(5.0);
            v1.setY(1.0);
            v2.setX(8.0); //setters
            v2.setY(2.0);
            Console.WriteLine("Get X vetor 1: " + v1.getX());
            Console.WriteLine("Get Y vetor 1: " + v1.getY());
            Console.WriteLine("Get X vetor 2: " + v2.getX());    //getters        
            Console.WriteLine("Get Y vetor 2: " + v2.getY());
            Console.WriteLine("\nProd. escalar V1 e V2: " + v1.produtoEscalar(v2)); //prod escalar de v1 com v2
            Console.WriteLine("\nModulo V1: " + v1.modulo()); //modulo v1
            Console.WriteLine("Modulo V2: " + v2.modulo()); //modulo v2
            Console.WriteLine("\nAngulo entre V1 e V2: " + v1.angulo(v2)); //angulo entre V1 e V2
            v1.vetorProjecao(v2); //vetor projeção                             
            Console.Read();
         }
    }
}
