using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBanco
{
    class Conta
    {
        protected int numero;
        protected double saldo;
        protected string cliente;

        public Conta()
        {
            numero = 0;
            saldo = 0.0;
            cliente = "";
        }
        public Conta(int _num,double _saldo,string _cliente)
        {
            numero = _num;
            saldo = _saldo;
            cliente = _cliente;
        }

        public int getNumero()
        { return numero; }
        public void setNumero(int _num)
        { numero = _num; }

        public double getSaldo()
        { return saldo; }
        public void setSaldo(double _saldo)
        { saldo = _saldo; }

        public string getCliente()
        { return cliente; }
        public void setCliente(string _cliente)
        { cliente = _cliente; }

        public virtual void Sacar(double valor)
        {
            saldo -= valor;
        }
        public virtual void Depositar(double valor)
        {
            saldo += valor;
        }



    }
}
