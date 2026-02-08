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
    public partial class formConsultaProduto : Form
    {
        public formConsultaProduto()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
                gbmarca.Enabled = false;
                gbcategoria.Enabled = false;
                gbpromocao.Enabled = false;
                gbStatus.Enabled = false;
                txtNome.Focus();
            }
            //Marca
            if (cbOpcoes.SelectedIndex == 1)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbmarca.Enabled = true;
                gbcategoria.Enabled = false;
                gbpromocao.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Categoria
            if (cbOpcoes.SelectedIndex == 2)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbmarca.Enabled = false;
                gbcategoria.Enabled = true;
                gbpromocao.Enabled = false;
                gbStatus.Enabled = false;
            }
            //Promoção
            if (cbOpcoes.SelectedIndex == 3)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbmarca.Enabled = false;
                gbcategoria.Enabled = false;
                gbpromocao.Enabled = true;
                gbStatus.Enabled = false;
            }
            //Status
            if (cbOpcoes.SelectedIndex == 4)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbmarca.Enabled = false;
                gbcategoria.Enabled = false;
                gbpromocao.Enabled = false;
                gbStatus.Enabled = true;
            }
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            //Criar variavel para alimentar o switch
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvProdutos.DataSource = cProduto.ConsultaProdutoStatus(1);
                    }
                    else
                    {
                        dgvProdutos.DataSource = cProduto.ConsultaProdutoStatus(0);
                    }
                    break;

                case "Marca":

                    dgvProdutos.DataSource = cProduto.ConsultaProdutoMarca(Convert.ToInt32(cbmarca.SelectedValue));

                    break;

                case "Categoria":

                    dgvProdutos.DataSource = cProduto.ConsultaProdutoCategoria(Convert.ToInt32(cbcategoria.SelectedValue));

                    break;

                case "Promoção":
                    if (rbpromocao.Checked == true)
                    {
                        dgvProdutos.DataSource = cProduto.ConsultaProdutoPromocao(1);
                    }
                    else
                    {
                        dgvProdutos.DataSource = cProduto.ConsultaProdutoPromocao(0);
                    }
                    break;

                default:
                    if (rbInicio.Checked == true)
                    {
                        if (txtNome.Text != "")
                        {
                            dgvProdutos.DataSource = cProduto.ConsultaProdutoNomeInicio(txtNome.Text);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        dgvProdutos.DataSource = cProduto.ConsultaProdutoNomeContem(txtNome.Text);
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

        private void formConsultaProduto_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Marca");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Promoção");
            cbOpcoes.Items.Add("Status");

            cbOpcoes.SelectedIndex = 0;

            //COMBO MARCA - ALIMENTADA PELA TABELA PRODUTO CAMPO MARCA
            classMarca cMarca = new classMarca();
            cbmarca.DataSource = cMarca.CarregarMarca();
            cbmarca.DisplayMember = "nome";
            cbmarca.ValueMember = "id_marca";
            cbmarca.SelectedIndex = 0;

            //COMBO CATEGORIA - ALIMENTADA PELA TABELA PRODUTO CAMPO CATEGORIA
            classCategoria cCategoria = new classCategoria();
            cbcategoria.DataSource = cCategoria.CarregarCategoria();
            cbcategoria.DisplayMember = "nome";
            cbcategoria.ValueMember = "id_categoria";
            cbcategoria.SelectedIndex = 0;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID E EDITAR OU EXCLUIR UM FUNCIONÁRIO
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA

            //PERGUNTAR SE O USUÁRIO REALMENTE QUER EDITAR O FUNCIONÁRIO
            DialogResult result = MessageBox.Show("Você quer editar este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //INSTANCIAR FORM/CLASSE
                classProduto cProduto = new classProduto();

                form_produto fProduto = new form_produto();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO
                cProduto.ConsultaProduto(Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS COMPONENETES DO FORM DO FUNCIONÁRIO
                fProduto.txtnome.Text = cProduto.nome;
                fProduto.txtdescricao.Text = cProduto.descricao;
                fProduto.txtestoque.Text = cProduto.estoque.ToString();
                fProduto.txtpreco_custo.Text = cProduto.preco_custo.ToString();
                fProduto.txtpercentual_lucro.Text = cProduto.percentual_lucro.ToString();
                fProduto.txtpreco_venda.Text = cProduto.preco_venda.ToString();

                if (cProduto.status_promocao == 1)
                {
                    fProduto.checkbstatus_promocao.Checked = true;
                }
                else
                {
                    fProduto.checkbstatus_promocao.Checked = false;
                }

                fProduto.txtdesconto.Text = cProduto.desconto.ToString();
                fProduto.txtpreco_promocao.Text = cProduto.preco_promocao.ToString();
                fProduto.data_cadastro = cProduto.data_cadastro;

                if (cProduto.status == 1)
                {
                    fProduto.checkbstatus.Checked = true;
                }
                else
                {
                    fProduto.checkbstatus.Checked = false;
                }

                fProduto.txtid_produto.Text = cProduto.id_produto.ToString();
                fProduto.marca = cProduto.id_marca;
                fProduto.categoria = cProduto.id_categoria;

                //PASSAR PARA A VARIÁVEL "TIPO" A INFORMAÇÃO DE ATUALIZAÇÃO
                fProduto.tipo = "Atualização";

                //ABRIR O FORM DO CADASTRO (MODO EDITAR)
                fProduto.ShowDialog();

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
