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
    public partial class form_forma_pagamento : Form
    {
        public string tipo;

        public DateTime data_cadastro;

        public form_forma_pagamento()
        {
            InitializeComponent();
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

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            //criar obj da classe FormaPagamento para usar propriedades e metodos da classe
            classFormaPagamento cFormaPagamento = new classFormaPagamento();

            //verificar se os compos obrigatorios estão preenchidos
            if (txtnome.Text != "")
            {
                //passar para as propriedades da classe o conteudo de todos os campos que o usuario pode preencher
                cFormaPagamento.nome = txtnome.Text;
                cFormaPagamento.observacao = txtobservacao.Text;

                //chamar o metodo cadastrar da classe FormaPagamento
                int resp = cFormaPagamento.CadastrarFormaPagamento();

                //exibir mensagem para o usuario
                if (resp == 1)//sucesso
                {
                    MessageBox.Show(cFormaPagamento.nome + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Clear();
                    txtobservacao.Clear();
                    txtnome.Focus();
                }
                else //falhou
                {
                    MessageBox.Show("Erro ao cadastrar Forma de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //não preencheu os campos obrigatorios
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //criar obj da classe FormaPagamento para usar propriedades e metodos da classe
            classFormaPagamento cFormaPagamento = new classFormaPagamento();

            //verificar se os compos obrigatorios estão preenchidos
            if (txtnome.Text != "")
            {
                //passar para as propriedades da classe o conteudo de todos os campos que o usuario pode preencher
                cFormaPagamento.id_forma_pagamento = Convert.ToInt32(mbid_forma_pagamento.Text);
                cFormaPagamento.nome = txtnome.Text;
                cFormaPagamento.observacao = txtobservacao.Text;

                //chamar o metodo cadastrar da classe FormaPagamento
                int resp = cFormaPagamento.AtualizarFormaPagamento();

                //exibir mensagem para o usuario
                if (resp == 1)//sucesso
                {
                    MessageBox.Show(cFormaPagamento.nome + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Clear();
                    txtobservacao.Clear();
                    txtnome.Focus();
                }
                else //falhou
                {
                    MessageBox.Show("Erro ao Alterar o Forma de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //não preencheu os campos obrigatorios
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
        }

        private void form_forma_pagamento_Load(object sender, EventArgs e)
        {
            //Verificar o modo de abertura do formulário - Atualização
            if (tipo == "Atualização")
            {
                lbcadastro_forma_pagamento.Text = "Atualização da Forma de Pagamento";
                cbstatus.Enabled = true;
                btconfirmar.Visible = false;
                btatualizar.Visible = true;

                //COMBO BOX (VARIÁVEL CRIADA PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIDO NA HORA DE CADASTRAR
                mbdata_cadastro.Text = data_cadastro.ToString();
            }
            else
            {
                btatualizar.Visible = false;
            }
        }
    }
}
