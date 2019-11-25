using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB01
{
    class Vetor2d
    {
        //atributos
        private double x;
        private double y;

        //metodos
        public Vetor2d() //default
        {
            x = 0.0;
            y = 0.0;
        }
        public Vetor2d(double a, double b) //construtor inicializaador
        {
            x = a;
            y = b;
        }
        public double getX() //getter
        {
            return x;
        }
        public double getY() //getter
        {
            return y;
        }
        public void setX(double a ) //setter
        {
            x = a;
        }
        public void setY(double a) //setter
        {
            y = a;
        }
        public double produtoEscalar(Vetor2d k) //produto escalar entre dois vetores
        {
            return (x * k.x + y * k.y);
        }
        public double modulo() //odulo de um vetor
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
        public double angulo(Vetor2d z) //angulo entre vetores
        {
            return Math.Acos((z.x*x+z.y*y)/(modulo()*Math.Sqrt((Math.Pow(z.x,2)+Math.Pow(z.y,2)))));
        }
        public void vetorProjecao(Vetor2d u) // vetor projeção de a em um b
        {
          Vetor2d q = new Vetor2d();
          q.x=((produtoEscalar(u)/((Math.Pow(u.x, 2) + Math.Pow(u.y, 2))*u.x)));
          q.y = ((produtoEscalar(u) /(( Math.Pow(u.x, 2) + Math.Pow(u.y, 2))* u.y)));
          Console.WriteLine("Vetor Projeção: ("+q.x+"."+q.y+")");
        }
        
    }
}
