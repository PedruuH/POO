using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroEmpregados
{
    class EmpregadoCLT : Empregado
    {
        private double sBrutoCLT;

        public EmpregadoCLT()
        {
            sBrutoCLT = 0.0;
        }

        public void setSalario(double _salario)
        {
            sBrutoCLT = _salario;
        }
        public double getSalario()
        {
            return sBrutoCLT;
        }

        public override double salarioLiq()
        {
            if (sBrutoCLT <= 5000)
                return sBrutoCLT * 0.85;
            else
                return sBrutoCLT * 0.725;
            
        }

        
    }
}
