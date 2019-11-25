using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCadastro_AlunoMateria
{
    public partial class Form1 : Form
    {
        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        string nome_aluno, matricula, codigo, nome_materia;
        int periodo, qtdalunos = 0;
        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaMateria = new List<Materia>();
        Aluno aL;
        Materia mL;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome_aluno = tbNome.Text;
            matricula = tbMatricula.Text;
            if (tbPeriodo.Text=="")
                MessageBox.Show("Digite um periodo valido (Número 1 - 10)");
            else 
                periodo = int.Parse(tbPeriodo.Text);
            Aluno a = new Aluno(nome_aluno, matricula, periodo);
            listaAlunos.Add(a);
            qtdalunos++;
            cbAlunos.Items.Add(tbNome.Text);
            cbRelatorio.Items.Add(tbNome.Text);
            tbNome.Text="";
            tbMatricula.Text="";
            tbPeriodo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome_materia = tbNomeMateria.Text;
            codigo = tbCodigoMateria.Text;
            Materia m = new Materia(nome_materia, codigo);
            listaMateria.Add(m);
            cbMaterias.Items.Add(tbNomeMateria.Text);
            tbNomeMateria.Text = "";
            tbCodigoMateria.Text = "";
        }

        private void btMatricular_Click(object sender, EventArgs e)
        {
            nome_aluno = cbAlunos.SelectedItem.ToString();
            aL = achaAluno(nome_aluno, listaAlunos);
            nome_materia = cbMaterias.SelectedItem.ToString();
            mL = achaMateria(nome_materia, listaMateria);
            aL.addMateria(mL);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtDados.Clear();
            nome_aluno = cbRelatorio.SelectedItem.ToString();
            aL = achaAluno(nome_aluno, listaAlunos);
            rtDados.SelectedText = ("Auno: " + aL.getNome());
            rtDados.SelectedText = ("\nMatricula: " + aL.getNum_Mat());
            rtDados.SelectedText = ("\nPeriodo: " + aL.getPeriodo());
            rtDados.SelectedText = ("\nMaterias matriculadas: \n" + aL.ImprimiDados());

        }

      
       

        

    
    }
}
