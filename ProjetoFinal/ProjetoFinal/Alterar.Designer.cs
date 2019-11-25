namespace ProjetoFinal
{
    partial class Alterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAlterar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.rbCargo = new System.Windows.Forms.RadioButton();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.tbTelefoneClt = new System.Windows.Forms.MaskedTextBox();
            this.tbEnderecoClt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificarCLT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCLT = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbTelefoneCorretor = new System.Windows.Forms.RadioButton();
            this.rbEnderecoCorretor = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefoneCorretor = new System.Windows.Forms.MaskedTextBox();
            this.tbEnderecoCorretor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btModificarCorretores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCorretores = new System.Windows.Forms.ComboBox();
            this.tabAlterar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.tabPage1);
            this.tabAlterar.Controls.Add(this.tabPage2);
            this.tabAlterar.Location = new System.Drawing.Point(13, 13);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.SelectedIndex = 0;
            this.tabAlterar.Size = new System.Drawing.Size(426, 310);
            this.tabAlterar.TabIndex = 0;
            this.tabAlterar.Click += new System.EventHandler(this.tabAlterar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbTelefone);
            this.tabPage1.Controls.Add(this.rbCargo);
            this.tabPage1.Controls.Add(this.rbEndereco);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbCargo);
            this.tabPage1.Controls.Add(this.tbTelefoneClt);
            this.tabPage1.Controls.Add(this.tbEnderecoClt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btModificarCLT);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbCLT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empregado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Location = new System.Drawing.Point(22, 211);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbTelefone.TabIndex = 29;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            // 
            // rbCargo
            // 
            this.rbCargo.AutoSize = true;
            this.rbCargo.Location = new System.Drawing.Point(22, 234);
            this.rbCargo.Name = "rbCargo";
            this.rbCargo.Size = new System.Drawing.Size(53, 17);
            this.rbCargo.TabIndex = 28;
            this.rbCargo.TabStop = true;
            this.rbCargo.Text = "Cargo";
            this.rbCargo.UseVisualStyleBackColor = true;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Location = new System.Drawing.Point(22, 188);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(71, 17);
            this.rbEndereco.TabIndex = 27;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Digite o dado que deseja alterar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "CARGO:";
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(92, 147);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(168, 21);
            this.cbCargo.TabIndex = 3;
            // 
            // tbTelefoneClt
            // 
            this.tbTelefoneClt.Location = new System.Drawing.Point(92, 121);
            this.tbTelefoneClt.Mask = "(##) #####-####";
            this.tbTelefoneClt.Name = "tbTelefoneClt";
            this.tbTelefoneClt.Size = new System.Drawing.Size(309, 20);
            this.tbTelefoneClt.TabIndex = 2;
            // 
            // tbEnderecoClt
            // 
            this.tbEnderecoClt.Location = new System.Drawing.Point(92, 95);
            this.tbEnderecoClt.Name = "tbEnderecoClt";
            this.tbEnderecoClt.Size = new System.Drawing.Size(310, 20);
            this.tbEnderecoClt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "TELEFONE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ENDEREÇO:";
            // 
            // btModificarCLT
            // 
            this.btModificarCLT.Location = new System.Drawing.Point(327, 21);
            this.btModificarCLT.Name = "btModificarCLT";
            this.btModificarCLT.Size = new System.Drawing.Size(75, 23);
            this.btModificarCLT.TabIndex = 19;
            this.btModificarCLT.Text = "MODIFICAR";
            this.btModificarCLT.UseVisualStyleBackColor = true;
            this.btModificarCLT.Click += new System.EventHandler(this.btModificarCLT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "NOME:";
            // 
            // cbCLT
            // 
            this.cbCLT.FormattingEnabled = true;
            this.cbCLT.Location = new System.Drawing.Point(72, 23);
            this.cbCLT.Name = "cbCLT";
            this.cbCLT.Size = new System.Drawing.Size(239, 21);
            this.cbCLT.TabIndex = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbTelefoneCorretor);
            this.tabPage2.Controls.Add(this.rbEnderecoCorretor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbTelefoneCorretor);
            this.tabPage2.Controls.Add(this.tbEnderecoCorretor);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btModificarCorretores);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbCorretores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corretor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbTelefoneCorretor
            // 
            this.rbTelefoneCorretor.AutoSize = true;
            this.rbTelefoneCorretor.Location = new System.Drawing.Point(24, 200);
            this.rbTelefoneCorretor.Name = "rbTelefoneCorretor";
            this.rbTelefoneCorretor.Size = new System.Drawing.Size(67, 17);
            this.rbTelefoneCorretor.TabIndex = 39;
            this.rbTelefoneCorretor.TabStop = true;
            this.rbTelefoneCorretor.Text = "Telefone";
            this.rbTelefoneCorretor.UseVisualStyleBackColor = true;
            // 
            // rbEnderecoCorretor
            // 
            this.rbEnderecoCorretor.AutoSize = true;
            this.rbEnderecoCorretor.Location = new System.Drawing.Point(24, 177);
            this.rbEnderecoCorretor.Name = "rbEnderecoCorretor";
            this.rbEnderecoCorretor.Size = new System.Drawing.Size(71, 17);
            this.rbEnderecoCorretor.TabIndex = 37;
            this.rbEnderecoCorretor.TabStop = true;
            this.rbEnderecoCorretor.Text = "Endereço";
            this.rbEnderecoCorretor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Digite o dado que deseja alterar";
            // 
            // tbTelefoneCorretor
            // 
            this.tbTelefoneCorretor.Location = new System.Drawing.Point(97, 122);
            this.tbTelefoneCorretor.Mask = "(##) #####-####";
            this.tbTelefoneCorretor.Name = "tbTelefoneCorretor";
            this.tbTelefoneCorretor.Size = new System.Drawing.Size(309, 20);
            this.tbTelefoneCorretor.TabIndex = 33;
            // 
            // tbEnderecoCorretor
            // 
            this.tbEnderecoCorretor.Location = new System.Drawing.Point(97, 96);
            this.tbEnderecoCorretor.Name = "tbEnderecoCorretor";
            this.tbEnderecoCorretor.Size = new System.Drawing.Size(310, 20);
            this.tbEnderecoCorretor.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "TELEFONE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "ENDEREÇO:";
            // 
            // btModificarCorretores
            // 
            this.btModificarCorretores.Location = new System.Drawing.Point(329, 21);
            this.btModificarCorretores.Name = "btModificarCorretores";
            this.btModificarCorretores.Size = new System.Drawing.Size(75, 23);
            this.btModificarCorretores.TabIndex = 19;
            this.btModificarCorretores.Text = "MODIFICAR";
            this.btModificarCorretores.UseVisualStyleBackColor = true;
            this.btModificarCorretores.Click += new System.EventHandler(this.btModificarCorretores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "NOME:";
            // 
            // cbCorretores
            // 
            this.cbCorretores.FormattingEnabled = true;
            this.cbCorretores.Location = new System.Drawing.Point(74, 23);
            this.cbCorretores.Name = "cbCorretores";
            this.cbCorretores.Size = new System.Drawing.Size(239, 21);
            this.cbCorretores.TabIndex = 17;
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 335);
            this.Controls.Add(this.tabAlterar);
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.tabAlterar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAlterar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btModificarCLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCLT;
        private System.Windows.Forms.Button btModificarCorretores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCorretores;
        private System.Windows.Forms.MaskedTextBox tbTelefoneClt;
        private System.Windows.Forms.TextBox tbEnderecoClt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.RadioButton rbCargo;
        private System.Windows.Forms.RadioButton rbEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.RadioButton rbTelefoneCorretor;
        private System.Windows.Forms.RadioButton rbEnderecoCorretor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbTelefoneCorretor;
        private System.Windows.Forms.TextBox tbEnderecoCorretor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}