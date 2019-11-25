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
            lbResult.Text = Convert.ToString(0); ;
            tbNum2.Text = Convert.ToString(0); ;
            tbNum1.Text = Convert.ToString(0);

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            lbResult.Text = Convert.ToString(((Convert.ToDouble(tbNum1.Text) + Convert.ToDouble(tbNum2.Text)) / 2));
                          
        }
    }
}
