namespace ProjetoFinal
{
    partial class Consultar
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
            this.tabConsulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmpregados = new System.Windows.Forms.DataGridView();
            this.btBuscarEmpregados = new System.Windows.Forms.Button();
            this.cbEmpregados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.btBuscarVendas = new System.Windows.Forms.Button();
            this.cbCorretores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dgvRenda = new System.Windows.Forms.DataGridView();
            this.btBuscarRenda = new System.Windows.Forms.Button();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabConsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "CONSULTAR";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabPage1);
            this.tabConsulta.Controls.Add(this.tabPage2);
            this.tabConsulta.Controls.Add(this.tabPage3);
            this.tabConsulta.Location = new System.Drawing.Point(12, 39);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.SelectedIndex = 0;
            this.tabConsulta.Size = new System.Drawing.Size(394, 307);
            this.tabConsulta.TabIndex = 10;
            this.tabConsulta.Click += new System.EventHandler(this.tabConsulta_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEmpregados);
            this.tabPage1.Controls.Add(this.btBuscarEmpregados);
            this.tabPage1.Controls.Add(this.cbEmpregados);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empregados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpregados
            // 
            this.dgvEmpregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregados.Location = new System.Drawing.Point(7, 56);
            this.dgvEmpregados.Name = "dgvEmpregados";
            this.dgvEmpregados.Size = new System.Drawing.Size(373, 219);
            this.dgvEmpregados.TabIndex = 38;
            // 
            // btBuscarEmpregados
            // 
            this.btBuscarEmpregados.Location = new System.Drawing.Point(294, 17);
            this.btBuscarEmpregados.Name = "btBuscarEmpregados";
            this.btBuscarEmpregados.Size = new System.Drawing.Size(75, 23);
            this.btBuscarEmpregados.TabIndex = 37;
            this.btBuscarEmpregados.Text = "BUSCAR";
            this.btBuscarEmpregados.UseVisualStyleBackColor = true;
            this.btBuscarEmpregados.Click += new System.EventHandler(this.btBuscarEmpregados_Click);
            // 
            // cbEmpregados
            // 
            this.cbEmpregados.FormattingEnabled = true;
            this.cbEmpregados.Location = new System.Drawing.Point(120, 19);
            this.cbEmpregados.Name = "cbEmpregados";
            this.cbEmpregados.Size = new System.Drawing.Size(168, 21);
            this.cbEmpregados.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "EMPREGADOS:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvVendas);
            this.tabPage2.Controls.Add(this.btBuscarVendas);
            this.tabPage2.Controls.Add(this.cbCorretores);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 49);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(374, 226);
            this.dgvVendas.TabIndex = 38;
            // 
            // btBuscarVendas
            // 
            this.btBuscarVendas.Location = new System.Drawing.Point(297, 20);
            this.btBuscarVendas.Name = "btBuscarVendas";
            this.btBuscarVendas.Size = new System.Drawing.Size(75, 23);
            this.btBuscarVendas.TabIndex = 37;
            this.btBuscarVendas.Text = "BUSCAR";
            this.btBuscarVendas.UseVisualStyleBackColor = true;
            this.btBuscarVendas.Click += new System.EventHandler(this.btBuscarVendas_Click);
            // 
            // cbCorretores
            // 
            this.cbCorretores.FormattingEnabled = true;
            this.cbCorretores.Location = new System.Drawing.Point(97, 22);
            this.cbCorretores.Name = "cbCorretores";
            this.cbCorretores.Size = new System.Drawing.Size(194, 21);
            this.cbCorretores.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "CORRETOR:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelTotal);
            this.tabPage3.Controls.Add(this.dgvRenda);
            this.tabPage3.Controls.Add(this.btBuscarRenda);
            this.tabPage3.Controls.Add(this.cbMeses);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(386, 281);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renda Mensal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(13, 251);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 17);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "TOTAL:";
            // 
            // dgvRenda
            // 
            this.dgvRenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenda.Location = new System.Drawing.Point(16, 57);
            this.dgvRenda.Name = "dgvRenda";
            this.dgvRenda.Size = new System.Drawing.Size(347, 176);
            this.dgvRenda.TabIndex = 35;
            // 
            // btBuscarRenda
            // 
            this.btBuscarRenda.Location = new System.Drawing.Point(288, 14);
            this.btBuscarRenda.Name = "btBuscarRenda";
            this.btBuscarRenda.Size = new System.Drawing.Size(75, 23);
            this.btBuscarRenda.TabIndex = 34;
            this.btBuscarRenda.Text = "BUSCAR";
            this.btBuscarRenda.UseVisualStyleBackColor = true;
            this.btBuscarRenda.Click += new System.EventHandler(this.btBuscarRenda_Click);
            // 
            // cbMeses
            // 
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Location = new System.Drawing.Point(53, 16);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(229, 21);
            this.cbMeses.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "MÊS:";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 358);
            this.Controls.Add(this.tabConsulta);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabConsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabConsulta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRenda;
        private System.Windows.Forms.Button btBuscarRenda;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btBuscarEmpregados;
        private System.Windows.Forms.ComboBox cbEmpregados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmpregados;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btBuscarVendas;
        private System.Windows.Forms.ComboBox cbCorretores;
        private System.Windows.Forms.Label label4;
    }
}