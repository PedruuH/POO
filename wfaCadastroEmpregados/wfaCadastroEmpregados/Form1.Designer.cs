namespace wfaCadastroEmpregados
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
            this.gbEmpregados = new System.Windows.Forms.GroupBox();
            this.rbClt = new System.Windows.Forms.RadioButton();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbPrecoH = new System.Windows.Forms.TextBox();
            this.lbQtdH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSalLiq = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbHorista = new System.Windows.Forms.GroupBox();
            this.gbCLT = new System.Windows.Forms.GroupBox();
            this.tbSalBruto = new System.Windows.Forms.TextBox();
            this.lbSalBruto = new System.Windows.Forms.Label();
            this.tbSalLiqCLT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEmpregados.SuspendLayout();
            this.gbHorista.SuspendLayout();
            this.gbCLT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmpregados
            // 
            this.gbEmpregados.Controls.Add(this.rbClt);
            this.gbEmpregados.Controls.Add(this.rbHorista);
            this.gbEmpregados.Location = new System.Drawing.Point(37, 12);
            this.gbEmpregados.Name = "gbEmpregados";
            this.gbEmpregados.Size = new System.Drawing.Size(200, 100);
            this.gbEmpregados.TabIndex = 0;
            this.gbEmpregados.TabStop = false;
            this.gbEmpregados.Text = "Empregados";
            // 
            // rbClt
            // 
            this.rbClt.AutoSize = true;
            this.rbClt.Location = new System.Drawing.Point(18, 60);
            this.rbClt.Name = "rbClt";
            this.rbClt.Size = new System.Drawing.Size(102, 17);
            this.rbClt.TabIndex = 1;
            this.rbClt.Text = "Empregado CLT";
            this.rbClt.UseVisualStyleBackColor = true;
            this.rbClt.CheckedChanged += new System.EventHandler(this.rbClt_CheckedChanged);
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(18, 28);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(130, 17);
            this.rbHorista.TabIndex = 0;
            this.rbHorista.Text = "Empregado HORISTA";
            this.rbHorista.UseVisualStyleBackColor = true;
            this.rbHorista.CheckedChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(15, 29);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(90, 20);
            this.tbHoras.TabIndex = 1;
            // 
            // tbPrecoH
            // 
            this.tbPrecoH.Location = new System.Drawing.Point(15, 74);
            this.tbPrecoH.Name = "tbPrecoH";
            this.tbPrecoH.Size = new System.Drawing.Size(90, 20);
            this.tbPrecoH.TabIndex = 2;
            // 
            // lbQtdH
            // 
            this.lbQtdH.AutoSize = true;
            this.lbQtdH.Location = new System.Drawing.Point(12, 13);
            this.lbQtdH.Name = "lbQtdH";
            this.lbQtdH.Size = new System.Drawing.Size(93, 13);
            this.lbQtdH.TabIndex = 3;
            this.lbQtdH.Text = "Quantidade Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço Hora";
            // 
            // tbSalLiq
            // 
            this.tbSalLiq.Location = new System.Drawing.Point(160, 74);
            this.tbSalLiq.Name = "tbSalLiq";
            this.tbSalLiq.Size = new System.Drawing.Size(90, 20);
            this.tbSalLiq.TabIndex = 5;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(213, 186);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(40, 147);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(145, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(39, 186);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 8;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(39, 228);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(146, 20);
            this.tbEndereco.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salário Liquido";
            // 
            // gbHorista
            // 
            this.gbHorista.Controls.Add(this.tbHoras);
            this.gbHorista.Controls.Add(this.label6);
            this.gbHorista.Controls.Add(this.tbPrecoH);
            this.gbHorista.Controls.Add(this.lbQtdH);
            this.gbHorista.Controls.Add(this.label1);
            this.gbHorista.Controls.Add(this.tbSalLiq);
            this.gbHorista.Location = new System.Drawing.Point(24, 257);
            this.gbHorista.Name = "gbHorista";
            this.gbHorista.Size = new System.Drawing.Size(264, 141);
            this.gbHorista.TabIndex = 2;
            this.gbHorista.TabStop = false;
            this.gbHorista.Text = "Horista";
            this.gbHorista.Visible = false;
            // 
            // gbCLT
            // 
            this.gbCLT.Controls.Add(this.label7);
            this.gbCLT.Controls.Add(this.tbSalLiqCLT);
            this.gbCLT.Controls.Add(this.lbSalBruto);
            this.gbCLT.Controls.Add(this.tbSalBruto);
            this.gbCLT.Location = new System.Drawing.Point(18, 270);
            this.gbCLT.Name = "gbCLT";
            this.gbCLT.Size = new System.Drawing.Size(264, 135);
            this.gbCLT.TabIndex = 15;
            this.gbCLT.TabStop = false;
            this.gbCLT.Text = "CLT";
            this.gbCLT.Visible = false;
            // 
            // tbSalBruto
            // 
            this.tbSalBruto.Location = new System.Drawing.Point(13, 39);
            this.tbSalBruto.Name = "tbSalBruto";
            this.tbSalBruto.Size = new System.Drawing.Size(100, 20);
            this.tbSalBruto.TabIndex = 16;
            // 
            // lbSalBruto
            // 
            this.lbSalBruto.AutoSize = true;
            this.lbSalBruto.Location = new System.Drawing.Point(15, 23);
            this.lbSalBruto.Name = "lbSalBruto";
            this.lbSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lbSalBruto.TabIndex = 17;
            this.lbSalBruto.Text = "Salario Bruto";
            // 
            // tbSalLiqCLT
            // 
            this.tbSalLiqCLT.Location = new System.Drawing.Point(13, 91);
            this.tbSalLiqCLT.Name = "tbSalLiqCLT";
            this.tbSalLiqCLT.Size = new System.Drawing.Size(100, 20);
            this.tbSalLiqCLT.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Salario Líquido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 425);
            this.Controls.Add(this.gbCLT);
            this.Controls.Add(this.gbHorista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.gbEmpregados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEmpregados.ResumeLayout(false);
            this.gbEmpregados.PerformLayout();
            this.gbHorista.ResumeLayout(false);
            this.gbHorista.PerformLayout();
            this.gbCLT.ResumeLayout(false);
            this.gbCLT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmpregados;
        private System.Windows.Forms.RadioButton rbClt;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbPrecoH;
        private System.Windows.Forms.Label lbQtdH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalLiq;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbHorista;
        private System.Windows.Forms.GroupBox gbCLT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSalLiqCLT;
        private System.Windows.Forms.Label lbSalBruto;
        private System.Windows.Forms.TextBox tbSalBruto;
    }
}

