using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classFuncionario
    {
        //construtor da classe - inicializar todos os objetos da classe
        //construtor precissa ter o mesmo nome do objeto de referencia
        public classFuncionario()
        {
            id_funcionario = 0;
            nome = null;
            nome_social = null;
            rg = null;
            cpf = null;
            foto = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            salario = 0;
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
            tipo_acesso = 0;
            data_cadastro = DateTime.Now;
            status = 0;
            id_cargo = 0;

        }

        //criar as propriedades da classe:ler e armazenar os dados que serão emviados ao banco ou retornados
        //mesmo nome dos campos do banco e tipo de dado
        //atalho para criar propiedade no c3 "escreva prop clica no tab tab
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public decimal salario { get; set; }
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
        public int tipo_acesso { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public int id_cargo { get; set; }




        //métodos
        // como criar: encapsulamenro(private/public) tipo de retorno (int/string/...) nome do método parametros() - condições

        //método cadastror cargo
        //insart tem que estar na ordem do banco de dados
        public int CadastrarFuncionario()
        {
            //criar uma variavel para o comando insart
            //Campos DATETIME: propriedade.tostring("yyy-MM-dd")
            //Campos decimal: propriedades.tostring().Replace("," , ".")
            //Não pode aspas simples em campo bit
            string query = " INSERT INTO funcionario VALUES (0, '" + nome + "', '" + nome_social + "', '" + rg + "', '" + cpf + "', '" + foto + "', '" + data_nascimento.ToString("yyy-MM-dd") + "', '" + sexo + "', '" + estado_civil + "', '" + salario.ToString().Replace("," , ".") + "', '" + cep + "', '" + estado + "', '" + cidade + "', '" + bairro + "', '" + endereco + "', '" + numero + "', '" + complemento + "', '" + telefone1 + "', '" + telefone2 + "', '" + email + "', '" + usuario + "', '" + senha + "', " + tipo_acesso + ", NOW(), 1, " + id_cargo + "); ";

            //criar obj da clase conexão para usar metodo executaquery
            classConexao cConexao = new classConexao();
            //definir o returne do metodo - chamando o metodo da classe conexãoque vai executar o comando e retornar o resultado 0-erro 1-sucesso
            return cConexao.ExecutaQuery(query);
        }

        //Métodos de consulta
        //Consulta de funcionários por Cidade, Sexo, Nome (Início e Contém), CPF, Cargo, Data de Admissão e Status
        //Consulta de funcionários por Cidade
        public DataTable ConsultaFuncionarioCidade(string Cidade)
        {
            string query = "SELECT funcionario.id_funcionario AS ID, funcionario.nome AS Nome, funcionario.cpf AS CPF, cargo.nome AS Cargo, funcionario.data_nascimento AS 'Data de Nascimento', funcionario.telefone1 AS Telefone FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '"+Cidade+"' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //Consulta de funcionários por Cargo
        public DataTable ConsultaFuncionarioCargo(int Cargo)
        {
            string query = "SELECT funcionario.id_funcionario AS ID, funcionario.nome AS Nome, funcionario.cpf AS CPF, cargo.nome AS Cargo, funcionario.data_nascimento AS 'Data de Nascimento', funcionario.telefone1 AS Telefone FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.id_cargo = " + Cargo + " ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FUNCIONÁRIO POR STATUS 
        public DataTable ConsultaFuncionarioStatus(int status)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = " + status + "  ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FUNCIONÁRIO POR SEXO
        public DataTable ConsultaFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FUNCIONÁRIO POR NOME
        public DataTable ConsultaFuncionarioNomeInicio(string nomei)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '" + nomei + "%' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FUNCIONÁRIO POR NOME CONTÉM
        public DataTable ConsultaFuncionarioNomeContem(string nomec)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '%" + nomec + "%' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CONSULTA DE FUNCIONÁRIO POR CPF
        public DataTable ConsultaFuncionarioCPF(string cpf)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.cpf = '" + cpf + "' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FUNCIONÁRIO POR DATA ADMISSÃO
        public DataTable ConsultaFuncionarioDataAdmissao(DateTime datai, DateTime dataf)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND CAST(funcionario.data_cadastro AS DATE) BETWEEN '" + datai.ToString("yyyy-MM-dd") + "' AND '" + dataf.ToString("yyyy-MM-dd") + "' ORDER BY funcionario.nome; ";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FUNCIONÁRIO POR SEXO E CIDADE
        public DataTable ConsultaFuncionarioSexoCidade(string sexo, string Cidade)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' AND funcionario.cidade = '" + Cidade + "' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //CONSULTA DE FUNCIONÁRIO POR Cidade e Cargo
        public DataTable ConsultaFuncionarioCidadeCargo(string Cidade, int Cargo)
        {
            string query = "SELECT funcionario.id_funcionario 'ID', funcionario.cpf 'CPF',funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.data_nascimento 'Data Nascimento', funcionario.telefone1 'Telefone' FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + Cidade + "' AND funcionario.id_cargo = " + Cargo + " ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


        //MÉTODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUÁRIO ESCOLHER O FUNCIONÁRIO NA GRID PARA EDITAR

        public bool ConsultaFuncionario(int id)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM funcionario WHERE id_funcionario = " + id + " ";


            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                id_funcionario = Convert.ToInt32(dt.Rows[0]["id_funcionario"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                salario = Convert.ToDecimal(dt.Rows[0]["salario"]);
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
                tipo_acesso = Convert.ToInt32(dt.Rows[0]["tipo_acesso"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                id_cargo = Convert.ToInt32(dt.Rows[0]["id_cargo"]);

                return true;

            }


            else //SE A CONSULTA NÃO DER CERTO
            {
                return false;
            }

        }

        //Método para carregar a combo de cidade no formConsultaFuncionario
        public DataTable CarregarCidade()
        {
            string query = "SELECT DISTINCT cidade FROM funcionario ORDER BY cidade;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //MÉTODO PARA ATUALIZAR FUNCIONÁRIO
        public int AtualizarFuncionario()
        {
            string query = "UPDATE funcionario SET nome_social =  '" + nome_social + "', nome = '" + nome + "', rg = '" + rg + "', cpf =  '" + cpf + "', estado_civil = '" + estado_civil + "',data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "', telefone1 ='" + telefone1 + "', telefone2 = '" + telefone2 + "', email = '" + email + "', estado ='" + estado + "', cep = '" + cep + "', complemento = '" + complemento + "', cidade = '" + cidade + "', numero = '" + numero + "',  endereco ='" + endereco + "', bairro = '" + bairro + "', usuario ='" + usuario + "', senha = '" + senha + "', status = " + status + ", id_cargo = " + id_cargo + ", salario = " + salario.ToString().Replace(",", ".") + ", tipo_acesso = " + tipo_acesso + ", foto = '" + foto + "' WHERE id_funcionario = " + id_funcionario + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //MÉTODO PARA EXCLUIR FUNCIONÁRIO
        public int ExcluirFuncionario()
        {
            string query = "DELETE FROM funcionario WHERE id_funcionario = " + id_funcionario + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //MÉTODO PARA RELATÓRIO DE FUNCIONÁRIO
        //CIDADE
        public DataTable RelatorioFuncionarioCidade(string Cidade)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + Cidade + "' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //relatório de funcionários por Cargo
        public DataTable RelatorioFuncionarioCargo(int Cargo)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.id_cargo = " + Cargo + " ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //relatório DE FUNCIONÁRIO POR STATUS 
        public DataTable RelatorioFuncionarioStatus(int status)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = " + status + "  ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //relatório DE FUNCIONÁRIO POR SEXO
        public DataTable RelatorioFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' ORDER BY funcionario.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATORIO DE FUNCIONÁRIO POR DATA ADMISSÃO
        public DataTable RelatorioFuncionarioDataAdmissao(DateTime datai, DateTime dataf)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND CAST(funcionario.data_cadastro AS DATE) BETWEEN '" + datai.ToString("yyyy-MM-dd") + "' AND '" + dataf.ToString("yyyy-MM-dd") + "' ORDER BY funcionario.nome; ";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATÓRIO DE FUNCIONÁRIO POR MES DE ANIVERSÁRIO
        public DataTable RelatorioFuncionarioMesAniversario(int mes)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND MONTH(funcionario.data_nascimento) = " + mes + " ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //RELATÓRIO DE FUNCIONÁRIO POR IDADE
        public DataTable RelatorioFuncionarioIdade(int idadei, int idadef)
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome, funcionario.cpf, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.telefone1, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND TIMESTAMPDIFF(YEAR, funcionario.data_nascimento, NOW()) BETWEEN " + idadei + " AND " + idadef + " ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable BuscarFuncionario()
        {
            string query = "SELECT funcionario.id_funcionario, funcionario.nome FROM funcionario JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE funcionario.status = 1 AND cargo.nome LIKE '%vendedor%' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(query);
        }
    }
}
