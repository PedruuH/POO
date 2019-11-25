using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace caLAB01
{
    class Vetor2D
    {
        private double x, y;

        public Vetor2D()
        { x = y = 0; }
        public Vetor2D(double x1 , double y1)
        { x = x1; y = y1; }

        public double getX()
        { return x; }
        public double getY()
        { return y; }

        public void  setX(double x1)
        { x = x1; }
        public void setY(double y1)
        { y = y1; }

        public double prodEscalar(Vetor2D v2)
        { return ((x * v2.getX()) + (y * v2.getY())); }

        public double modulo()
        { return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))); }

        public double angulo(Vetor2D z) //angulo entre vetores
        {
            return Math.Acos((z.x * x + z.y * y) / (modulo() * Math.Sqrt((Math.Pow(z.x, 2) + Math.Pow(z.y, 2)))));
        }
        public void vetorProjecao(Vetor2D u) // vetor projeção de a em um b
        {
            Vetor2D q = new Vetor2D();
            q.x = ((prodEscalar(u) / ((Math.Pow(u.x, 2) + Math.Pow(u.y, 2)) * u.x)));
            q.y = ((prodEscalar(u) / ((Math.Pow(u.x, 2) + Math.Pow(u.y, 2)) * u.y)));
            Console.WriteLine("Vetor Projeção: (" + q.x + "." + q.y + ")");
        }

        
    }
}
