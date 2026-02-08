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
    public partial class formConsultaCargo : Form
    {
        public formConsultaCargo()
        {
            InitializeComponent();
        }

        private void formConsultaCargo_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Status");

            cbOpcoes.SelectedIndex = 0;
        }

        private void cbOpcoes_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btconsultar_Click_1(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvCargo.DataSource = cCargo.ConsultaCargoStatus(1);
                    }
                    else
                    {
                        dgvCargo.DataSource = cCargo.ConsultaCargoStatus(0);
                    }
                    break;

                default:
                    if (rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvCargo.DataSource = cCargo.ConsultaCargoNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvCargo.DataSource = cCargo.ConsultaCargoNomeContem(txtNome.Text);
                    }
                    break;
            }
        }

        private void btsair_Click_1(object sender, EventArgs e)
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

        private void rbInicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar este cargo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classCargo cCargo = new classCargo();

                form_cargo fCargo = new form_cargo();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cCargo.ConsultaCargo(Convert.ToInt32(dgvCargo.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fCargo.txtnome.Text = cCargo.nome;
                fCargo.txtobservacao.Text = cCargo.observacao;
                fCargo.mbid_cargo.Text = Convert.ToString(cCargo.id_cargo);
                fCargo.data_cadastro = cCargo.data_cadastro;
                if (cCargo.status == 1)
                {
                    fCargo.cbstatus.Checked = true;
                }
                else
                {
                    fCargo.cbstatus.Checked = false;
                }

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fCargo.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fCargo.ShowDialog();

                //ATUALIZAR A GRID DE CONSULTA
                btconsultar_Click_1(this, new EventArgs());

            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }
    }
}
