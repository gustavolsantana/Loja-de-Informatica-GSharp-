using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classFormaPagamento
    {
        //construtor da classe - inicializar todos os objetos da classe
        //construtor precissa ter o mesmo nome do objeto de referencia
        public classFormaPagamento()
        {
            id_forma_pagamento = 0;
            nome = null;
            observacao = null;
            permite_parcelas = 0;
            data_cadastro = DateTime.Now;
            status = 0;
        }

        //criar as propriedades da classe:ler e armazenar os dados que serão emviados ao banco ou retornados
        //mesmo nome dos campos do banco e tipo de dado
        //atalho para criar propiedade no c3 "escreva prop clica no tab tab
        public int id_forma_pagamento { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int permite_parcelas { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        //métodos
        // como criar: encapsulamenro(private/public) tipo de retorno (int/string/...) nome do método parametros() - condições

        //método cadastror FormaPagamento
        //insart tem que estar na ordem do banco de dados
        public int CadastrarFormaPagamento()
        {
            //criar uma variavel para o comando insart
            string query = " INSERT INTO forma_pagamento VALUES (0, '" + nome + "',  '" + observacao + "', NOW(), 1); ";

            //criar obj da clase conexão para usar metodo executaquery
            classConexao cConexao = new classConexao();
            //definir o returne do metodo - chamando o metodo da classe conexãoque vai executar o comando e retornar o resultado 0-erro 1-sucesso
            return cConexao.ExecutaQuery(query);
        }


        public DataTable CarregarFormaPagamento()
        {
            string query = " SELECT id_forma_pagamento, nome FROM forma_pagamento WHERE status = 1 ORDER BY nome; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FormaPagamento POR NOME
        public DataTable ConsultaFormaPagamentoNomeInicio(string nomei)
        {
            string query = "SELECT id_forma_pagamento 'ID', nome 'Forma de Pagamento', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM forma_pagamento WHERE status = 1 AND nome LIKE '" + nomei + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FormaPagamento POR NOME CONTÉM
        public DataTable ConsultaFormaPagamentoNomeContem(string nomec)
        {
            string query = "SELECT id_forma_pagamento 'ID', nome 'Forma de Pagamento', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM forma_pagamento WHERE status = 1 AND nome LIKE '%" + nomec + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        public DataTable ConsultaFormaPagamentoStatus(int status)
        {
            string query = "SELECT id_forma_pagamento 'ID', nome 'Forma de Pagamento', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM forma_pagamento WHERE status = " + status + " ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        public bool ConsultaFormaPagamento(int id)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM forma_pagamento WHERE id_forma_pagamento = " + id + " ";


            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_forma_pagamento = Convert.ToInt32(dt.Rows[0]["id_forma_pagamento"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;

            }


            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }

        }


        public int AtualizarFormaPagamento()
        {
            string query = "UPDATE forma_pagamento SET nome = '" + nome + "', status = " + status + ", observacao = '" + observacao + "' WHERE id_forma_pagamento = " + id_forma_pagamento + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
        public int ExcluirFormaPagamento()
        {
            string query = "DELETE FROM forma_pagamento WHERE id_forma_pagamento = " + id_forma_pagamento + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public string BuscaNomeFormaPagamento(int id)
        {
            string query = "SELECT nome FROM forma_pagamento WHERE id_forma_pagamento = " + id + ";";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(query);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["nome"].ToString();
            }
            return nome;
        }
    }
}
