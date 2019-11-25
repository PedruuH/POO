using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPolimorfismo
{
    class Veiculo
    {
        // atributos
        protected String tipo;

        // métodos
        public Veiculo(String _tipo)
        {
            tipo = _tipo;
        }

        public String getTipo()
        {
            return tipo;
        }

    }
}
