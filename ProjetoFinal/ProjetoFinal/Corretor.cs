using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Corretor : Empregado
    {
        private String creci;

        public Corretor(String nome, String cpf, String telefone, String endereco, String creci) : base(nome, cpf, telefone, endereco)
        {
            this.creci = creci;
        }

        public String getCreci()
        {
            return creci;
        }
    }
}
