using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO1
{
    class Resistor
    {
        private double resistencia, potencia;
        
        public Resistor()
        {
            resistencia = 0.0;
            potencia = 0.0;
        }
        public Resistor(double _resistencia, double _potencia)
        {
            resistencia = _resistencia;
            potencia = _potencia;
        }

        public Resistor resistorSerie(Resistor r1)
        {
            Resistor aux = new Resistor();
            aux.resistencia=(resistencia + r1.resistencia);
            if(potencia<r1.potencia)
                aux.potencia=potencia;
            else
                aux.potencia=r1.potencia;
            return aux;
        }
        public Resistor resistorParalelo(Resistor r1)
        {
            Resistor aux = new Resistor();
            aux.resistencia=((resistencia * r1.resistencia) / (resistencia + r1.resistencia));
            if(potencia<r1.potencia)
                aux.potencia=potencia;
            else
                aux.potencia=r1.potencia;
            return aux;
        }

        public void imprimeResistor()
        {
            Console.WriteLine("Ressitor de " + resistencia + " Ohms e " + potencia + " Watts");
        }

    }
}
