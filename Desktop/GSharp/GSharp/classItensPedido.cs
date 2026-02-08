using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSharp
{
    class classItensPedido
    {
        public classItensPedido()
        {
            id_itens_pedido = 0;
            quantidade = 0;
            preco_unitario = 0;
            valor_total = 0;
            id_produto = 0;
            id_pedido = 0;
        }

        public int id_itens_pedido { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal valor_total { get; set; }
        public int id_produto { get; set; }
        public int id_pedido { get; set; }

        public bool CadastrarItensPedido()
        {
            // CORREÇÃO: Adicionado o parêntese ')' que faltava antes do ponto e vírgula
            string query = "INSERT INTO itens_pedido VALUES (0, '" + quantidade + "', " + preco_unitario.ToString().Replace(",", ".") + ", " + valor_total.ToString().Replace(",", ".") + ", '" + id_produto + "', '" + id_pedido + "');";

            classConexao cConexao = new classConexao();
            int resp = cConexao.ExecutaQuery(query);

            // CORREÇÃO: Retorna true se o banco confirmou a inserção (resp == 1)
            return resp == 1;
        }
    }
}
