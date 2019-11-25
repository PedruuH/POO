using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança
{
    class Empregado
    {
        protected String nome { get; set; }
        protected String secao { get; set; }
        protected Double salario { get; set; }

        public Empregado()
        {
            nome = secao = "";
            salario = 0.0;
        }
        public Empregado(string _nome, string _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }
        public virtual void aumentaSalario(double percentagem)
        {
            salario *= 1 + percentual / 100;
        }
        public string getNome()
        {
            return nome;
        }
        public string getSecao()
        {
            return nome;
        }
        public double getSalario()
        {
            return salario;
        }


        
    }
}
