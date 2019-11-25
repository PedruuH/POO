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
            Estacionamento[] E = new Estacionamento[5];
            for(int i=0;i<5;i++)
                E[i]= new Estacionamento();

            Console.WriteLine("Entre com os dados dos carros:");
            for (int i = 0; i < 5; i++){
                Console.Write("Carro " + (i + 1));
                E[i].solicitaDadosCarro();}

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nDados carro " +(i+1));
                E[i].dadosCarro();
                E[i].valorCobrado();
            }

            Console.ReadLine();
        }
    }
}
