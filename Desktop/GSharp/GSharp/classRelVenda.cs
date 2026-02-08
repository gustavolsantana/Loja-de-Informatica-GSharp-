using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classRelVenda
    {
        //CLASSE PARA ALIMENTAR O RELATÓRIO DE VENDAS DETALHADO

        //CONSTRUTOR
        public classRelVenda()
        {
            //CLASS VENDA
            id_pedido = 0;
            valor_total = 0;
            desconto = 0;
            troco = 0;
            data_pedido = DateTime.Now;
            id_cliente = 0;
            id_funcionario = 0;

            //CLASSE ITENS VENDA

            id_itens_pedido = 0;
            quantidade = 0;
            preco_unitario = 0;
            valor_total_iten = 0;
            id_produto = 0;

            //MARCA DO PRODUTO
            id_marca = 0;

            //CLASS FORMA DE PAGAMENTO
            id_forma_pagamento = 0;

        }

        //PROPRIEDADES

        //CLASS VENDA
        public int id_pedido { get; set; }
        public decimal valor_total { get; set; }
        public decimal desconto { get; set; }
        public decimal troco { get; set; }
        public DateTime data_pedido { get; set; }
        public int id_cliente { get; set; }
        public int id_funcionario { get; set; }

        //CLASS ITENS VENDA
        public int id_itens_pedido { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal valor_total_iten { get; set; }
        public int id_produto { get; set; }

        //CLASS MARCA
        public int id_marca { get; set; }

        //CLASS FORMA DE PAGAMENTO
        public int id_forma_pagamento { get; set; }

        //MÉTODOS DE RELATÓRIO

        //RELATÓRIO DE VENDA POR PERÍODO
        public DataTable RelVendaPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            string query = "SELECT pedido.id_pedido, pedido.data_pedido, pedido.desconto, pedido.valor_total, pagamentos_agrupados.formas_pagamento 'id_forma_pagamento', cliente.nome 'id_cliente', funcionario.nome 'id_funcionario', SUM(itens_pedido.quantidade) AS quantidade, itens_pedido.preco_unitario, SUM(itens_pedido.valor_total) AS valor_total_iten, produto.nome 'id_produto', marca.nome 'id_marca' FROM pedido JOIN itens_pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN produto ON produto.id_produto = itens_pedido.id_produto JOIN marca ON marca.id_marca = produto.id_marca JOIN cliente ON cliente.id_cliente = pedido.id_cliente JOIN funcionario ON funcionario.id_funcionario = pedido.id_funcionario LEFT JOIN (SELECT dp.id_pedido, GROUP_CONCAT(DISTINCT fp.nome SEPARATOR ', ') AS formas_pagamento FROM detalhe_pagamento dp JOIN forma_pagamento fp ON dp.id_forma_pagamento = fp.id_forma_pagamento GROUP BY dp.id_pedido) AS pagamentos_agrupados ON pagamentos_agrupados.id_pedido = pedido.id_pedido WHERE CAST(pedido.data_pedido AS DATE) BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFim.ToString("yyyy-MM-dd") + "' GROUP BY pedido.id_pedido, produto.id_produto, itens_pedido.preco_unitario ORDER BY pedido.data_pedido;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelVendaPeriodoeCliente(DateTime dataInicio, DateTime dataFim,int cliente)
        {
            string query = "SELECT pedido.id_pedido, pedido.data_pedido, pedido.desconto, pedido.valor_total, pagamentos_agrupados.formas_pagamento 'id_forma_pagamento', cliente.nome 'id_cliente', funcionario.nome 'id_funcionario', SUM(itens_pedido.quantidade) AS quantidade, itens_pedido.preco_unitario, SUM(itens_pedido.valor_total) AS valor_total_iten, produto.nome 'id_produto', marca.nome 'id_marca' FROM pedido JOIN itens_pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN produto ON produto.id_produto = itens_pedido.id_produto JOIN marca ON marca.id_marca = produto.id_marca JOIN cliente ON cliente.id_cliente = pedido.id_cliente JOIN funcionario ON funcionario.id_funcionario = pedido.id_funcionario LEFT JOIN(SELECT dp.id_pedido, GROUP_CONCAT(DISTINCT fp.nome SEPARATOR ', ') AS formas_pagamento FROM detalhe_pagamento dp JOIN forma_pagamento fp ON dp.id_forma_pagamento = fp.id_forma_pagamento GROUP BY dp.id_pedido) AS pagamentos_agrupados ON pagamentos_agrupados.id_pedido = pedido.id_pedido WHERE CAST(pedido.data_pedido AS DATE) BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFim.ToString("yyyy-MM-dd") + "' AND cliente.id_cliente = '" + cliente + "' GROUP BY pedido.id_pedido, produto.id_produto, itens_pedido.preco_unitario ORDER BY pedido.data_pedido; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelVendaPeriodoeFuncionario(DateTime dataInicio, DateTime dataFim, int funcionario)
        {
            string query = "SELECT pedido.id_pedido, pedido.data_pedido, pedido.desconto, pedido.valor_total, pagamentos_agrupados.formas_pagamento 'id_forma_pagamento', cliente.nome 'id_cliente', funcionario.nome 'id_funcionario', SUM(itens_pedido.quantidade) AS quantidade, itens_pedido.preco_unitario, SUM(itens_pedido.valor_total) AS valor_total_iten, produto.nome 'id_produto', marca.nome 'id_marca' FROM pedido JOIN itens_pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN produto ON produto.id_produto = itens_pedido.id_produto JOIN marca ON marca.id_marca = produto.id_marca JOIN cliente ON cliente.id_cliente = pedido.id_cliente JOIN funcionario ON funcionario.id_funcionario = pedido.id_funcionario LEFT JOIN (SELECT dp.id_pedido, GROUP_CONCAT(DISTINCT fp.nome SEPARATOR ', ') AS formas_pagamento FROM detalhe_pagamento dp JOIN forma_pagamento fp ON dp.id_forma_pagamento = fp.id_forma_pagamento GROUP BY dp.id_pedido) AS pagamentos_agrupados ON pagamentos_agrupados.id_pedido = pedido.id_pedido WHERE CAST(pedido.data_pedido AS DATE) BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFim.ToString("yyyy-MM-dd") + "' AND cliente.id_cliente = '" + funcionario + "' GROUP BY pedido.id_pedido, produto.id_produto, itens_pedido.preco_unitario ORDER BY pedido.data_pedido;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelVendaCliente(int cliente)
        {
            string query = "SELECT pedido.id_pedido, pedido.data_pedido, pedido.desconto, pedido.valor_total, pagamentos_agrupados.formas_pagamento 'id_forma_pagamento', cliente.nome 'id_cliente', funcionario.nome 'id_funcionario', SUM(itens_pedido.quantidade) AS quantidade, itens_pedido.preco_unitario, SUM(itens_pedido.valor_total) AS valor_total_iten, produto.nome 'id_produto', marca.nome 'id_marca' FROM pedido JOIN itens_pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN produto ON produto.id_produto = itens_pedido.id_produto JOIN marca ON marca.id_marca = produto.id_marca JOIN cliente ON cliente.id_cliente = pedido.id_cliente JOIN funcionario ON funcionario.id_funcionario = pedido.id_funcionario LEFT JOIN (SELECT dp.id_pedido, GROUP_CONCAT(DISTINCT fp.nome SEPARATOR ', ') AS formas_pagamento FROM detalhe_pagamento dp JOIN forma_pagamento fp ON dp.id_forma_pagamento = fp.id_forma_pagamento GROUP BY dp.id_pedido) AS pagamentos_agrupados ON pagamentos_agrupados.id_pedido = pedido.id_pedido WHERE cliente.id_cliente = '" + cliente + "' GROUP BY pedido.id_pedido, produto.id_produto, itens_pedido.preco_unitario ORDER BY pedido.data_pedido;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelVendaFuncionario(int funcionario)
        {
            string query = "SELECT pedido.id_pedido, pedido.data_pedido, pedido.desconto, pedido.valor_total, pagamentos_agrupados.formas_pagamento 'id_forma_pagamento', cliente.nome 'id_cliente', funcionario.nome 'id_funcionario', SUM(itens_pedido.quantidade) AS quantidade, itens_pedido.preco_unitario, SUM(itens_pedido.valor_total) AS valor_total_iten, produto.nome 'id_produto', marca.nome 'id_marca' FROM pedido JOIN itens_pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN produto ON produto.id_produto = itens_pedido.id_produto JOIN marca ON marca.id_marca = produto.id_marca JOIN cliente ON cliente.id_cliente = pedido.id_cliente JOIN funcionario ON funcionario.id_funcionario = pedido.id_funcionario LEFT JOIN (SELECT dp.id_pedido, GROUP_CONCAT(DISTINCT fp.nome SEPARATOR ', ') AS formas_pagamento FROM detalhe_pagamento dp JOIN forma_pagamento fp ON dp.id_forma_pagamento = fp.id_forma_pagamento GROUP BY dp.id_pedido) AS pagamentos_agrupados ON pagamentos_agrupados.id_pedido = pedido.id_pedido WHERE cliente.id_cliente = '" + funcionario + "' GROUP BY pedido.id_pedido, produto.id_produto, itens_pedido.preco_unitario ORDER BY pedido.data_pedido;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
    }
}
