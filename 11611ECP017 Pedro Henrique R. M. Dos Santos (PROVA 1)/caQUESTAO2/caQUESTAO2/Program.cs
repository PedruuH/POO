using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
            // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
            Pagtos[] lista_pagtos = new Pagtos[6];
            int k = 0;
            int aux = 1;
            while(aux!=0)
            {
                Console.WriteLine("Pagamentos\n");
                Console.WriteLine("[1] - Pagamento Alimentacao \n[2] - Pagamento Saude\n[3] - Relatorio\n[4] - Sair");
                string op = Console.ReadLine();
                switch(op)
                {
                    case "1":
                        Console.Clear();
                        Alimentacao a = new Alimentacao();
                        Console.WriteLine("CPF:");
                        a.setCPF(long.Parse(Console.ReadLine()));
                        Console.WriteLine("Valor:");
                        a.setValor(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Codigo:");
                        a.setCod(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Descricao:");
                        a.setDescricao(Console.ReadLine());
                        Console.WriteLine("Valor Fatura Alimentacao:");
                        a.setVlfatAliment(double.Parse(Console.ReadLine()));
                        lista_pagtos[k] = a;
                        k++;
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Saude b = new Saude();
                        Console.WriteLine("CPF:");
                        b.setCPF(long.Parse(Console.ReadLine()));
                        Console.WriteLine("Valor:");
                        b.setValor(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Codigo:");
                        b.setCod(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Estabelecimento:");
                        b.setEstabelecimento(Console.ReadLine());
                        Console.WriteLine("Valor Fatura Saude:");
                        b.setVfatSaude(double.Parse(Console.ReadLine()));
                        lista_pagtos[k] = b;
                        k++;
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        for (int i = 0; i < lista_pagtos.Length;i++)
                        {
                            Console.WriteLine("Pagamento: " + (i + 1));
                            lista_pagtos[i].faturar();
                            Console.WriteLine("CPF:"+lista_pagtos[i].getCPF());                            
                            Console.WriteLine("Valor:"+lista_pagtos[i].getValor());
                            Console.WriteLine("Codigo:"+lista_pagtos[i].getCod());
                            if (Convert.ToString(lista_pagtos[i].GetType()) == "caQUESTAO2.Saude")
                            
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO
                                // ACABOU O TEMPO DE PROVA E A QUESTAO 2 ACHEI MAL FORMULADO O TEXTO EXPLICATIVO

                            Console.ReadLine();
                        }
                            break;
                    case "4":
                        aux = 0;
                        break;

                }
            }


        }
    }
}
