using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO2
{
    class Pagtos
    {
        protected long cpf;
        protected double valor;
        protected int cod;

        public Pagtos()
        {
            cpf = 0;
            valor = 0.0;
            cod = 0;
        }


        public virtual void faturar()
        { }

        public long getCPF() { return cpf; }        
        public int getCod() { return cod; }
        public double getValor() { return valor; }

        public void setCPF(long _cpf) { cpf = _cpf; }
        public void setCod(int _cod) { cod = _cod; }
        public void setValor(double _valor) { valor = _valor; }





        

    }
}
