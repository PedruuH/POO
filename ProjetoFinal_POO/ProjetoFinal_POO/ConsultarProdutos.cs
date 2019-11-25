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
    public partial class ConsultarProdutos : Form
    {
        ComandosBanco comandos = new ComandosBanco();
        public ConsultarProdutos()
        {
            InitializeComponent();

            


        }

        private void ConsultarProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = comandos.receberProdutos();
            dgvFornecedor.DataSource = comandos.receberFornecedor();
        }
    }
}
