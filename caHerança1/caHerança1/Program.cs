using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e1 = new Empregado("Joao", "Contabilidade", 1000.0);
            Gerente g1 = new Gerente("Jose", "Almoxarifado", 1000.0, "Maria");

            Console.WriteLine(g1.getSecretaria());
            Console.WriteLine("Nome do Gerente" + g1.getNome());
            Console.WriteLine("Salario anterior Empregado: " + e1.getSalario());
            Console.WriteLine("Salario anterior do Gerente: " + g1.getSalario());
            e1.aumentaSalario(30);
            g1.aumentaSalario(30);
            Console.WriteLine("Salario depois Empregado: " + e1.getSalario());
            Console.WriteLine("Salario depois do Gerente: " + g1.getSalario());
            Console.ReadLine();
            
        }
    }
}
