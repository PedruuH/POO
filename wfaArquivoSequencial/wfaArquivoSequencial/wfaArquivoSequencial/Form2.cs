using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace wfaArquivoSequencial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btSaldo_positivo.Enabled = false;
            btSaldo_negativo.Enabled = false;
            btSaldo_nulo.Enabled = false;
            btFechar_arquivo.Enabled = false;
        }


            List<Registro> negativos = new List<Registro>();
            List<Registro> positivos = new List<Registro>();
            List<Registro> nulos = new List<Registro>();
            string[] values;

        int nu =0, po =0, ne = 0;
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();

        private FileStream arquivo_entrada;

        private void btAbrir_arquivo_Click(object sender, EventArgs e)
        {
            // cria caixa de diálogo para usuário abrir arquivo
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName; // nome do arquivo contendo os dados

            // sai do evento se o usuário clicar Cancel
            if (result == DialogResult.Cancel)
                return;

            // obtém o nome do arquivo para leitura
            fileName = fileChooser.FileName;


            // mostra erro se o usuário digitou arquivo inválido
            if (fileName == "" || fileName == null)
                MessageBox.Show("Nome de arquivo inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // cria FileStream para obter acesso de leitura ao arquivo 
                arquivo_entrada = new FileStream(fileName, FileMode.Open,
                   FileAccess.Read);

                btSaldo_positivo.Enabled = true;
                btSaldo_negativo.Enabled = true;
                btSaldo_nulo.Enabled = true;

            }
            while (true)
            {
                try
                {
                    // get next Record available in file
                    Registro registro =
                       (Registro)reader.Deserialize(arquivo_entrada);

                    if (double.Parse(registro.getSaldo().ToString()) == 0)
                    { nulos.Add(registro); nu++; }
                    if (double.Parse(registro.getSaldo().ToString()) > 0.0)
                    { positivos.Add(registro); po++; }
                    if (double.Parse(registro.getSaldo().ToString()) < 0)
                    { negativos.Add(registro); ne++; }

                }
                catch (SerializationException)
                {                    
                    arquivo_entrada.Close();
                    btFechar_arquivo.Enabled = true;
                    btAbrir_arquivo.Enabled = false;
                    break;
                }
            }

        }

        private void btSaldo_negativo_Click(object sender, EventArgs e)
        {
            try
            {
                rcTexto.Clear();
                for (int i = 0; i < ne; i++)
                {

                    rcTexto.Text = rcTexto.Text + "\n Conta: " + negativos[i].getConta().ToString() + "\n Primeiro Nome: " + negativos[i].getPrimeiroNome().ToString()
                        + "\n Ultimo Nome:" + negativos[i].getUltimoNome().ToString() + "\n Saldo: " + negativos[i].getSaldo().ToString() + "\n";

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                rcTexto.Clear();
                rcTexto.Text = "Sem saldos negativos";
            }
        }

        private void btSaldo_nulo_Click(object sender, EventArgs e)
        {
            try
            {
                rcTexto.Clear();
                for (int i = 0; i < nu; i++)
                {

                    rcTexto.Text = rcTexto.Text + "\n Conta: " + nulos[i].getConta().ToString() + "\n Primeiro Nome: " + nulos[i].getPrimeiroNome().ToString()
                        + "\n Ultimo Nome: " + nulos[i].getUltimoNome().ToString() + "\n Saldo: " + nulos[i].getSaldo().ToString() + "\n";

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                rcTexto.Clear();
                rcTexto.Text = "Sem saldos nulos";
            }
        }

        private void btSaldo_positivo_Click(object sender, EventArgs e)
        {
            try
            {
                rcTexto.Clear();
                for (int i = 0; i < po; i++)
                {
                    
                    rcTexto.Text = rcTexto.Text + "\n Conta: " + positivos[i].getConta().ToString() + "\n Primeiro Nome: " + positivos[i].getPrimeiroNome().ToString()
                        + "\n Ultimo Nome: " + positivos[i].getUltimoNome().ToString() + "\n Saldo: " + positivos[i].getSaldo().ToString()+ "\n";
                    
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                rcTexto.Clear();
                rcTexto.Text = "Sem saldos positivos";
            }

        }

        private void btFechar_arquivo_Click(object sender, EventArgs e)
        {
            arquivo_entrada.Close();
            btSaldo_positivo.Enabled = false;
            btSaldo_negativo.Enabled = false;
            btSaldo_nulo.Enabled = false;
            btFechar_arquivo.Enabled = false;
            btAbrir_arquivo.Enabled = true;
            rcTexto.Clear();
        }
    } 
}
