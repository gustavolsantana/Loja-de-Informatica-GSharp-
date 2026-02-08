namespace GSharp
{
    partial class form_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_funcionario));
            this.btcancelar = new System.Windows.Forms.Button();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcadastro_funcionario = new System.Windows.Forms.Label();
            this.txtnome_social = new System.Windows.Forms.TextBox();
            this.lbnome_social = new System.Windows.Forms.Label();
            this.lbrg = new System.Windows.Forms.Label();
            this.mbrg = new System.Windows.Forms.MaskedTextBox();
            this.mbcpf = new System.Windows.Forms.MaskedTextBox();
            this.lbcpf = new System.Windows.Forms.Label();
            this.mbdata_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbdata_nascimento = new System.Windows.Forms.Label();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.lbsexo = new System.Windows.Forms.Label();
            this.lbestado_civil = new System.Windows.Forms.Label();
            this.cbestado_civil = new System.Windows.Forms.ComboBox();
            this.lbsalario = new System.Windows.Forms.Label();
            this.mbcep = new System.Windows.Forms.MaskedTextBox();
            this.lbcep = new System.Windows.Forms.Label();
            this.lbestado = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lbcidade = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lbbairro = new System.Windows.Forms.Label();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.lblogradouro = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lbnumero = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lbcomplemento = new System.Windows.Forms.Label();
            this.mbtelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lbtelefone1 = new System.Windows.Forms.Label();
            this.mbtelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lbtelefone2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbtipo_acesso = new System.Windows.Forms.Label();
            this.cbtipo_acesso = new System.Windows.Forms.ComboBox();
            this.mbdata_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.lbdata_cadastro = new System.Windows.Forms.Label();
            this.checkbstatus = new System.Windows.Forms.CheckBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.gbinformacoes_pessoais = new System.Windows.Forms.GroupBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lbcargo = new System.Windows.Forms.Label();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.gbendereco = new System.Windows.Forms.GroupBox();
            this.gbcontato = new System.Windows.Forms.GroupBox();
            this.gbinformacoes_acesso = new System.Windows.Forms.GroupBox();
            this.txtid_funcionario = new System.Windows.Forms.TextBox();
            this.lbid_funcionario = new System.Windows.Forms.Label();
            this.btatualizar = new System.Windows.Forms.Button();
            this.gbinformacoes_pessoais.SuspendLayout();
            this.gbendereco.SuspendLayout();
            this.gbcontato.SuspendLayout();
            this.gbinformacoes_acesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btcancelar.Image")));
            this.btcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcancelar.Location = new System.Drawing.Point(496, 882);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(122, 43);
            this.btcancelar.TabIndex = 28;
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
            this.btconfirmar.Location = new System.Drawing.Point(263, 882);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(122, 43);
            this.btconfirmar.TabIndex = 27;
            this.btconfirmar.Text = "Cadastrar";
            this.btconfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btconfirmar.UseVisualStyleBackColor = false;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(16, 55);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(340, 26);
            this.txtnome.TabIndex = 22;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(12, 32);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(65, 20);
            this.lbnome.TabIndex = 17;
            this.lbnome.Text = "* Nome:";
            // 
            // lbcadastro_funcionario
            // 
            this.lbcadastro_funcionario.AutoSize = true;
            this.lbcadastro_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcadastro_funcionario.Location = new System.Drawing.Point(303, 36);
            this.lbcadastro_funcionario.Name = "lbcadastro_funcionario";
            this.lbcadastro_funcionario.Size = new System.Drawing.Size(315, 37);
            this.lbcadastro_funcionario.TabIndex = 16;
            this.lbcadastro_funcionario.Text = "Cadastro de Funcionário";
            // 
            // txtnome_social
            // 
            this.txtnome_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome_social.Location = new System.Drawing.Point(369, 55);
            this.txtnome_social.Name = "txtnome_social";
            this.txtnome_social.Size = new System.Drawing.Size(340, 26);
            this.txtnome_social.TabIndex = 30;
            this.txtnome_social.TextChanged += new System.EventHandler(this.txtnome_social_TextChanged);
            // 
            // lbnome_social
            // 
            this.lbnome_social.AutoSize = true;
            this.lbnome_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome_social.Location = new System.Drawing.Point(365, 32);
            this.lbnome_social.Name = "lbnome_social";
            this.lbnome_social.Size = new System.Drawing.Size(102, 20);
            this.lbnome_social.TabIndex = 29;
            this.lbnome_social.Text = "Nome Social:";
            // 
            // lbrg
            // 
            this.lbrg.AutoSize = true;
            this.lbrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrg.Location = new System.Drawing.Point(12, 89);
            this.lbrg.Name = "lbrg";
            this.lbrg.Size = new System.Drawing.Size(38, 20);
            this.lbrg.TabIndex = 31;
            this.lbrg.Text = "RG:";
            // 
            // mbrg
            // 
            this.mbrg.Location = new System.Drawing.Point(16, 112);
            this.mbrg.Mask = "99,999,999-9";
            this.mbrg.Name = "mbrg";
            this.mbrg.Size = new System.Drawing.Size(108, 26);
            this.mbrg.TabIndex = 34;
            this.mbrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbrg_KeyPress);
            // 
            // mbcpf
            // 
            this.mbcpf.Location = new System.Drawing.Point(150, 112);
            this.mbcpf.Mask = "000,000,000-00";
            this.mbcpf.Name = "mbcpf";
            this.mbcpf.Size = new System.Drawing.Size(131, 26);
            this.mbcpf.TabIndex = 36;
            this.mbcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbcpf_KeyPress);
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcpf.Location = new System.Drawing.Point(146, 89);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(54, 20);
            this.lbcpf.TabIndex = 35;
            this.lbcpf.Text = "* CPF:";
            // 
            // mbdata_nascimento
            // 
            this.mbdata_nascimento.Location = new System.Drawing.Point(346, 112);
            this.mbdata_nascimento.Mask = "00/00/0000";
            this.mbdata_nascimento.Name = "mbdata_nascimento";
            this.mbdata_nascimento.Size = new System.Drawing.Size(108, 26);
            this.mbdata_nascimento.TabIndex = 38;
            this.mbdata_nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbdata_nascimento.ValidatingType = typeof(System.DateTime);
            this.mbdata_nascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mbdata_nascimento_TypeValidationCompleted);
            // 
            // lbdata_nascimento
            // 
            this.lbdata_nascimento.AutoSize = true;
            this.lbdata_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata_nascimento.Location = new System.Drawing.Point(314, 89);
            this.lbdata_nascimento.Name = "lbdata_nascimento";
            this.lbdata_nascimento.Size = new System.Drawing.Size(168, 20);
            this.lbdata_nascimento.TabIndex = 37;
            this.lbdata_nascimento.Text = "* Data de Nascimento:";
            // 
            // cbsexo
            // 
            this.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Location = new System.Drawing.Point(528, 109);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(181, 28);
            this.cbsexo.TabIndex = 43;
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsexo.Location = new System.Drawing.Point(521, 89);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(59, 20);
            this.lbsexo.TabIndex = 44;
            this.lbsexo.Text = "* Sexo:";
            // 
            // lbestado_civil
            // 
            this.lbestado_civil.AutoSize = true;
            this.lbestado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado_civil.Location = new System.Drawing.Point(12, 151);
            this.lbestado_civil.Name = "lbestado_civil";
            this.lbestado_civil.Size = new System.Drawing.Size(105, 20);
            this.lbestado_civil.TabIndex = 46;
            this.lbestado_civil.Text = "* Estado Civil:";
            // 
            // cbestado_civil
            // 
            this.cbestado_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado_civil.FormattingEnabled = true;
            this.cbestado_civil.Location = new System.Drawing.Point(16, 174);
            this.cbestado_civil.Name = "cbestado_civil";
            this.cbestado_civil.Size = new System.Drawing.Size(181, 28);
            this.cbestado_civil.TabIndex = 45;
            // 
            // lbsalario
            // 
            this.lbsalario.AutoSize = true;
            this.lbsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsalario.Location = new System.Drawing.Point(314, 151);
            this.lbsalario.Name = "lbsalario";
            this.lbsalario.Size = new System.Drawing.Size(97, 20);
            this.lbsalario.TabIndex = 47;
            this.lbsalario.Text = "Salário (R$):";
            // 
            // mbcep
            // 
            this.mbcep.Location = new System.Drawing.Point(20, 57);
            this.mbcep.Mask = "00000-000";
            this.mbcep.Name = "mbcep";
            this.mbcep.Size = new System.Drawing.Size(94, 26);
            this.mbcep.TabIndex = 50;
            this.mbcep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbcep_KeyPress);
            // 
            // lbcep
            // 
            this.lbcep.AutoSize = true;
            this.lbcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcep.Location = new System.Drawing.Point(16, 32);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(55, 20);
            this.lbcep.TabIndex = 49;
            this.lbcep.Text = "* CEP:";
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.Location = new System.Drawing.Point(160, 32);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(74, 20);
            this.lbestado.TabIndex = 52;
            this.lbestado.Text = "* Estado:";
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Location = new System.Drawing.Point(164, 55);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(70, 28);
            this.cbestado.TabIndex = 51;
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(284, 57);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(215, 26);
            this.txtcidade.TabIndex = 54;
            this.txtcidade.TextChanged += new System.EventHandler(this.txtcidade_TextChanged);
            // 
            // lbcidade
            // 
            this.lbcidade.AutoSize = true;
            this.lbcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcidade.Location = new System.Drawing.Point(280, 32);
            this.lbcidade.Name = "lbcidade";
            this.lbcidade.Size = new System.Drawing.Size(73, 20);
            this.lbcidade.TabIndex = 53;
            this.lbcidade.Text = "* Cidade:";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(549, 57);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(159, 26);
            this.txtbairro.TabIndex = 56;
            this.txtbairro.TextChanged += new System.EventHandler(this.txtbairro_TextChanged);
            // 
            // lbbairro
            // 
            this.lbbairro.AutoSize = true;
            this.lbbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbairro.Location = new System.Drawing.Point(546, 32);
            this.lbbairro.Name = "lbbairro";
            this.lbbairro.Size = new System.Drawing.Size(65, 20);
            this.lbbairro.TabIndex = 55;
            this.lbbairro.Text = "* Bairro:";
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogradouro.Location = new System.Drawing.Point(16, 120);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(295, 26);
            this.txtlogradouro.TabIndex = 58;
            this.txtlogradouro.TextChanged += new System.EventHandler(this.txtlogradouro_TextChanged);
            // 
            // lblogradouro
            // 
            this.lblogradouro.AutoSize = true;
            this.lblogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogradouro.Location = new System.Drawing.Point(16, 97);
            this.lblogradouro.Name = "lblogradouro";
            this.lblogradouro.Size = new System.Drawing.Size(105, 20);
            this.lblogradouro.TabIndex = 57;
            this.lblogradouro.Text = "* Logradouro:";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(377, 120);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(75, 26);
            this.txtnumero.TabIndex = 60;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // lbnumero
            // 
            this.lbnumero.AutoSize = true;
            this.lbnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumero.Location = new System.Drawing.Point(373, 97);
            this.lbnumero.Name = "lbnumero";
            this.lbnumero.Size = new System.Drawing.Size(79, 20);
            this.lbnumero.TabIndex = 59;
            this.lbnumero.Text = "* Número:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.Location = new System.Drawing.Point(518, 120);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(191, 26);
            this.txtcomplemento.TabIndex = 62;
            this.txtcomplemento.TextChanged += new System.EventHandler(this.txtcomplemento_TextChanged);
            // 
            // lbcomplemento
            // 
            this.lbcomplemento.AutoSize = true;
            this.lbcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcomplemento.Location = new System.Drawing.Point(514, 97);
            this.lbcomplemento.Name = "lbcomplemento";
            this.lbcomplemento.Size = new System.Drawing.Size(112, 20);
            this.lbcomplemento.TabIndex = 61;
            this.lbcomplemento.Text = "Complemento:";
            // 
            // mbtelefone1
            // 
            this.mbtelefone1.Location = new System.Drawing.Point(16, 55);
            this.mbtelefone1.Mask = "(00) 00000-0000";
            this.mbtelefone1.Name = "mbtelefone1";
            this.mbtelefone1.Size = new System.Drawing.Size(131, 26);
            this.mbtelefone1.TabIndex = 64;
            this.mbtelefone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbtelefone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbtelefone1_KeyPress);
            // 
            // lbtelefone1
            // 
            this.lbtelefone1.AutoSize = true;
            this.lbtelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefone1.Location = new System.Drawing.Point(12, 32);
            this.lbtelefone1.Name = "lbtelefone1";
            this.lbtelefone1.Size = new System.Drawing.Size(98, 20);
            this.lbtelefone1.TabIndex = 63;
            this.lbtelefone1.Text = "* Telefone 1:";
            // 
            // mbtelefone2
            // 
            this.mbtelefone2.Location = new System.Drawing.Point(181, 55);
            this.mbtelefone2.Mask = "(99) 99999-9999";
            this.mbtelefone2.Name = "mbtelefone2";
            this.mbtelefone2.Size = new System.Drawing.Size(131, 26);
            this.mbtelefone2.TabIndex = 66;
            this.mbtelefone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbtelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mbtelefone2_KeyPress);
            // 
            // lbtelefone2
            // 
            this.lbtelefone2.AutoSize = true;
            this.lbtelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefone2.Location = new System.Drawing.Point(177, 32);
            this.lbtelefone2.Name = "lbtelefone2";
            this.lbtelefone2.Size = new System.Drawing.Size(88, 20);
            this.lbtelefone2.TabIndex = 65;
            this.lbtelefone2.Text = "Telefone 2:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(346, 55);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(363, 26);
            this.txtemail.TabIndex = 68;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(342, 32);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(57, 20);
            this.lbemail.TabIndex = 67;
            this.lbemail.Text = "E-Mail:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(16, 55);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(340, 26);
            this.txtusuario.TabIndex = 70;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(16, 32);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(78, 20);
            this.lbusuario.TabIndex = 69;
            this.lbusuario.Text = "* Usuário:";
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(369, 55);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(340, 26);
            this.txtsenha.TabIndex = 72;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.Location = new System.Drawing.Point(365, 32);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(70, 20);
            this.lbsenha.TabIndex = 71;
            this.lbsenha.Text = "* Senha:";
            // 
            // lbtipo_acesso
            // 
            this.lbtipo_acesso.AutoSize = true;
            this.lbtipo_acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtipo_acesso.Location = new System.Drawing.Point(16, 93);
            this.lbtipo_acesso.Name = "lbtipo_acesso";
            this.lbtipo_acesso.Size = new System.Drawing.Size(132, 20);
            this.lbtipo_acesso.TabIndex = 74;
            this.lbtipo_acesso.Text = "* Tipo de Acesso:";
            // 
            // cbtipo_acesso
            // 
            this.cbtipo_acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo_acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipo_acesso.FormattingEnabled = true;
            this.cbtipo_acesso.Location = new System.Drawing.Point(20, 116);
            this.cbtipo_acesso.Name = "cbtipo_acesso";
            this.cbtipo_acesso.Size = new System.Drawing.Size(161, 28);
            this.cbtipo_acesso.TabIndex = 73;
            // 
            // mbdata_cadastro
            // 
            this.mbdata_cadastro.Enabled = false;
            this.mbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbdata_cadastro.Location = new System.Drawing.Point(446, 116);
            this.mbdata_cadastro.Mask = "00/00/0000";
            this.mbdata_cadastro.Name = "mbdata_cadastro";
            this.mbdata_cadastro.Size = new System.Drawing.Size(105, 26);
            this.mbdata_cadastro.TabIndex = 76;
            this.mbdata_cadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mbdata_cadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lbdata_cadastro
            // 
            this.lbdata_cadastro.AutoSize = true;
            this.lbdata_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata_cadastro.Location = new System.Drawing.Point(429, 93);
            this.lbdata_cadastro.Name = "lbdata_cadastro";
            this.lbdata_cadastro.Size = new System.Drawing.Size(139, 20);
            this.lbdata_cadastro.TabIndex = 75;
            this.lbdata_cadastro.Text = "Data do Cadastro:";
            // 
            // checkbstatus
            // 
            this.checkbstatus.AutoSize = true;
            this.checkbstatus.Enabled = false;
            this.checkbstatus.ForeColor = System.Drawing.Color.White;
            this.checkbstatus.Location = new System.Drawing.Point(646, 120);
            this.checkbstatus.Name = "checkbstatus";
            this.checkbstatus.Size = new System.Drawing.Size(63, 24);
            this.checkbstatus.TabIndex = 78;
            this.checkbstatus.Text = "Ativo";
            this.checkbstatus.UseVisualStyleBackColor = true;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(642, 97);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(60, 20);
            this.lbstatus.TabIndex = 77;
            this.lbstatus.Text = "Status:";
            // 
            // gbinformacoes_pessoais
            // 
            this.gbinformacoes_pessoais.Controls.Add(this.txtsalario);
            this.gbinformacoes_pessoais.Controls.Add(this.lbcargo);
            this.gbinformacoes_pessoais.Controls.Add(this.cbcargo);
            this.gbinformacoes_pessoais.Controls.Add(this.lbnome);
            this.gbinformacoes_pessoais.Controls.Add(this.txtnome);
            this.gbinformacoes_pessoais.Controls.Add(this.lbnome_social);
            this.gbinformacoes_pessoais.Controls.Add(this.txtnome_social);
            this.gbinformacoes_pessoais.Controls.Add(this.lbrg);
            this.gbinformacoes_pessoais.Controls.Add(this.mbrg);
            this.gbinformacoes_pessoais.Controls.Add(this.lbcpf);
            this.gbinformacoes_pessoais.Controls.Add(this.mbcpf);
            this.gbinformacoes_pessoais.Controls.Add(this.lbdata_nascimento);
            this.gbinformacoes_pessoais.Controls.Add(this.mbdata_nascimento);
            this.gbinformacoes_pessoais.Controls.Add(this.lbsexo);
            this.gbinformacoes_pessoais.Controls.Add(this.cbsexo);
            this.gbinformacoes_pessoais.Controls.Add(this.lbestado_civil);
            this.gbinformacoes_pessoais.Controls.Add(this.cbestado_civil);
            this.gbinformacoes_pessoais.Controls.Add(this.lbsalario);
            this.gbinformacoes_pessoais.ForeColor = System.Drawing.Color.White;
            this.gbinformacoes_pessoais.Location = new System.Drawing.Point(82, 104);
            this.gbinformacoes_pessoais.Name = "gbinformacoes_pessoais";
            this.gbinformacoes_pessoais.Size = new System.Drawing.Size(723, 224);
            this.gbinformacoes_pessoais.TabIndex = 79;
            this.gbinformacoes_pessoais.TabStop = false;
            this.gbinformacoes_pessoais.Text = "Informações Pessoais:";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(318, 176);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(97, 26);
            this.txtsalario.TabIndex = 51;
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalario_KeyPress);
            // 
            // lbcargo
            // 
            this.lbcargo.AutoSize = true;
            this.lbcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcargo.Location = new System.Drawing.Point(524, 151);
            this.lbcargo.Name = "lbcargo";
            this.lbcargo.Size = new System.Drawing.Size(66, 20);
            this.lbcargo.TabIndex = 50;
            this.lbcargo.Text = "* Cargo:";
            // 
            // cbcargo
            // 
            this.cbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(528, 174);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(181, 28);
            this.cbcargo.TabIndex = 49;
            // 
            // gbendereco
            // 
            this.gbendereco.Controls.Add(this.cbestado);
            this.gbendereco.Controls.Add(this.lbcep);
            this.gbendereco.Controls.Add(this.mbcep);
            this.gbendereco.Controls.Add(this.lbestado);
            this.gbendereco.Controls.Add(this.txtcidade);
            this.gbendereco.Controls.Add(this.lbcidade);
            this.gbendereco.Controls.Add(this.txtbairro);
            this.gbendereco.Controls.Add(this.lbbairro);
            this.gbendereco.Controls.Add(this.lblogradouro);
            this.gbendereco.Controls.Add(this.txtlogradouro);
            this.gbendereco.Controls.Add(this.txtnumero);
            this.gbendereco.Controls.Add(this.lbnumero);
            this.gbendereco.Controls.Add(this.txtcomplemento);
            this.gbendereco.Controls.Add(this.lbcomplemento);
            this.gbendereco.ForeColor = System.Drawing.Color.White;
            this.gbendereco.Location = new System.Drawing.Point(82, 350);
            this.gbendereco.Name = "gbendereco";
            this.gbendereco.Size = new System.Drawing.Size(723, 167);
            this.gbendereco.TabIndex = 80;
            this.gbendereco.TabStop = false;
            this.gbendereco.Text = "Endereço:";
            // 
            // gbcontato
            // 
            this.gbcontato.Controls.Add(this.mbtelefone1);
            this.gbcontato.Controls.Add(this.lbtelefone1);
            this.gbcontato.Controls.Add(this.lbtelefone2);
            this.gbcontato.Controls.Add(this.mbtelefone2);
            this.gbcontato.Controls.Add(this.txtemail);
            this.gbcontato.Controls.Add(this.lbemail);
            this.gbcontato.ForeColor = System.Drawing.Color.White;
            this.gbcontato.Location = new System.Drawing.Point(82, 539);
            this.gbcontato.Name = "gbcontato";
            this.gbcontato.Size = new System.Drawing.Size(723, 100);
            this.gbcontato.TabIndex = 81;
            this.gbcontato.TabStop = false;
            this.gbcontato.Text = "Contato:";
            // 
            // gbinformacoes_acesso
            // 
            this.gbinformacoes_acesso.Controls.Add(this.txtid_funcionario);
            this.gbinformacoes_acesso.Controls.Add(this.lbid_funcionario);
            this.gbinformacoes_acesso.Controls.Add(this.lbusuario);
            this.gbinformacoes_acesso.Controls.Add(this.txtusuario);
            this.gbinformacoes_acesso.Controls.Add(this.lbsenha);
            this.gbinformacoes_acesso.Controls.Add(this.txtsenha);
            this.gbinformacoes_acesso.Controls.Add(this.checkbstatus);
            this.gbinformacoes_acesso.Controls.Add(this.lbtipo_acesso);
            this.gbinformacoes_acesso.Controls.Add(this.lbstatus);
            this.gbinformacoes_acesso.Controls.Add(this.cbtipo_acesso);
            this.gbinformacoes_acesso.Controls.Add(this.mbdata_cadastro);
            this.gbinformacoes_acesso.Controls.Add(this.lbdata_cadastro);
            this.gbinformacoes_acesso.ForeColor = System.Drawing.Color.White;
            this.gbinformacoes_acesso.Location = new System.Drawing.Point(82, 668);
            this.gbinformacoes_acesso.Name = "gbinformacoes_acesso";
            this.gbinformacoes_acesso.Size = new System.Drawing.Size(723, 166);
            this.gbinformacoes_acesso.TabIndex = 82;
            this.gbinformacoes_acesso.TabStop = false;
            this.gbinformacoes_acesso.Text = "Informações de Acesso:";
            // 
            // txtid_funcionario
            // 
            this.txtid_funcionario.Enabled = false;
            this.txtid_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_funcionario.Location = new System.Drawing.Point(267, 116);
            this.txtid_funcionario.Name = "txtid_funcionario";
            this.txtid_funcionario.Size = new System.Drawing.Size(99, 26);
            this.txtid_funcionario.TabIndex = 64;
            // 
            // lbid_funcionario
            // 
            this.lbid_funcionario.AutoSize = true;
            this.lbid_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid_funcionario.Location = new System.Drawing.Point(248, 93);
            this.lbid_funcionario.Name = "lbid_funcionario";
            this.lbid_funcionario.Size = new System.Drawing.Size(139, 20);
            this.lbid_funcionario.TabIndex = 63;
            this.lbid_funcionario.Text = "ID do Funcionário:";
            // 
            // btatualizar
            // 
            this.btatualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.ForeColor = System.Drawing.Color.White;
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(263, 882);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(122, 43);
            this.btatualizar.TabIndex = 83;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btatualizar.UseVisualStyleBackColor = false;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // form_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(900, 947);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.gbinformacoes_acesso);
            this.Controls.Add(this.gbcontato);
            this.Controls.Add(this.gbendereco);
            this.Controls.Add(this.gbinformacoes_pessoais);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.lbcadastro_funcionario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSharp";
            this.Load += new System.EventHandler(this.form_funcionario_Load);
            this.gbinformacoes_pessoais.ResumeLayout(false);
            this.gbinformacoes_pessoais.PerformLayout();
            this.gbendereco.ResumeLayout(false);
            this.gbendereco.PerformLayout();
            this.gbcontato.ResumeLayout(false);
            this.gbcontato.PerformLayout();
            this.gbinformacoes_acesso.ResumeLayout(false);
            this.gbinformacoes_acesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbcadastro_funcionario;
        public System.Windows.Forms.Button btatualizar;
        public System.Windows.Forms.Button btcancelar;
        public System.Windows.Forms.Button btconfirmar;
        public System.Windows.Forms.GroupBox gbinformacoes_pessoais;
        public System.Windows.Forms.GroupBox gbendereco;
        public System.Windows.Forms.GroupBox gbcontato;
        public System.Windows.Forms.GroupBox gbinformacoes_acesso;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.Label lbnome;
        public System.Windows.Forms.TextBox txtnome_social;
        public System.Windows.Forms.Label lbnome_social;
        public System.Windows.Forms.Label lbrg;
        public System.Windows.Forms.MaskedTextBox mbrg;
        public System.Windows.Forms.MaskedTextBox mbcpf;
        public System.Windows.Forms.Label lbcpf;
        public System.Windows.Forms.MaskedTextBox mbdata_nascimento;
        public System.Windows.Forms.Label lbdata_nascimento;
        public System.Windows.Forms.ComboBox cbsexo;
        public System.Windows.Forms.Label lbsexo;
        public System.Windows.Forms.Label lbestado_civil;
        public System.Windows.Forms.ComboBox cbestado_civil;
        public System.Windows.Forms.Label lbsalario;
        public System.Windows.Forms.MaskedTextBox mbcep;
        public System.Windows.Forms.Label lbcep;
        public System.Windows.Forms.Label lbestado;
        public System.Windows.Forms.ComboBox cbestado;
        public System.Windows.Forms.TextBox txtcidade;
        public System.Windows.Forms.Label lbcidade;
        public System.Windows.Forms.TextBox txtbairro;
        public System.Windows.Forms.Label lbbairro;
        public System.Windows.Forms.TextBox txtlogradouro;
        public System.Windows.Forms.Label lblogradouro;
        public System.Windows.Forms.TextBox txtnumero;
        public System.Windows.Forms.Label lbnumero;
        public System.Windows.Forms.TextBox txtcomplemento;
        public System.Windows.Forms.Label lbcomplemento;
        public System.Windows.Forms.MaskedTextBox mbtelefone1;
        public System.Windows.Forms.Label lbtelefone1;
        public System.Windows.Forms.MaskedTextBox mbtelefone2;
        public System.Windows.Forms.Label lbtelefone2;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.Label lbemail;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.Label lbusuario;
        public System.Windows.Forms.TextBox txtsenha;
        public System.Windows.Forms.Label lbsenha;
        public System.Windows.Forms.Label lbtipo_acesso;
        public System.Windows.Forms.ComboBox cbtipo_acesso;
        public System.Windows.Forms.MaskedTextBox mbdata_cadastro;
        public System.Windows.Forms.Label lbdata_cadastro;
        public System.Windows.Forms.CheckBox checkbstatus;
        public System.Windows.Forms.Label lbstatus;
        public System.Windows.Forms.TextBox txtid_funcionario;
        public System.Windows.Forms.Label lbid_funcionario;
        public System.Windows.Forms.Label lbcargo;
        public System.Windows.Forms.ComboBox cbcargo;
        public System.Windows.Forms.TextBox txtsalario;
    }
}