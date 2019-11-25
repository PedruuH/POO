namespace wfaCadastro_AlunoMateria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageAluno = new System.Windows.Forms.TabPage();
            this.btCadastrarAluno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.pageMateria = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigoMateria = new System.Windows.Forms.TextBox();
            this.tbNomeMateria = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabMatricular = new System.Windows.Forms.TabPage();
            this.btMatricular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.cbAlunos = new System.Windows.Forms.ComboBox();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.rtDados = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRelatorio = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.pageAluno.SuspendLayout();
            this.pageMateria.SuspendLayout();
            this.tabMatricular.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageAluno);
            this.tabControl1.Controls.Add(this.pageMateria);
            this.tabControl1.Controls.Add(this.tabMatricular);
            this.tabControl1.Controls.Add(this.tabRelatorio);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // pageAluno
            // 
            this.pageAluno.Controls.Add(this.btCadastrarAluno);
            this.pageAluno.Controls.Add(this.label3);
            this.pageAluno.Controls.Add(this.label2);
            this.pageAluno.Controls.Add(this.label1);
            this.pageAluno.Controls.Add(this.tbPeriodo);
            this.pageAluno.Controls.Add(this.tbMatricula);
            this.pageAluno.Controls.Add(this.tbNome);
            this.pageAluno.Location = new System.Drawing.Point(4, 22);
            this.pageAluno.Name = "pageAluno";
            this.pageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.pageAluno.Size = new System.Drawing.Size(280, 238);
            this.pageAluno.TabIndex = 0;
            this.pageAluno.Text = "Aluno";
            this.pageAluno.UseVisualStyleBackColor = true;
            // 
            // btCadastrarAluno
            // 
            this.btCadastrarAluno.Location = new System.Drawing.Point(199, 204);
            this.btCadastrarAluno.Name = "btCadastrarAluno";
            this.btCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarAluno.TabIndex = 6;
            this.btCadastrarAluno.Text = "Cadastrar";
            this.btCadastrarAluno.UseVisualStyleBackColor = true;
            this.btCadastrarAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Aluno";
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(9, 138);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(100, 20);
            this.tbPeriodo.TabIndex = 2;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(9, 85);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(100, 20);
            this.tbMatricula.TabIndex = 1;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(8, 30);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(231, 20);
            this.tbNome.TabIndex = 0;
            // 
            // pageMateria
            // 
            this.pageMateria.Controls.Add(this.label5);
            this.pageMateria.Controls.Add(this.label4);
            this.pageMateria.Controls.Add(this.tbCodigoMateria);
            this.pageMateria.Controls.Add(this.tbNomeMateria);
            this.pageMateria.Controls.Add(this.button2);
            this.pageMateria.Location = new System.Drawing.Point(4, 22);
            this.pageMateria.Name = "pageMateria";
            this.pageMateria.Padding = new System.Windows.Forms.Padding(3);
            this.pageMateria.Size = new System.Drawing.Size(280, 238);
            this.pageMateria.TabIndex = 1;
            this.pageMateria.Text = "Materia";
            this.pageMateria.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // tbCodigoMateria
            // 
            this.tbCodigoMateria.Location = new System.Drawing.Point(14, 83);
            this.tbCodigoMateria.Name = "tbCodigoMateria";
            this.tbCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoMateria.TabIndex = 2;
            // 
            // tbNomeMateria
            // 
            this.tbNomeMateria.Location = new System.Drawing.Point(14, 35);
            this.tbNomeMateria.Name = "tbNomeMateria";
            this.tbNomeMateria.Size = new System.Drawing.Size(156, 20);
            this.tbNomeMateria.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabMatricular
            // 
            this.tabMatricular.Controls.Add(this.btMatricular);
            this.tabMatricular.Controls.Add(this.label7);
            this.tabMatricular.Controls.Add(this.label6);
            this.tabMatricular.Controls.Add(this.cbMaterias);
            this.tabMatricular.Controls.Add(this.cbAlunos);
            this.tabMatricular.Location = new System.Drawing.Point(4, 22);
            this.tabMatricular.Name = "tabMatricular";
            this.tabMatricular.Size = new System.Drawing.Size(280, 238);
            this.tabMatricular.TabIndex = 3;
            this.tabMatricular.Text = "Matricular";
            this.tabMatricular.UseVisualStyleBackColor = true;
            // 
            // btMatricular
            // 
            this.btMatricular.Location = new System.Drawing.Point(193, 204);
            this.btMatricular.Name = "btMatricular";
            this.btMatricular.Size = new System.Drawing.Size(75, 23);
            this.btMatricular.TabIndex = 4;
            this.btMatricular.Text = "Matricular";
            this.btMatricular.UseVisualStyleBackColor = true;
            this.btMatricular.Click += new System.EventHandler(this.btMatricular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Materias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alunos";
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(18, 90);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(217, 21);
            this.cbMaterias.TabIndex = 1;
            // 
            // cbAlunos
            // 
            this.cbAlunos.FormattingEnabled = true;
            this.cbAlunos.Location = new System.Drawing.Point(18, 33);
            this.cbAlunos.Name = "cbAlunos";
            this.cbAlunos.Size = new System.Drawing.Size(217, 21);
            this.cbAlunos.TabIndex = 0;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.rtDados);
            this.tabRelatorio.Controls.Add(this.button3);
            this.tabRelatorio.Controls.Add(this.label9);
            this.tabRelatorio.Controls.Add(this.label8);
            this.tabRelatorio.Controls.Add(this.cbRelatorio);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Size = new System.Drawing.Size(280, 238);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // rtDados
            // 
            this.rtDados.Location = new System.Drawing.Point(8, 87);
            this.rtDados.Name = "rtDados";
            this.rtDados.Size = new System.Drawing.Size(260, 140);
            this.rtDados.TabIndex = 4;
            this.rtDados.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Selecione Aluno";
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.FormattingEnabled = true;
            this.cbRelatorio.Location = new System.Drawing.Point(11, 36);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(201, 21);
            this.cbRelatorio.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.pageAluno.ResumeLayout(false);
            this.pageAluno.PerformLayout();
            this.pageMateria.ResumeLayout(false);
            this.pageMateria.PerformLayout();
            this.tabMatricular.ResumeLayout(false);
            this.tabMatricular.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.tabRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageAluno;
        private System.Windows.Forms.TabPage pageMateria;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Button btCadastrarAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigoMateria;
        private System.Windows.Forms.TextBox tbNomeMateria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabMatricular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.ComboBox cbAlunos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRelatorio;
        private System.Windows.Forms.Button btMatricular;
        private System.Windows.Forms.RichTextBox rtDados;

    }
}

