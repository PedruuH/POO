using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLAB03
{
    public partial class Form1 : Form
    {
        int i = 0, j = 0, k = 0;
        Materia[] vetMat;
        Aluno[] Alunos;
        
        public Form1()
        {
            InitializeComponent();
            vetMat = new Materia[10];
            Alunos = new Aluno[10];
            MessageBox.Show("Favor Cadastrar \nas materias primeiro");
                            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Alunos[j].setNome(tbNome.Text);
            Alunos[j].setMat(tbCodigoMat.Text);
            j++;
            
        }

        private void btCadastrarMat_Click(object sender, EventArgs e)
        {
            vetMat[i] = new Materia();
            vetMat[i].setNome(tbNomeMat.Text);
            vetMat[i].setCodigo(tbCodigoMat.Text);
            i += 1;
            cbMaterias.Items.Add(tbNomeMat.Text);
            tbNomeMat.Text = "";
            tbCodigoMat.Text = "";
            lbqtdCadastrada.Text = Convert.ToString(i);
                      
         }

        private void btMatricular_Click(object sender, EventArgs e)
        {
            
            for(;k<i;k++)
            {
                Alunos[j] = new Aluno();
                if(cbMaterias.SelectedItem.ToString()==vetMat[k].getNome())
                {
                    Alunos[j].addMateria(vetMat[k]);                    
                }
                
            }
         }

        private void tabControl_Click(object sender, EventArgs e)
        {
            lbqtdCadastrada.Text = Convert.ToString(i);
            
        }

        private void btVerDados_Click(object sender, EventArgs e)
        {
            for(int i=0;i<j;i++)
            {
                listbNomes.Items.Add(Alunos[i].getNome());
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            for(int i=0;i<j;i++)
            {
                if(listbNomes.SelectedItem.ToString() == Alunos[i].getNome())
                {
                    
                    rtbDisplay.Text="Nome: "+ Alunos[i].getNome()+"\nMatricula: "+
                        Alunos[i].getMat()+"\nMaterias: "+Alunos[i].getMaterias();
                }
            }
        }

        

        
    }
}
