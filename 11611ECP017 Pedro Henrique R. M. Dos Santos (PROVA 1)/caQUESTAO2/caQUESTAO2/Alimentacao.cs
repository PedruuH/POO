using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO2
{
    class Alimentacao:Pagtos
    {
        private string descricao;
        private double vlfatAliment;

        public Alimentacao():base()
        {
            descricao = "";
            vlfatAliment = 0.0;
        }

        public override void faturar()
        {
            vlfatAliment += (1.05 * vlfatAliment);
            Console.WriteLine("Item adquirido: " + descricao);
        }

        public string getDescricao() { return descricao; }
        public double getVlfatAliment() { return vlfatAliment; }

        public void setDescricao(string _descricao) { descricao = _descricao; }
        public void setVlfatAliment(double _vlfatAliment) { vlfatAliment = _vlfatAliment; }

        }
}
