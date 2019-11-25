namespace wfaArquivoSequencial
{
    partial class Form2
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
            this.btSaldo_nulo = new System.Windows.Forms.Button();
            this.btFechar_arquivo = new System.Windows.Forms.Button();
            this.btSaldo_negativo = new System.Windows.Forms.Button();
            this.btSaldo_positivo = new System.Windows.Forms.Button();
            this.btAbrir_arquivo = new System.Windows.Forms.Button();
            this.rcTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btSaldo_nulo
            // 
            this.btSaldo_nulo.Location = new System.Drawing.Point(401, 264);
            this.btSaldo_nulo.Name = "btSaldo_nulo";
            this.btSaldo_nulo.Size = new System.Drawing.Size(75, 36);
            this.btSaldo_nulo.TabIndex = 9;
            this.btSaldo_nulo.Text = "Saldo Nulo";
            this.btSaldo_nulo.UseVisualStyleBackColor = true;
            this.btSaldo_nulo.Click += new System.EventHandler(this.btSaldo_nulo_Click);
            // 
            // btFechar_arquivo
            // 
            this.btFechar_arquivo.Location = new System.Drawing.Point(513, 264);
            this.btFechar_arquivo.Name = "btFechar_arquivo";
            this.btFechar_arquivo.Size = new System.Drawing.Size(75, 36);
            this.btFechar_arquivo.TabIndex = 8;
            this.btFechar_arquivo.Text = "Fechar Arquivo";
            this.btFechar_arquivo.UseVisualStyleBackColor = true;
            this.btFechar_arquivo.Click += new System.EventHandler(this.btFechar_arquivo_Click);
            // 
            // btSaldo_negativo
            // 
            this.btSaldo_negativo.Location = new System.Drawing.Point(283, 264);
            this.btSaldo_negativo.Name = "btSaldo_negativo";
            this.btSaldo_negativo.Size = new System.Drawing.Size(75, 36);
            this.btSaldo_negativo.TabIndex = 7;
            this.btSaldo_negativo.Text = "Saldo Negativo";
            this.btSaldo_negativo.UseVisualStyleBackColor = true;
            this.btSaldo_negativo.Click += new System.EventHandler(this.btSaldo_negativo_Click);
            // 
            // btSaldo_positivo
            // 
            this.btSaldo_positivo.Location = new System.Drawing.Point(173, 264);
            this.btSaldo_positivo.Name = "btSaldo_positivo";
            this.btSaldo_positivo.Size = new System.Drawing.Size(81, 36);
            this.btSaldo_positivo.TabIndex = 6;
            this.btSaldo_positivo.Text = "Saldo Positivo";
            this.btSaldo_positivo.UseVisualStyleBackColor = true;
            this.btSaldo_positivo.Click += new System.EventHandler(this.btSaldo_positivo_Click);
            // 
            // btAbrir_arquivo
            // 
            this.btAbrir_arquivo.Location = new System.Drawing.Point(56, 264);
            this.btAbrir_arquivo.Name = "btAbrir_arquivo";
            this.btAbrir_arquivo.Size = new System.Drawing.Size(75, 36);
            this.btAbrir_arquivo.TabIndex = 5;
            this.btAbrir_arquivo.Text = "Abrir Arquivo";
            this.btAbrir_arquivo.UseVisualStyleBackColor = true;
            this.btAbrir_arquivo.Click += new System.EventHandler(this.btAbrir_arquivo_Click);
            // 
            // rcTexto
            // 
            this.rcTexto.Location = new System.Drawing.Point(56, 12);
            this.rcTexto.Name = "rcTexto";
            this.rcTexto.Size = new System.Drawing.Size(532, 227);
            this.rcTexto.TabIndex = 10;
            this.rcTexto.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 317);
            this.Controls.Add(this.rcTexto);
            this.Controls.Add(this.btSaldo_nulo);
            this.Controls.Add(this.btFechar_arquivo);
            this.Controls.Add(this.btSaldo_negativo);
            this.Controls.Add(this.btSaldo_positivo);
            this.Controls.Add(this.btAbrir_arquivo);
            this.Name = "Form2";
            this.Text = "Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaldo_nulo;
        private System.Windows.Forms.Button btFechar_arquivo;
        private System.Windows.Forms.Button btSaldo_negativo;
        private System.Windows.Forms.Button btSaldo_positivo;
        private System.Windows.Forms.Button btAbrir_arquivo;
        private System.Windows.Forms.RichTextBox rcTexto;
    }
}