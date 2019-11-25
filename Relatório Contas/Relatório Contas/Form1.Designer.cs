namespace Relatório_Contas
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAbrir_arquivo = new System.Windows.Forms.Button();
            this.btSaldo_positivo = new System.Windows.Forms.Button();
            this.btSaldo_negativo = new System.Windows.Forms.Button();
            this.btFechar_arquivo = new System.Windows.Forms.Button();
            this.btSaldo_nulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAbrir_arquivo
            // 
            this.btAbrir_arquivo.Location = new System.Drawing.Point(58, 179);
            this.btAbrir_arquivo.Name = "btAbrir_arquivo";
            this.btAbrir_arquivo.Size = new System.Drawing.Size(75, 36);
            this.btAbrir_arquivo.TabIndex = 0;
            this.btAbrir_arquivo.Text = "Abrir Arquivo";
            this.btAbrir_arquivo.UseVisualStyleBackColor = true;
            this.btAbrir_arquivo.Click += new System.EventHandler(this.btAbrir_arquivo_Click);
            // 
            // btSaldo_positivo
            // 
            this.btSaldo_positivo.Location = new System.Drawing.Point(175, 179);
            this.btSaldo_positivo.Name = "btSaldo_positivo";
            this.btSaldo_positivo.Size = new System.Drawing.Size(81, 36);
            this.btSaldo_positivo.TabIndex = 1;
            this.btSaldo_positivo.Text = "Saldo Positivo";
            this.btSaldo_positivo.UseVisualStyleBackColor = true;
            this.btSaldo_positivo.Click += new System.EventHandler(this.btSaldo_positivo_Click);
            // 
            // btSaldo_negativo
            // 
            this.btSaldo_negativo.Location = new System.Drawing.Point(285, 179);
            this.btSaldo_negativo.Name = "btSaldo_negativo";
            this.btSaldo_negativo.Size = new System.Drawing.Size(75, 36);
            this.btSaldo_negativo.TabIndex = 2;
            this.btSaldo_negativo.Text = "Saldo Negativo";
            this.btSaldo_negativo.UseVisualStyleBackColor = true;
            // 
            // btFechar_arquivo
            // 
            this.btFechar_arquivo.Location = new System.Drawing.Point(515, 179);
            this.btFechar_arquivo.Name = "btFechar_arquivo";
            this.btFechar_arquivo.Size = new System.Drawing.Size(75, 36);
            this.btFechar_arquivo.TabIndex = 3;
            this.btFechar_arquivo.Text = "Fechar Arquivo";
            this.btFechar_arquivo.UseVisualStyleBackColor = true;
            // 
            // btSaldo_nulo
            // 
            this.btSaldo_nulo.Location = new System.Drawing.Point(403, 179);
            this.btSaldo_nulo.Name = "btSaldo_nulo";
            this.btSaldo_nulo.Size = new System.Drawing.Size(75, 36);
            this.btSaldo_nulo.TabIndex = 4;
            this.btSaldo_nulo.Text = "Saldo Nulo";
            this.btSaldo_nulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 230);
            this.Controls.Add(this.btSaldo_nulo);
            this.Controls.Add(this.btFechar_arquivo);
            this.Controls.Add(this.btSaldo_negativo);
            this.Controls.Add(this.btSaldo_positivo);
            this.Controls.Add(this.btAbrir_arquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAbrir_arquivo;
        private System.Windows.Forms.Button btSaldo_positivo;
        private System.Windows.Forms.Button btSaldo_negativo;
        private System.Windows.Forms.Button btFechar_arquivo;
        private System.Windows.Forms.Button btSaldo_nulo;
    }
}

