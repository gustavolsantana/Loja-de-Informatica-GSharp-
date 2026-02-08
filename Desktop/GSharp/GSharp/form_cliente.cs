using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSharp
{
    public partial class form_cliente : Form
    {

        //Atualizar/Excluir Funcionario
        public string tipo, estado, estado_civil, sexo;

        public DateTime data_cadastro;

        public form_cliente()
        {
            InitializeComponent();
        }

        public void CamposObrigatórios()
        {
            lbnome.ForeColor = Color.Red;
            lbcpf.ForeColor = Color.Red;
            lbdata_nascimento.ForeColor = Color.Red;
            lbsexo.ForeColor = Color.Red;
            lbestado_civil.ForeColor = Color.Red;
            lbcep.ForeColor = Color.Red;
            lbestado.ForeColor = Color.Red;
            lbcidade.ForeColor = Color.Red;
            lbbairro.ForeColor = Color.Red;
            lblogradouro.ForeColor = Color.Red;
            lbnumero.ForeColor = Color.Red;
            lbtelefone1.ForeColor = Color.Red;
            lbusuario.ForeColor = Color.Red;
            lbsenha.ForeColor = Color.Red;
            txtnome.Focus();
        }

        public void Limpar()
        {
            txtnome.Clear();
            txtnome_social.Clear();
            mbrg.Clear();
            mbcpf.Clear();
            mbdata_nascimento.Clear();
            cbsexo.SelectedIndex = -1;
            cbestado_civil.SelectedIndex = -1;

            mbcep.Clear();
            cbestado.SelectedIndex = -1;
            txtcidade.Clear();
            txtbairro.Clear();
            txtlogradouro.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            mbtelefone1.Clear();
            mbtelefone2.Clear();
            txtemail.Clear();
            txtusuario.Clear();
            txtsenha.Clear();
            txtid_cliente.Clear();
            mbdata_cadastro.Clear();
            checkbstatus.Checked = false;
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //Verificar campos obrigatórios
            if (txtnome.Text != "" && mbcpf.Text != "   .   .   -" && mbdata_nascimento.Text != "  /  /" && cbsexo.SelectedIndex != -1 && cbestado_civil.SelectedIndex != -1 && mbcep.Text != "     -" && cbestado.SelectedIndex != -1 && txtcidade.Text != "" && txtbairro.Text != "" && txtlogradouro.Text != "" && txtusuario.Text != "" && txtsenha.Text != "")
            {
                //Passar para as propriedades da classe clientes todos os dados preenchidos pelo usuario no formulário
                cCliente.nome = txtnome.Text;
                cCliente.nome_social = txtnome_social.Text;

                if (mbrg.Text != "  .   .   -")
                {
                    cCliente.rg = mbrg.Text;
                }
                else
                {
                    cCliente.rg = "";
                }

                cCliente.cpf = mbcpf.Text;
                cCliente.foto = "";
                cCliente.data_nascimento = Convert.ToDateTime(mbdata_nascimento.Text);

                //Combo box sexo
                if (cbsexo.SelectedIndex == 0)
                {
                    cCliente.sexo = "M";
                }
                else if (cbsexo.SelectedIndex == 1)
                {
                    cCliente.sexo = "F";
                }
                else
                {
                    cCliente.sexo = "N";
                }

                //Combo box estado_civil
                cCliente.estado_civil = cbestado_civil.SelectedItem.ToString();

                cCliente.cep = mbcep.Text;
                cCliente.estado = cbestado.SelectedItem.ToString();
                cCliente.cidade = txtcidade.Text;
                cCliente.bairro = txtbairro.Text;
                cCliente.endereco = txtlogradouro.Text;
                cCliente.numero = txtnumero.Text;
                cCliente.complemento = txtcomplemento.Text;
                cCliente.telefone1 = mbtelefone1.Text;

                //Telefone2 - não obrigatório
                if (mbtelefone2.Text != "(  )      -")
                {
                    cCliente.telefone2 = mbtelefone2.Text;
                }
                else
                {
                    cCliente.telefone2 = "";
                }

                cCliente.email = txtemail.Text;
                cCliente.usuario = txtusuario.Text;
                cCliente.senha = txtsenha.Text;

                //Chamar método cadastrar cliente - classe cliente
                int resp = cCliente.CadastrarCliente();

                //Se deu certo
                if (resp == 1)
                {
                    if (txtnome_social.Text != "")
                    {
                        MessageBox.Show(cCliente.nome_social + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show(cCliente.nome + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                else //Se deu erro
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatórios();
            }
        }

        private void form_cliente_Load(object sender, EventArgs e)
        {
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Feminino");
            cbsexo.Items.Add("Outro");
            cbsexo.SelectedIndex = -1;

            cbestado_civil.Items.Add("Solteiro(a)");
            cbestado_civil.Items.Add("Casado(a)");
            cbestado_civil.Items.Add("Separado(a)");
            cbestado_civil.Items.Add("Divorciado(a)");
            cbestado_civil.Items.Add("Viúvo(a)");
            cbestado_civil.SelectedIndex = -1;

            cbestado.Items.Add("AC");
            cbestado.Items.Add("AL");
            cbestado.Items.Add("AP");
            cbestado.Items.Add("AM");
            cbestado.Items.Add("BA");
            cbestado.Items.Add("CE");
            cbestado.Items.Add("DF");
            cbestado.Items.Add("ES");
            cbestado.Items.Add("GO");
            cbestado.Items.Add("MA");
            cbestado.Items.Add("MT");
            cbestado.Items.Add("MS");
            cbestado.Items.Add("MG");
            cbestado.Items.Add("PA");
            cbestado.Items.Add("PB");
            cbestado.Items.Add("PR");
            cbestado.Items.Add("PE");
            cbestado.Items.Add("PI");
            cbestado.Items.Add("RJ");
            cbestado.Items.Add("RN");
            cbestado.Items.Add("RS");
            cbestado.Items.Add("RO");
            cbestado.Items.Add("RR");
            cbestado.Items.Add("SC");
            cbestado.Items.Add("SP");
            cbestado.Items.Add("SE");
            cbestado.Items.Add("TO");
            cbestado.SelectedIndex = -1;

            //Verificar o modo de abertura do formulário - Atualização
            if (tipo == "Atualização")
            {
                lbcadastro_cliente.Text = "Atualização do Cliente";
                checkbstatus.Enabled = true;
                btconfirmar.Visible = false;
                btatualizar.Visible = true;

                //COMBO BOX (VARIÁVEL CRIADA PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIDO NA HORA DE CADASTRAR
                mbdata_cadastro.Text = data_cadastro.ToString();
                cbestado.SelectedItem = estado;
                cbestado_civil.SelectedItem = estado_civil;
                if (sexo == "M")
                {
                    cbsexo.SelectedItem = "Masculino";
                }
                else if (sexo == "F")
                {
                    cbsexo.SelectedItem = "Feminino";
                }
                else
                {
                    cbsexo.SelectedItem = "Outro";
                }
            }
            else
            {
                btatualizar.Visible = false;
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }

        private void mbdata_nascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mbdata_nascimento.Focus();
            }
        }

        private void mbrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mbcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mbcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mbtelefone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mbtelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            txtnome.MaxLength = 100;
        }

        private void txtnome_social_TextChanged(object sender, EventArgs e)
        {
            txtnome_social.MaxLength = 100;
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {
            txtcidade.MaxLength = 100;
        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {
            txtbairro.MaxLength = 100;
        }

        private void txtlogradouro_TextChanged(object sender, EventArgs e)
        {
            txtlogradouro.MaxLength = 100;
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtnumero.MaxLength = 10;
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //Verificar campos obrigatórios
            if (txtnome.Text != "" && mbcpf.Text != "   .   .   -" && mbdata_nascimento.Text != "  /  /" && cbsexo.SelectedIndex != -1 && cbestado_civil.SelectedIndex != -1 && mbcep.Text != "     -" && cbestado.SelectedIndex != -1 && txtcidade.Text != "" && txtbairro.Text != "" && txtlogradouro.Text != "" && txtusuario.Text != "" && txtsenha.Text != "")
            {
                //Passar para as propriedades da classe clientes todos os dados preenchidos pelo usuario no formulário
                cCliente.id_cliente = Convert.ToInt32(txtid_cliente.Text);
                cCliente.nome = txtnome.Text;
                cCliente.nome_social = txtnome_social.Text;

                if (mbrg.Text != "  .   .   -")
                {
                    cCliente.rg = mbrg.Text;
                }
                else
                {
                    cCliente.rg = "";
                }

                cCliente.cpf = mbcpf.Text;
                cCliente.foto = "";
                cCliente.data_nascimento = Convert.ToDateTime(mbdata_nascimento.Text);

                //Combo box sexo
                if (cbsexo.SelectedIndex == 0)
                {
                    cCliente.sexo = "M";
                }
                else if (cbsexo.SelectedIndex == 1)
                {
                    cCliente.sexo = "F";
                }
                else
                {
                    cCliente.sexo = "N";
                }

                //Combo box estado_civil
                cCliente.estado_civil = cbestado_civil.SelectedItem.ToString();

                cCliente.cep = mbcep.Text;
                cCliente.estado = cbestado.SelectedItem.ToString();
                cCliente.cidade = txtcidade.Text;
                cCliente.bairro = txtbairro.Text;
                cCliente.endereco = txtlogradouro.Text;
                cCliente.numero = txtnumero.Text;
                cCliente.complemento = txtcomplemento.Text;
                cCliente.telefone1 = mbtelefone1.Text;

                //Telefone2 - não obrigatório
                if (mbtelefone2.Text != "(  )      -")
                {
                    cCliente.telefone2 = mbtelefone2.Text;
                }
                else
                {
                    cCliente.telefone2 = "";
                }

                cCliente.email = txtemail.Text;
                cCliente.usuario = txtusuario.Text;
                cCliente.senha = txtsenha.Text;

                //Status
                cCliente.status = checkbstatus.Checked ? 1 : 0;

                //Chamar método cadastrar cliente - classe cliente
                int resp = cCliente.AtualizarCliente();

                //Se deu certo
                if (resp == 1)
                {
                    if (txtnome_social.Text != "")
                    {
                        MessageBox.Show(cCliente.nome_social + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show(cCliente.nome + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                else //Se deu erro
                {
                    MessageBox.Show("Erro ao Alterado Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatórios();
            }
        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {
            txtcomplemento.MaxLength = 100;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            txtemail.MaxLength = 100;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            txtusuario.MaxLength = 100;
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.MaxLength = 100;
        }
    }
}
