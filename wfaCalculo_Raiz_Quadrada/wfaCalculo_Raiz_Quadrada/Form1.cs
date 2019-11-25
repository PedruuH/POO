using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculo_Raiz_Quadrada
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public double calcRaiz(double num)
        {
            if(num<0)
                throw new NegativeNumberException("Raiz de numero negativo nao permitida");

            return Math.Sqrt(num);
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            
                try
                {
                    double numero;
                    numero = Convert.ToDouble(tbNumero.Text);
                    tbResultado.Text = Convert.ToString(calcRaiz(numero));
                    //op = false;
                }

                catch (FormatException formatException)
                { 
                   MessageBox.Show(formatException.Message + "\nNúmero invalido");
                   tbNumero.Text = "";                    
                }
                catch (NegativeNumberException neg)
                {
                    MessageBox.Show(neg.Message);
                }
                finally
                {
                   Console.WriteLine("Try again later");                    
                }


            


        }
    }
}
