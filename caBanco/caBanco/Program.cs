using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Poupanca p1 = new Poupanca();

            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu: \n");
                Console.WriteLine(" [1] - Abrir conta\n [2]- Sacar\n [3] - Depositar\n [4] - Imprimir Dados Cliente\n [5] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Nome do Cliente: ");
                        p1.setCliente(Console.ReadLine());
                        Console.WriteLine("\nTipo de conta Poupança");
                        p1.setTipo(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Numero da conta: ");
                        p1.setNumero(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Saldo inicial eh 0.0");
                        Console.Clear();
                        break;
                    case "2":
                        double saque;
                        Console.Clear();
                        Console.WriteLine("Saldo atual: " + p1.getSaldo());
                        Console.WriteLine("Selecione o valor a sacar: ");
                        saque = double.Parse(Console.ReadLine());
                        if (p1.getSaldo() == 0.0)
                        { Console.WriteLine("Não é possivel sacar o valor"); }
                        else  
                            if ((p1.getSaldo() - (saque+0.1)) < 0.0)
                                Console.WriteLine("Não é possivel sacar o valor");
                           else
                             p1.Sacar(saque);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Valor de deposito:");
                        p1.Depositar(double.Parse(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Nome: "+p1.getCliente());
                        Console.WriteLine("Tipo de conta: "+p1.getTipo());
                        Console.WriteLine("Número da conta: "+p1.getNumero());
                        Console.WriteLine("Saldo atual: "+p1.getSaldo());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        aux = 0;
                        break;
                    default:
                        Console.Write("\nFavor selecionar uma das opções do menu \n");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
