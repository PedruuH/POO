using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança1
{
    class Gerente:Empregado
    {
        private string secretaria;

        public Gerente()
        { }

        public Gerente(string _nome, string _secao, double _salario,string _secretaria)
            :base(_nome,_secao,_salario)
        {
            secretaria = _secretaria;
        }

        public void setSecretaria(string _secretaria)
        { secretaria = _secretaria; }
        public string getSecretaria()
        { return secretaria; }

        public override void aumentaSalario(double taxa)
        {
            base.aumentaSalario(taxa+15);
        }

    }
}
