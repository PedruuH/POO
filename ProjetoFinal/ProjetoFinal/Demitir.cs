using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Demitir : Form
    {
        private DataTable data;
        private DBComandos comandos = new DBComandos();

        public Demitir()
        {
            InitializeComponent();
            recuperarCLTs();
            recuperarCorretores();
        }

        private void recuperarCLTs()
        {
            cbCLT.Items.Clear();
            data = comandos.receberNomesCLT();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbCLT.Items.Insert(i, data.Rows[i]["nome"].ToString());
            }
        }

        private void recuperarCorretores()
        {
            cbCorretores.Items.Clear();
            data = comandos.receberNomesCorretores();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbCorretores.Items.Insert(i, data.Rows[i]["nome"].ToString());
            }
        }

        private void btDemitirCLT_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbCLT.SelectedItem);
            if(MessageBox.Show("Você realmente deseja Remover o Empregado: " + escolha + " ?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comandos.demitirClt(escolha);
                MessageBox.Show("Empregado CLT demitido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Ação cancelada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDemitirCorretores_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbCorretores.SelectedItem);
            if (MessageBox.Show("Você realmente deseja Remover o Corretor: " + escolha + " ?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comandos.demitirCorretor(escolha);
                MessageBox.Show("Empregado CLT demitido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ação cancelada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
