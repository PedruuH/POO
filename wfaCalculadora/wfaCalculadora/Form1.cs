using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfaCalculadora
{   
    public partial class Form1 : Form
    {
        int i = 0; // Soma=1; Subtração=2; Divisão=3; Multiplicação=4;
        
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button11_Click(object sender, EventArgs e)
        {
            tbTela.Text += "1";            
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            tbTela.Text = "";
            i = 0;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            i = 1;            
            tbTela.Text = "";
        }
        
        private void btSubtracao_Click(object sender, EventArgs e)
        {
            double sub=Convert.ToDouble(tbTela.Text);
            i = 2;
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            i = 4;
        }

        private void btDIvidir_Click(object sender, EventArgs e)
        {
            i = 3;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbTela.Text += "0";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbTela.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbTela.Text += "3";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbTela.Text += "6";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbTela.Text += "5";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbTela.Text += "4";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbTela.Text += "9";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbTela.Text += "8";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbTela.Text += "7";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:

                    break;
            }
        }
    }
}
