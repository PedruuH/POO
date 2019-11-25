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
    public partial class Consultar : Form
    {
        private DataTable data;
        private DBComandos comandos = new DBComandos();
        private String[] mesesDoAno = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        private String[] empregadosTodos = { "CLT", "Corretores" };

        public Consultar()
        {
            InitializeComponent();
        }

        //Mostra a lista de empregados
        private void btBuscarEmpregados_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbEmpregados.SelectedItem);
            if (escolha.Equals("CLT"))
            {
                dgvEmpregados.DataSource = comandos.receberEmpregadosCLT();
            } else if (escolha.Equals("Corretores"))
            {
                dgvEmpregados.DataSource = comandos.receberEmpregadosCorretores();
            }
        }

        //Muda os ComboBox quando clica no tabControl
        private void tabConsulta_Click(object sender, EventArgs e)
        {
            if (tabConsulta.SelectedTab.Text.Equals("Vendas"))
            {
                cbCorretores.Items.Clear();
                cbCorretores.Items.Insert(0, "Todos");
                data = comandos.receberNomesCorretores();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    cbCorretores.Items.Insert(i+1, data.Rows[i]["nome"].ToString());
                }
            }

            if (tabConsulta.SelectedTab.Text.Equals("Empregados"))
            {
                cbEmpregados.Items.Clear();
                for (int i = 0; i < empregadosTodos.Length; i++)
                {
                    cbEmpregados.Items.Insert(i, empregadosTodos[i]);
                }
            }

            if (tabConsulta.SelectedTab.Text.Equals("Renda Mensal"))
            {
                cbMeses.Items.Clear();
                for (int i = 0; i < mesesDoAno.Length; i++)
                {
                    cbMeses.Items.Insert(i, mesesDoAno[i]);
                }
            }
        }

        //Mostra a lista de vendas de um determinado empreagado
        private void btBuscarVendas_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbCorretores.SelectedItem);
            if (escolha.Equals("Todos"))
            {
                dgvVendas.DataSource = comandos.receberVendasTodas();
            } else
            {
                data = comandos.receberIDCorretor(escolha);
                int id = Convert.ToInt16(data.Rows[0]["id_corretor"]);
                dgvVendas.DataSource = comandos.receberVendasCorretorEspecifico(id);
            }
            
        }

        private void btBuscarRenda_Click(object sender, EventArgs e)
        {
            Double entrada = 0;
            Double saida = 0;
            String escolha = Convert.ToString(cbMeses.SelectedItem);
            data = comandos.recebeTodasEntradaSaida(escolha);
            dgvRenda.DataSource = comandos.recebeTodasEntradaSaida(escolha);

            if(data.Rows.Count != 0)
            {
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    entrada = entrada + Convert.ToDouble(data.Rows[i]["entrada"]);
                    saida = saida + Convert.ToDouble(data.Rows[i]["saida"]);
                }
                Double resultado = entrada - saida;
                labelTotal.Text = "Total: " + Convert.ToString(resultado);
            } else
            {
                labelTotal.Text = "Total: 0.00";
            }
            
        }
    }
}
