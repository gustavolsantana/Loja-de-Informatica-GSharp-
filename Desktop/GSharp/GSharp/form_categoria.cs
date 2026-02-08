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
    public partial class form_categoria : Form
    {
        public string tipo;

        public DateTime data_cadastro;

        public form_categoria()
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
            //criar obj da classe marca para usar propriedades e metodos da classe
            classCategoria cCategoria = new classCategoria();

            //verificar se os compos obrigatorios estão preenchidos
            if (txtnome.Text != "")
            {
                //passar para as propriedades da classe o conteudo de todos os campos que o usuario pode preencher
                cCategoria.nome = txtnome.Text;
                cCategoria.observacao = txtobservacao.Text;

                //chamar o metodo cadastrar da classe marca
                int resp = cCategoria.CadastrarCategoria();

                //exibir mensagem para o usuario
                if (resp == 1)//sucesso
                {
                    MessageBox.Show(cCategoria.nome + " Cadastrado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Clear();
                    txtobservacao.Clear();
                    txtnome.Focus();
                }
                else //falhou
                {
                    MessageBox.Show("Erro ao cadastrar Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //não preencheu os campos obrigatorios
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            txtnome.MaxLength = 100;
        }

        private void txtobservacao_TextChanged(object sender, EventArgs e)
        {
            txtobservacao.MaxLength = 100;
        }

        private void form_categoria_Load(object sender, EventArgs e)
        {
            //Verificar o modo de abertura do formulário - Atualização
            if (tipo == "Atualização")
            {
                lbcadastro_categoria.Text = "Atualização do Categoria";
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

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //criar obj da classe cargo para usar propriedades e metodos da classe
            classCategoria cCategoria = new classCategoria();

            //verificar se os compos obrigatorios estão preenchidos
            if (txtnome.Text != "")
            {
                //passar para as propriedades da classe o conteudo de todos os campos que o usuario pode preencher
                cCategoria.id_categoria = Convert.ToInt32(mbid_categoria.Text);
                cCategoria.nome = txtnome.Text;
                cCategoria.observacao = txtobservacao.Text;

                //chamar o metodo cadastrar da classe cargo
                int resp = cCategoria.AtualizarCategoria();

                //exibir mensagem para o usuario
                if (resp == 1)//sucesso
                {
                    MessageBox.Show(cCategoria.nome + " Alterado com Sucesso", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Clear();
                    txtobservacao.Clear();
                    txtnome.Focus();
                }
                else //falhou
                {
                    MessageBox.Show("Erro ao Alterar a Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //não preencheu os campos obrigatorios
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
        }
    }
}
