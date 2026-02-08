
namespace GSharp
{
    partial class form_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_produto));
            this.btcancelar = new System.Windows.Forms.Button();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.lbcadastro_produto = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbdescricao = new System.Windows.Forms.Label();
            this.txtid_produto = new System.Windows.Forms.TextBox();
            this.lbid_produto = new System.Windows.Forms.Label();
            this.checkbstatus = new System.Windows.Forms.CheckBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.mbdata_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.lbdata_cadastro = new System.Windows.Forms.Label();
            this.lbestoque = new System.Windows.Forms.Label();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.lbpreco_custo = new System.Windows.Forms.Label();
            this.txtpreco_custo = new System.Windows.Forms.TextBox();
            this.lbpercentual_lucro = new System.Windows.Forms.Label();
            this.txtpercentual_lucro = new System.Windows.Forms.TextBox();
            this.lbpreco_venda = new System.Windows.Forms.Label();
            this.txtpreco_venda = new System.Windows.Forms.TextBox();
            this.gbpreco = new System.Windows.Forms.GroupBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.lbdesconto = new System.Windows.Forms.Label();
            this.txtpreco_promocao = new System.Windows.Forms.TextBox();
            this.lbpreco_promocao = new System.Windows.Forms.Label();
            this.checkbstatus_promocao = new System.Windows.Forms.CheckBox();
            this.lbstatus_promocao = new System.Windows.Forms.Label();
            this.lbcategoria = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.lbmarca = new System.Windows.Forms.Label();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.btatualizar = new System.Windows.Forms.Button();
            this.gbpreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btcancelar.Image")));
            this.btcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcancelar.Location = new System.Drawing.Point(496, 799);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(122, 43);
            this.btcancelar.TabIndex = 85;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btconfirmar
            // 
            this.btconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btconfirmar.Image")));
            this.btconfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btconfirmar.Location = new System.Drawing.Point(263, 799);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(122, 43);
            this.btconfirmar.TabIndex = 84;
            this.btconfirmar.Text = "Cadastrar";
            this.btconfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btconfirmar.UseVisualStyleBackColor = false;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // lbcadastro_produto
            // 
            this.lbcadastro_produto.AutoSize = true;
            this.lbcadastro_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcadastro_produto.Location = new System.Drawing.Point(303, 36);
            this.lbcadastro_produto.Name = "lbcadastro_produto";
            this.lbcadastro_produto.Size = new System.Drawing.Size(277, 37);
            this.lbcadastro_produto.TabIndex = 83;
            this.lbcadastro_produto.Text = "Cadastro de Produto:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(94, 136);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(65, 20);
            this.lbnome.TabIndex = 79;
            this.lbnome.Text = "* Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(98, 159);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(693, 26);
            this.txtnome.TabIndex = 80;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(98, 240);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(693, 95);
            this.txtdescricao.TabIndex = 91;
            this.txtdescricao.TextChanged += new System.EventHandler(this.txtdescricao_TextChanged);
            // 
            // lbdescricao
            // 
            this.lbdescricao.AutoSize = true;
            this.lbdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescricao.Location = new System.Drawing.Point(94, 216);
            this.lbdescricao.Name = "lbdescricao";
            this.lbdescricao.Size = new System.Drawing.Size(84, 20);
            this.lbdescricao.TabIndex = 90;
            this.lbdescricao.Text = "Descrição:";
            // 
            // txtid_produto
            // 
            this.txtid_produto.Enabled = false;
            this.txtid_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_produto.Location = new System.Drawing.Point(110, 713);
            this.txtid_produto.Name = "txtid_produto";
            this.txtid_produto.Size = new System.Drawing.Size(99, 26);
            this.txtid_produto.TabIndex = 93;
            // 
            // lbid_produto
            // 
            this.lbid_produto.AutoSize = true;
            this.lbid_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid_produto.Location = new System.Drawing.Point(106, 690);
            this.lbid_produto.Name = "lbid_produto";
            this.lbid_produto.Size = new System.Drawing.Size(112, 20);
            this.lbid_produto.TabIndex = 92;
            this.lbid_produto.Text = "ID do Produto:";
            // 
            // checkbstatus
            // 
            this.checkbstatus.AutoSize = true;
            this.checkbstatus.Enabled = false;
            this.checkbstatus.ForeColor = System.Drawing.Color.White;
            this.checkbstatus.Location = new System.Drawing.Point(728, 717);
            this.checkbstatus.Name = "checkbstatus";
            this.checkbstatus.Size = new System.Drawing.Size(63, 24);
            this.checkbstatus.TabIndex = 97;
            this.checkbstatus.Text = "Ativo";
            this.checkbstatus.UseVisualStyleBackColor = true;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(724, 690);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(60, 20);
            this.lbstatus.TabIndex = 96;
            this.lbstatus.Text = "Status:";
            // 
            // mbdata_cadastro
            // 
            this.mbdata_cadastro.Enabled = false;
            this.mbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbdata_cadastro.Location = new System.Drawing.Point(410, 713);
            this.mbdata_cadastro.Mask = "00/00/0000";
            this.mbdata_cadastro.Name = "mbdata_cadastro";
            this.mbdata_cadastro.Size = new System.Drawing.Size(105, 26);
            this.mbdata_cadastro.TabIndex = 95;
            this.mbdata_cadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbdata_cadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lbdata_cadastro
            // 
            this.lbdata_cadastro.AutoSize = true;
            this.lbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata_cadastro.Location = new System.Drawing.Point(392, 690);
            this.lbdata_cadastro.Name = "lbdata_cadastro";
            this.lbdata_cadastro.Size = new System.Drawing.Size(139, 20);
            this.lbdata_cadastro.TabIndex = 94;
            this.lbdata_cadastro.Text = "Data do Cadastro:";
            // 
            // lbestoque
            // 
            this.lbestoque.AutoSize = true;
            this.lbestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestoque.Location = new System.Drawing.Point(673, 371);
            this.lbestoque.Name = "lbestoque";
            this.lbestoque.Size = new System.Drawing.Size(83, 20);
            this.lbestoque.TabIndex = 98;
            this.lbestoque.Text = "* Estoque:";
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(680, 396);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(111, 26);
            this.txtestoque.TabIndex = 99;
            this.txtestoque.TextChanged += new System.EventHandler(this.txtestoque_TextChanged);
            this.txtestoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestoque_KeyPress);
            // 
            // lbpreco_custo
            // 
            this.lbpreco_custo.AutoSize = true;
            this.lbpreco_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpreco_custo.Location = new System.Drawing.Point(12, 38);
            this.lbpreco_custo.Name = "lbpreco_custo";
            this.lbpreco_custo.Size = new System.Drawing.Size(110, 20);
            this.lbpreco_custo.TabIndex = 100;
            this.lbpreco_custo.Text = "* Preço Custo:";
            // 
            // txtpreco_custo
            // 
            this.txtpreco_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco_custo.Location = new System.Drawing.Point(16, 63);
            this.txtpreco_custo.Name = "txtpreco_custo";
            this.txtpreco_custo.Size = new System.Drawing.Size(152, 26);
            this.txtpreco_custo.TabIndex = 101;
            this.txtpreco_custo.TextChanged += new System.EventHandler(this.txtpreco_custo_TextChanged);
            this.txtpreco_custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_custo_KeyPress);
            // 
            // lbpercentual_lucro
            // 
            this.lbpercentual_lucro.AutoSize = true;
            this.lbpercentual_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpercentual_lucro.Location = new System.Drawing.Point(265, 38);
            this.lbpercentual_lucro.Name = "lbpercentual_lucro";
            this.lbpercentual_lucro.Size = new System.Drawing.Size(87, 20);
            this.lbpercentual_lucro.TabIndex = 102;
            this.lbpercentual_lucro.Text = "* Lucro(%):";
            // 
            // txtpercentual_lucro
            // 
            this.txtpercentual_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpercentual_lucro.Location = new System.Drawing.Point(269, 63);
            this.txtpercentual_lucro.Name = "txtpercentual_lucro";
            this.txtpercentual_lucro.Size = new System.Drawing.Size(152, 26);
            this.txtpercentual_lucro.TabIndex = 103;
            this.txtpercentual_lucro.TextChanged += new System.EventHandler(this.txtpercentual_lucro_TextChanged);
            this.txtpercentual_lucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpercentual_lucro_KeyPress);
            // 
            // lbpreco_venda
            // 
            this.lbpreco_venda.AutoSize = true;
            this.lbpreco_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpreco_venda.Location = new System.Drawing.Point(518, 38);
            this.lbpreco_venda.Name = "lbpreco_venda";
            this.lbpreco_venda.Size = new System.Drawing.Size(105, 20);
            this.lbpreco_venda.TabIndex = 104;
            this.lbpreco_venda.Text = "Preço Venda:";
            // 
            // txtpreco_venda
            // 
            this.txtpreco_venda.Enabled = false;
            this.txtpreco_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco_venda.Location = new System.Drawing.Point(522, 63);
            this.txtpreco_venda.Name = "txtpreco_venda";
            this.txtpreco_venda.Size = new System.Drawing.Size(153, 26);
            this.txtpreco_venda.TabIndex = 105;
            this.txtpreco_venda.TextChanged += new System.EventHandler(this.txtpreco_venda_TextChanged);
            this.txtpreco_venda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_venda_KeyPress);
            // 
            // gbpreco
            // 
            this.gbpreco.Controls.Add(this.txtdesconto);
            this.gbpreco.Controls.Add(this.lbpreco_custo);
            this.gbpreco.Controls.Add(this.txtpreco_custo);
            this.gbpreco.Controls.Add(this.lbdesconto);
            this.gbpreco.Controls.Add(this.txtpercentual_lucro);
            this.gbpreco.Controls.Add(this.txtpreco_promocao);
            this.gbpreco.Controls.Add(this.lbpreco_venda);
            this.gbpreco.Controls.Add(this.lbpercentual_lucro);
            this.gbpreco.Controls.Add(this.lbpreco_promocao);
            this.gbpreco.Controls.Add(this.txtpreco_venda);
            this.gbpreco.Controls.Add(this.checkbstatus_promocao);
            this.gbpreco.Controls.Add(this.lbstatus_promocao);
            this.gbpreco.ForeColor = System.Drawing.Color.White;
            this.gbpreco.Location = new System.Drawing.Point(98, 462);
            this.gbpreco.Name = "gbpreco";
            this.gbpreco.Size = new System.Drawing.Size(693, 206);
            this.gbpreco.TabIndex = 110;
            this.gbpreco.TabStop = false;
            this.gbpreco.Text = "Preço:";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Enabled = false;
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(269, 152);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(152, 26);
            this.txtdesconto.TabIndex = 110;
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            this.txtdesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesconto_KeyPress);
            // 
            // lbdesconto
            // 
            this.lbdesconto.AutoSize = true;
            this.lbdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdesconto.Location = new System.Drawing.Point(265, 129);
            this.lbdesconto.Name = "lbdesconto";
            this.lbdesconto.Size = new System.Drawing.Size(106, 20);
            this.lbdesconto.TabIndex = 111;
            this.lbdesconto.Text = "Desconto(%):";
            // 
            // txtpreco_promocao
            // 
            this.txtpreco_promocao.Enabled = false;
            this.txtpreco_promocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco_promocao.Location = new System.Drawing.Point(522, 153);
            this.txtpreco_promocao.Name = "txtpreco_promocao";
            this.txtpreco_promocao.Size = new System.Drawing.Size(152, 26);
            this.txtpreco_promocao.TabIndex = 106;
            this.txtpreco_promocao.TextChanged += new System.EventHandler(this.txtpreco_promocao_TextChanged);
            this.txtpreco_promocao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_promocao_KeyPress);
            // 
            // lbpreco_promocao
            // 
            this.lbpreco_promocao.AutoSize = true;
            this.lbpreco_promocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpreco_promocao.Location = new System.Drawing.Point(518, 129);
            this.lbpreco_promocao.Name = "lbpreco_promocao";
            this.lbpreco_promocao.Size = new System.Drawing.Size(161, 20);
            this.lbpreco_promocao.TabIndex = 106;
            this.lbpreco_promocao.Text = "Preço com Desconto:";
            // 
            // checkbstatus_promocao
            // 
            this.checkbstatus_promocao.AutoSize = true;
            this.checkbstatus_promocao.ForeColor = System.Drawing.Color.White;
            this.checkbstatus_promocao.Location = new System.Drawing.Point(55, 155);
            this.checkbstatus_promocao.Name = "checkbstatus_promocao";
            this.checkbstatus_promocao.Size = new System.Drawing.Size(63, 24);
            this.checkbstatus_promocao.TabIndex = 109;
            this.checkbstatus_promocao.Text = "Ativo";
            this.checkbstatus_promocao.UseVisualStyleBackColor = true;
            this.checkbstatus_promocao.CheckedChanged += new System.EventHandler(this.checkbstatus_promocao_CheckedChanged);
            // 
            // lbstatus_promocao
            // 
            this.lbstatus_promocao.AutoSize = true;
            this.lbstatus_promocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus_promocao.Location = new System.Drawing.Point(25, 129);
            this.lbstatus_promocao.Name = "lbstatus_promocao";
            this.lbstatus_promocao.Size = new System.Drawing.Size(136, 20);
            this.lbstatus_promocao.TabIndex = 108;
            this.lbstatus_promocao.Text = "Status Promoção:";
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategoria.Location = new System.Drawing.Point(385, 371);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(92, 20);
            this.lbcategoria.TabIndex = 112;
            this.lbcategoria.Text = "* Categoria:";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(389, 396);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(229, 28);
            this.cbcategoria.TabIndex = 111;
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmarca.Location = new System.Drawing.Point(94, 371);
            this.lbmarca.Name = "lbmarca";
            this.lbmarca.Size = new System.Drawing.Size(67, 20);
            this.lbmarca.TabIndex = 114;
            this.lbmarca.Text = "* Marca:";
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(98, 396);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(229, 28);
            this.cbmarca.TabIndex = 113;
            // 
            // btatualizar
            // 
            this.btatualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.ForeColor = System.Drawing.Color.White;
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(263, 799);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(122, 43);
            this.btatualizar.TabIndex = 115;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btatualizar.UseVisualStyleBackColor = false;
            this.btatualizar.Visible = false;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // form_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(900, 904);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.lbcategoria);
            this.Controls.Add(this.lbestoque);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.gbpreco);
            this.Controls.Add(this.txtestoque);
            this.Controls.Add(this.txtid_produto);
            this.Controls.Add(this.lbid_produto);
            this.Controls.Add(this.checkbstatus);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.mbdata_cadastro);
            this.Controls.Add(this.lbdata_cadastro);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbdescricao);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.lbcadastro_produto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_produto";
            this.Load += new System.EventHandler(this.form_produto_Load);
            this.gbpreco.ResumeLayout(false);
            this.gbpreco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btconfirmar;
        private System.Windows.Forms.Label lbcadastro_produto;
        private System.Windows.Forms.GroupBox gbpreco;
        public System.Windows.Forms.Button btatualizar;
        public System.Windows.Forms.Label lbnome;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.TextBox txtdescricao;
        public System.Windows.Forms.Label lbdescricao;
        public System.Windows.Forms.TextBox txtid_produto;
        public System.Windows.Forms.Label lbid_produto;
        public System.Windows.Forms.CheckBox checkbstatus;
        public System.Windows.Forms.Label lbstatus;
        public System.Windows.Forms.MaskedTextBox mbdata_cadastro;
        public System.Windows.Forms.Label lbdata_cadastro;
        public System.Windows.Forms.Label lbestoque;
        public System.Windows.Forms.TextBox txtestoque;
        public System.Windows.Forms.Label lbpreco_custo;
        public System.Windows.Forms.TextBox txtpreco_custo;
        public System.Windows.Forms.Label lbpercentual_lucro;
        public System.Windows.Forms.TextBox txtpercentual_lucro;
        public System.Windows.Forms.Label lbpreco_venda;
        public System.Windows.Forms.TextBox txtpreco_venda;
        public System.Windows.Forms.Label lbcategoria;
        public System.Windows.Forms.ComboBox cbcategoria;
        public System.Windows.Forms.Label lbmarca;
        public System.Windows.Forms.ComboBox cbmarca;
        public System.Windows.Forms.Label lbstatus_promocao;
        public System.Windows.Forms.CheckBox checkbstatus_promocao;
        public System.Windows.Forms.Label lbpreco_promocao;
        public System.Windows.Forms.TextBox txtpreco_promocao;
        public System.Windows.Forms.TextBox txtdesconto;
        public System.Windows.Forms.Label lbdesconto;
    }
}