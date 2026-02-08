namespace GSharp
{
    partial class form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.menu_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.AutoSize = false;
            this.menu_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.menu_principal.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_principal.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrar,
            this.menu_consulta,
            this.menu_relatorios,
            this.menu_vendas,
            this.sairToolStripMenuItem});
            this.menu_principal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu_principal.Location = new System.Drawing.Point(54, 163);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(0);
            this.menu_principal.Size = new System.Drawing.Size(204, 260);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_principal_ItemClicked);
            // 
            // menu_cadastrar
            // 
            this.menu_cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrar_cargo,
            this.cadastrar_funcionario,
            this.cadastrar_cliente,
            this.cadastrar_marca,
            this.cadastrar_categoria,
            this.cadastrar_produto,
            this.formaDePagamentoToolStripMenuItem});
            this.menu_cadastrar.ForeColor = System.Drawing.Color.White;
            this.menu_cadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.menu_cadastrar.Name = "menu_cadastrar";
            this.menu_cadastrar.Padding = new System.Windows.Forms.Padding(0);
            this.menu_cadastrar.Size = new System.Drawing.Size(193, 41);
            this.menu_cadastrar.Text = "Cadastrar";
            this.menu_cadastrar.Click += new System.EventHandler(this.menu_cadastro_Click);
            // 
            // cadastrar_cargo
            // 
            this.cadastrar_cargo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar_cargo.Name = "cadastrar_cargo";
            this.cadastrar_cargo.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_cargo.Text = "Cargo";
            this.cadastrar_cargo.Click += new System.EventHandler(this.cadastrar_cargo_Click);
            // 
            // cadastrar_funcionario
            // 
            this.cadastrar_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar_funcionario.Name = "cadastrar_funcionario";
            this.cadastrar_funcionario.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_funcionario.Text = "Funcionário";
            this.cadastrar_funcionario.Click += new System.EventHandler(this.cadastrar_funcionario_Click);
            // 
            // cadastrar_cliente
            // 
            this.cadastrar_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrar_cliente.Name = "cadastrar_cliente";
            this.cadastrar_cliente.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_cliente.Text = "Cliente";
            this.cadastrar_cliente.Click += new System.EventHandler(this.cadastrar_cliente_Click);
            // 
            // cadastrar_marca
            // 
            this.cadastrar_marca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrar_marca.Name = "cadastrar_marca";
            this.cadastrar_marca.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_marca.Text = "Marca";
            this.cadastrar_marca.Click += new System.EventHandler(this.cadastrar_marca_Click);
            // 
            // cadastrar_categoria
            // 
            this.cadastrar_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrar_categoria.Name = "cadastrar_categoria";
            this.cadastrar_categoria.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_categoria.Text = "Categoria";
            this.cadastrar_categoria.Click += new System.EventHandler(this.cadastrar_categoria_Click);
            // 
            // cadastrar_produto
            // 
            this.cadastrar_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrar_produto.Name = "cadastrar_produto";
            this.cadastrar_produto.Size = new System.Drawing.Size(243, 26);
            this.cadastrar_produto.Text = "Produto";
            this.cadastrar_produto.Click += new System.EventHandler(this.cadastrar_produto_Click);
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            this.formaDePagamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            this.formaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento";
            this.formaDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagamentoToolStripMenuItem_Click);
            // 
            // menu_consulta
            // 
            this.menu_consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.cargoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.formaDePagamentoToolStripMenuItem1});
            this.menu_consulta.ForeColor = System.Drawing.Color.White;
            this.menu_consulta.Margin = new System.Windows.Forms.Padding(5);
            this.menu_consulta.Name = "menu_consulta";
            this.menu_consulta.Padding = new System.Windows.Forms.Padding(0);
            this.menu_consulta.Size = new System.Drawing.Size(193, 41);
            this.menu_consulta.Text = "Consultar";
            this.menu_consulta.Click += new System.EventHandler(this.menu_consulta_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // formaDePagamentoToolStripMenuItem1
            // 
            this.formaDePagamentoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.formaDePagamentoToolStripMenuItem1.Name = "formaDePagamentoToolStripMenuItem1";
            this.formaDePagamentoToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.formaDePagamentoToolStripMenuItem1.Text = "Forma de Pagamento";
            this.formaDePagamentoToolStripMenuItem1.Click += new System.EventHandler(this.formaDePagamentoToolStripMenuItem1_Click);
            // 
            // menu_relatorios
            // 
            this.menu_relatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menu_relatorios.ForeColor = System.Drawing.Color.White;
            this.menu_relatorios.Margin = new System.Windows.Forms.Padding(5);
            this.menu_relatorios.Name = "menu_relatorios";
            this.menu_relatorios.Padding = new System.Windows.Forms.Padding(0);
            this.menu_relatorios.Size = new System.Drawing.Size(193, 41);
            this.menu_relatorios.Text = "Relatórios";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // menu_vendas
            // 
            this.menu_vendas.ForeColor = System.Drawing.Color.White;
            this.menu_vendas.Margin = new System.Windows.Forms.Padding(5);
            this.menu_vendas.Name = "menu_vendas";
            this.menu_vendas.Padding = new System.Windows.Forms.Padding(0);
            this.menu_vendas.Size = new System.Drawing.Size(193, 41);
            this.menu_vendas.Text = "Vendas";
            this.menu_vendas.Click += new System.EventHandler(this.menu_vendas_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(203, 41);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1333, 1061);
            this.Controls.Add(this.menu_principal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_principal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_principal";
            this.Text = "GSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem menu_consulta;
        private System.Windows.Forms.ToolStripMenuItem menu_relatorios;
        private System.Windows.Forms.ToolStripMenuItem menu_vendas;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_cargo;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_funcionario;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_cliente;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_marca;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_categoria;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_produto;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}

