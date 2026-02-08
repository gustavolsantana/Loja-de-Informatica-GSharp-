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
    public partial class formVenda : Form
    {
        public formVenda()
        {
            InitializeComponent();
        }

        //CRIAR A LISTA QUE SERÁ USADA NA GRID DE PRODUTOS VENDIDOS QUE TERA COMO BASE A CLASSE DE ITENSVENDA
        private List<classItensPedido> ListaItensPedido = new List<classItensPedido>();

        //VARIÁVEL PARA CALCULAR VALOR TOTAL DA VENDA
        private decimal vendatotal = 0;

        //VARIÁVEL PARA CONTAR QUANTAS LINHAS FORAM ADICIONADAS NA GRID DE VENDA
        private int itensvenda = 0;

        //CRIAR A LISTA QUE SERÁ USADA NA GRID DE FORMA DE PAGAMENTO USADOS QUE TERA COMO BASE A CLASSE DE DETALHE_PAGAMENTOS
        private List<classDetalhePagamento> ListaDetalhePagamento = new List<classDetalhePagamento>();

        //VARIÁVEL PARA CALCULAR VALOR TOTAL PAGO
        private decimal valortotalpago = 0;

        //VARIÁVEL PARA CONTAR QUANTAS LINHAS FORAM ADICIONADAS NA GRID DE FORMA PAGAMENTO
        private int detalhe_pagamento = 0;

        //MÉTODO LIMPAR - CHAMADO QUANDO VENDA FINALIZA
        private void Limpar()
        {
            cbFuncionario.SelectedIndex = -1;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;
            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;

            ListaItensPedido.Clear();
            AtualizarGrid();
            dgvItens.Refresh();

            ListaDetalhePagamento.Clear();
            AtualizarGrid2();
            dgvFormaPagamento.Refresh();

            txtValorTotal.Text = "0";
            txtTotalVenda.Text = "0";
            txtPercentualDesconto.Text = "0";
            txtTotalDesconto.Text = "0";

            txtQtdeItens.Clear();
            cbforma_pagamento.SelectedIndex = -1;
            vendatotal = 0;
        }

        private void CalcularEstoque(int qtde, int cod)
        {
            classProduto cProduto = new classProduto();
            cProduto.ConsultaProduto(cod);
            int estoque = cProduto.estoque;
            cProduto.AtualizarEstoque(estoque - qtde, cod);
        }

        private void formVenda49_Load(object sender, EventArgs e)
        {
            dgvProduto.ForeColor = Color.Black;
            dgvCliente.ForeColor = Color.Black;
            dgvItens.ForeColor = Color.Black;
            dgvFormaPagamento.ForeColor = Color.Black;

            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            classFormaPagamento cFormaPagamento = new classFormaPagamento();
            cbforma_pagamento.DataSource = cFormaPagamento.CarregarFormaPagamento();
            cbforma_pagamento.DisplayMember = "nome";
            cbforma_pagamento.ValueMember = "id_forma_pagamento";
            cbforma_pagamento.SelectedIndex = -1;

            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "id_funcionario";
            cbFuncionario.SelectedIndex = -1;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "GSharp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqCliente.Text))
            {
                MessageBox.Show("Favor informar um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbClientes.ForeColor = Color.Red;
                txtPesqCliente.Focus();
            }
            else
            {
                classCliente cCliente = new classCliente();
                dgvCliente.DataSource = cCliente.CarregarGridCliente(txtPesqCliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqProduto.Text))
            {
                MessageBox.Show("Favor informar um produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbProdutos.ForeColor = Color.Red;
                txtPesqProduto.Focus();
            }
            else
            {
                classProduto cProduto = new classProduto();
                dgvProduto.DataSource = cProduto.CarregarGridProduto(txtPesqProduto.Text);
            }
        }
              
        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            dgvProduto.DataSource = cProduto.CarregarGridProduto(cbFuncionario.Text);
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQtde.Text) || txtQtde.Text == "0")
            {
                MessageBox.Show("Favor informar uma quantidade", "Gharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "1";
                txtQtde.SelectAll();
            }

            int qtdevendida = Convert.ToInt32(txtQtde.Text);
            int estoque = Convert.ToInt32(txtQtdeEstoque.Text);

            if (qtdevendida > estoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é de " + estoque + " unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "1";
                txtQtde.SelectAll();
            }
            else
            {
                qtdevendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtdevendida * valor).ToString();
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();

            bool resp = cProduto.ConsultaProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

            if (resp == true)
            {
                txtProduto.Text = cProduto.nome;
                txtQtdeEstoque.Text = cProduto.estoque.ToString();
                txtValor.Text = cProduto.preco_venda.ToString();
                txtQtde.Text = "1";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();

            }
        }

        private void AtualizarGrid()
        {
            classProduto cProduto = new classProduto();

            //CRIAR UMA TABELA TEMPORÁRIA
            DataTable dt = new DataTable();

            //CRIAR AS COLUNAS DA GRID
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("Nome"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor Unitário"));
            dt.Columns.Add(new DataColumn("Valor Total"));

            //CRIAR AS LINHAS DA GRID
            foreach (classItensPedido item in ListaItensPedido)
            {
                dt.Rows.Add(item.id_produto, cProduto.BuscaNomeProduto(item.id_produto), item.quantidade, item.preco_unitario, item.valor_total);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;
        }

        private void AtualizarGrid2()
        {
            classFormaPagamento cFormaPagamento = new classFormaPagamento();

            //CRIAR UMA TABELA TEMPORÁRIA
            DataTable dt = new DataTable();

            //CRIAR AS COLUNAS DA GRID
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("Nome"));
            dt.Columns.Add(new DataColumn("Nº de Parcelas"));
            dt.Columns.Add(new DataColumn("Valor das Parcelas"));
            dt.Columns.Add(new DataColumn("Total Pago"));

            //CRIAR AS LINHAS DA GRID
            foreach (classDetalhePagamento item in ListaDetalhePagamento)
            {
                dt.Rows.Add(item.id_forma_pagamento, cFormaPagamento.BuscaNomeFormaPagamento(item.id_forma_pagamento), item.numero_parcelas, item.valor_das_parcelas.ToString("n2"), item.valor_pago);
                dt.AcceptChanges();
            }
            dgvFormaPagamento.DataSource = dt;
        }

        private void CalcularTroco()
        {
            try
            {
                // 1. Pegamos o total atual da venda (que pode ter mudado se ele adicionou mais itens)
                // txtTotalVenda é o campo que recebe o valor final após descontos
                decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text);

                // 2. valortotalpago é sua variável global que acumula o que já entrou de dinheiro
                decimal saldo = valortotalpago - totalVenda;

                // Se o saldo for positivo, temos troco
                txttroco.Text = saldo.ToString("n2");
            }
            catch
            {
                txttroco.Text = "0,00";
            }
        }

        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
                //SE O USUÁRIO APAGAR O PERCENTUAL DO DESCONTO
                if (txtPercentualDesconto.Text == "" || txtPercentualDesconto.Text == "0")
                {
                    //PEGAR O VALOR DA VENDA
                    decimal valortotal = Convert.ToDecimal(txtValorTotal.Text);
                    //EXIBIR NA CAIXA
                    txtTotalVenda.Text = valortotal.ToString("n2");
                    //ZERAR O DESCONTO DO PERCENTUAL
                    txtPercentualDesconto.Text = "0";
                    txtPercentualDesconto.SelectAll();
                    //ZERAR O DESCONTO DO CAMPO CALCULADO
                    txtTotalDesconto.Text = "0,00";
                }
                else
                {

                    //VALOR DA PORCENTAGEM DE DESCONTO
                    decimal percentual = Convert.ToDecimal(txtPercentualDesconto.Text) / 100;
                    //VALOR DA VENDA
                    decimal valorpedido = Convert.ToDecimal(txtValorTotal.Text);
                    //CALCULO DO DESCONTO
                    decimal valordesconto = percentual * valorpedido;
                    //EXIBIR O VALOR DO DESCONTO
                    txtTotalDesconto.Text = valordesconto.ToString("n2");
                    //CALCULO DO VALOR FINAL DA VENDA COM DESCONTO
                    decimal totalpedido = valorpedido - valordesconto;
                    //EXIBIR VALOR DO DESCONTO CALCULADO
                    txtTotalVenda.Text = totalpedido.ToString("n2");
                }
            
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            classItensPedido cItensPedido = new classItensPedido();

            //SOMAR VALOR DO ITEM AO TOTAL DA VENDA
            decimal valoritem = 0;

            //VERIFICAR SE ALGUM PRODUTO FOI SELECIONADO
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //INFORMAÇÕES DOS PRODUTOS VENDIDOS
                cItensPedido.id_produto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
                cItensPedido.quantidade = Convert.ToInt32(txtQtde.Text);
                cItensPedido.preco_unitario = Convert.ToDecimal(txtValor.Text);
                cItensPedido.valor_total = Convert.ToDecimal(txtTotal.Text);

                //SOMAR VALOR DO ITEM SELECIONADO AO TOTAL DA VENDA
                valoritem = Convert.ToDecimal(txtValor.Text)*Convert.ToDecimal(txtQtde.Text);
                vendatotal = vendatotal + valoritem;
                txtValorTotal.Text = vendatotal.ToString("N2");

                //CONTAR ITENS DA VENDA (QUANTIDADE DE LINHAS DA GRID)
                itensvenda++;

                //ADICIONAR NA LISTA
                ListaItensPedido.Add(cItensPedido);

                //PEGAR DA LISTA A QUANTIDADE DE ITENS
                txtQtdeItens.Text = itensvenda.ToString();
                txtQtdeItens.Text = ListaItensPedido.Count.ToString();

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                AtualizarGrid();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR NA GRID DE VENDA
                txtProduto.Clear();
                txtQtde.Text = "1";
                txtValor.Clear();
                txtTotal.Clear();
                txtQtdeEstoque.Clear();
                txtPercentualDesconto_TextChanged(this, new EventArgs());
                txtPercentualDesconto.Select();
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja Remover o Produto Selecionado?","GSharp",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //RECARREGAR TOTAL DA VENDA
                    //PEGAR O VALOR DO ITEM SELECIONADO PELO USUARIO
                    decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[4].Value);
                    vendatotal = vendatotal - valor;
                    txtTotalVenda.Text = vendatotal.ToString();
                    txtValorTotal.Text = vendatotal.ToString();

                    //REMOVER O ITEM SELECIONADO DA LISTA E ATUALIZAR GRID
                    ListaItensPedido.RemoveAt(dgvItens.CurrentRow.Index);
                    AtualizarGrid();

                    //REMOVER A LISTA DE PRODUTOS VENDIDOS
                    txtQtdeItens.Text = ListaItensPedido.Count.ToString();
                    txtPercentualDesconto_TextChanged(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Não há produtos para ser removido", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            classDetalhePagamento cDetalhePagamento = new classDetalhePagamento();

            //VERIFICAR SE ALGUMA FORMA DE PAGAMENTO FOI SELECIONADO
            if (cbforma_pagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Não há forma de pagamento para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //INFORMAÇÕES DAS FORMAS DE PAGAMENTOS USADAS
                cDetalhePagamento.id_forma_pagamento = Convert.ToInt32(cbforma_pagamento.SelectedValue);
                cDetalhePagamento.valor_pago = Convert.ToDecimal(txtvalorpago.Text);
                cDetalhePagamento.numero_parcelas = Convert.ToInt16(txtparcelas.Text);
                cDetalhePagamento.valor_das_parcelas = Convert.ToDecimal(txtvalorpago.Text)/Convert.ToDecimal(txtparcelas.Text);

                //SOMAR VALOR DO ITEM SELECIONADO AO TOTAL DA VENDA
                decimal valorpago = Convert.ToDecimal(txtvalorpago.Text);
                valortotalpago = valortotalpago + valorpago;

                CalcularTroco();

                //CONTAR ITENS DA VENDA (QUANTIDADE DE LINHAS DA GRID)
                detalhe_pagamento++;

                //ADICIONAR NA LISTA
                ListaDetalhePagamento.Add(cDetalhePagamento);

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                AtualizarGrid2();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR NA GRID DE VENDA
                cbforma_pagamento.SelectedIndex = -1;
                txtparcelas.Text = "1";
                txtvalordasparcelas.Text = "";
                txtvalorpago.Text = "";
            }
        }

        private void btremove_Click(object sender, EventArgs e)
        {

            if (dgvFormaPagamento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja remover esta forma de pagamento?", "GSharp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 1. Pegamos o valor do pagamento que será removido
                    // Na sua AtualizarGrid2, o Valor Pago é a coluna index 4
                    decimal valorRemovido = Convert.ToDecimal(dgvFormaPagamento.SelectedRows[0].Cells[4].Value);

                    // 2. Subtraímos da nossa variável acumuladora global
                    valortotalpago -= valorRemovido;

                    // 3. Removemos da lista e atualizamos a grid
                    ListaDetalhePagamento.RemoveAt(dgvFormaPagamento.CurrentRow.Index);
                    AtualizarGrid2();

                    // 4. Recalculamos o troco/saldo imediatamente
                    CalcularTroco();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pagamento para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtparcelas_TextChanged(object sender, EventArgs e)
        {
            if (txtparcelas.Text != "" && txtvalorpago.Text != "")
            {
                decimal valordasparcelas = 0;

                valordasparcelas = Convert.ToDecimal(txtvalorpago.Text) / Convert.ToDecimal(txtparcelas.Text);

                txtvalordasparcelas.Text = valordasparcelas.ToString("n2");
            }
            
        }

        private void txtvalorpago_TextChanged(object sender, EventArgs e)
        {
            if (txtparcelas.Text != "" && txtvalorpago.Text != "")
            {
                decimal valordasparcelas = 0;

                valordasparcelas = Convert.ToDecimal(txtvalorpago.Text) / Convert.ToDecimal(txtparcelas.Text);

                txtvalordasparcelas.Text = valordasparcelas.ToString("n2");
            }
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalVenda.Text != "")
            {
                txtPercentualDesconto.Enabled = true;
            }
            else
            {
                txtPercentualDesconto.Enabled = false;
            }
            CalcularTroco();
        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            // 1. Verificação de segurança: precisa de cliente, itens e pagamentos
            if (cbFuncionario.SelectedIndex != -1 && dgvCliente.SelectedRows.Count > 0 && ListaItensPedido.Count > 0 && ListaDetalhePagamento.Count > 0)
            {
                decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text);

                // 2. Barreira de Troco: Valor pago deve ser >= Total
                if (valortotalpago < totalVenda)
                {
                    MessageBox.Show("O valor pago é insuficiente!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    classPedido cPedido = new classPedido();
                    cPedido.valor_total = totalVenda;
                    // CORREÇÃO: ToDecimal para aceitar centavos no desconto
                    cPedido.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
                    cPedido.troco = valortotalpago - totalVenda;
                    cPedido.id_cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                    cPedido.id_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);

                    // 3. Cadastra o Pedido e recupera o ID gerado
                    if (cPedido.CadastrarVenda())
                    {
                        // 4. Salvar os Produtos
                        foreach (classItensPedido item in ListaItensPedido)
                        {
                            item.id_pedido = cPedido.id_pedido; // Passa o ID real da venda
                            item.CadastrarItensPedido();
                            CalcularEstoque(item.quantidade, item.id_produto);
                        }

                        // 5. SALVAR OS PAGAMENTOS
                        foreach (classDetalhePagamento pag in ListaDetalhePagamento)
                        {
                            pag.id_pedido = cPedido.id_pedido;
                            pag.CadastrarDetalhePagamento();
                        }

                        MessageBox.Show("Venda finalizada com sucesso!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpeza total para a próxima venda
                        valortotalpago = 0;
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao fechar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro técnico: " + ex.Message, "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique se inseriu todos os dados corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btremove_Click_1(object sender, EventArgs e)
        {
            if (dgvFormaPagamento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja remover esta forma de pagamento?", "GSharp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 1. Pegamos o valor do pagamento que será removido
                    // Na sua AtualizarGrid2, o Valor Pago é a coluna index 4
                    decimal valorRemovido = Convert.ToDecimal(dgvFormaPagamento.SelectedRows[0].Cells[4].Value);

                    // 2. Subtraímos da nossa variável acumuladora global
                    valortotalpago -= valorRemovido;

                    // 3. Removemos da lista e atualizamos a grid
                    ListaDetalhePagamento.RemoveAt(dgvFormaPagamento.CurrentRow.Index);
                    AtualizarGrid2();

                    // 4. Recalculamos o troco/saldo imediatamente
                    CalcularTroco();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pagamento para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbforma_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtparcelas.Text = "1";
            // 1. Primeiro, tentamos pegar o valor que está no txtTroco
            decimal valorTroco = 0;

            // O TryParse evita que o programa quebre se o campo estiver vazio ou com texto inválido
            if (decimal.TryParse(txttroco.Text, out valorTroco))
            {
                // 2. Verificamos se o troco é negativo (está devendo)
                if (valorTroco < 0)
                {
                    // Math.Abs transforma -10,00 em 10,00 (remove o sinal negativo)
                    txtvalorpago.Text = Math.Abs(valorTroco).ToString("N2");
                }
                else
                {
                    // Se o troco for positivo ou zero, zera o valor a pagar
                    txtvalorpago.Text = "0,00";
                }
            }
        }

        private void txtparcelas_Click(object sender, EventArgs e)
        {
            txtparcelas.SelectAll();
        }

        private void txtparcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        private void txtPercentualDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }

        private void txtvalorpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
                MessageBox.Show("Este campo aceita apenas números!", "GSharp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
