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
    public partial class Alterar : Form
    {
        private DataTable data;
        private DBComandos comandos = new DBComandos();
        private String[] CargosCadastrados = { "Gerente", "Gestor", "Recepcionista", "Estagiário", "Serviçal", "Outro" };


        public Alterar()
        {
            InitializeComponent();
            criarCargos();
        }

        //Cria os Cargos CLT
        public void criarCargos()
        {
            for (int i = 0; i < CargosCadastrados.Length; i++)
            {
                cbCargo.Items.Insert(i, CargosCadastrados[i]);
            }
        }

        //Efetua os carregamentos aos clicks nas tabs
        private void tabAlterar_Click(object sender, EventArgs e)
        {
            if (tabAlterar.SelectedTab.Text.Equals("Corretor"))
            {
                cbCorretores.Items.Clear();
                data = comandos.receberNomesCorretores();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    cbCorretores.Items.Insert(i, data.Rows[i]["nome"].ToString());
                }
            }

            if (tabAlterar.SelectedTab.Text.Equals("Empregado"))
            {
                cbCLT.Items.Clear();
                data = comandos.receberNomesCLT();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    cbCLT.Items.Insert(i, data.Rows[i]["nome"].ToString());
                }
            }
        }

        private void btModificarCLT_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbCLT.SelectedItem);
            if (escolha.Equals(""))
            {
                MessageBox.Show("Escolha um dos Empregados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = verificaRadioEscolhido();
                switch (x)
                {
                    case 0:
                        if (tbEnderecoClt.Text.Equals(""))
                        {
                            MessageBox.Show("O atributo a ser alterado esta em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            comandos.alterarCLT(escolha, "endereco", tbEnderecoClt.Text);
                            MessageBox.Show("O atributo foi alterado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbEnderecoClt.Text = "";
                        }
                        break;
                    case 1:
                        
                        String telefone = tbTelefoneClt.Text;
                        tbTelefoneClt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (tbTelefoneClt.Text.Equals(""))
                        {
                            MessageBox.Show("O atributo a ser alterado esta em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            comandos.alterarCLT(escolha, "telefone", telefone);
                            MessageBox.Show("O atributo foi alterado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbTelefoneClt.Text = "";
                        }
                        break;
                    case 2:
                        String cargo = Convert.ToString(cbCargo.SelectedItem);
                        if (cargo.Equals(""))
                        {
                            MessageBox.Show("O atributo a ser alterado esta em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            comandos.alterarCLT(escolha, "cargo", Convert.ToString(cbCargo.SelectedItem));
                            MessageBox.Show("O atributo foi alterado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case 3:
                        MessageBox.Show("Escolha uma das opções de Marcação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
        }

        public int verificaRadioEscolhido()
        {
            if (rbEndereco.Checked)
            {
                return 0;
            }

            if (rbTelefone.Checked)
            {
                return 1;
            }

            if (rbCargo.Checked)
            {
                return 2;
            }

            return 3;
        }

        private void btModificarCorretores_Click(object sender, EventArgs e)
        {
            String escolha = Convert.ToString(cbCorretores.SelectedItem);
            if (escolha.Equals(""))
            {
                MessageBox.Show("Escolha um dos Corretores!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int x = verificaRadioEscolhidoCorretores();
                switch (x)
                {
                    case 0:
                        if (tbEnderecoCorretor.Text.Equals(""))
                        {
                            MessageBox.Show("O atributo a ser alterado esta em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                        else
                        {
                            comandos.alterarCorretor(escolha, "endereco", tbEnderecoCorretor.Text);
                            MessageBox.Show("O atributo foi alterado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbEnderecoCorretor.Text = "";
                        }
                        break;
                    case 1:

                        String telefone = tbTelefoneCorretor.Text;
                        tbTelefoneCorretor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (tbTelefoneCorretor.Text.Equals(""))
                        {
                            MessageBox.Show("O atributo a ser alterado esta em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            comandos.alterarCorretor(escolha, "telefone", telefone);
                            MessageBox.Show("O atributo foi alterado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbTelefoneCorretor.Text = "";
                        }
                        break;
                    case 3:
                        MessageBox.Show("Escolha uma das opções de Marcação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
        }

        public int verificaRadioEscolhidoCorretores()
        {
            if (rbEnderecoCorretor.Checked)
            {
                return 0;
            }

            if (rbTelefoneCorretor.Checked)
            {
                return 1;
            }

            return 2;
        }
    }
}
