namespace ProjetoFinal
{
    partial class Cadastrar
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
            this.btClt = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.btCorretor = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbTelefoneClt = new System.Windows.Forms.MaskedTextBox();
            this.tbPisClt = new System.Windows.Forms.MaskedTextBox();
            this.tbEnderecoClt = new System.Windows.Forms.TextBox();
            this.tbCpfClt = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeClt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbCreciCorretor = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkTermos = new System.Windows.Forms.CheckBox();
            this.tbTelefoneCorretor = new System.Windows.Forms.MaskedTextBox();
            this.tbEnderecoCorretor = new System.Windows.Forms.TextBox();
            this.tbCpfCorretor = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeCorretor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbComissao = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbEmpreendimentos = new System.Windows.Forms.TextBox();
            this.cbCorretores = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClt
            // 
            this.btClt.Location = new System.Drawing.Point(120, 218);
            this.btClt.Name = "btClt";
            this.btClt.Size = new System.Drawing.Size(227, 23);
            this.btClt.TabIndex = 4;
            this.btClt.Text = "CADASTRAR CLT";
            this.btClt.UseVisualStyleBackColor = true;
            this.btClt.Click += new System.EventHandler(this.btClt_Click);
            // 
            // btVenda
            // 
            this.btVenda.Location = new System.Drawing.Point(119, 218);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(227, 23);
            this.btVenda.TabIndex = 6;
            this.btVenda.Text = "CADASTRAR VENDA";
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // btCorretor
            // 
            this.btCorretor.Location = new System.Drawing.Point(125, 229);
            this.btCorretor.Name = "btCorretor";
            this.btCorretor.Size = new System.Drawing.Size(227, 23);
            this.btCorretor.TabIndex = 5;
            this.btCorretor.Text = "CADASTRAR CORRETOR";
            this.btCorretor.UseVisualStyleBackColor = true;
            this.btCorretor.Click += new System.EventHandler(this.btCorretor_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(13, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(456, 284);
            this.tabControl.TabIndex = 7;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbTelefoneClt);
            this.tabPage1.Controls.Add(this.tbPisClt);
            this.tabPage1.Controls.Add(this.tbEnderecoClt);
            this.tabPage1.Controls.Add(this.tbCpfClt);
            this.tabPage1.Controls.Add(this.tbNomeClt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbCargo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btClt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CLT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbTelefoneClt
            // 
            this.tbTelefoneClt.Location = new System.Drawing.Point(117, 106);
            this.tbTelefoneClt.Mask = "(##) #####-####";
            this.tbTelefoneClt.Name = "tbTelefoneClt";
            this.tbTelefoneClt.Size = new System.Drawing.Size(309, 20);
            this.tbTelefoneClt.TabIndex = 16;
            // 
            // tbPisClt
            // 
            this.tbPisClt.Location = new System.Drawing.Point(117, 134);
            this.tbPisClt.Mask = "###,#####,##-#";
            this.tbPisClt.Name = "tbPisClt";
            this.tbPisClt.Size = new System.Drawing.Size(309, 20);
            this.tbPisClt.TabIndex = 15;
            // 
            // tbEnderecoClt
            // 
            this.tbEnderecoClt.Location = new System.Drawing.Point(117, 75);
            this.tbEnderecoClt.Name = "tbEnderecoClt";
            this.tbEnderecoClt.Size = new System.Drawing.Size(310, 20);
            this.tbEnderecoClt.TabIndex = 14;
            // 
            // tbCpfClt
            // 
            this.tbCpfClt.Location = new System.Drawing.Point(118, 48);
            this.tbCpfClt.Mask = "###,###,###-##";
            this.tbCpfClt.Name = "tbCpfClt";
            this.tbCpfClt.Size = new System.Drawing.Size(309, 20);
            this.tbCpfClt.TabIndex = 13;
            this.tbCpfClt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCpfClt_MaskInputRejected);
            // 
            // tbNomeClt
            // 
            this.tbNomeClt.Location = new System.Drawing.Point(118, 18);
            this.tbNomeClt.Name = "tbNomeClt";
            this.tbNomeClt.Size = new System.Drawing.Size(310, 20);
            this.tbNomeClt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "CARGO:";
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(118, 160);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(168, 21);
            this.cbCargo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "TELEFONE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "NPIS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ENDEREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOME:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbCreciCorretor);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.checkTermos);
            this.tabPage2.Controls.Add(this.tbTelefoneCorretor);
            this.tabPage2.Controls.Add(this.tbEnderecoCorretor);
            this.tabPage2.Controls.Add(this.tbCpfCorretor);
            this.tabPage2.Controls.Add(this.tbNomeCorretor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btCorretor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corretor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbCreciCorretor
            // 
            this.tbCreciCorretor.Location = new System.Drawing.Point(116, 133);
            this.tbCreciCorretor.Mask = "PF #####";
            this.tbCreciCorretor.Name = "tbCreciCorretor";
            this.tbCreciCorretor.Size = new System.Drawing.Size(309, 20);
            this.tbCreciCorretor.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "CRECI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "TERMOS:";
            // 
            // checkTermos
            // 
            this.checkTermos.AutoSize = true;
            this.checkTermos.Location = new System.Drawing.Point(116, 167);
            this.checkTermos.Name = "checkTermos";
            this.checkTermos.Size = new System.Drawing.Size(104, 17);
            this.checkTermos.TabIndex = 25;
            this.checkTermos.Text = "Aceito os termos";
            this.checkTermos.UseVisualStyleBackColor = true;
            // 
            // tbTelefoneCorretor
            // 
            this.tbTelefoneCorretor.Location = new System.Drawing.Point(116, 103);
            this.tbTelefoneCorretor.Mask = "(##) #####-####";
            this.tbTelefoneCorretor.Name = "tbTelefoneCorretor";
            this.tbTelefoneCorretor.Size = new System.Drawing.Size(309, 20);
            this.tbTelefoneCorretor.TabIndex = 24;
            // 
            // tbEnderecoCorretor
            // 
            this.tbEnderecoCorretor.Location = new System.Drawing.Point(116, 72);
            this.tbEnderecoCorretor.Name = "tbEnderecoCorretor";
            this.tbEnderecoCorretor.Size = new System.Drawing.Size(310, 20);
            this.tbEnderecoCorretor.TabIndex = 23;
            // 
            // tbCpfCorretor
            // 
            this.tbCpfCorretor.Location = new System.Drawing.Point(117, 45);
            this.tbCpfCorretor.Mask = "###,###,###-##";
            this.tbCpfCorretor.Name = "tbCpfCorretor";
            this.tbCpfCorretor.Size = new System.Drawing.Size(309, 20);
            this.tbCpfCorretor.TabIndex = 22;
            // 
            // tbNomeCorretor
            // 
            this.tbNomeCorretor.Location = new System.Drawing.Point(117, 19);
            this.tbNomeCorretor.Name = "tbNomeCorretor";
            this.tbNomeCorretor.Size = new System.Drawing.Size(310, 20);
            this.tbNomeCorretor.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "TELEFONE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "ENDEREÇO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "CPF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "NOME:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.cbMeses);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.tbComissao);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.tbValor);
            this.tabPage3.Controls.Add(this.tbEmpreendimentos);
            this.tabPage3.Controls.Add(this.cbCorretores);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btVenda);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(448, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vendas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(171, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 15);
            this.label19.TabIndex = 32;
            this.label19.Text = "%";
            // 
            // cbMeses
            // 
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Location = new System.Drawing.Point(147, 132);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(288, 21);
            this.cbMeses.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(107, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "MÊS:";
            // 
            // tbComissao
            // 
            this.tbComissao.Location = new System.Drawing.Point(147, 102);
            this.tbComissao.Mask = "#";
            this.tbComissao.Name = "tbComissao";
            this.tbComissao.Size = new System.Drawing.Size(18, 20);
            this.tbComissao.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(67, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "COMISSÃO:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(147, 76);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(288, 20);
            this.tbValor.TabIndex = 23;
            // 
            // tbEmpreendimentos
            // 
            this.tbEmpreendimentos.Location = new System.Drawing.Point(147, 49);
            this.tbEmpreendimentos.Name = "tbEmpreendimentos";
            this.tbEmpreendimentos.Size = new System.Drawing.Size(288, 20);
            this.tbEmpreendimentos.TabIndex = 22;
            // 
            // cbCorretores
            // 
            this.cbCorretores.FormattingEnabled = true;
            this.cbCorretores.Location = new System.Drawing.Point(147, 20);
            this.cbCorretores.Name = "cbCorretores";
            this.cbCorretores.Size = new System.Drawing.Size(288, 21);
            this.cbCorretores.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(91, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 20;
            this.label16.Text = "VALOR:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "EMPREENDIMENTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "CORRETOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "CADASTRAR";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClt;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btCorretor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox tbTelefoneClt;
        private System.Windows.Forms.MaskedTextBox tbPisClt;
        private System.Windows.Forms.TextBox tbEnderecoClt;
        private System.Windows.Forms.MaskedTextBox tbCpfClt;
        private System.Windows.Forms.TextBox tbNomeClt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkTermos;
        private System.Windows.Forms.MaskedTextBox tbTelefoneCorretor;
        private System.Windows.Forms.TextBox tbEnderecoCorretor;
        private System.Windows.Forms.MaskedTextBox tbCpfCorretor;
        private System.Windows.Forms.TextBox tbNomeCorretor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbCreciCorretor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox tbComissao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbEmpreendimentos;
        private System.Windows.Forms.ComboBox cbCorretores;
        private System.Windows.Forms.Label label19;
    }
}