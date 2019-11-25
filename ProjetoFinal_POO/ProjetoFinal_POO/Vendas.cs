using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    class Vendas
    {
        private double valor;
        private string cliente;

        public double getValor()
        { return valor; }
        public string getCliente()
        { return cliente; }

        public void setValor(double v)
        { valor = v; }
        public void setCliente(string c)
        { cliente = c; }


    }
}
