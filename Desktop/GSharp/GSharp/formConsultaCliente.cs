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
    public partial class formConsultaCliente : Form
    {
        public formConsultaCliente()
        {
            InitializeComponent();
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "CPF":

                    //Verificar se o usuario digitou o cpf
                    if (mskCpf.Text != "   .   .   -")
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteCPF(mskCpf.Text);
                    }
                    else
                    {
                        MessageBox.Show("Por gentileza, insira um CPF válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCPF.ForeColor = Color.Red;
                        mskCpf.Focus();
                    }

                    break;

                case "Sexo":

                    if (cbSexo.SelectedIndex == 0)
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexo("M");
                    }
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexo("F");
                    }
                    else
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexo("O");
                    }

                    break;

                case "Cidade":

                    dgvClientes.DataSource = cCliente.ConsultaClienteCidade(cbCidade.SelectedValue.ToString());

                    break;

                case "Data de Admissão":

                    dgvClientes.DataSource = cCliente.ConsultaClienteDataAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteStatus(1);
                    }
                    else
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteStatus(0);
                    }
                    break;

                case "Sexo e Cidade":
                    if (cbSexo.SelectedIndex == 0)
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexoCidade("M", cbCidade.SelectedValue.ToString());
                    }
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexoCidade("F", cbCidade.SelectedValue.ToString());
                    }
                    else
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteSexoCidade("O", cbCidade.SelectedValue.ToString());
                    }
                    break;

                default:
                    if (rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvClientes.DataSource = cCliente.ConsultaClienteNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvClientes.DataSource = cCliente.ConsultaClienteNomeContem(txtNome.Text);
                    }
                    break;
            }
        }

        private void formConsultaCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Data de Admissão");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Sexo e Cidade");

            cbOpcoes.SelectedIndex = 0;

            //COMBO SEXO
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Não Informado");

            cbSexo.SelectedIndex = 0;

            //COMBO CIDADE - ALIMENTADA PELA TABELA Clliente CAMPO CIDADE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.CarregarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;
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
                gbStatus.Enabled = false;
                mskCpf.Focus();
            }
            //Sexo
            if (cbOpcoes.SelectedIndex == 2)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Cidade
            if (cbOpcoes.SelectedIndex == 3)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Data de Admissão
            if (cbOpcoes.SelectedIndex == 4)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
            }
            //Status
            if (cbOpcoes.SelectedIndex == 5)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
            }
            //Sexo e Cidade
            if (cbOpcoes.SelectedIndex == 6)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classCliente cCliente = new classCliente();

                form_cliente fCliente = new form_cliente();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cCliente.ConsultaCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fCliente.txtnome.Text = cCliente.nome;
                fCliente.txtnome_social.Text = cCliente.nome_social;
                fCliente.mbrg.Text = cCliente.rg;
                fCliente.mbcpf.Text = cCliente.cpf;
                fCliente.mbdata_nascimento.Text = Convert.ToString(cCliente.data_nascimento);
                fCliente.sexo = cCliente.sexo;
                fCliente.estado_civil = cCliente.estado_civil;
                fCliente.mbcep.Text = cCliente.cep;
                fCliente.estado = cCliente.estado;
                fCliente.txtcidade.Text = cCliente.cidade;
                fCliente.txtbairro.Text = cCliente.bairro;
                fCliente.txtlogradouro.Text = cCliente.endereco;
                fCliente.txtnumero.Text = cCliente.numero;
                fCliente.txtcomplemento.Text = cCliente.complemento;
                fCliente.mbtelefone1.Text = cCliente.telefone1;
                fCliente.mbtelefone2.Text = cCliente.telefone2;
                fCliente.txtemail.Text = cCliente.email;
                fCliente.txtusuario.Text = cCliente.usuario;
                fCliente.txtsenha.Text = cCliente.senha;

                fCliente.txtid_cliente.Text = Convert.ToString(cCliente.id_cliente);
                fCliente.data_cadastro = cCliente.data_cadastro;
                if (cCliente.status == 1)
                {
                    fCliente.checkbstatus.Checked = true;
                }
                else
                {
                    fCliente.checkbstatus.Checked = false;
                }

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fCliente.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fCliente.ShowDialog();

                //ATUALIZAR A GRID DE CONSULTA
                btconsultar_Click(this, new EventArgs());

            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }
    }
}
