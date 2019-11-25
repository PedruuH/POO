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
    public partial class Cadastrar : Form
    {
        //O CER´TO É VIRGULA
        private DataTable data;
        private String[] mesesDoAno = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        private String[] CargosCadastrados = { "Gerente", "Gestor", "Recepcionista", "Estagiário", "Serviçal", "Outro" };
        private DBComandos comandos = new DBComandos();

        public Cadastrar()
        {
            InitializeComponent();
            criarCargos();
            criarMeses();
        }

        //Cria os Meses
        public void criarMeses()
        {
            for(int i = 0; i < mesesDoAno.Length; i++)
            {
                cbMeses.Items.Insert(i, mesesDoAno[i]);
            }
        }

        //Cria os Cargos CLT
        public void criarCargos()
        {
            for(int i = 0; i < CargosCadastrados.Length; i++)
            {
                cbCargo.Items.Insert(i, CargosCadastrados[i]);
            }
        }

        //Cadastra um Empregado CLT
        private void btClt_Click(object sender, EventArgs e)
        {
            if (verificaTbVazio(0))
            {
                CLT clt = new CLT(tbNomeClt.Text, tbCpfClt.Text, tbTelefoneClt.Text, tbEnderecoClt.Text, tbPisClt.Text, Convert.ToString(cbCargo.SelectedItem));
                comandos.cadastrarCLT(clt);
                MessageBox.Show("Empregado CLT cadastrado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTb(0);
            }
            else
            {
                MessageBox.Show("Verifique se não há nenhum campo vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Verifica se tem algum text Box Vazio na hora de cadastrar
        public Boolean verificaTbVazio(int tab)
        {
            if(tab == 0)
            {
                if (tbNomeClt.Text.Equals("") || tbCpfClt.Text.Equals("") || tbTelefoneClt.Text.Equals("") || tbEnderecoClt.Text.Equals("") || tbPisClt.Text.Equals(""))
                {
                    return false;
                } else
                {
                    return true;
                }
            } else if(tab == 1)
            {
                if(tbNomeCorretor.Text.Equals("") || tbCpfCorretor.Text.Equals("") || tbEnderecoCorretor.Text.Equals("") || tbTelefoneCorretor.Text.Equals("") || tbCreciCorretor.Text.Equals(""))
                {
                    return false;
                } else
                {
                    return true;
                }
            } else if(tab == 2)
            {
                if(tbEmpreendimentos.Text.Equals("") || tbValor.Text.Equals("") || tbComissao.Text.Equals(""))
                {
                    return false;
                } else
                {
                    return true;
                }
            } else
            {
                return false;
            }
        }

        //Limpa as TextBox apos utilizar
        public void limparTb(int tab)
        {
            if(tab == 0)
            {
                tbNomeClt.Text = "";
                tbCpfClt.Text = "";
                tbTelefoneClt.Text = "";
                tbEnderecoClt.Text = "";
                tbPisClt.Text = "";
            } else if(tab == 1)
            {
                tbNomeCorretor.Text = "";
                tbCpfCorretor.Text = "";
                tbTelefoneCorretor.Text = "";
                tbEnderecoCorretor.Text = "";
                tbCreciCorretor.Text = "";
            } else if(tab == 2)
            {
                tbEmpreendimentos.Text = "";
                tbValor.Text = "";
                tbComissao.Text = "";
            }
        }

        private void tbCpfClt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Cadastra um novo Corretor
        private void btCorretor_Click(object sender, EventArgs e)
        {
            if (verificaTbVazio(1))
            {
                if (checkTermos.Checked)
                {
                    Corretor corretor = new Corretor(tbNomeCorretor.Text, tbCpfCorretor.Text, tbTelefoneCorretor.Text, tbEnderecoCorretor.Text, tbCreciCorretor.Text);
                    comandos.cadastrarCorretor(corretor);
                    MessageBox.Show("Corretor cadastrado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparTb(1);
                } else
                {
                    MessageBox.Show("Corretor precisa aceitar os termos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Verifique se não há nenhum campo vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cadastra uma nova Venda
        private void btVenda_Click(object sender, EventArgs e)
        {
            if (verificaTbVazio(2))
            {
                              data = comandos.receberIDCorretor(Convert.ToString(cbCorretores.SelectedItem));
                Vendas vendas = new Vendas(Convert.ToInt16(data.Rows[0]["id_corretor"]), tbEmpreendimentos.Text, Convert.ToDouble(tbValor.Text), Convert.ToInt16(tbComissao.Text), Convert.ToString(cbMeses.SelectedItem));
                comandos.cadastrarVenda(vendas);
                Double entrada = vendas.cadastraEntrada();
                Double saida = vendas.cadastraSaida(entrada);
                comandos.cadastrarEntradaSaida(entrada, saida, Convert.ToString(cbMeses.SelectedItem));
                MessageBox.Show("Venda cadastrada com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTb(2);
            } else
            {
                MessageBox.Show("Verifique se não há nenhum campo vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Muda os ComboBox quando clica no tabControl
        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text.Equals("Vendas"))
            {
                data = comandos.receberNomesCorretores();
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    cbCorretores.Items.Insert(i, data.Rows[i]["nome"].ToString());
                }
            }
        }
    }
}
