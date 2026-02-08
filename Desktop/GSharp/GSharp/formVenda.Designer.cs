
namespace GSharp
{
    partial class formVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenda));
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQtdeItens = new System.Windows.Forms.TextBox();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.pnTituloVenda = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.gbPagamneto = new System.Windows.Forms.GroupBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFormaPagamento = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbvalordasparcelas = new System.Windows.Forms.Label();
            this.txtvalordasparcelas = new System.Windows.Forms.TextBox();
            this.cbforma_pagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btremove = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.txtparcelas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnTituloVenda.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbPagamneto.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvCliente);
            this.gbClientes.Controls.Add(this.txtPesqCliente);
            this.gbClientes.Controls.Add(this.btBuscaCliente);
            this.gbClientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.ForeColor = System.Drawing.Color.White;
            this.gbClientes.Location = new System.Drawing.Point(14, 146);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(4);
            this.gbClientes.Size = new System.Drawing.Size(647, 354);
            this.gbClientes.TabIndex = 212;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "* Pesquisa de Clientes:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(8, 78);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(636, 259);
            this.dgvCliente.TabIndex = 4;
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.Location = new System.Drawing.Point(8, 34);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(576, 27);
            this.txtPesqCliente.TabIndex = 1;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.Location = new System.Drawing.Point(590, 22);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(50, 47);
            this.btBuscaCliente.TabIndex = 3;
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(16, 141);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(122, 30);
            this.txtTotalVenda.TabIndex = 220;
            this.txtTotalVenda.TextChanged += new System.EventHandler(this.txtTotalVenda_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 219;
            this.label11.Text = "Total da Venda (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 218;
            this.label2.Text = "=";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(486, 52);
            this.txtTotalDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(90, 30);
            this.txtTotalDesconto.TabIndex = 217;
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Enabled = false;
            this.txtPercentualDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualDesconto.Location = new System.Drawing.Point(378, 51);
            this.txtPercentualDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentualDesconto.MaxLength = 3;
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(90, 30);
            this.txtPercentualDesconto.TabIndex = 216;
            this.txtPercentualDesconto.TextChanged += new System.EventHandler(this.txtPercentualDesconto_TextChanged);
            this.txtPercentualDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentualDesconto_KeyPress);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(167, 52);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(123, 30);
            this.txtValorTotal.TabIndex = 215;
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.Enabled = false;
            this.txtQtdeItens.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItens.Location = new System.Drawing.Point(16, 52);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.Size = new System.Drawing.Size(105, 30);
            this.txtQtdeItens.TabIndex = 214;
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQtdeEstoque.Location = new System.Drawing.Point(513, 47);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(110, 30);
            this.txtQtdeEstoque.TabIndex = 213;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtProduto.Location = new System.Drawing.Point(10, 47);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(496, 30);
            this.txtProduto.TabIndex = 211;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.dgvProduto);
            this.gbProdutos.Controls.Add(this.txtPesqProduto);
            this.gbProdutos.Controls.Add(this.btBuscaProduto);
            this.gbProdutos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProdutos.ForeColor = System.Drawing.Color.White;
            this.gbProdutos.Location = new System.Drawing.Point(14, 508);
            this.gbProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.gbProdutos.Size = new System.Drawing.Size(648, 271);
            this.gbProdutos.TabIndex = 210;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "* Pesquisa de Produtos:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dgvProduto.Location = new System.Drawing.Point(9, 79);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(632, 185);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.Location = new System.Drawing.Point(8, 34);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(577, 27);
            this.txtPesqProduto.TabIndex = 1;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.Location = new System.Drawing.Point(591, 21);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(50, 47);
            this.btBuscaProduto.TabIndex = 3;
            this.btBuscaProduto.UseVisualStyleBackColor = true;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFechaVenda.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(374, 121);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(202, 66);
            this.btFechaVenda.TabIndex = 209;
            this.btFechaVenda.Text = "       Fechar Venda";
            this.btFechaVenda.UseVisualStyleBackColor = true;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(411, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 23);
            this.label13.TabIndex = 208;
            this.label13.Text = "Desconto (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 207;
            this.label10.Text = "Valor Total (R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 206;
            this.label9.Text = "Qtde Itens:";
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.dgvItens);
            this.gbItensVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItensVenda.ForeColor = System.Drawing.Color.White;
            this.gbItensVenda.Location = new System.Drawing.Point(668, 63);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(590, 258);
            this.gbItensVenda.TabIndex = 205;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "* Itens da Venda:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(8, 29);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(575, 223);
            this.dgvItens.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(327, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 204;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(327, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(118, 30);
            this.txtTotal.TabIndex = 203;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(163, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 202;
            this.label6.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(163, 108);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(118, 30);
            this.txtValor.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 200;
            this.label5.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.White;
            this.txtQtde.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQtde.Location = new System.Drawing.Point(10, 108);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(106, 30);
            this.txtQtde.TabIndex = 199;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(513, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 198;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 197;
            this.label3.Text = "Produto";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFuncionario.Location = new System.Drawing.Point(8, 32);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(450, 27);
            this.cbFuncionario.TabIndex = 194;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // btRemover
            // 
            this.btRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(573, 96);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(51, 53);
            this.btRemover.TabIndex = 230;
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdicionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.Location = new System.Drawing.Point(513, 96);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(51, 53);
            this.btAdicionar.TabIndex = 229;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // pnTituloVenda
            // 
            this.pnTituloVenda.Controls.Add(this.btSair);
            this.pnTituloVenda.Controls.Add(this.lbTitulo);
            this.pnTituloVenda.Location = new System.Drawing.Point(14, 9);
            this.pnTituloVenda.Name = "pnTituloVenda";
            this.pnTituloVenda.Size = new System.Drawing.Size(1242, 47);
            this.pnTituloVenda.TabIndex = 231;
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(1198, -6);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(44, 57);
            this.btSair.TabIndex = 232;
            this.btSair.Text = "X";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(456, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(217, 36);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Venda  -  GSharp";
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbFuncionario.Location = new System.Drawing.Point(196, 63);
            this.gbFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Padding = new System.Windows.Forms.Padding(4);
            this.gbFuncionario.Size = new System.Drawing.Size(465, 82);
            this.gbFuncionario.TabIndex = 213;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "* Escolha o Funcionário:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDataVenda);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 63);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(173, 82);
            this.groupBox3.TabIndex = 214;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "* Data Venda:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BackColor = System.Drawing.Color.White;
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(15, 33);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(136, 27);
            this.txtDataVenda.TabIndex = 232;
            // 
            // gbPagamneto
            // 
            this.gbPagamneto.Controls.Add(this.txttroco);
            this.gbPagamneto.Controls.Add(this.label12);
            this.gbPagamneto.Controls.Add(this.txtValorTotal);
            this.gbPagamneto.Controls.Add(this.label10);
            this.gbPagamneto.Controls.Add(this.label13);
            this.gbPagamneto.Controls.Add(this.txtPercentualDesconto);
            this.gbPagamneto.Controls.Add(this.txtTotalDesconto);
            this.gbPagamneto.Controls.Add(this.txtQtdeItens);
            this.gbPagamneto.Controls.Add(this.txtTotalVenda);
            this.gbPagamneto.Controls.Add(this.label2);
            this.gbPagamneto.Controls.Add(this.btFechaVenda);
            this.gbPagamneto.Controls.Add(this.label11);
            this.gbPagamneto.Controls.Add(this.label9);
            this.gbPagamneto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagamneto.ForeColor = System.Drawing.Color.White;
            this.gbPagamneto.Location = new System.Drawing.Point(668, 751);
            this.gbPagamneto.Name = "gbPagamneto";
            this.gbPagamneto.Size = new System.Drawing.Size(590, 191);
            this.gbPagamneto.TabIndex = 206;
            this.gbPagamneto.TabStop = false;
            this.gbPagamneto.Text = "Resumo:";
            // 
            // txttroco
            // 
            this.txttroco.Enabled = false;
            this.txttroco.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(202, 141);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(121, 30);
            this.txttroco.TabIndex = 233;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(198, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 232;
            this.label12.Text = "Troco (R$)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtProduto);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtQtde);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btRemover);
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Controls.Add(this.btAdicionar);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.txtQtdeEstoque);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(14, 787);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(648, 155);
            this.groupBox5.TabIndex = 211;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "* Produto Selecionado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFormaPagamento);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(668, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 224);
            this.groupBox1.TabIndex = 206;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "* Detalhe de Pagamento";
            // 
            // dgvFormaPagamento
            // 
            this.dgvFormaPagamento.AllowUserToAddRows = false;
            this.dgvFormaPagamento.AllowUserToDeleteRows = false;
            this.dgvFormaPagamento.AllowUserToResizeColumns = false;
            this.dgvFormaPagamento.AllowUserToResizeRows = false;
            this.dgvFormaPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFormaPagamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPagamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFormaPagamento.Location = new System.Drawing.Point(8, 29);
            this.dgvFormaPagamento.MultiSelect = false;
            this.dgvFormaPagamento.Name = "dgvFormaPagamento";
            this.dgvFormaPagamento.ReadOnly = true;
            this.dgvFormaPagamento.RowHeadersVisible = false;
            this.dgvFormaPagamento.RowHeadersWidth = 51;
            this.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPagamento.Size = new System.Drawing.Size(571, 185);
            this.dgvFormaPagamento.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbvalordasparcelas);
            this.groupBox2.Controls.Add(this.txtvalordasparcelas);
            this.groupBox2.Controls.Add(this.cbforma_pagamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btremove);
            this.groupBox2.Controls.Add(this.btadd);
            this.groupBox2.Controls.Add(this.txtvalorpago);
            this.groupBox2.Controls.Add(this.txtparcelas);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(668, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(590, 186);
            this.groupBox2.TabIndex = 231;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "* Formas de Pagamento:";
            // 
            // lbvalordasparcelas
            // 
            this.lbvalordasparcelas.AutoSize = true;
            this.lbvalordasparcelas.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbvalordasparcelas.Location = new System.Drawing.Point(403, 26);
            this.lbvalordasparcelas.Name = "lbvalordasparcelas";
            this.lbvalordasparcelas.Size = new System.Drawing.Size(157, 23);
            this.lbvalordasparcelas.TabIndex = 232;
            this.lbvalordasparcelas.Text = "Valor das Parcelas:";
            // 
            // txtvalordasparcelas
            // 
            this.txtvalordasparcelas.BackColor = System.Drawing.SystemColors.Window;
            this.txtvalordasparcelas.Enabled = false;
            this.txtvalordasparcelas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordasparcelas.Location = new System.Drawing.Point(427, 51);
            this.txtvalordasparcelas.Name = "txtvalordasparcelas";
            this.txtvalordasparcelas.Size = new System.Drawing.Size(110, 27);
            this.txtvalordasparcelas.TabIndex = 233;
            // 
            // cbforma_pagamento
            // 
            this.cbforma_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbforma_pagamento.FormattingEnabled = true;
            this.cbforma_pagamento.Location = new System.Drawing.Point(17, 51);
            this.cbforma_pagamento.Name = "cbforma_pagamento";
            this.cbforma_pagamento.Size = new System.Drawing.Size(201, 30);
            this.cbforma_pagamento.TabIndex = 231;
            this.cbforma_pagamento.SelectedIndexChanged += new System.EventHandler(this.cbforma_pagamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 197;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(250, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 198;
            this.label8.Text = "Parcelas:";
            // 
            // btremove
            // 
            this.btremove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btremove.Image = ((System.Drawing.Image)(resources.GetObject("btremove.Image")));
            this.btremove.Location = new System.Drawing.Point(225, 115);
            this.btremove.Margin = new System.Windows.Forms.Padding(2);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(51, 53);
            this.btremove.TabIndex = 230;
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click_1);
            // 
            // btadd
            // 
            this.btadd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.Location = new System.Drawing.Point(166, 115);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(51, 53);
            this.btadd.TabIndex = 229;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.BackColor = System.Drawing.Color.White;
            this.txtvalorpago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorpago.Location = new System.Drawing.Point(19, 129);
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(118, 27);
            this.txtvalorpago.TabIndex = 203;
            this.txtvalorpago.TextChanged += new System.EventHandler(this.txtvalorpago_TextChanged);
            this.txtvalorpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorpago_KeyPress);
            // 
            // txtparcelas
            // 
            this.txtparcelas.BackColor = System.Drawing.SystemColors.Window;
            this.txtparcelas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparcelas.Location = new System.Drawing.Point(254, 51);
            this.txtparcelas.MaxLength = 2;
            this.txtparcelas.Name = "txtparcelas";
            this.txtparcelas.Size = new System.Drawing.Size(110, 27);
            this.txtparcelas.TabIndex = 213;
            this.txtparcelas.Click += new System.EventHandler(this.txtparcelas_Click);
            this.txtparcelas.TextChanged += new System.EventHandler(this.txtparcelas_TextChanged);
            this.txtparcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparcelas_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(15, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 23);
            this.label15.TabIndex = 204;
            this.label15.Text = "Total Pago:";
            // 
            // formVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1270, 997);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbPagamneto);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.pnTituloVenda);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.formVenda49_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gbItensVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnTituloVenda.ResumeLayout(false);
            this.pnTituloVenda.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbPagamneto.ResumeLayout(false);
            this.gbPagamneto.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQtdeItens;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Panel pnTituloVenda;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.GroupBox gbPagamneto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbforma_pagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtvalorpago;
        private System.Windows.Forms.TextBox txtparcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFormaPagamento;
        private System.Windows.Forms.Label lbvalordasparcelas;
        private System.Windows.Forms.TextBox txtvalordasparcelas;
    }
}