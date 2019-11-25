using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class CLT : Empregado
    {
        //Atributos
        private String npis;
        private String cargo;

        //Construtor
        public CLT(String nome, String cpf ,String telefone, String endereco, String npis, String cargo) : base(nome, cpf, telefone, endereco)
        {
            this.npis = npis;
            this.cargo = cargo;
        }

        //Getters
        public String getNpis()
        {
            return npis;
        }

        public String getCargo()
        {
            return cargo;
        }
    }
}
