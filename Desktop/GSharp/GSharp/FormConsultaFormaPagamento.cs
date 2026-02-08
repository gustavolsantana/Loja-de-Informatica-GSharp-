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
    public partial class FormConsultaFormaPagamento : Form
    {
        public FormConsultaFormaPagamento()
        {
            InitializeComponent();
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            classFormaPagamento cFormaPagamento = new classFormaPagamento();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvFormaPagamento.DataSource = cFormaPagamento.ConsultaFormaPagamentoStatus(1);
                    }
                    else
                    {
                        dgvFormaPagamento.DataSource = cFormaPagamento.ConsultaFormaPagamentoStatus(0);
                    }
                    break;

                default:
                    if (rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvFormaPagamento.DataSource = cFormaPagamento.ConsultaFormaPagamentoNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvFormaPagamento.DataSource = cFormaPagamento.ConsultaFormaPagamentoNomeContem(txtNome.Text);
                    }
                    break;
            }
        }

        private void FormConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Status");

            cbOpcoes.SelectedIndex = 0;
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
                gbStatus.Enabled = false;
                txtNome.Focus();
            }
            //Status
            if (cbOpcoes.SelectedIndex == 1)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbStatus.Enabled = true;
            }
        }

        private void dgvFormaPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar esta forma de pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classFormaPagamento cFormaPagamento = new classFormaPagamento();

                form_forma_pagamento fFormaPagamento = new form_forma_pagamento();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cFormaPagamento.ConsultaFormaPagamento(Convert.ToInt32(dgvFormaPagamento.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fFormaPagamento.txtnome.Text = cFormaPagamento.nome;
                fFormaPagamento.txtobservacao.Text = cFormaPagamento.observacao;
                fFormaPagamento.mbid_forma_pagamento.Text = Convert.ToString(cFormaPagamento.id_forma_pagamento);
                fFormaPagamento.data_cadastro = cFormaPagamento.data_cadastro;
                if (cFormaPagamento.status == 1)
                {
                    fFormaPagamento.cbstatus.Checked = true;
                }
                else
                {
                    fFormaPagamento.cbstatus.Checked = false;
                }

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fFormaPagamento.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fFormaPagamento.ShowDialog();

                //ATUALIZAR A GRID DE CONSULTA
                btconsultar_Click(this, new EventArgs());

            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }

        private void dgvFormaPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
