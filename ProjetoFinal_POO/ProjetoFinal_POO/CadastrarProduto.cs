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
    public partial class CadastrarProduto : Form
    {
        private DataTable data;
        private ComandosBanco comandos = new ComandosBanco();
        public CadastrarProduto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cbFornecedor.Items.Clear();
            cbFornecedor.Items.Insert(0, "Todos");
            data = comandos.receberNomesFornecedor();
            for(int i=0;i<data.Rows.Count;i++)
            {
                cbFornecedor.Items.Insert(i + 1, data.Rows[i]["nome_fornecedor"].ToString());
            }
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarProd_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.setNome_produto(tbNomeProduto.Text);
            produto.setCodProduto(Convert.ToInt32(tbCodProduto.Text));
            produto.setFornecedor(Convert.ToString(cbFornecedor.SelectedItem));
            produto.setQuantidade(Convert.ToInt32(tbQuantidade.Text));
            produto.setValor(Convert.ToDouble(tbValor.Text));
            comandos.cadastrar_produto(produto);
        }
    }
}
