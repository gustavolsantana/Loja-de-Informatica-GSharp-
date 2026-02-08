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
    public partial class formConsultaCategoria : Form
    {
        public formConsultaCategoria()
        {
            InitializeComponent();
        }

        private void formConsultaCategoria_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Status");

            cbOpcoes.SelectedIndex = 0;
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvCategorias.DataSource = cCategoria.ConsultaCategoriaStatus(1);
                    }
                    else
                    {
                        dgvCategorias.DataSource = cCategoria.ConsultaCategoriaStatus(0);
                    }
                    break;

                default:
                    if (rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvCategorias.DataSource = cCategoria.ConsultaCategoriaNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvCategorias.DataSource = cCategoria.ConsultaCategoriaNomeContem(txtNome.Text);
                    }
                    break;
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

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar esta categoria?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classCategoria cCategoria = new classCategoria();

                form_categoria fCategoria = new form_categoria();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cCategoria.ConsultaCategoria(Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fCategoria.txtnome.Text = cCategoria.nome;
                fCategoria.txtobservacao.Text = cCategoria.observacao;
                fCategoria.mbid_categoria.Text = Convert.ToString(cCategoria.id_categoria);
                fCategoria.data_cadastro = cCategoria.data_cadastro;
                if (cCategoria.status == 1)
                {
                    fCategoria.cbstatus.Checked = true;
                }
                else
                {
                    fCategoria.cbstatus.Checked = false;
                }

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fCategoria.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fCategoria.ShowDialog();

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
