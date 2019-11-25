using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMediaAritimetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //txbEntradaNum1.Text = Convert.ToString(0);
            //txbEntradaNum2.Text = Convert.ToString(0);
           // txbResult.Text = Convert.ToString(0);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txbEntradaNum1.Text == "")
                MessageBox.Show("Digite Número valido");
            else if (txbEntradaNum2.Text == "")
                    MessageBox.Show("Digite Número valido");
                  else 
                    txbResult.Text = Convert.ToString(((Convert.ToDouble(txbEntradaNum1.Text) + Convert.ToDouble(txbEntradaNum2.Text)) / 2));
        }

        

        
    }
}
