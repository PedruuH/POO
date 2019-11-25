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
    public partial class CadastrarFornecedor : Form

    {
        ComandosBanco comandos = new ComandosBanco();
        public CadastrarFornecedor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.setNomeFornecedor(tbNomeEmpresa.Text);
            fornecedor.setCNPJ(tbCNPJ.Text);
            fornecedor.setTelefone(tbTelefone.Text);
            comandos.cadastrar_fornecedor(fornecedor);
            tbNomeEmpresa.Text = "";
            tbCNPJ.Text = "";
            tbTelefone.Text = "";
        }
    }
}
