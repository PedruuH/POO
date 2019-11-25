using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNumeroComplexo
{
    class NumeroComplexo
    {
        //atributos
        private double re;
        private double im;

        //metodos
        public NumeroComplexo()
        {
            re =0.0;
            im= 0.0;
        }
        public NumeroComplexo(double a, double b)
        {
            re = a;
            im = b;
        }
        public double modulo()
        {
            return Math.Sqrt(Math.Pow(re,2) + Math.Pow(im,2));
        }
        public void print()
        {
            Console.WriteLine("Numero Complexo: "+ re + "+"+ im+"i");
        }
       public NumeroComplexo soma(NumeroComplexo z)
       {
           NumeroComplexo zx =new NumeroComplexo();
           zx.re = re+z.re ;
           zx.im = im + z.im;
           return zx;
       }

    
    }
}
