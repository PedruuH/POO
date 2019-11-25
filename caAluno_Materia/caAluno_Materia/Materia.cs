using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno_Materia
{
    class Materia
    {
        private String nome, codigo;

        public Materia()
        { nome = codigo = "";  }

        public Materia(String _nome, String _codigo)
        { nome = _nome;  codigo = _codigo; }

        public string getNome()
        { return nome; }
        public string getCodigo()
        { return codigo; }

        public void setNome(String _nome)
        { nome = _nome; }
        public void setCodigo(String _codigo)
        { codigo = _codigo; }


        
    }
}
