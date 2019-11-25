using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHerança
{
    class Gerente:Empregado
    {
        private String secretaria;

        public Gerente()
        {
        }
        public Gerente(string _nome,string _secao,double _salario, string _secretaria)
            :base(_nome,_secao,_salario)
        {
            secretaria = _secretaria;
        }
        public override void aumentaSalario(double percentagem)
        {
            double novaPercentagem = percentagem + 15.0;
            base.aumentaSalario(novaPercentagem);
        }
        public string getSecretaria()
        {
            return secretaria;
        }
    }
}
