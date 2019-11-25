using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLAB04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor3D v1 = new Vetor3D();
            Vetor3D v2 = new Vetor3D();
            v1.setX(double.Parse(tbV1x.Text));
            v1.setY(double.Parse(tbV1y.Text));
            v1.setZ(double.Parse(tbV1z.Text));
            v2.setX(double.Parse(tbV2x.Text));
            v2.setY(double.Parse(tbV2y.Text));
            v2.setZ(double.Parse(tbV2z.Text));
            tbModuloV1.Text = Convert.ToString(v1.modulo());
            tbModuloV2.Text = Convert.ToString(v2.modulo());
           tbEscalarV1V2.Text = Convert.ToString(v1.prodEscalar(v2));
        }
    }
}
