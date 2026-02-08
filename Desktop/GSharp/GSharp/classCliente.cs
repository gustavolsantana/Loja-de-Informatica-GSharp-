using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classCliente
    {
        //construtor da classe - inicializar todos os objetos da classe
        //construtor precissa ter o mesmo nome do objeto de referencia
        public classCliente()
        {
            id_cliente = 0;
            nome = null;
            nome_social = null;
            rg = null;
            cpf = null;
            foto = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            cep = null;
            estado = null;
            cidade = null;
            bairro = null;
            endereco = null;
            numero = null;
            complemento = null;
            telefone1 = null;
            telefone2 = null;
            email = null;
            usuario = null;
            senha = null;
            data_cadastro = DateTime.Now;
            status = 0;

        }

        //criar as propriedades da classe:ler e armazenar os dados que serão emviados ao banco ou retornados
        //mesmo nome dos campos do banco e tipo de dado
        //atalho para criar propiedade no c3 "escreva prop clica no tab tab
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }




        //métodos
        // como criar: encapsulamenro(private/public) tipo de retorno (int/string/...) nome do método parametros() - condições

        //método cadastror cargo
        //insart tem que estar na ordem do banco de dados
        public int CadastrarCliente()
        {
            //criar uma variavel para o comando insart
            //Campos DATETIME: propriedade.tostring("yyy-MM-dd")
            //Campos decimal: propriedades.tostring().Replace("," , ".")
            //Não pode aspas simples em campo bit
            string query = " INSERT INTO cliente VALUES (0, '" + nome + "', '" + nome_social + "', '" + rg + "', '" + cpf + "', '" + foto + "', '" + data_nascimento.ToString("yyy-MM-dd") + "', '" + sexo + "', '" + estado_civil + "', '" + cep + "', '" + estado + "', '" + cidade + "', '" + bairro + "', '" + endereco + "', '" + numero + "', '" + complemento + "', '" + telefone1 + "', '" + telefone2 + "', '" + email + "', '" + usuario + "', '" + senha + "', NOW(), 1); ";

            //criar obj da clase conexão para usar metodo executaquery
            classConexao cConexao = new classConexao();
            //definir o returne do metodo - chamando o metodo da classe conexãoque vai executar o comando e retornar o resultado 0-erro 1-sucesso
            return cConexao.ExecutaQuery(query);
        }

        public DataTable ConsultaClienteCidade(string Cidade)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND cidade = '" + Cidade + "' ORDER BY nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE Cliente POR STATUS 
        public DataTable ConsultaClienteStatus(int status)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = " + status + "  ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE Cliente POR SEXO
        public DataTable ConsultaClienteSexo(string sexo)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND sexo = '" + sexo + "' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE Cliente POR NOME
        public DataTable ConsultaClienteNomeInicio(string nomei)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND nome LIKE '" + nomei + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE Cliente POR NOME CONTÉM
        public DataTable ConsultaClienteNomeContem(string nomec)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND nome LIKE '%" + nomec + "%' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE Cliente POR CPF
        public DataTable ConsultaClienteCPF(string cpf)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND cpf = '" + cpf + "' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE Cliente POR DATA ADMISSÃO
        public DataTable ConsultaClienteDataAdmissao(DateTime datai, DateTime dataf)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND CAST(data_cadastro AS DATE) BETWEEN '" + datai.ToString("yyyy-MM-dd") + "' AND '" + dataf.ToString("yyyy-MM-dd") + "' ORDER BY nome; ";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE Cliente POR SEXO E CIDADE
        public DataTable ConsultaClienteSexoCidade(string sexo, string Cidade)
        {
            string query = "SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF, data_nascimento AS 'Data de Nascimento', telefone1 AS Telefone FROM cliente WHERE status = 1 AND sexo = '" + sexo + "' AND cidade = '" + Cidade + "' ORDER BY nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //MÉTODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUÁRIO ESCOLHER O Cliente NA GRID PARA EDITAR

        public bool ConsultaCliente(int id)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM cliente WHERE id_cliente = " + id + " ";


            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO cliente
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_cliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToString(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                telefone1 = Convert.ToString(dt.Rows[0]["telefone1"]);
                telefone2 = Convert.ToString(dt.Rows[0]["telefone2"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;

            }


            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }

        }
        //Método para carregar a combo de cidade no formConsultacliente
        public DataTable CarregarCidade()
        {
            string query = "SELECT DISTINCT cidade FROM cliente ORDER BY cidade;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //ATUALIZAR CLIENTE
        public int AtualizarCliente()
        {
            string query = "UPDATE cliente SET nome_social =  '" + nome_social + "', nome = '" + nome + "', rg = '" + rg + "', cpf =  '" + cpf + "', estado_civil = '" + estado_civil + "',data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "', telefone1 ='" + telefone1 + "', telefone2 = '" + telefone2 + "', email = '" + email + "', estado ='" + estado + "', cep = '" + cep + "', complemento = '" + complemento + "', cidade = '" + cidade + "', numero = '" + numero + "',  endereco ='" + endereco + "', bairro = '" + bairro + "', usuario ='" + usuario + "', senha = '" + senha + "', status = " + status + ", foto = '" + foto + "' WHERE id_cliente = " + id_cliente + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //MÉTODO PARA RELATÓRIO DE FUNCIONÁRIO
        //CIDADE
        public DataTable RelatorioClienteCidade(string Cidade)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '" + Cidade + "' ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //relatório DE FUNCIONÁRIO POR STATUS 
        public DataTable RelatorioClienteStatus(int status)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = " + status + "  ORDER BY cliente.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //relatório DE FUNCIONÁRIO POR SEXO
        public DataTable RelatorioClienteSexo(string sexo)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND cliente.sexo = '" + sexo + "' ORDER BY cliente.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATORIO DE FUNCIONÁRIO POR DATA ADMISSÃO
        public DataTable RelatorioClienteDataAdmissao(DateTime datai, DateTime dataf)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND CAST(cliente.data_cadastro AS DATE) BETWEEN '" + datai.ToString("yyyy-MM-dd") + "' AND '" + dataf.ToString("yyyy-MM-dd") + "' ORDER BY cliente.nome; ";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATÓRIO DE FUNCIONÁRIO POR MES DE ANIVERSÁRIO
        public DataTable RelatorioclienteMesAniversario(int mes)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND MONTH(cliente.data_nascimento) = " + mes + " ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATÓRIO DE FUNCIONÁRIO POR IDADE
        public DataTable RelatorioClienteIdade(int idadei, int idadef)
        {
            string query = "SELECT cliente.id_cliente, cliente.nome, cliente.cpf, cliente.data_nascimento, cliente.telefone1, cliente.cidade, cliente.sexo, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND TIMESTAMPDIFF(YEAR, cliente.data_nascimento, NOW()) BETWEEN " + idadei + " AND " + idadef + " ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //EXCLUIR CLIENTE
        public int ExcluirCliente()
        {
            string query = "DELETE FROM cliente WHERE id_cliente = " + id_cliente + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public DataTable CarregarGridCliente(string nomec)
        {
            string query = "SELECT id_cliente 'ID', cpf 'CPF', nome 'Nome' FROM cliente WHERE nome LIKE '%" + nomec + "%' AND status = 1 ORDER BY nome;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(query);
        }

        public DataTable BuscarCliente()
        {
            string query = "SELECT cliente.id_cliente, cliente.nome FROM cliente WHERE cliente.status = 1 ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(query);
        }
    }
}
