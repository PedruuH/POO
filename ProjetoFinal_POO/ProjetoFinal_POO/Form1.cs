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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void bt_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
            this.Visible = true;
        }

        private void bt_Produto_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarProduto produto = new CadastrarProduto();
            produto.ShowDialog();
            this.Visible = true;
        }

        private void bt_Fornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarFornecedor fornecedor = new CadastrarFornecedor();
            fornecedor.ShowDialog();
            this.Visible = true;

        }

        private void bt_ConsProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarProdutos consprod = new ConsultarProdutos();
            consprod.ShowDialog();
            this.Visible = true;
        }

        private void bt_Relatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterações relatorio = new Alterações();
            relatorio.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterações relatorio = new Alterações();
            relatorio.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarProduto produto = new CadastrarProduto();
            produto.ShowDialog();
            this.Visible = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarFornecedor fornecedor = new CadastrarFornecedor();
            fornecedor.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarProdutos consprod = new ConsultarProdutos();
            consprod.ShowDialog();
            this.Visible = true;
        }

        private void bt_Venda_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda venda = new Venda();
            venda.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
