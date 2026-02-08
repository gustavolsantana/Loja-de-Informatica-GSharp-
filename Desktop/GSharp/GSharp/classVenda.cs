using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GSharp
{
    class classPedido
    {
        public classPedido()
        {
            id_pedido = 0;
            valor_total = 0;
            desconto = 0;
            troco = 0;
            data_pedido = DateTime.Now;
            id_cliente = 0;
            id_funcionario = 0;
        }

        public int id_pedido { get; set; }
        public decimal valor_total { get; set; }
        public decimal desconto { get; set; }
        public decimal troco { get; set; }
        public DateTime data_pedido { get; set; }
        public int id_cliente { get; set; }
        public int id_funcionario { get; set; }


        public bool CadastrarVenda()
        {
            string query = "INSERT INTO pedido VALUES (0, '" + valor_total.ToString().Replace(",", ".") + "', '" + desconto.ToString().Replace(",", ".") + "', '" + troco.ToString().Replace(",", ".") + "', NOW(), " + id_cliente + ", " + id_funcionario + "); SELECT LAST_INSERT_ID()";

            classConexao cConexao = new classConexao();

            id_pedido = 0;
            id_pedido = cConexao.ExecutaQueryID(query);

            if (id_pedido != 0)
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
