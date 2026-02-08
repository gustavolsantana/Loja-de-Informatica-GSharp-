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
    public partial class form_produto : Form
    {
        public string tipo;

        public int marca, categoria;

        public DateTime data_cadastro;

        public form_produto()
        {
            InitializeComponent();
        }

        /// Calcula o preço de venda com base no preço de custo e no percentual de lucro.
        private void CalcularPrecoVenda()
        {
            // Tenta converter os valores de custo e lucro para decimal.
            // O TryParse evita erros se o campo estiver vazio ou com texto inválido.
            bool custoValido = decimal.TryParse(txtpreco_custo.Text, out decimal precoCusto);
            bool lucroValido = decimal.TryParse(txtpercentual_lucro.Text, out decimal percentualLucro);

            // Realiza o cálculo apenas se ambos os valores forem válidos.
            if (custoValido && lucroValido)
            {
                // Calcula o valor do lucro
                decimal valorLucro = precoCusto * (percentualLucro / 100);

                // Calcula o preço de venda final.
                decimal precoVenda = precoCusto + valorLucro;

                // Exibe o resultado formatado com duas casas decimais.
                txtpreco_venda.Text = precoVenda.ToString("F2");
            }
            else
            {
                // Limpa o campo de preço de venda se algum dos valores de entrada for inválido.
                txtpreco_venda.Text = string.Empty;
            }
        }
        private void CalcularPrecoPromocao()
        {
            // Tenta converter os valores de venda, desconto e CUSTO (necessário para a comparação)
            bool vendaValida = decimal.TryParse(txtpreco_venda.Text, out decimal precoVendaa);
            bool descontoValido = decimal.TryParse(txtdesconto.Text, out decimal descontoo);
            bool custoValido = decimal.TryParse(txtpreco_custo.Text, out decimal precoCusto);

            // Realiza o cálculo apenas se venda e desconto forem válidos
            if (vendaValida && descontoValido)
            {
                // Calcula o valor do desconto
                decimal valorDesconto = precoVendaa * (descontoo / 100);

                // Calcula o preço de promoção provisório
                decimal precoPromocao = precoVendaa - valorDesconto;

                // Verifica se o custo é válido e se a promoção ficou abaixo do custo
                if (custoValido && precoPromocao < precoCusto)
                {
                    MessageBox.Show("O preço de promoção não pode ser menor que o preço de custo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Apaga as caixas
                    txtpreco_promocao.Clear();
                    txtdesconto.Clear();
                    txtdesconto.Focus(); // Devolve o foco para o usuário digitar um desconto menor
                }
                else
                {
                    // Se estiver tudo ok, exibe o resultado formatado
                    txtpreco_promocao.Text = precoPromocao.ToString("F2");
                }
            }
            else
            {
                // Limpa o campo se os valores de entrada forem inválidos
                txtpreco_promocao.Text = string.Empty;
            }
        }

        // Eventos que disparam o cálculo automático do preço de venda
        private void txtpreco_custo_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
            CalcularPrecoPromocao();
            txtpreco_custo.MaxLength = 9;
        }

        private void txtpercentual_lucro_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
            CalcularPrecoPromocao();
            txtpercentual_lucro.MaxLength = 5;
        }

        private void form_produto_Load(object sender, EventArgs e)
        {
            // Carrega as Marcas na ComboBox
            classMarca cMarca = new classMarca();
            cbmarca.DataSource = cMarca.CarregarMarca();
            cbmarca.DisplayMember = "nome";
            cbmarca.ValueMember = "id_marca";
            cbmarca.SelectedIndex = -1;

            // Carrega as Categorias na ComboBox
            classCategoria cCategoria = new classCategoria();
            cbcategoria.DataSource = cCategoria.CarregarCategoria();
            cbcategoria.DisplayMember = "nome";
            cbcategoria.ValueMember = "id_categoria";
            cbcategoria.SelectedIndex = -1;

            //Verificar o modo de abertura do formulário - Atualização
            if (tipo == "Atualização")
            {
                lbcadastro_produto.Text = "Atualização do Produto";
                checkbstatus.Enabled = true;
                btconfirmar.Visible = false;
                btatualizar.Visible = true;

                //COMBO BOX (VARIÁVEL CRIADA PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIDO NA HORA DE CADASTRAR
                mbdata_cadastro.Text = data_cadastro.ToString();
                cbmarca.SelectedValue = marca;
                cbcategoria.SelectedValue = categoria;
            }
            else
            {
                btatualizar.Visible = false;
            }
        }

        /// Destaca os campos obrigatórios em vermelho.
        public void CamposObrigatorios()
        {
            lbnome.ForeColor = Color.Red;
            lbmarca.ForeColor = Color.Red;
            lbcategoria.ForeColor = Color.Red;
            lbestoque.ForeColor = Color.Red;
            lbpreco_custo.ForeColor = Color.Red;
            lbpercentual_lucro.ForeColor = Color.Red;
            txtnome.Focus();
        }

        /// Limpa todos os campos do formulário.
        public void Limpar()
        {
            txtnome.Clear();
            txtdescricao.Clear();
            cbmarca.SelectedIndex = -1;
            cbcategoria.SelectedIndex = -1;
            txtestoque.Clear();
            txtpreco_custo.Clear();
            txtpercentual_lucro.Clear();
            txtpreco_venda.Clear();
            checkbstatus_promocao.Checked = false;
            txtdesconto.Clear();
            txtpreco_promocao.Clear();
            mbdata_cadastro.Clear();
            checkbstatus.Checked = false;
            txtnome.Focus();
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            // Instancia a classe de Produto para acessar seus métodos e propriedades.
            classProduto cProduto = new classProduto();

            // Verifica se os campos obrigatórios foram preenchidos.
            if (txtnome.Text != "" && cbmarca.SelectedIndex != -1 && cbcategoria.SelectedIndex != -1 && txtestoque.Text != "" && txtpreco_custo.Text != "" && txtpercentual_lucro.Text != "")
            {
                // Atribui os valores dos campos às propriedades do objeto.
                cProduto.nome = txtnome.Text;
                cProduto.descricao = txtdescricao.Text;
                cProduto.estoque = Convert.ToInt32(txtestoque.Text);
                cProduto.preco_custo = Convert.ToDecimal(txtpreco_custo.Text);
                cProduto.percentual_lucro = Convert.ToInt32(txtpercentual_lucro.Text);
                cProduto.preco_venda = Convert.ToDecimal(txtpreco_venda.Text);
                cProduto.id_marca = Convert.ToInt32(cbmarca.SelectedValue);
                cProduto.id_categoria = Convert.ToInt32(cbcategoria.SelectedValue);
                cProduto.status_promocao = checkbstatus_promocao.Checked ? 1 : 0;

                if (txtdesconto.Text != "")
                {
                    cProduto.desconto = Convert.ToInt32(txtdesconto.Text);
                    cProduto.preco_promocao = Convert.ToDecimal(txtpreco_promocao.Text);
                }
                else
                {
                    cProduto.desconto = 0;
                    cProduto.preco_promocao = 0;
                }

                

                // Chama o método para cadastrar o produto no banco de dados.
                int resp = cProduto.CadastrarProduto();

                // Exibe uma mensagem de sucesso ou erro para o usuário.
                if (resp == 1) // Sucesso
                {
                    MessageBox.Show(cProduto.nome + " cadastrado com sucesso!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else // Falha
                {
                    MessageBox.Show("Erro ao cadastrar produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Caso os campos obrigatórios não sejam preenchidos.
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkbstatus_promocao_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkbstatus_promocao.Checked == true)
            {
                // Habilita ou desabilita o campo de preço promocional conforme o status do checkbox.
                txtdesconto.Enabled = checkbstatus_promocao.Checked;
            }
            else
            {
                txtdesconto.Enabled = checkbstatus_promocao.Checked;
                txtdesconto.Text = "";
                txtpreco_promocao.Text = "";
            }
        }

        private void txtestoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpreco_custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpercentual_lucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpreco_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpreco_promocao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            txtnome.MaxLength = 100;
        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {
            txtdescricao.MaxLength = 255;
        }

        private void txtestoque_TextChanged(object sender, EventArgs e)
        {
            txtestoque.MaxLength = 4;
        }

        private void txtpreco_promocao_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoPromocao();
            txtpreco_promocao.MaxLength = 9;
        }

        private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoPromocao();
            txtdesconto.MaxLength = 3;
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            // Instancia a classe de Produto para acessar seus métodos e propriedades.
            classProduto cProduto = new classProduto();

            // Verifica se os campos obrigatórios foram preenchidos.
            if (txtnome.Text != "" && cbmarca.SelectedIndex != -1 && cbcategoria.SelectedIndex != -1 && txtestoque.Text != "" && txtpreco_custo.Text != "" && txtpercentual_lucro.Text != "")
            {
                // Atribui os valores dos campos às propriedades do objeto.
                cProduto.id_produto = Convert.ToInt32(txtid_produto.Text);
                cProduto.nome = txtnome.Text;
                cProduto.descricao = txtdescricao.Text;
                cProduto.estoque = Convert.ToInt32(txtestoque.Text);
                cProduto.preco_custo = Convert.ToDecimal(txtpreco_custo.Text);
                cProduto.percentual_lucro = Convert.ToInt32(txtpercentual_lucro.Text);
                cProduto.preco_venda = Convert.ToDecimal(txtpreco_venda.Text);
                cProduto.id_marca = Convert.ToInt32(cbmarca.SelectedValue);
                cProduto.id_categoria = Convert.ToInt32(cbcategoria.SelectedValue);
                cProduto.status_promocao = checkbstatus_promocao.Checked ? 1 : 0;

                if (txtdesconto.Text != "")
                {
                    cProduto.desconto = Convert.ToInt32(txtdesconto.Text);
                    cProduto.preco_promocao = Convert.ToDecimal(txtpreco_promocao.Text);
                }
                else
                {
                    cProduto.desconto = 0;
                    cProduto.preco_promocao = 0;
                }

                //Status
                cProduto.status = checkbstatus.Checked ? 1 : 0;

                // Chama o método para cadastrar o produto no banco de dados.
                int resp = cProduto.AtualizarProduto();

                // Exibe uma mensagem de sucesso ou erro para o usuário.
                if (resp == 1) // Sucesso
                {
                    MessageBox.Show(cProduto.nome + " Alterado com sucesso!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else // Falha
                {
                    MessageBox.Show("Erro ao Alterar o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Caso os campos obrigatórios não sejam preenchidos.
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
            }
        }

        private void txtpreco_venda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}