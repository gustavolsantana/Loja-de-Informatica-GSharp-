using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classCategoria
    {
        //construtor da classe - inicializar todos os objetos da classe
        //construtor precissa ter o mesmo nome do objeto de referencia
        public classCategoria()
        {
            id_categoria = 0;
            nome = null;
            observacao = null;
            data_cadastro = DateTime.Now;
            status = 0;
        }

        //criar as propriedades da classe:ler e armazenar os dados que serão emviados ao banco ou retornados
        //mesmo nome dos campos do banco e tipo de dado
        //atalho para criar propiedade no c3 "escreva prop clica no tab tab
        public int id_categoria { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        //métodos
        // como riar: encapsulamenro(private/public) tipo de retorno (int/string/...) nome do método parametros() - condições

        //método cadastror categoria
        //insart tem que estar na ordem do banco de dados
        public int CadastrarCategoria()
        {
            //criar uma variavel para o comando insart
            string query = " INSERT INTO categoria VALUES (0, '" + nome + "',  '" + observacao + "', NOW(), 1); ";

            //criar obj da clase conexão para usar metodo executaquery
            classConexao cConexao = new classConexao();
            //definir o returne do metodo - chamando o metodo da classe conexãoque vai executar o comando e retornar o resultado 0-erro 1-sucesso
            return cConexao.ExecutaQuery(query);
        }


        public DataTable CarregarCategoria()
        {
            string query = " SELECT id_categoria , nome FROM categoria WHERE status = 1 ORDER BY nome; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE CATEGORIA POR NOME
        public DataTable ConsultaCategoriaNomeInicio(string nomei)
        {
            string query = "SELECT id_categoria 'ID', nome 'Categoria', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM categoria WHERE status = 1 AND nome LIKE '" + nomei + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE CATEGORIA POR NOME CONTÉM
        public DataTable ConsultaCategoriaNomeContem(string nomec)
        {
            string query = "SELECT id_categoria 'ID', nome 'Categoria', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM categoria WHERE status = 1 AND nome LIKE '%" + nomec + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        public DataTable ConsultaCategoriaStatus(int status)
        {
            string query = "SELECT id_categoria 'ID', nome 'Categoria', observacao 'Observacao', data_cadastro 'Data do Cadastro' FROM categoria WHERE status = " + status + " ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        public bool ConsultaCategoria(int id)
        {
            //EXIBIR TODOS OS DADOS DO CATEGORIA ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM categoria WHERE id_categoria = " + id + " ";


            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO CATEGORIA
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_categoria = Convert.ToInt32(dt.Rows[0]["id_categoria"]);
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

        public int AtualizarCategoria()
        {
            string query = "UPDATE categoria SET nome = '" + nome + "', status = " + status + ", observacao = '" + observacao + "' WHERE id_categoria = " + id_categoria + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
        public int ExcluirCategoria()
        {
            string query = "DELETE FROM categoria WHERE id_categoria = " + id_categoria + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
    }
}
