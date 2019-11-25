using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB04
{
    class Vetor3D:Vetor2D
    {
        private double z;

        public double getZ()
        { return z; }

        public void setZ(double _z)
        { z = _z; }

        public Vetor3D(): base()
        { z = 0.0; }

        public Vetor3D(double _x, double _y, double _z):base(_x,_y)
        { z = _z; }

        public  double prodEscalar(Vetor3D v2)
        { return ((x * v2.getX()) + (y * v2.getY()) + (z*v2.getZ())); }

        public double modulo()
        { return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))); }


    }
}
