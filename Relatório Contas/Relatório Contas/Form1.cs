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

namespace Relatório_Contas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btSaldo_positivo.Enabled = false;
            btSaldo_negativo.Enabled = false;
            btSaldo_nulo.Enabled = false;

        }
        List<Registro> negativos = new List<Registro>();
        List<Registro> positivos = new List<Registro>();
        List<Registro> nulos = new List<Registro>();
        string[] values;


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
            while(true)
            {
                try
                {
                    // get next Record available in file
                    Registro registro =
                       (Registro)reader.Deserialize(arquivo_entrada);

                    // armazena valores de Registro num array de string 
                    values = new string[] {   registro.getConta().ToString(),
                                              registro.getPrimeiroNome().ToString(),
                                              registro.getUltimoNome().ToString(),
                                              registro.getSaldo().ToString()
                                               };

                    // copia os valores do array de string nos valores dos TextBox 
                    
                }

                // trata excecção, quando não existe Registro no arquivo
                catch (SerializationException)
                {
                    // fecha FileStream se não houver Registro no arquivo
                    arquivo_entrada.Close();
                    break;
                }
            }
            
        }

        private void btSaldo_positivo_Click(object sender, EventArgs e)
        {
          // string s= positivos[0].getConta().ToString();
         
                
        }
    }
}
