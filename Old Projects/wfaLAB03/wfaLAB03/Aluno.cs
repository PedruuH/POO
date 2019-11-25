using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLAB03
{
    public class Aluno
    {
        
        private string nome, matricula;
        private Materia[] listmaterias;
        private int qtdM;

        public Aluno()
        {
            nome = matricula = "";
            listmaterias = new Materia[10];
            qtdM = 0;
        }
        public string getNome()
        {
            return nome;
        }
        public string getMat()
        {
            return matricula;
        }
        public void setNome(string n)
        {
            nome = n;
        }
        public void setMat(string m)
        {
            matricula=m;
        }
        
        public void addMateria(Materia m)
        {
            listmaterias[qtdM] = new Materia();
            listmaterias[qtdM] = m;
            qtdM++;
        }
        public string getMaterias()
        {
            string m="";
            for(int i=0;i<qtdM;i++)
            {
                m = m + listmaterias[i].getNome();   
            }
            return m;
        }

    }
}
