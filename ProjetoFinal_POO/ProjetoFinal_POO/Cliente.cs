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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void bt_cadastrarCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.setNome_empresa(tbNomeEmpresa.Text);
            cliente.setEndereço(tbEndereco.Text);
            cliente.setTelefone(tbTelefone.Text);
            cliente.setCNPJ(tbCNPJ.Text);
            ComandosBanco comandos = new ComandosBanco();
            comandos.cadastrar_cliente(cliente);
            tbNomeEmpresa.Text = "";
            tbEndereco.Text = "";
            tbTelefone.Text = "";
            tbCNPJ.Text = "";
        }
    }
}
