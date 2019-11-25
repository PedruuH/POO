namespace wfaLAB03
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAluno = new System.Windows.Forms.TabPage();
            this.btMatricular = new System.Windows.Forms.Button();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.lbMat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.lbqtdCadastrada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCadastrarMat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoMat = new System.Windows.Forms.TextBox();
            this.tbNomeMat = new System.Windows.Forms.TextBox();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btVerDados = new System.Windows.Forms.Button();
            this.listbNomes = new System.Windows.Forms.ListBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAluno.SuspendLayout();
            this.tabMateria.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAluno);
            this.tabControl.Controls.Add(this.tabMateria);
            this.tabControl.Controls.Add(this.tabRelatorio);
            this.tabControl.Location = new System.Drawing.Point(0, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(291, 363);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabAluno
            // 
            this.tabAluno.Controls.Add(this.btMatricular);
            this.tabAluno.Controls.Add(this.cbMaterias);
            this.tabAluno.Controls.Add(this.lbMateria);
            this.tabAluno.Controls.Add(this.tbMat);
            this.tabAluno.Controls.Add(this.lbMat);
            this.tabAluno.Controls.Add(this.label1);
            this.tabAluno.Controls.Add(this.tbNome);
            this.tabAluno.Controls.Add(this.btSave);
            this.tabAluno.Location = new System.Drawing.Point(4, 22);
            this.tabAluno.Name = "tabAluno";
            this.tabAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAluno.Size = new System.Drawing.Size(283, 337);
            this.tabAluno.TabIndex = 0;
            this.tabAluno.Text = "Aluno";
            this.tabAluno.UseVisualStyleBackColor = true;
            // 
            // btMatricular
            // 
            this.btMatricular.Location = new System.Drawing.Point(195, 215);
            this.btMatricular.Name = "btMatricular";
            this.btMatricular.Size = new System.Drawing.Size(75, 35);
            this.btMatricular.TabIndex = 7;
            this.btMatricular.Text = "Matricular Aluno";
            this.btMatricular.UseVisualStyleBackColor = true;
            this.btMatricular.Click += new System.EventHandler(this.btMatricular_Click);
            // 
            // cbMaterias
            // 
            this.cbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(13, 185);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(257, 24);
            this.cbMaterias.TabIndex = 6;
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateria.Location = new System.Drawing.Point(10, 149);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(72, 16);
            this.lbMateria.TabIndex = 5;
            this.lbMateria.Text = "Matérias:";
            // 
            // tbMat
            // 
            this.tbMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMat.Location = new System.Drawing.Point(13, 100);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(257, 29);
            this.tbMat.TabIndex = 4;
            // 
            // lbMat
            // 
            this.lbMat.AutoSize = true;
            this.lbMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMat.Location = new System.Drawing.Point(10, 81);
            this.lbMat.Name = "lbMat";
            this.lbMat.Size = new System.Drawing.Size(75, 16);
            this.lbMat.TabIndex = 3;
            this.lbMat.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(13, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(257, 29);
            this.tbNome.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(195, 308);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tabMateria
            // 
            this.tabMateria.Controls.Add(this.lbqtdCadastrada);
            this.tabMateria.Controls.Add(this.label4);
            this.tabMateria.Controls.Add(this.btCadastrarMat);
            this.tabMateria.Controls.Add(this.label3);
            this.tabMateria.Controls.Add(this.label2);
            this.tabMateria.Controls.Add(this.tbCodigoMat);
            this.tabMateria.Controls.Add(this.tbNomeMat);
            this.tabMateria.Location = new System.Drawing.Point(4, 22);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria.Size = new System.Drawing.Size(283, 337);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Matéria";
            this.tabMateria.UseVisualStyleBackColor = true;
            // 
            // lbqtdCadastrada
            // 
            this.lbqtdCadastrada.AutoSize = true;
            this.lbqtdCadastrada.Location = new System.Drawing.Point(6, 198);
            this.lbqtdCadastrada.Name = "lbqtdCadastrada";
            this.lbqtdCadastrada.Size = new System.Drawing.Size(0, 13);
            this.lbqtdCadastrada.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quatidade Cadastrada (Máx. 10)";
            // 
            // btCadastrarMat
            // 
            this.btCadastrarMat.Location = new System.Drawing.Point(198, 305);
            this.btCadastrarMat.Name = "btCadastrarMat";
            this.btCadastrarMat.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarMat.TabIndex = 4;
            this.btCadastrarMat.Text = "Cadastrar";
            this.btCadastrarMat.UseVisualStyleBackColor = true;
            this.btCadastrarMat.Click += new System.EventHandler(this.btCadastrarMat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Matéria:";
            // 
            // tbCodigoMat
            // 
            this.tbCodigoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoMat.Location = new System.Drawing.Point(9, 107);
            this.tbCodigoMat.Name = "tbCodigoMat";
            this.tbCodigoMat.Size = new System.Drawing.Size(264, 26);
            this.tbCodigoMat.TabIndex = 1;
            // 
            // tbNomeMat
            // 
            this.tbNomeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeMat.Location = new System.Drawing.Point(9, 35);
            this.tbNomeMat.Name = "tbNomeMat";
            this.tbNomeMat.Size = new System.Drawing.Size(264, 26);
            this.tbNomeMat.TabIndex = 0;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.btConsultar);
            this.tabRelatorio.Controls.Add(this.rtbDisplay);
            this.tabRelatorio.Controls.Add(this.btVerDados);
            this.tabRelatorio.Controls.Add(this.listbNomes);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Size = new System.Drawing.Size(283, 337);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(0, 174);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(280, 160);
            this.rtbDisplay.TabIndex = 2;
            this.rtbDisplay.Text = "";
            // 
            // btVerDados
            // 
            this.btVerDados.Location = new System.Drawing.Point(8, 14);
            this.btVerDados.Name = "btVerDados";
            this.btVerDados.Size = new System.Drawing.Size(75, 23);
            this.btVerDados.TabIndex = 1;
            this.btVerDados.Text = "Ver Dados";
            this.btVerDados.UseVisualStyleBackColor = true;
            this.btVerDados.Click += new System.EventHandler(this.btVerDados_Click);
            // 
            // listbNomes
            // 
            this.listbNomes.FormattingEnabled = true;
            this.listbNomes.Location = new System.Drawing.Point(0, 47);
            this.listbNomes.Name = "listbNomes";
            this.listbNomes.Size = new System.Drawing.Size(280, 121);
            this.listbNomes.TabIndex = 0;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(184, 14);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 360);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno/Matéria";
            this.tabControl.ResumeLayout(false);
            this.tabAluno.ResumeLayout(false);
            this.tabAluno.PerformLayout();
            this.tabMateria.ResumeLayout(false);
            this.tabMateria.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAluno;
        private System.Windows.Forms.TabPage tabMateria;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label lbMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btMatricular;
        private System.Windows.Forms.Button btCadastrarMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoMat;
        private System.Windows.Forms.TextBox tbNomeMat;
        private System.Windows.Forms.Label lbqtdCadastrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btVerDados;
        private System.Windows.Forms.ListBox listbNomes;
        private System.Windows.Forms.Button btConsultar;
    }
}

