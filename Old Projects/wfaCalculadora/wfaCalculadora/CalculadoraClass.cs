using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadora
{
    public class CalculadoraClass
    {
        private double acc, valor;
        private string op;

        public CalculadoraClass()
        {
            acc = valor = 0.0;
            op = "";
        }
        public CalculadoraClass(double _acc,double _valor,string _op)
        {
            acc = _acc;
            valor = _valor;
            op = _op;
        }
        public string getOp()
        {
            return op;
        }
        public double getAcc()
        {
            return acc;
        }
        public double getValor()
        {
            return valor;
        }
        public void setAcc(double _acc)
        {
            acc = _acc;
        }
        public void setValor(double _valor)
        {
            valor = _valor;
        }
        public void setOp(string _op)
        {
            op=_op;
        }
        public void Calcular()
        {
            if (op.Equals("+"))
            {
                acc = acc + valor;
            }
            if (op.Equals("-"))
            {
                acc = acc - valor;
            }
            if (op.Equals("*"))
            {
                acc = acc * valor;
            }
            if (op.Equals("/"))
            {
                if (valor == 0)
                    acc = 0;
                else                    
                    acc = acc /valor;
            }
        }




    }
}
