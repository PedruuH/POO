namespace wfaMediaAritimetica
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
            this.lbNum_1 = new System.Windows.Forms.Label();
            this.lbNum_2 = new System.Windows.Forms.Label();
            this.lbMedia = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum_1
            // 
            this.lbNum_1.AutoSize = true;
            this.lbNum_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum_1.Location = new System.Drawing.Point(13, 36);
            this.lbNum_1.Name = "lbNum_1";
            this.lbNum_1.Size = new System.Drawing.Size(82, 20);
            this.lbNum_1.TabIndex = 0;
            this.lbNum_1.Text = "Número 1:";
            // 
            // lbNum_2
            // 
            this.lbNum_2.AutoSize = true;
            this.lbNum_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum_2.Location = new System.Drawing.Point(13, 97);
            this.lbNum_2.Name = "lbNum_2";
            this.lbNum_2.Size = new System.Drawing.Size(82, 20);
            this.lbNum_2.TabIndex = 1;
            this.lbNum_2.Text = "Número 2:";
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedia.Location = new System.Drawing.Point(16, 166);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(56, 20);
            this.lbMedia.TabIndex = 2;
            this.lbMedia.Text = "Média:";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(111, 38);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 20);
            this.tbNum1.TabIndex = 3;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(111, 99);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 20);
            this.tbNum2.TabIndex = 4;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(107, 166);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 20);
            this.lbResult.TabIndex = 5;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(197, 207);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.lbNum_2);
            this.Controls.Add(this.lbNum_1);
            this.Name = "Form1";
            this.Text = "Média Aritimética";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum_1;
        private System.Windows.Forms.Label lbNum_2;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btOk;
    }
}

