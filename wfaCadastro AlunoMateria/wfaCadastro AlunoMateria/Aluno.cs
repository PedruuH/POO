using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastro_AlunoMateria
{
    class Aluno
    {
        private String nome, numero_matricula;
        private int periodo;
        private Materia[] lista_materias;
        int i;

        public Aluno()
        {
            nome = numero_matricula = "";
            periodo = 0;
            lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String name, String mat, int peri)
        {
            nome = name;
            numero_matricula = mat;
            periodo = peri;
            lista_materias = new Materia[8];
            i = 0;
        }

        public String getNome()
        { return nome; }
        public String getNum_Mat()
        { return numero_matricula; }
        public int getPeriodo()
        { return periodo; }


        public void setNome(String name)
        { nome = name; }
        public void setNum_Mat(String mat)
        { numero_matricula = mat; }
        public void setPeriodo(int peri)
        { periodo = peri; }

        public void addMateria(Materia m)
        {
            if (i < 7)
            {
                lista_materias[i] = m;
                i++;
            }
            
        }
        public string ImprimiDados()
       {
          string aux="";
          for (int k = 0; k < i; k++)
            aux+=(lista_materias[k].getNome() + " " + lista_materias[k].getCodigo()+"\n");
          return aux;
       }
    }
}
