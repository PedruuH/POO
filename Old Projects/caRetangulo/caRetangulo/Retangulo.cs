using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Retangulo
    {
        //atributos
        private double basis;
        private double altura;

        //metodos
        public double calculaArea()
        {
            return (basis * altura);
        }
        public void setBase(double b)
        {
            basis = b;
        }
        public void setAltura(double a)
        {
            altura = a;
        }
        public double perimetro()
        {
            return 2 * (basis+altura);
        }
        //construtores da classe
        public Retangulo() // contrutor que inicializa com valores
        {
            basis = 4.0;
            altura = 5.0;
        }
        public Retangulo(double b,double a)
        {
            basis = b;
            altura = a;
        }
    }
}
