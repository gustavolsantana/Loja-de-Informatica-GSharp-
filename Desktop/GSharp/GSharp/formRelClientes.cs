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
    public partial class formRelClientes : Form
    {
        public formRelClientes()
        {
            InitializeComponent();
        }

        private void formRelClientes_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Data de Admissão");
            cbTipoRel.Items.Add("Idade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            //COMBO CIDADE - ALIMENTADA PELA TABELA CLIENTE CAMPO CIDADE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.CarregarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 2)//Data de Admissão
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 3)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 5)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar o relatório de cliente?", "GSharp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //VARIÁVEL PARA ALIMENTAR O SWITCH - ESCOLHA DO TIPO DE RELATÓRIO USANDO ÍNDICE DA COMBO
            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch (relatorio)
            {
                //RELATÓRIO POR CIDADE
                case 1:
                    //CHAMAR O MÉTODO DO RELATÓRIO (SELECT)
                    classClienteBindingSource.DataSource = cCliente.RelatorioClienteCidade(cbCidade.SelectedValue.ToString());

                    //ATUALIZAR O REPORT
                    this.rvcliente.RefreshReport();
                    break;

                //RELATÓRIO POR DATA ADMISSÃO
                case 2:
                    //CHAMAR O MÉTODO DO RELATÓRIO (SELECT)
                    classClienteBindingSource.DataSource = cCliente.RelatorioClienteDataAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                    //ATUALIZAR O REPORT
                    this.rvcliente.RefreshReport();
                    break;

                //RELATÓRIO POR IDADE
                case 3:
                    //VERIFICAR SE AS IDADES FORAM PREENCHIDAS
                    if (string.IsNullOrWhiteSpace(txtIdadeInicial.Text) || string.IsNullOrWhiteSpace(txtIdadeFinal.Text))
                    {
                        MessageBox.Show("Favor informar as idades", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbIdade.ForeColor = Color.Red;
                    }
                    else
                    {
                        //CHAMAR O MÉTODO DO RELATÓRIO (SELECT)
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    break;

                //RELATÓRIO POR SEXO
                case 4:
                    if (cbSexo.SelectedIndex == 0)
                    {
                        MessageBox.Show("Favor inserir um sexo válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteSexo("F");

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    else if (cbSexo.SelectedIndex == 2)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteSexo("M");

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    else if (cbSexo.SelectedIndex == 3)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteSexo("O");

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    break;

                //RELATÓRIO POR STATUS
                case 5:
                    if (rbAtivo.Checked == true)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteStatus(1);

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelatorioClienteStatus(0);

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    break;

                //RELATÓRIO POR ANIVERSARIANTE DO MÊS
                default:
                    //VERIFICAR SE O USUÁRIO ESCOLHEU O MÊS
                    if (cbMes.SelectedIndex != 0)
                    {
                        //CHAMAR O MÉTODO DO RELATÓRIO (SELECT)
                        classClienteBindingSource.DataSource = cCliente.RelatorioclienteMesAniversario(Convert.ToInt32(cbMes.SelectedIndex));

                        //ATUALIZAR O REPORT
                        this.rvcliente.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor inserir um mês válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
        }
    }
}
