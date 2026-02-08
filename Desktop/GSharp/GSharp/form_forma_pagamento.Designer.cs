
namespace GSharp
{
    partial class form_forma_pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_forma_pagamento));
            this.btatualizar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.cbstatus = new System.Windows.Forms.CheckBox();
            this.mbdata_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.mbid_forma_pagamento = new System.Windows.Forms.MaskedTextBox();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.lbobservacao = new System.Windows.Forms.Label();
            this.lbid_forma_pagamento = new System.Windows.Forms.Label();
            this.lbdata_cadastro = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcadastro_forma_pagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btatualizar
            // 
            this.btatualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.ForeColor = System.Drawing.Color.White;
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(263, 458);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(122, 43);
            this.btatualizar.TabIndex = 98;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btatualizar.UseVisualStyleBackColor = false;
            this.btatualizar.Visible = false;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btcancelar.Image")));
            this.btcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcancelar.Location = new System.Drawing.Point(496, 458);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(122, 43);
            this.btcancelar.TabIndex = 97;
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
            this.btconfirmar.Location = new System.Drawing.Point(263, 458);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(122, 43);
            this.btconfirmar.TabIndex = 96;
            this.btconfirmar.Text = "Cadastrar";
            this.btconfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btconfirmar.UseVisualStyleBackColor = false;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // cbstatus
            // 
            this.cbstatus.AutoSize = true;
            this.cbstatus.Enabled = false;
            this.cbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbstatus.ForeColor = System.Drawing.Color.White;
            this.cbstatus.Location = new System.Drawing.Point(731, 382);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(63, 24);
            this.cbstatus.TabIndex = 95;
            this.cbstatus.Text = "Ativo";
            this.cbstatus.UseVisualStyleBackColor = true;
            // 
            // mbdata_cadastro
            // 
            this.mbdata_cadastro.Enabled = false;
            this.mbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbdata_cadastro.Location = new System.Drawing.Point(404, 383);
            this.mbdata_cadastro.Mask = "00/00/0000";
            this.mbdata_cadastro.Name = "mbdata_cadastro";
            this.mbdata_cadastro.Size = new System.Drawing.Size(105, 26);
            this.mbdata_cadastro.TabIndex = 94;
            this.mbdata_cadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbdata_cadastro.ValidatingType = typeof(System.DateTime);
            // 
            // mbid_forma_pagamento
            // 
            this.mbid_forma_pagamento.Enabled = false;
            this.mbid_forma_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbid_forma_pagamento.Location = new System.Drawing.Point(117, 380);
            this.mbid_forma_pagamento.Name = "mbid_forma_pagamento";
            this.mbid_forma_pagamento.Size = new System.Drawing.Size(94, 26);
            this.mbid_forma_pagamento.TabIndex = 93;
            // 
            // txtobservacao
            // 
            this.txtobservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacao.Location = new System.Drawing.Point(89, 229);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(705, 95);
            this.txtobservacao.TabIndex = 92;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(89, 139);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(705, 26);
            this.txtnome.TabIndex = 91;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(727, 360);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(60, 20);
            this.lbstatus.TabIndex = 90;
            this.lbstatus.Text = "Status:";
            // 
            // lbobservacao
            // 
            this.lbobservacao.AutoSize = true;
            this.lbobservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbobservacao.Location = new System.Drawing.Point(85, 205);
            this.lbobservacao.Name = "lbobservacao";
            this.lbobservacao.Size = new System.Drawing.Size(98, 20);
            this.lbobservacao.TabIndex = 89;
            this.lbobservacao.Text = "Observação:";
            // 
            // lbid_forma_pagamento
            // 
            this.lbid_forma_pagamento.AutoSize = true;
            this.lbid_forma_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid_forma_pagamento.Location = new System.Drawing.Point(85, 357);
            this.lbid_forma_pagamento.Name = "lbid_forma_pagamento";
            this.lbid_forma_pagamento.Size = new System.Drawing.Size(166, 20);
            this.lbid_forma_pagamento.TabIndex = 88;
            this.lbid_forma_pagamento.Text = "ID Forma Pagamento:";
            // 
            // lbdata_cadastro
            // 
            this.lbdata_cadastro.AutoSize = true;
            this.lbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata_cadastro.Location = new System.Drawing.Point(387, 360);
            this.lbdata_cadastro.Name = "lbdata_cadastro";
            this.lbdata_cadastro.Size = new System.Drawing.Size(139, 20);
            this.lbdata_cadastro.TabIndex = 87;
            this.lbdata_cadastro.Text = "Data do Cadastro:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(85, 115);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(65, 20);
            this.lbnome.TabIndex = 86;
            this.lbnome.Text = "* Nome:";
            // 
            // lbcadastro_forma_pagamento
            // 
            this.lbcadastro_forma_pagamento.AutoSize = true;
            this.lbcadastro_forma_pagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcadastro_forma_pagamento.Location = new System.Drawing.Point(243, 20);
            this.lbcadastro_forma_pagamento.Name = "lbcadastro_forma_pagamento";
            this.lbcadastro_forma_pagamento.Size = new System.Drawing.Size(431, 37);
            this.lbcadastro_forma_pagamento.TabIndex = 85;
            this.lbcadastro_forma_pagamento.Text = "Cadastro de Forma de Pagamento";
            // 
            // form_forma_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.mbdata_cadastro);
            this.Controls.Add(this.mbid_forma_pagamento);
            this.Controls.Add(this.txtobservacao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.lbobservacao);
            this.Controls.Add(this.lbid_forma_pagamento);
            this.Controls.Add(this.lbdata_cadastro);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbcadastro_forma_pagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_forma_pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_forma_pagamento";
            this.Load += new System.EventHandler(this.form_forma_pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btconfirmar;
        public System.Windows.Forms.CheckBox cbstatus;
        public System.Windows.Forms.MaskedTextBox mbdata_cadastro;
        public System.Windows.Forms.MaskedTextBox mbid_forma_pagamento;
        public System.Windows.Forms.TextBox txtobservacao;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.Label lbstatus;
        public System.Windows.Forms.Label lbobservacao;
        public System.Windows.Forms.Label lbid_forma_pagamento;
        public System.Windows.Forms.Label lbdata_cadastro;
        public System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbcadastro_forma_pagamento;
    }
}