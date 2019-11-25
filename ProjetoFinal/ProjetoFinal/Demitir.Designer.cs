namespace ProjetoFinal
{
    partial class Demitir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCLT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDemitirCLT = new System.Windows.Forms.Button();
            this.btDemitirCorretores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCorretores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "DEMITIR UM CLT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "DEMITIR UM CORRETOR";
            // 
            // cbCLT
            // 
            this.cbCLT.FormattingEnabled = true;
            this.cbCLT.Location = new System.Drawing.Point(80, 39);
            this.cbCLT.Name = "cbCLT";
            this.cbCLT.Size = new System.Drawing.Size(239, 21);
            this.cbCLT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "NOME:";
            // 
            // btDemitirCLT
            // 
            this.btDemitirCLT.Location = new System.Drawing.Point(335, 37);
            this.btDemitirCLT.Name = "btDemitirCLT";
            this.btDemitirCLT.Size = new System.Drawing.Size(75, 23);
            this.btDemitirCLT.TabIndex = 13;
            this.btDemitirCLT.Text = "DEMITIR";
            this.btDemitirCLT.UseVisualStyleBackColor = true;
            this.btDemitirCLT.Click += new System.EventHandler(this.btDemitirCLT_Click);
            // 
            // btDemitirCorretores
            // 
            this.btDemitirCorretores.Location = new System.Drawing.Point(335, 107);
            this.btDemitirCorretores.Name = "btDemitirCorretores";
            this.btDemitirCorretores.Size = new System.Drawing.Size(75, 23);
            this.btDemitirCorretores.TabIndex = 16;
            this.btDemitirCorretores.Text = "DEMITIR";
            this.btDemitirCorretores.UseVisualStyleBackColor = true;
            this.btDemitirCorretores.Click += new System.EventHandler(this.btDemitirCorretores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "NOME:";
            // 
            // cbCorretores
            // 
            this.cbCorretores.FormattingEnabled = true;
            this.cbCorretores.Location = new System.Drawing.Point(80, 109);
            this.cbCorretores.Name = "cbCorretores";
            this.cbCorretores.Size = new System.Drawing.Size(239, 21);
            this.cbCorretores.TabIndex = 14;
            // 
            // Demitir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 171);
            this.Controls.Add(this.btDemitirCorretores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCorretores);
            this.Controls.Add(this.btDemitirCLT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Demitir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDemitirCLT;
        private System.Windows.Forms.Button btDemitirCorretores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCorretores;
    }
}