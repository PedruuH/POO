using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança1
{
    class Empregado
    {
        protected string nome, secao;
        protected double salario;

        public Empregado()
        {
            nome = "";
            secao = "";
            salario = 0.00;
        }
        public Empregado(string n, string s, double sal)
        {
            nome = n;
            secao = s;
            salario = sal;
        }

        public void setNome(string _nome)
        { nome = _nome; }
        public void setsecao(string _secao)
        { secao = _secao; }
        public void setSalario(double _salario)
        { salario = _salario;}

        public string getNome()
        { return nome; }
        public string getSecao()
        { return secao; }
        public double getSalario()
        { return salario; }

        public virtual void aumentaSalario(double taxa)
        { salario *= 1 + (taxa/100); }


        

    }
}
