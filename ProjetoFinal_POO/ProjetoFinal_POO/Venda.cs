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
    public partial class Venda : Form
    {
        private DataTable data, data2, produto;
        private ComandosBanco comandos = new ComandosBanco();
        public Venda()
        {
            InitializeComponent();
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

        }

        private void btVender_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas();
            venda.setCliente(Convert.ToString(cbProdutos.SelectedItem));
            produto = comandos.receberValorProduto(Convert.ToString(cbProdutos.SelectedItem));
            
            venda.setValor((Convert.ToDouble(produto.Rows[0]["valor"])*Convert.ToInt32(tbQuantidade.Text)));
            comandos.cadastrar_venda(venda);
        }

        private void Venda_Load(object sender, EventArgs e)
        {

        }
    }
}
