using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroEmpregados
{
    class Empregado
    {
        protected string nome, cpf, endereço;

        public Empregado()
        {
            nome = cpf = endereço = "";
        }
        public Empregado(string _nome, string _cpf, string _end)
        {
            nome = _nome;
            cpf = _cpf;
            endereço = _end;
        }

        public void setNome(string _nome)
        { nome = _nome; }
        public void setCPF(string _cpf)
        { cpf = _cpf; }
        public void setEndereço(string _end)
        { endereço = _end; }

        public string getNome()
        { return nome; }
        public string getCPF()
        { return cpf; }
        public string getEndereço()
        { return endereço; }

        public virtual double salarioLiq() { return 1; }
        
        



    }
}
