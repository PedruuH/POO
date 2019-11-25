using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO2
{
    class Saude:Pagtos
    {
        private string estabelecimento;
        private double vlfatSaude;

        public Saude():base()
        {
            estabelecimento = "";
            vlfatSaude = 0.0;
        }
        public override void faturar()
        {
            vlfatSaude += 1.2 * vlfatSaude;
            Console.WriteLine("Estabelecimento: " + estabelecimento);
        }

        public string getEstabelecimento() { return estabelecimento; }
        public double getVfatSaude() { return vlfatSaude; }
        public void setEstabelecimento(string _estabelecimento) { estabelecimento = _estabelecimento; }
        public void setVfatSaude(double _vlfatSaude) { vlfatSaude = _vlfatSaude; }
        
    }
}
