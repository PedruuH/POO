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
    public partial class Calculadora : Form
    {
        public CalculadoraClass calcWindows = new CalculadoraClass();
        public string op="";    

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void bt7_Click(object sender, EventArgs e)
        {            
            tbDisplay.Text = tbDisplay.Text + bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt8.Text;
        }
        private void bt9_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt9.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt6.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt3.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt0.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            calcWindows.setOp("");
            tbDisplay.Text = "";
            calcWindows.setAcc(0);
            calcWindows.setValor(0);
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            calcWindows.setOp("/");
            if(tbDisplay.Text=="")
               tbDisplay.Text="";
            else
                calcWindows.setAcc(Convert.ToDouble(tbDisplay.Text));
            tbDisplay.Text = "";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            calcWindows.setOp("*");
            calcWindows.setAcc(Convert.ToDouble(tbDisplay.Text));
            tbDisplay.Text = "";
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            calcWindows.setOp("-");
            calcWindows.setAcc(Convert.ToDouble(tbDisplay.Text));
            tbDisplay.Text = "";
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            calcWindows.setOp("+");
            calcWindows.setAcc(Convert.ToDouble(tbDisplay.Text));
            tbDisplay.Text = "";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {

            if (tbDisplay.Text == "")
            { }
            else
            {
                calcWindows.setValor(Convert.ToDouble(tbDisplay.Text));
                calcWindows.Calcular();
            }
            tbDisplay.Text = Convert.ToString(calcWindows.getAcc());
        }

        

        

    }
}
