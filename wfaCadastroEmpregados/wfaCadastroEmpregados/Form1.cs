using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCadastroEmpregados
{
    public partial class Form1 : Form

    {
        List<Empregado> lista_empregado = new List<Empregado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void rbHorista_CheckedChanged(object sender, EventArgs e)
        {
            gbHorista.Visible = true;
            gbCLT.Visible = false;
        }
        private void rbClt_CheckedChanged(object sender, EventArgs e)
        {
            gbCLT.Visible = true;
            gbHorista.Visible = false;
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(rbClt.Checked==true)
            {
                EmpregadoCLT e1 = new EmpregadoCLT();                
                e1.setNome(tbNome.Text);
                e1.setCPF(tbCPF.Text);
                e1.setEndereço(tbEndereco.Text);
                e1.setSalario(double.Parse(tbSalBruto.Text));
                tbSalLiqCLT.Text = Convert.ToString(e1.salarioLiq());
                lista_empregado.Add(e1);
              
            }
            if(rbHorista.Checked==true)
            {
                EmpregadoHorista e1 = new EmpregadoHorista();
                e1.setNome(tbNome.Text);
                e1.setCPF(tbCPF.Text);
                e1.setEndereço(tbEndereco.Text);
                e1.setHoras(int.Parse(tbHoras.Text));
                e1.setPreço(double.Parse(tbPrecoH.Text));
                tbSalLiq.Text = Convert.ToString(e1.salarioLiq());
                lista_empregado.Add(e1);
               
            }
        }

        
    }
}
