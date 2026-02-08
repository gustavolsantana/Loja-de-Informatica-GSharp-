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
    public partial class formRelVendaDetalhado : Form
    {
        public formRelVendaDetalhado()
        {
            InitializeComponent();
        }

        private void formRelVendaDetalhado_Load(object sender, EventArgs e)
        {
            // CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Vendas por Período");
            cbTipoRel.Items.Add("Vendas por Cliente");
            cbTipoRel.Items.Add("Vendas por Funcionário");
            cbTipoRel.Items.Add("Vendas por Período e Cliente");
            cbTipoRel.Items.Add("Vendas por Período e Funcionário");
            cbTipoRel.SelectedIndex = 0;
            this.rpvVenda.RefreshReport();

            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "id_funcionario";
            cbFuncionario.SelectedIndex = -1;

            classCliente cCliente = new classCliente();
            cbCliente.DataSource = cCliente.BuscarCliente();
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id_cliente";
            cbCliente.SelectedIndex = -1;
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Vendas por Período
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 1)//Vendas por Cliente
            {
                gbPeriodo.Enabled = false;
                gbCliente.Enabled = true;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 2)//Vendas por Funcionário
            {
                gbPeriodo.Enabled = false;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = true;
            }
            if (cbTipoRel.SelectedIndex == 3)//Vendas por Período e Cliente
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = true;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 4)//Vendas por Período e Funcionário
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = true;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classRelVenda cRelVenda = new classRelVenda();

            int tiporel = cbTipoRel.SelectedIndex;

            switch (tiporel)
            {
                case 1: //Vendas por Clientes
                    if (cbCliente.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaCliente(Convert.ToInt32(cbCliente.SelectedValue));
                        this.rpvVenda.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbCliente.ForeColor = Color.Red;
                    }
                    break;

                case 2: //Vendas por Funcionários
                    if (cbFuncionario.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaFuncionario(Convert.ToInt32(cbFuncionario.SelectedValue));
                        this.rpvVenda.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbCliente.ForeColor = Color.Red;
                    }
                    break;

                case 3: //Vendas por Período e Cliente
                    if (cbCliente.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaPeriodoeCliente(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text), Convert.ToInt32(cbCliente.SelectedValue));
                        this.rpvVenda.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbCliente.ForeColor = Color.Red;
                    }
                    break;

                case 4: //Vendas por Período e Funcionário
                    if (cbFuncionario.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaPeriodoeFuncionario(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text), Convert.ToInt32(cbFuncionario.SelectedValue));
                        this.rpvVenda.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbCliente.ForeColor = Color.Red;
                    }
                    break;


                default:
                    classRelVendaBindingSource.DataSource = cRelVenda.RelVendaPeriodo(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                    this.rpvVenda.RefreshReport();
                    break;
            }
        }

        private void rpvVenda_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o relatório de vendas?", "GSharp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
