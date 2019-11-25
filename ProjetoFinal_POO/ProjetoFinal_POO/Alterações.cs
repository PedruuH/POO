using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_POO
{
    public partial class Alterações : Form
    {
        private DataTable data, data2, data3;

        private void rbDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeletar.Checked == true)
            {
                gbDeletar.Visible = true;
                gbAlterar.Visible = false;
            }
        }

        private void rbAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlterar.Checked == true)
            {
                gbAlterar.Visible = true;
                gbDeletar.Visible = false;
            }
        }

        private void btDelProd_Click(object sender, EventArgs e)
        {
            comandos.deletar_produto(Convert.ToString(cbProdutos.SelectedItem));
        }

        private void btDelCliente_Click(object sender, EventArgs e)
        {
            comandos.deletar_cliente(Convert.ToString(cbClientes.SelectedItem));
        }

        private void btDelFornecedor_Click(object sender, EventArgs e)
        {
            comandos.deletar_fornecedor(Convert.ToString(cbFornecedor.SelectedItem));
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCliente.Checked == true)
            {
                
                cbSelect.Items.Clear();
                cbSelect.Items.Insert(0, "Todos");
                data2 = comandos.receberNomesClientes();
                for (int i = 0; i < data2.Rows.Count; i++)
                {
                    cbSelect.Items.Insert(i + 1, data2.Rows[i]["nome_empresa"].ToString());
                }
                gbClienteAlt.Visible = true;
                gbProdutosAlt.Visible = false;
                gbFornecedorAlt.Visible = false;


            }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
            if(rbProduto.Checked == true)
            {
                cbSelect.Items.Clear();
                cbSelect.Items.Insert(0, "Todos");
                data = comandos.receberNomesProdutos();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    cbSelect.Items.Insert(i + 1, data.Rows[i]["nome_produto"].ToString());
                }
                gbProdutosAlt.Visible = true;
                gbClienteAlt.Visible = false;
                gbFornecedorAlt.Visible = false;

            }
        }

        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFornecedor.Checked == true)
            {
                cbSelect.Items.Clear();
                cbSelect.Items.Insert(0, "Todos");
                data3 = comandos.receberFornecedor();
                for (int i = 0; i < data3.Rows.Count; i++)
                {
                    cbSelect.Items.Insert(i + 1, data3.Rows[i]["nome_fornecedor"].ToString());
                }
                gbProdutosAlt.Visible = false;
                gbClienteAlt.Visible = false;
                gbFornecedorAlt.Visible = true;
            }
        }

        private ComandosBanco comandos = new ComandosBanco();
        public Alterações()
        {
            InitializeComponent();
            gbDeletar.Visible = false;
            gbClienteAlt.Visible = false;
            gbProdutosAlt.Visible = false;
            gbFornecedorAlt.Visible = false;
            cbProdutos.Items.Clear();
            cbProdutos.Items.Insert(0, "Todos");
            data = comandos.receberNomesProdutos();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbProdutos.Items.Insert(i + 1, data.Rows[i]["nome_produto"].ToString());
            }
            cbClientes.Items.Clear();
            cbClientes.Items.Insert(0, "Todos");
            data2 = comandos.receberNomesClientes();
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                cbClientes.Items.Insert(i + 1, data2.Rows[i]["nome_empresa"].ToString());
            }
            cbFornecedor.Items.Clear();
            cbFornecedor.Items.Insert(0, "Todos");
            data3 = comandos.receberFornecedor();
            for (int i = 0; i < data3.Rows.Count; i++)
            {
                cbFornecedor.Items.Insert(i + 1, data3.Rows[i]["nome_fornecedor"].ToString());
            }

            

        }

        

        
    }
}
