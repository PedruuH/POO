using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace caArquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter x;

            string CaminhoNome = "C:\\Users\\Pedro\\Desktop\\arq01.txt";

            x = File.CreateText(CaminhoNome);
            Console.ReadKey();

            x.WriteLine("Recibo de Pagamento");
            x.WriteLine();
            x.WriteLine();
            x.WriteLine("Recebi do Sr. Fulano");
            x.WriteLine("a quantia de XXX (XXXXXXXXXXXX),");
            x.WriteLine("CIDADE, DATA");
            x.WriteLine();
            x.WriteLine();
            x.WriteLine("________________________________________");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF: ");
            x.WriteLine();
            x.Close();

            //x = File.OpenText(CaminhoNome);
            //x = File.AppendText(CaminhoNome);
            x.WriteLine();
            x.WriteLine("________________________________________");
            x.WriteLine("Recebedor: ");
            x.WriteLine("CPF: ");
            x.Close();

        }
    }
}
