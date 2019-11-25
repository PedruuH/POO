using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    public class Retangulo
    {
        
        private int a { get; set; }
        private int b { get; set; }

        public Retangulo()
        { b = a = 0; }
        public Retangulo(int basi, int alt)
        { b = basi; a = alt; }

        public int getBase()
        { return b; }
        public int getAltura()
        { return a; }

        public void setBase(int basi)
        { b = basi; }
        public void setAltura(int alt)
        { a = alt; }

        public int perimetro()
        {
            return (2 * a + 2 * b);
        }
        public int area()
        { return a * b; }




        
            

    }
}
