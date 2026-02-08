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
    public partial class form_funcionario : Form
    {
        //Atualizar/Excluir Funcionario
        public string tipo, estado, estado_civil, sexo;

        public int cargo, tipo_acesso;

        public DateTime data_cadastro;

        public form_funcionario()
        {
            InitializeComponent();
        }

        

        private void form_funcionario_Load(object sender, EventArgs e)
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

            cbtipo_acesso.Items.Add("Comum");
            cbtipo_acesso.Items.Add("Administrador(a)");

            //Cargo - alimentada pelo bd - tabela cargo
            classCargo cCargo = new classCargo();

            //Chamar o método que carrega a combo de cargo - classe cargo
            cbcargo.DataSource = cCargo.CarregarCargo();

            //O que será exibido na combo
            cbcargo.DisplayMember = "nome";

            //O que será armazenado no bd
            cbcargo.ValueMember = "id_cargo";

            //Não deixaar nenhum cargo pré-selecionado
            cbcargo.SelectedIndex = -1;

            //Verificar o modo de abertura do formulário - Atualização
            if (tipo == "Atualização")
            {
                lbcadastro_funcionario.Text = "Atualização do Funcionário";
                checkbstatus.Enabled = true;
                btconfirmar.Visible = false;

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
                cbcargo.SelectedValue = cargo;

                if (tipo_acesso == 0)
                {
                    cbtipo_acesso.SelectedItem = "Comum";
                }
                else
                {
                    cbtipo_acesso.SelectedItem = "Administrador(a)";
                }
            }
            else
            {
                btatualizar.Visible = false;
            }
        }

        private void txtlogradouro_TextChanged(object sender, EventArgs e)
        {
            txtlogradouro.MaxLength = 100;
        }

        //Método para pintar as labels de campos obrigatórios
        public void CamposObrigatórios()
        {
            lbnome.ForeColor = Color.Red;
            lbcpf.ForeColor = Color.Red;
            lbdata_nascimento.ForeColor = Color.Red;
            lbsexo.ForeColor = Color.Red;
            lbestado_civil.ForeColor = Color.Red;
            lbcargo.ForeColor = Color.Red;
            lbcep.ForeColor = Color.Red;
            lbestado.ForeColor = Color.Red;
            lbcidade.ForeColor = Color.Red;
            lbbairro.ForeColor = Color.Red;
            lblogradouro.ForeColor = Color.Red;
            lbnumero.ForeColor = Color.Red;
            lbtelefone1.ForeColor = Color.Red;
            lbusuario.ForeColor = Color.Red;
            lbsenha.ForeColor = Color.Red;
            lbtipo_acesso.ForeColor = Color.Red;
            txtnome.Focus();
        }

        //Método para limpar todas as caixinhas do formulário
        public void Limpar()
        {
            txtnome.Clear();
            txtnome_social.Clear();
            mbrg.Clear();
            mbcpf.Clear();
            mbdata_nascimento.Clear();
            cbsexo.SelectedIndex = -1;
            cbestado_civil.SelectedIndex = -1;
            txtsalario.Clear();
            cbcargo.SelectedIndex = -1;

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
            cbtipo_acesso.SelectedIndex = -1;
            txtid_funcionario.Clear();
            mbdata_cadastro.Clear();
            checkbstatus.Checked = false;
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //Verificar campos obrigatórios
            if (txtnome.Text != "" && mbcpf.Text != "   .   .   -" && mbdata_nascimento.Text != "  /  /" && cbsexo.SelectedIndex != -1 && cbestado_civil.SelectedIndex != -1 && mbcep.Text != "     -" && cbestado.SelectedIndex != -1 && txtcidade.Text != "" && txtbairro.Text != "" && txtlogradouro.Text != "" && txtusuario.Text != "" && txtsenha.Text != "" && cbtipo_acesso.SelectedIndex != -1)
            {
                //Passar para as propriedades da classe funcionário todos os dados preenchidos pelo usuario no formulário
                cFuncionario.nome = txtnome.Text;
                cFuncionario.nome_social = txtnome_social.Text;

                if (mbrg.Text != "  .   .   -")
                {
                    cFuncionario.rg = mbrg.Text;
                }
                else
                {
                    cFuncionario.rg = "";
                }
                
                cFuncionario.cpf = mbcpf.Text;
                cFuncionario.foto = "";
                cFuncionario.data_nascimento = Convert.ToDateTime(mbdata_nascimento.Text);

                //Combo box sexo
                if (cbsexo.SelectedIndex == 0)
                {
                    cFuncionario.sexo = "M";
                }
                else if (cbsexo.SelectedIndex == 1)
                {
                    cFuncionario.sexo = "F";
                }
                else
                {
                    cFuncionario.sexo = "N";
                }

                //Combo box estado_civil
                cFuncionario.estado_civil = cbestado_civil.SelectedItem.ToString();

                //Fazer if para não mandar vazio para o banco - o campo salário não é obrigatório no nosso sistema
                if (txtsalario.Text != "")
                {
                    cFuncionario.salario = Convert.ToDecimal(txtsalario.Text);
                }
                else
                {
                    cFuncionario.salario = 0;
                }

                cFuncionario.cep = mbcep.Text;
                cFuncionario.estado = cbestado.SelectedItem.ToString();
                cFuncionario.cidade = txtcidade.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.endereco = txtlogradouro.Text;
                cFuncionario.numero = txtnumero.Text;
                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.telefone1 = mbtelefone1.Text;

                //Telefone2 - não obrigatório
                if (mbtelefone2.Text != "(  )      -")
                {
                    cFuncionario.telefone2 = mbtelefone2.Text;
                }
                else
                {
                    cFuncionario.telefone2 = "";
                }

                cFuncionario.email = txtemail.Text;
                cFuncionario.usuario = txtusuario.Text;
                cFuncionario.senha = txtsenha.Text;

                //Tipo de acesso - 0 Comum - 1 Administrador
                cFuncionario.tipo_acesso = cbtipo_acesso.SelectedIndex;

                //ID cargo - chave estrangeira
                cFuncionario.id_cargo = Convert.ToInt32(cbcargo.SelectedValue);

                //Chamar método cadastrar funcionário - classe funcionário
                int resp = cFuncionario.CadastrarFuncionario();

                //Se deu certo
                if (resp == 1)
                {
                    if (txtnome_social.Text != "")
                    {
                        MessageBox.Show(cFuncionario.nome_social + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show(cFuncionario.nome + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                else //Se deu erro
                {
                    MessageBox.Show("Erro ao cadastrar Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatórios","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                CamposObrigatórios();

            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //Verificar campos obrigatórios
            if (txtnome.Text != "" && mbcpf.Text != "   .   .   -" && mbdata_nascimento.Text != "  /  /" && cbsexo.SelectedIndex != -1 && cbestado_civil.SelectedIndex != -1 && mbcep.Text != "     -" && cbestado.SelectedIndex != -1 && txtcidade.Text != "" && txtbairro.Text != "" && txtlogradouro.Text != "" && txtusuario.Text != "" && txtsenha.Text != "" && cbtipo_acesso.SelectedIndex != -1)
            {
                //Passar para as propriedades da classe funcionário todos os dados preenchidos pelo usuario no formulário
                cFuncionario.id_funcionario = Convert.ToInt32(txtid_funcionario.Text);
                cFuncionario.nome = txtnome.Text;
                cFuncionario.nome_social = txtnome_social.Text;

                if (mbrg.Text != "  .   .   -")
                {
                    cFuncionario.rg = mbrg.Text;
                }
                else
                {
                    cFuncionario.rg = "";
                }

                cFuncionario.cpf = mbcpf.Text;
                cFuncionario.foto = "";
                cFuncionario.data_nascimento = Convert.ToDateTime(mbdata_nascimento.Text);

                //Combo box sexo
                if (cbsexo.SelectedIndex == 0)
                {
                    cFuncionario.sexo = "M";
                }
                else if (cbsexo.SelectedIndex == 1)
                {
                    cFuncionario.sexo = "F";
                }
                else
                {
                    cFuncionario.sexo = "N";
                }

                //Combo box estado_civil
                cFuncionario.estado_civil = cbestado_civil.SelectedItem.ToString();

                //Fazer if para não mandar vazio para o banco - o campo salário não é obrigatório no nosso sistema
                if (txtsalario.Text != "")
                {
                    cFuncionario.salario = Convert.ToDecimal(txtsalario.Text);
                }
                else
                {
                    cFuncionario.salario = 0;
                }

                cFuncionario.cep = mbcep.Text;
                cFuncionario.estado = cbestado.SelectedItem.ToString();
                cFuncionario.cidade = txtcidade.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.endereco = txtlogradouro.Text;
                cFuncionario.numero = txtnumero.Text;
                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.telefone1 = mbtelefone1.Text;

                //Telefone2 - não obrigatório
                if (mbtelefone2.Text != "(  )      -")
                {
                    cFuncionario.telefone2 = mbtelefone2.Text;
                }
                else
                {
                    cFuncionario.telefone2 = "";
                }

                cFuncionario.email = txtemail.Text;
                cFuncionario.usuario = txtusuario.Text;
                cFuncionario.senha = txtsenha.Text;

                //Tipo de acesso - 0 Comum - 1 Administrador
                cFuncionario.tipo_acesso = cbtipo_acesso.SelectedIndex;

                //ID cargo - chave estrangeira
                cFuncionario.id_cargo = Convert.ToInt32(cbcargo.SelectedValue);

                //Status
                cFuncionario.status = checkbstatus.Checked ? 1 : 0;

                //Chamar método atualizar funcionário - classe funcionário
                int resp = cFuncionario.AtualizarFuncionario();

                //Se deu certo
                if (resp == 1)
                {
                    if (txtnome_social.Text != "")
                    {
                        MessageBox.Show(cFuncionario.nome_social + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(cFuncionario.nome + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else //Se deu erro
                {
                    MessageBox.Show("Erro ao Alterar Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatórios();

            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtnumero.MaxLength = 10;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            txtnome.MaxLength = 100;
        }

        private void txtnome_social_TextChanged(object sender, EventArgs e)
        {
            txtnome_social.MaxLength = 100;
        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {
            txtsalario.MaxLength = 9;
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {
            txtcidade.MaxLength = 100;
        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {
            txtbairro.MaxLength = 100;
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
