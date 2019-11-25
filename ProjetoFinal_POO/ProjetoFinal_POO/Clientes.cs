using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    class Clientes
    {
        private string nome_empresa;
        private string endereço;
        private string cnpj;
        private string telefone;

        public string getNome_empresa()
        { return nome_empresa; }
        public string getEndereço()
        { return endereço; }
        public string getCNPJ()
        { return cnpj; }
        public string getTelefone()
        { return telefone; }

        public void setNome_empresa(string n)
        { nome_empresa = n; }
        public void setEndereço(string e)
        { endereço = e; }
        public void setCNPJ(string c)
        { cnpj = c; }
        public void setTelefone(string t)
        { telefone = t; }
    }
}
