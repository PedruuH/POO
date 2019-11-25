using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB02
{
    class Tempo
    {
        private int hora, min, seg;


        public Tempo() // construtor default
        {
            hora = min = seg = 0;
        }
        public void solicitaTempo() //incializa valores do usuário
        {
            Console.WriteLine("Insira a hora: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira os minutos: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira os segundos: ");
            seg = Convert.ToInt32(Console.ReadLine());
        }
        public int getHora()
        {
            return hora;
        }
        public int getMin()
        {
            return min;
        }
        public int getSeg()
        {
            return seg;
        }
        public void setHora(int a)
        {
            hora=a;
        }
        public void setMin(int a)

        {
            min=a;
        }
        public void setSeg(int a)
        {
            seg=a;
        }
        public void imprimeTempo()
        {
            Console.WriteLine(hora + ":" + min + ":" + seg);
        }

    }
}
