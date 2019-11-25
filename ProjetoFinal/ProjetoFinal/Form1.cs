using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {

        private SplashScreen splashScreen;
        private bool done = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(HandleFormLoad);
            this.splashScreen = new SplashScreen();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();
            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();
            Timer worker = new Timer();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };
            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };
            worker.DoHardWork();
        }
        private void ShowSplashScreen()
        {
            splashScreen.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScreen.Close();
            this.splashScreen.Dispose();
        }

        //Cadastra
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
            this.Visible = true;
        }

        //Fecha Aplicacao
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Consulta
        private void btConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar consultar = new Consultar();
            consultar.ShowDialog();
            this.Visible = true;
        }

        //Altera
        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterar alterar = new Alterar();
            alterar.ShowDialog();
            this.Visible = true;
        }

        //Demite um funcionario (Assim removendo-o do BD)
        private void btRemover_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demitir demitir = new Demitir();
            demitir.ShowDialog();
            this.Visible = true;
        }
    }
}
