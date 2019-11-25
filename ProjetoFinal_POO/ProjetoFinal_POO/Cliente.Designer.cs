namespace ProjetoFinal_POO
{
    partial class Cliente
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
            this.bt_cadastrarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomeEmpresa = new System.Windows.Forms.TextBox();
            this.tbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt_cadastrarCliente
            // 
            this.bt_cadastrarCliente.Location = new System.Drawing.Point(181, 238);
            this.bt_cadastrarCliente.Name = "bt_cadastrarCliente";
            this.bt_cadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastrarCliente.TabIndex = 0;
            this.bt_cadastrarCliente.Text = "Cadastrar";
            this.bt_cadastrarCliente.UseVisualStyleBackColor = true;
            this.bt_cadastrarCliente.Click += new System.EventHandler(this.bt_cadastrarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // tbNomeEmpresa
            // 
            this.tbNomeEmpresa.Location = new System.Drawing.Point(36, 47);
            this.tbNomeEmpresa.Name = "tbNomeEmpresa";
            this.tbNomeEmpresa.Size = new System.Drawing.Size(262, 20);
            this.tbNomeEmpresa.TabIndex = 6;
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Location = new System.Drawing.Point(36, 97);
            this.tbCNPJ.Mask = "##.###.###/####-##";
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(182, 20);
            this.tbCNPJ.TabIndex = 7;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(36, 146);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(182, 20);
            this.tbEndereco.TabIndex = 8;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(36, 195);
            this.tbTelefone.Mask = "(##) #####-####";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(123, 20);
            this.tbTelefone.TabIndex = 9;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 273);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbCNPJ);
            this.Controls.Add(this.tbNomeEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cadastrarCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeEmpresa;
        private System.Windows.Forms.MaskedTextBox tbCNPJ;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
    }
}