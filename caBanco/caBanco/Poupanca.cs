using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBanco
{
    class Poupanca:Conta
    {
        private int tipo;

        public int getTipo()
        { return tipo; }
        public void setTipo(int _tipo)
        { tipo = _tipo; }

        
        public override void Sacar(double valor)
        {
            base.Sacar(valor+0.10);
        }
    }
}
