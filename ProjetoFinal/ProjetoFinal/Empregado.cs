using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Empregado
    {
        //Atributos
        protected String nome;
        protected String cpf;
        protected String telefone;
        protected String endereco;

        public Empregado()
        {
        }

        public Empregado(String nome, String cpf, String telefone, String endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        //Usaremos apenas Getters
        public String getNome()
        {
            return nome;
        }

        public String getCpf()
        {
            return cpf;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public String getEndereco()
        {
            return endereco;
        }
    }
}
