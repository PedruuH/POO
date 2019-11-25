using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLAB04
{
    class Vetor3d:Vetor2d
    {
        private double z;

        public Vetor3d()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }
        public Vetor3d(double _x,double _y,double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public override double getX()
        {
            return base.getX();
        }
        public override double getY()
        {
            return base.getY();
        }
        public override void setX(double a)
        {
            base.setX(a);
        }
        public override void setY(double a)
        {
            base.setY(a);
        }
        public void setZ(double _z)
        {
            z = _z;
        }
        public double getZ()
        {
            return z;
        }
        public override double produtoEscalar(Vetor2d k)
        {
            return base.produtoEscalar(k);
        }
        public double modulo3d() 
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
        }

    }
}
