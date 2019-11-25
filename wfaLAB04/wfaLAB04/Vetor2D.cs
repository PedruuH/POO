using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLAB04
{
    class Vetor2D
    {
        protected double x, y;

        public Vetor2D()
        { x = y = 0; }
        public Vetor2D(double x1, double y1)
        { x = x1; y = y1; }

        public double getX()
        { return x; }
        public double getY()
        { return y; }

        public void setX(double x1)
        { x = x1; }
        public void setY(double y1)
        { y = y1; }

        //public  virtual double prodEscalar(Vetor2D v2)
        //{ return ((x * v2.getX()) + (y * v2.getY())); }

        //public virtual double modulo()
        //{ return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))); }
    }
}
