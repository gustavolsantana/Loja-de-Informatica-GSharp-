using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// para adicionar essa linah acima precisa ir em referencias e adicionar a referencia mysqul.data

namespace GSharp
{
    class classConexao
    {

        // MySqlCommand -> TRATA OS TIPOS DE COMANDO E CADA AÇÃO QUE DEVERÁ SER TOMADA, POR EXEMPLO UM SELECT OU INSERT
        // MySqlDataAdapter-> RESULTADO DO ExecuteReader (utilizado para executar uma instrução SQL que retorna um DataReader)
        // MySqlDataAdapter SERÁ USADO PARA EXECUTAR COMANDOS USANDO UM DataSet OU DataTable
        // DataSet -> ARMAZENA DADOS EM EM MEMÓRIA, PODEMOS TER UM CONJUNTO DE TABELAS
        // DataTable -> É UMA TABELA APENAS QUE PODEMOS MONTAR NO AMBIENTE DE PROGRAMAÇÃO, REPRESENTA UMA TABELA DE DADOS NA MEMÓRIA

        //PRECISAMOS USAR UM OBJETO PARA A CONEXÃO COM O BANCO
        //OBJETO MySqlConnection TRATA A CONEXÃO COM O MySQL ou MariaDB
        private MySqlConnection conexao;

        private string erro;

        public classConexao()
        {
            conexao = new MySqlConnection();
            erro = null;
        }

        #region Métodos de Conexão

        private void Conectar()
        {
            // CRIAMOS A STRING CONEXÃO, OU PRECISAMOS PEGAR ESTA STRING DE ALGUM LUGAR CADA SERVIDOR TEM SUA STRING DE CONEXÃO
            //WEB
            //string conexao = @"Persist Security Info = False; Server = 000.000.000.000; Database = NomeBanco; uid = Usuario; pwd= Senha ";

            //LOCAL
            string stringConexao = @"Persist Security Info=False; Server=localhost; Database=gsharp; uid=root; pwd='';";

            //c.State -> STATE É UMA PROPRIEDADE QUE PODEMOS VERIFICAR O ESTADO DA CONEXÃO, COMO NO PROJETO VAMOS SEMPRE FECHAR A CONEXÃO 
            //PODEREMOS MANTER O ESTADO SEMPRE FECHADO DEPENDO DA SITUAÇÃO PODEREMOS REALIZAR E MANTER O ESTADO ABERTO  
            if (conexao.State == ConnectionState.Closed || conexao.State == ConnectionState.Broken)
            {
                conexao.ConnectionString = stringConexao;
                conexao.Open();
            }
        }

        //TODA A CONEXÃO DEVE SER FECHADA E LIBERADA
        //c.Dispose() LIBERA A CONEXÃO
        //c.Close() FECHA A CONEXÃO
        //PODEMOS LIBERAR E FECHAR EM QUALQUER MOMENTO CHAMANDO ESTE MÉTODO
        private void Desconectar()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }
        #endregion


        #region Execução de Comandos

        //MÉTODO UTILIZADO PARA EXECUTAR OS COMANDOS DO BD - INSERT, UPDATE E DELETE
        //EXECUTA A QUERY E DEPENDE DO RETORNO DO BANCO SQL (0 OU 1)
        //0 -> QUANDO GERA ALGUM ERRO
        //1 -> QUANDO OCORRE TUDO CERTO 
        public int ExecutaQuery(string query)
        {
            try
            {
                Conectar();

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.CommandType = CommandType.Text;
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado;
                }
            }
            catch (MySqlException ex)
            {
                erro = ex.Message;
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }

        //MÉTODO PARA EXECUTAR TODOS OS COMANDOS DE CONSULTA        
        // Executa uma consulta SELECT e retorna um DataTable com os resultados       
        public DataTable RetornaDados(string query)
        {
            try
            {
                Conectar();

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.CommandType = CommandType.Text;

                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        dataAdapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
            catch (MySqlException ex)
            {
                erro = ex.Message;
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        // O método ExecuteScalar é utilizado para executar instruções SQL utilizando funções agregadas, como COUNT, SUM, MIN, MAX e AVG.Este método retorna apenas um valor como resultado.
        // O método ExecuteScalar é usado para executar Comandos SQL ou storeprocedure, após a execução retornar um único valor do banco de dados. Ele também retorna a primeira coluna da primeira linha no conjunto de resultados de um banco de dados.
        // USADO PARA CADASTRAR, QUANDO ESPERAMOS O CÓDIGO DE RETORNO, CHAVE PRIMÁRIA(PK)
        // SERÁ USADO NOS CADASTROS NxN
        // Executa uma query que retorna um valor único, como o ID de um registro inserido. 
        public int ExecutaQueryID(string query)
        {
            try
            {
                Conectar();

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.CommandType = CommandType.Text;
                    object resultado = cmd.ExecuteScalar();
                    return Convert.ToInt32(resultado);
                }
            }
            catch (MySqlException ex)
            {
                erro = ex.Message;
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }
        #endregion

    }
}
