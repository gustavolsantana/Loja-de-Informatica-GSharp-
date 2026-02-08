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
    public partial class formConsultaFuncionario : Form
    {
        public formConsultaFuncionario()
        {
            InitializeComponent();        }

        private void formConsultaFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Cargo");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Data de Admissão");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Sexo e Cidade");
            cbOpcoes.Items.Add("Cidade e Cargo");

            cbOpcoes.SelectedIndex = 0;

            //COMBO SEXO
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Não Informado");

            cbSexo.SelectedIndex = 0;

            //Cargo - alimentada pelo bd - tabela cargo
            classCargo cCargo = new classCargo();

            //Chamar o método que carrega a combo de cargo - classe cargo
            cbCargo.DataSource = cCargo.CarregarCargo();

            //O que será exibido na combo
            cbCargo.DisplayMember = "nome";

            //O que será armazenado no bd
            cbCargo.ValueMember = "id_cargo";

            //Não deixaar nenhum cargo pré-selecionado
            cbCargo.SelectedIndex = 0;

            //COMBO CIDADE - ALIMENTADA PELA TABELA FUNCIONARIO CAMPO CIDADE
            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.CarregarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;
        }

        private void gbOpcao_Enter(object sender, EventArgs e)
        {

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilitar/Desabilitar componentes do form de acordo com a escolha do usuario
            //Nome
            if (cbOpcoes.SelectedIndex == 0)
            {
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
                txtNome.Focus();
            }
            //CPF
            if (cbOpcoes.SelectedIndex == 1)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
                mskCpf.Focus();
            }
            //Cargo
            if (cbOpcoes.SelectedIndex == 2)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = true;
                gbStatus.Enabled = false;
            }
            //Sexo
            if (cbOpcoes.SelectedIndex == 3)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Cidade
            if (cbOpcoes.SelectedIndex == 4)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Data de Admissão
            if (cbOpcoes.SelectedIndex == 5)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Status
            if (cbOpcoes.SelectedIndex == 6)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = true;
            }
            //Sexo e Cidade
            if (cbOpcoes.SelectedIndex == 7)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Cidade e Cargo
            if (cbOpcoes.SelectedIndex == 8)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = true;
                gbStatus.Enabled = false;
            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair da consulta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "CPF":

                    //Verificar se o usuario digitou o cpf
                    if (mskCpf.Text != "   .   .   -")
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioCPF(mskCpf.Text);
                    }
                    else
                    {
                        MessageBox.Show("Por gentileza, insira um CPF válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCPF.ForeColor = Color.Red;
                        mskCpf.Focus();
                    }

                    break;
                case "Cargo":

                    dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioCargo(Convert.ToInt32(cbCargo.SelectedValue));

                    break;

                case "Sexo":

                    if (cbSexo.SelectedIndex == 0)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexo("M");
                    }
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexo("F");
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexo("O");
                    }

                    break;

                case "Cidade":

                    dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioCidade(cbCidade.SelectedValue.ToString());

                    break;

                case "Data de Admissão":

                    dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioDataAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                    break;

                case "Status":
                    if(rbAtivo.Checked == true)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioStatus(1);
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioStatus(0);
                    }
                    break;

                case "Sexo e Cidade":
                    if (cbSexo.SelectedIndex == 0)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexoCidade("M", cbCidade.SelectedValue.ToString());
                    }
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexoCidade("F", cbCidade.SelectedValue.ToString());
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioSexoCidade("O", cbCidade.SelectedValue.ToString());
                    }
                    break;

                case "Cidade e Cargo":
                    dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioCidadeCargo(cbCidade.SelectedValue.ToString(), Convert.ToInt32(cbCargo.SelectedValue));
                    break;


                default:
                    if(rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsultaFuncionarioNomeContem(txtNome.Text);
                    }
                    break;
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar este funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classFuncionario cFuncionario = new classFuncionario();

                form_funcionario fFuncionario = new form_funcionario();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cFuncionario.ConsultaFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fFuncionario.txtnome.Text = cFuncionario.nome;
                fFuncionario.txtnome_social.Text = cFuncionario.nome_social;
                fFuncionario.mbrg.Text = cFuncionario.rg;
                fFuncionario.mbcpf.Text = cFuncionario.cpf;
                fFuncionario.mbdata_nascimento.Text = Convert.ToString(cFuncionario.data_nascimento);
                fFuncionario.sexo = cFuncionario.sexo;
                fFuncionario.estado_civil = cFuncionario.estado_civil;
                fFuncionario.txtsalario.Text = Convert.ToString(cFuncionario.salario);
                fFuncionario.cargo = cFuncionario.id_cargo;
                fFuncionario.mbcep.Text = cFuncionario.cep;
                fFuncionario.estado = cFuncionario.estado;
                fFuncionario.txtcidade.Text = cFuncionario.cidade;
                fFuncionario.txtbairro.Text = cFuncionario.bairro;
                fFuncionario.txtlogradouro.Text = cFuncionario.endereco;
                fFuncionario.txtnumero.Text = cFuncionario.numero;
                fFuncionario.txtcomplemento.Text = cFuncionario.complemento;
                fFuncionario.mbtelefone1.Text = cFuncionario.telefone1;
                fFuncionario.mbtelefone2.Text = cFuncionario.telefone2;
                fFuncionario.txtemail.Text = cFuncionario.email;
                fFuncionario.txtusuario.Text = cFuncionario.usuario;
                fFuncionario.txtsenha.Text = cFuncionario.senha;
                if (cFuncionario.tipo_acesso == 0)
                {
                    fFuncionario.tipo_acesso = 0;
                }
                else
                {
                    fFuncionario.tipo_acesso = 1;
                }
                fFuncionario.txtid_funcionario.Text = cFuncionario.id_funcionario.ToString();
                fFuncionario.data_cadastro = cFuncionario.data_cadastro;
                if (cFuncionario.status == 1)
                {
                    fFuncionario.checkbstatus.Checked = true;
                }
                else
                {
                    fFuncionario.checkbstatus.Checked = false;
                }

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fFuncionario.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fFuncionario.ShowDialog();

                //ATUALIZAR A GRID DE CONSULTA
                btconsultar_Click(this, new EventArgs());

            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
