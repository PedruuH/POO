using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e1 = new Empregado("João", "Contabilidade", 1000.0);
            Gerente g1 = new Gerente("Jose", "Almoxarifado", 1000, "Maria");

            Console.WriteLine(g1.getSecretaria());
            Console.WriteLine("Nome gerente: " + g1.getNome());


            
            
        }

    }
}
