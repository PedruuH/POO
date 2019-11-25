using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Estacionamento[] estaci = new Estacionamento[5];
            for(int i=0;i<estaci.Length;i++)
            {
                estaci[i] = new Estacionamento();
            }
            for(int i=0;i<estaci.Length;i++)
            {
                Console.WriteLine("Carro" + (i + 1));
                estaci[i].novoCarro();
                Console.Clear();
            }
            Console.Clear();
            for(int i=0;i<estaci.Length;i++)
            {
                Console.WriteLine("\nDados do carro "+(i+1));
                estaci[i].dadosCarro();
            }
            Console.Read();
        }
    }
}
