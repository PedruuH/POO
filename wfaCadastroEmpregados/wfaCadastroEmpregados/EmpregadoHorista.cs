using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroEmpregados
{
    class EmpregadoHorista : Empregado
    {
        private int horas;
        private double preçoH;

        public EmpregadoHorista()
        {

        }

        public int getHoras()
        { return horas; }
        public void setHoras(int _horas)
        { horas = _horas; }
        public double getPreço()
        { return preçoH; }
        public void setPreço(double _preço)
        { preçoH = _preço; }

        public override double salarioLiq()
        {
            return (preçoH*horas)*0.85;
                
        }


    }
}
