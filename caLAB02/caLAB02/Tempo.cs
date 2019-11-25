using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB02
{
    public class Tempo
    {

        private int hora, min, seg; //atributos
        int valor_hora = 7;
        public int getHora()
        { return hora; }
        public int getMin()         //getters
        { return min; }
        public int getSeg()
        { return seg; }

        public void setHora(int h)
        { hora = h; }
        public void setMin(int m)       //setters
        { min = m; }
        public void setSeg(int s)
        { seg = s; }
        
        public Tempo() // constr. default
        { hora = min = seg = 0; }
        public Tempo(int h, int m, int s) //constr. aridade 3
        { hora = h; min = m; seg = s; }

        public void solicitaHora()      //metodo solicita hora
        {
            Console.WriteLine("Insira a hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os minutos: ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os segundos: ");
            seg = int.Parse(Console.ReadLine());
        }

        public void imprimiHora()       //metodo imprimir hora hh:mm:ss
        { Console.WriteLine("Horario: " + hora + ":" + min + ":" + seg); }


        public Tempo somaHoras(Tempo t1)
        {
            Tempo t2 = new Tempo();
            t2.seg = t1.seg + seg;
            t2.min = t1.min + min;
            t2.hora = t1.hora + hora;

            if (t2.seg >= 60)
            { t2.min++; t2.seg = t2.seg - 60; }
            if (t2.min >= 60)
            { t2.hora++; t2.min = t2.min - 60; }
            return t2;
        }

        public Tempo subtraiHoras(Tempo t1)
        {
            Tempo t2 = new Tempo();
            t2.hora = hora - t1.hora;

            if (t2.hora == 0)
            {
                t2.min = min - t1.min;

                if (t2.min == 0)
                {
                    t2.seg = seg - t1.seg;
                }
                else
                {
                    t2.seg = seg - t1.seg;
                    if (t2.seg < 0)
                    {
                        t2.seg = t2.seg + 60;
                        t2.min = t2.min - 1;
                    }
                }
            }
            else
            {
                t2.min = min - t1.min;
                if (t2.min < 0)
                {
                    t2.min = t2.min + 60;
                    t2.hora = t2.hora - 1;
                }
            }

            return t2;
        }




    }
}