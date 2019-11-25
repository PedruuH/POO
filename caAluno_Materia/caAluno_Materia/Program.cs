using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno_Materia
{
    class Program
    {
        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        static void Main(string[] args)
        {
            string nome_aluno, matricula, codigo, nome_materia;
            int periodo, qtdalunos = 0;
           // Aluno A1 = new Aluno("Pedro","11611ECP017",5);
           // Materia m1 = new Materia("POO", "FEELT134");
           // Materia m2 = new Materia("ED", "FEELT138");
           // Materia m3 = new Materia("CG", "FEELT141");
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Materia> listaMateria = new List<Materia>();
            Aluno aL;
            Materia mL;

            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu: \n");
                Console.WriteLine(" [1] - Cadastrar aluno\n [2]- Cadastrar disciplina \n [3] - Associar disciplina a aluno \n [4] - Imprimir relatório \n [5] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Cadastrar um aluno");
                        Console.Write("\nAluno: ");
                        nome_aluno = Console.ReadLine();
                        Console.Write("\nMatricula: ");
                        matricula = Console.ReadLine();
                        Console.Write("\nPeriodo: ");
                        periodo = int.Parse(Console.ReadLine());
                        Aluno a = new Aluno(nome_aluno, matricula, periodo);
                        listaAlunos.Add(a);
                        qtdalunos++;
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Cadastrar uma disciplina");
                        Console.Write("\nMateria: ");
                        nome_materia = Console.ReadLine();
                        Console.Write("\nCodigo: ");
                        codigo = Console.ReadLine();
                        Materia m = new Materia(nome_materia, codigo);
                        listaMateria.Add(m);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Associar aluno - disciplina\n");
                        Console.Write("Materias cadastradas: ");    
                        for (int i = 0; i < listaAlunos.Count; i++)
                          Console.Write("Alunos\n" + listaAlunos[i].getNome());
                        nome_aluno = Console.ReadLine();
                        aL = achaAluno(nome_aluno, listaAlunos);
                        Console.WriteLine("Escolha uma materia:\n");
                        // Apresentar lista de materias:
                        for (int i = 0; i < listaMateria.Count; i++)
                        {
                            Console.WriteLine("Materia = " + listaMateria[i].getNome());
                        }

                        nome_materia = Console.ReadLine();
                        mL = achaMateria(nome_materia, listaMateria);
                        // associa Aluno à materia
                        aL.addMateria(mL);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < qtdalunos; i++)
                            listaAlunos[i].ImprimiDados();
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
