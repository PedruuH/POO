using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLAB03
{
    public class Materia
    {
        
        private string nome_da_materia, codigo;

        public Materia()
        {
            nome_da_materia = codigo = "";
        }
        public Materia(string _nome,string _codigo)
        {
            nome_da_materia = _nome;
            codigo = _codigo;
        }
        public void setNome(string n )
        {
            nome_da_materia = n;
        }
        public void setCodigo(string c)
        {
            codigo = c;
        }
        public string getNome()
        {
            return nome_da_materia;
        }
        public string getCodigo()
        {
            return codigo;
        }
        
        
        

    }
}
