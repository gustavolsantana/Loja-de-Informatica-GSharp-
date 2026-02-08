using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GSharp
{
    class classProduto
    {
        // Propriedades da classe que representam os campos da tabela 'produto'
        // (atalho para criar: digite "prop" e pressione Tab duas vezes)
        public int id_produto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string foto { get; set; }
        public int estoque { get; set; }
        public decimal preco_custo { get; set; }
        public int percentual_lucro { get; set; }
        public decimal preco_venda { get; set; }
        public int desconto { get; set; }
        public decimal preco_promocao { get; set; }
        public int status_promocao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public int id_marca { get; set; }
        public int id_categoria { get; set; }

        /// Construtor da classe. Inicializa as propriedades com valores padrão.
        public classProduto()
        {
            id_produto = 0;
            nome = null;
            descricao = null;
            foto = null;
            estoque = 0;
            preco_custo = 0;
            percentual_lucro = 0;
            preco_venda = 0;
            desconto = 0;
            preco_promocao = 0;
            status_promocao = 0;
            data_cadastro = DateTime.Now;
            status = 0;
            id_marca = 0;
            id_categoria = 0;
        }


        /// Grava os dados do produto no banco de dados.
        /// <returns>Retorna 1 para sucesso e 0 para falha.</returns>
        public int CadastrarProduto()
        {
            // Observações para a montagem da query:
            // - Campos DECIMAL: o separador decimal deve ser ponto ('.') e não vírgula (',').
            // - A ordem dos valores no INSERT deve ser a mesma das colunas na tabela do banco.

            // Utilizando string interpolada ($) para facilitar a leitura da query.
            string query = " INSERT INTO produto VALUES (0, '" + nome + "',  '" + descricao + "', '" + foto + "',  '" + estoque + "',  " + preco_custo.ToString().Replace(",", ".") + ",  " + percentual_lucro.ToString() + ",  " + preco_venda.ToString().Replace(",", ".") + ",   " + status_promocao + ", " + desconto.ToString() + ",  " + preco_promocao.ToString().Replace(",", ".") + ", NOW(), 1,  " + id_marca + ",  " + id_categoria + "); ";

            // Cria um objeto da classe de conexão para executar o comando SQL.
            classConexao cConexao = new classConexao();

            // Chama o método que executa a query e retorna o resultado.
            return cConexao.ExecutaQuery(query);
        }

        public DataTable CarregarMarca()
        {
            string query = " SELECT id_marca , nome FROM marca WHERE status = 1 ORDER BY nome; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable CarregarCategoria()
        {
            string query = " SELECT id_categoria , nome FROM categoria WHERE status = 1 ORDER BY nome; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE Produto POR NOME
        public DataTable ConsultaProdutoNomeInicio(string nomei)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = 1 AND produto.nome LIKE '" + nomei + "%' ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE Produto POR NOME CONTÉM
        public DataTable ConsultaProdutoNomeContem(string nomec)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = 1 AND produto.nome LIKE '%" + nomec + "%' ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsultaProdutoMarca(int marca)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = 1 AND produto.id_marca = " + marca + "  ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsultaProdutoCategoria(int categoria)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = 1 AND produto.id_categoria = " + categoria + "  ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FUNCIONÁRIO POR promocao 
        public DataTable ConsultaProdutoPromocao(int promocao)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = 1 AND produto.status_promocao = " + promocao + " ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FUNCIONÁRIO POR STATUS 
        public DataTable ConsultaProdutoStatus(int status)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Nome', produto.descricao 'Descrição', marca.nome 'Marca', categoria.nome 'Categoria' FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE produto.status = " + status + "  ORDER BY produto.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //MÉTODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUÁRIO ESCOLHER O FUNCIONÁRIO NA GRID PARA EDITAR

        public bool ConsultaProduto(int id)
        {
            //EXIBIR TODOS OS DADOS DO produto ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM produto WHERE id_produto = " + id + " ";


            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_produto = Convert.ToInt32(dt.Rows[0]["id_produto"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                estoque = Convert.ToInt32(dt.Rows[0]["estoque"]);
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                percentual_lucro = Convert.ToInt32(dt.Rows[0]["percentual_lucro"]);
                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);
                status_promocao = Convert.ToInt32(dt.Rows[0]["status_promocao"]);
                desconto = Convert.ToInt32(dt.Rows[0]["desconto"]);
                preco_promocao = Convert.ToDecimal(dt.Rows[0]["preco_promocao"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                id_marca = Convert.ToInt32(dt.Rows[0]["id_marca"]);
                id_categoria = Convert.ToInt32(dt.Rows[0]["id_categoria"]);

                return true;

            }


            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }
        }

        public int AtualizarProduto()
        {
            string query = "UPDATE produto SET nome = '" + nome + "', descricao = '" + descricao + "', estoque = '" + estoque + "', preco_custo = " + preco_custo.ToString().Replace(",", ".") + ", percentual_lucro = " + percentual_lucro + ", preco_venda = " + preco_venda.ToString().Replace(",", ".") + ", status_promocao = " + status_promocao + ", desconto = '" + desconto + "', preco_promocao = " + preco_promocao.ToString().Replace(",", ".") + ", status = " + status + ", id_marca = '" + id_marca + "', id_categoria = '" + id_categoria + "'  WHERE id_produto = " + id_produto + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
        public int ExcluirProduto()
        {
            string query = "DELETE FROM produto WHERE id_produto = " + id_produto + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public DataTable CarregarGridProduto(string produto)
        {
            string query = "SELECT produto.id_produto 'ID', produto.nome 'Produto', marca.nome 'Marca', produto.estoque 'Estoque', produto.preco_venda 'Valor' FROM produto JOIN marca ON produto.id_marca = marca.id_marca WHERE produto.nome LIKE '%" + produto + "%' AND produto.status = 1 AND produto.estoque > 0 ORDER BY produto.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public string BuscaNomeProduto(int id)
        {
            string query = "SELECT nome FROM produto WHERE id_produto = " + id + ";";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(query);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["nome"].ToString();
            }
            return nome;
        }

        public bool AtualizarEstoque(int estoque, int id)
        {
            string query = "UPDATE produto SET estoque = " + estoque + " WHERE id_produto = " + id + ";";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(query);

            if (resp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}