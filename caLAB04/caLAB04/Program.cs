using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D v1 = new Vetor3D(10,2,6);
            Vetor3D v2 = new Vetor3D(30, 9, 16);
            Console.WriteLine("Vetor 3D v1 x: "+ v1.getX());
            Console.WriteLine("Vetor 3D v1 y: " + v1.getY());
            Console.WriteLine("Vetor 3D v1 z: " + v1.getZ());
            Console.WriteLine("\nVetor 3D v2 x: " + v2.getX());
            Console.WriteLine("Vetor 3D v2 y: " + v2.getY());
            Console.WriteLine("Vetor 3D v2 z: " + v2.getZ());
            Console.WriteLine("\n\nProduto esvalar v1 e v2: " + v1.prodEscalar(v2));
            Console.WriteLine("\n\nModulo v1: " + v1.modulo());
            Console.WriteLine("\n\nModulo v2: " + v2.modulo());
            Console.ReadLine();
            

        }
    }
}
