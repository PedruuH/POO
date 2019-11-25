namespace ProjetoFinal_POO
{
    partial class Alterações
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
            this.rbAlterar = new System.Windows.Forms.RadioButton();
            this.rbDeletar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDeletar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelFornecedor = new System.Windows.Forms.Button();
            this.btDelProd = new System.Windows.Forms.Button();
            this.btDelCliente = new System.Windows.Forms.Button();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.gbClienteAlt = new System.Windows.Forms.GroupBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAlterarCliente = new System.Windows.Forms.Button();
            this.gbProdutosAlt = new System.Windows.Forms.GroupBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btAlterarProd = new System.Windows.Forms.Button();
            this.gbFornecedorAlt = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btAlterarForn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDeletar.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            this.gbClienteAlt.SuspendLayout();
            this.gbProdutosAlt.SuspendLayout();
            this.gbFornecedorAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAlterar
            // 
            this.rbAlterar.AutoSize = true;
            this.rbAlterar.Location = new System.Drawing.Point(16, 19);
            this.rbAlterar.Name = "rbAlterar";
            this.rbAlterar.Size = new System.Drawing.Size(55, 17);
            this.rbAlterar.TabIndex = 0;
            this.rbAlterar.TabStop = true;
            this.rbAlterar.Text = "Alterar";
            this.rbAlterar.UseVisualStyleBackColor = true;
            this.rbAlterar.CheckedChanged += new System.EventHandler(this.rbAlterar_CheckedChanged);
            // 
            // rbDeletar
            // 
            this.rbDeletar.AutoSize = true;
            this.rbDeletar.Location = new System.Drawing.Point(16, 42);
            this.rbDeletar.Name = "rbDeletar";
            this.rbDeletar.Size = new System.Drawing.Size(59, 17);
            this.rbDeletar.TabIndex = 1;
            this.rbDeletar.TabStop = true;
            this.rbDeletar.Text = "Deletar";
            this.rbDeletar.UseVisualStyleBackColor = true;
            this.rbDeletar.CheckedChanged += new System.EventHandler(this.rbDeletar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlterar);
            this.groupBox1.Controls.Add(this.rbDeletar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o tipo de alteração";
            // 
            // gbDeletar
            // 
            this.gbDeletar.Controls.Add(this.label3);
            this.gbDeletar.Controls.Add(this.label2);
            this.gbDeletar.Controls.Add(this.label1);
            this.gbDeletar.Controls.Add(this.btDelFornecedor);
            this.gbDeletar.Controls.Add(this.btDelProd);
            this.gbDeletar.Controls.Add(this.btDelCliente);
            this.gbDeletar.Controls.Add(this.cbFornecedor);
            this.gbDeletar.Controls.Add(this.cbProdutos);
            this.gbDeletar.Controls.Add(this.cbClientes);
            this.gbDeletar.Location = new System.Drawing.Point(13, 88);
            this.gbDeletar.Name = "gbDeletar";
            this.gbDeletar.Size = new System.Drawing.Size(259, 207);
            this.gbDeletar.TabIndex = 3;
            this.gbDeletar.TabStop = false;
            this.gbDeletar.Text = "Deletar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // btDelFornecedor
            // 
            this.btDelFornecedor.Location = new System.Drawing.Point(169, 165);
            this.btDelFornecedor.Name = "btDelFornecedor";
            this.btDelFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btDelFornecedor.TabIndex = 5;
            this.btDelFornecedor.Text = "Deletar";
            this.btDelFornecedor.UseVisualStyleBackColor = true;
            this.btDelFornecedor.Click += new System.EventHandler(this.btDelFornecedor_Click);
            // 
            // btDelProd
            // 
            this.btDelProd.Location = new System.Drawing.Point(169, 103);
            this.btDelProd.Name = "btDelProd";
            this.btDelProd.Size = new System.Drawing.Size(75, 23);
            this.btDelProd.TabIndex = 4;
            this.btDelProd.Text = "Deletar";
            this.btDelProd.UseVisualStyleBackColor = true;
            this.btDelProd.Click += new System.EventHandler(this.btDelProd_Click);
            // 
            // btDelCliente
            // 
            this.btDelCliente.Location = new System.Drawing.Point(169, 45);
            this.btDelCliente.Name = "btDelCliente";
            this.btDelCliente.Size = new System.Drawing.Size(75, 23);
            this.btDelCliente.TabIndex = 3;
            this.btDelCliente.Text = "Deletar";
            this.btDelCliente.UseVisualStyleBackColor = true;
            this.btDelCliente.Click += new System.EventHandler(this.btDelCliente_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(15, 167);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbFornecedor.TabIndex = 2;
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(15, 105);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(121, 21);
            this.cbProdutos.TabIndex = 1;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(15, 47);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 0;
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.gbFornecedorAlt);
            this.gbAlterar.Controls.Add(this.gbProdutosAlt);
            this.gbAlterar.Controls.Add(this.gbClienteAlt);
            this.gbAlterar.Controls.Add(this.cbSelect);
            this.gbAlterar.Controls.Add(this.rbFornecedor);
            this.gbAlterar.Controls.Add(this.rbProduto);
            this.gbAlterar.Controls.Add(this.rbCliente);
            this.gbAlterar.Location = new System.Drawing.Point(12, 87);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(260, 385);
            this.gbAlterar.TabIndex = 4;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(56, 46);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 21);
            this.cbSelect.TabIndex = 3;
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(170, 16);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbFornecedor.TabIndex = 2;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbFornecedor_CheckedChanged);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(86, 16);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 1;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.rbProduto_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(7, 16);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // gbClienteAlt
            // 
            this.gbClienteAlt.Controls.Add(this.btAlterarCliente);
            this.gbClienteAlt.Controls.Add(this.tbTelefone);
            this.gbClienteAlt.Controls.Add(this.tbEndereco);
            this.gbClienteAlt.Controls.Add(this.tbCNPJ);
            this.gbClienteAlt.Controls.Add(this.tbNomeEmpresa);
            this.gbClienteAlt.Controls.Add(this.label5);
            this.gbClienteAlt.Controls.Add(this.label4);
            this.gbClienteAlt.Controls.Add(this.label6);
            this.gbClienteAlt.Controls.Add(this.label7);
            this.gbClienteAlt.Location = new System.Drawing.Point(16, 89);
            this.gbClienteAlt.Name = "gbClienteAlt";
            this.gbClienteAlt.Size = new System.Drawing.Size(214, 265);
            this.gbClienteAlt.TabIndex = 4;
            this.gbClienteAlt.TabStop = false;
            this.gbClienteAlt.Text = "Cliente";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(28, 178);
            this.tbTelefone.Mask = "(##) #####-####";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(104, 20);
            this.tbTelefone.TabIndex = 17;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(28, 129);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(154, 20);
            this.tbEndereco.TabIndex = 16;
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Location = new System.Drawing.Point(28, 80);
            this.tbCNPJ.Mask = "##.###.###/####-##";
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(120, 20);
            this.tbCNPJ.TabIndex = 15;
            // 
            // tbNomeEmpresa
            // 
            this.tbNomeEmpresa.Location = new System.Drawing.Point(28, 30);
            this.tbNomeEmpresa.Name = "tbNomeEmpresa";
            this.tbNomeEmpresa.Size = new System.Drawing.Size(120, 20);
            this.tbNomeEmpresa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome da Empresa:";
            // 
            // btAlterarCliente
            // 
            this.btAlterarCliente.Location = new System.Drawing.Point(73, 223);
            this.btAlterarCliente.Name = "btAlterarCliente";
            this.btAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCliente.TabIndex = 18;
            this.btAlterarCliente.Text = "Alterar";
            this.btAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // gbProdutosAlt
            // 
            this.gbProdutosAlt.Controls.Add(this.btAlterarProd);
            this.gbProdutosAlt.Controls.Add(this.tbValor);
            this.gbProdutosAlt.Controls.Add(this.tbCodProduto);
            this.gbProdutosAlt.Controls.Add(this.tbQuantidade);
            this.gbProdutosAlt.Controls.Add(this.tbNomeProduto);
            this.gbProdutosAlt.Controls.Add(this.comboBox1);
            this.gbProdutosAlt.Controls.Add(this.label8);
            this.gbProdutosAlt.Controls.Add(this.label9);
            this.gbProdutosAlt.Controls.Add(this.label10);
            this.gbProdutosAlt.Controls.Add(this.label11);
            this.gbProdutosAlt.Controls.Add(this.label12);
            this.gbProdutosAlt.Location = new System.Drawing.Point(16, 76);
            this.gbProdutosAlt.Name = "gbProdutosAlt";
            this.gbProdutosAlt.Size = new System.Drawing.Size(214, 288);
            this.gbProdutosAlt.TabIndex = 5;
            this.gbProdutosAlt.TabStop = false;
            this.gbProdutosAlt.Text = "Produtos";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(128, 142);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(46, 20);
            this.tbValor.TabIndex = 19;
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Location = new System.Drawing.Point(9, 92);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(129, 20);
            this.tbCodProduto.TabIndex = 18;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(10, 138);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(45, 20);
            this.tbQuantidade.TabIndex = 17;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(9, 44);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(170, 20);
            this.tbNomeProduto.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fornecedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Código do produto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nome do produto:";
            // 
            // btAlterarProd
            // 
            this.btAlterarProd.Location = new System.Drawing.Point(63, 249);
            this.btAlterarProd.Name = "btAlterarProd";
            this.btAlterarProd.Size = new System.Drawing.Size(75, 23);
            this.btAlterarProd.TabIndex = 20;
            this.btAlterarProd.Text = "Alterar";
            this.btAlterarProd.UseVisualStyleBackColor = true;
            // 
            // gbFornecedorAlt
            // 
            this.gbFornecedorAlt.Controls.Add(this.btAlterarForn);
            this.gbFornecedorAlt.Controls.Add(this.maskedTextBox1);
            this.gbFornecedorAlt.Controls.Add(this.maskedTextBox2);
            this.gbFornecedorAlt.Controls.Add(this.textBox1);
            this.gbFornecedorAlt.Controls.Add(this.label13);
            this.gbFornecedorAlt.Controls.Add(this.label14);
            this.gbFornecedorAlt.Controls.Add(this.label15);
            this.gbFornecedorAlt.Location = new System.Drawing.Point(16, 76);
            this.gbFornecedorAlt.Name = "gbFornecedorAlt";
            this.gbFornecedorAlt.Size = new System.Drawing.Size(229, 288);
            this.gbFornecedorAlt.TabIndex = 6;
            this.gbFornecedorAlt.TabStop = false;
            this.gbFornecedorAlt.Text = "Fornecedor";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 163);
            this.maskedTextBox1.Mask = "(##) #####-####";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(10, 99);
            this.maskedTextBox2.Mask = "##.###.###/####-##";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(204, 20);
            this.maskedTextBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telefone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "CNPJ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nome da Empresa:";
            // 
            // btAlterarForn
            // 
            this.btAlterarForn.Location = new System.Drawing.Point(73, 236);
            this.btAlterarForn.Name = "btAlterarForn";
            this.btAlterarForn.Size = new System.Drawing.Size(75, 23);
            this.btAlterarForn.TabIndex = 24;
            this.btAlterarForn.Text = "Alterar";
            this.btAlterarForn.UseVisualStyleBackColor = true;
            // 
            // Alterações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 503);
            this.Controls.Add(this.gbAlterar);
            this.Controls.Add(this.gbDeletar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alterações";
            this.Text = "Relatorio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDeletar.ResumeLayout(false);
            this.gbDeletar.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            this.gbClienteAlt.ResumeLayout(false);
            this.gbClienteAlt.PerformLayout();
            this.gbProdutosAlt.ResumeLayout(false);
            this.gbProdutosAlt.PerformLayout();
            this.gbFornecedorAlt.ResumeLayout(false);
            this.gbFornecedorAlt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAlterar;
        private System.Windows.Forms.RadioButton rbDeletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDeletar;
        private System.Windows.Forms.Button btDelFornecedor;
        private System.Windows.Forms.Button btDelProd;
        private System.Windows.Forms.Button btDelCliente;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.GroupBox gbClienteAlt;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.MaskedTextBox tbCNPJ;
        private System.Windows.Forms.TextBox tbNomeEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAlterarCliente;
        private System.Windows.Forms.GroupBox gbProdutosAlt;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btAlterarProd;
        private System.Windows.Forms.GroupBox gbFornecedorAlt;
        private System.Windows.Forms.Button btAlterarForn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}