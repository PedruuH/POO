using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    class Fornecedor
    {
        private string nome_fornecedor;
        private string telefone;
        private string cnpj;

        public string getNomeFornecedor()
        { return nome_fornecedor; }
        public string getTelefone()
        { return telefone; }
        public string getCNPJ()
        { return cnpj; }

        public void setNomeFornecedor(string n)
        { nome_fornecedor = n; }
        public void setTelefone(string t)
        { telefone = t; }
        public void setCNPJ(string c)
        { cnpj = c; }

    }
}
