using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSharp
{
    class classDetalhePagamento
    {
        public classDetalhePagamento()
        {
            id_detalhe_pagamento = 0;
            valor_pago = 0;
            numero_parcelas = 0;
            valor_das_parcelas = 0;
            id_pedido = 0;
            id_forma_pagamento = 0;
        }

        public int id_detalhe_pagamento { get; set; }
        public decimal valor_pago { get; set; }
        public int numero_parcelas{ get; set; }
        public decimal valor_das_parcelas{ get; set; }
        public int id_pedido { get; set; }
        public int id_forma_pagamento { get; set; }

        public bool CadastrarDetalhePagamento()
        {
            // CORREÇÃO: Adicionado o parêntese ')' final
            string query = "INSERT INTO detalhe_pagamento VALUES (0, " + valor_pago.ToString().Replace(",", ".") + ", '" + numero_parcelas + "', '" + valor_das_parcelas.ToString().Replace(",", ".") + "', '" + id_pedido + "', '" + id_forma_pagamento + "');";

            classConexao cConexao = new classConexao();
            int resp = cConexao.ExecutaQuery(query);

            // CORREÇÃO: Retorna true se o banco confirmou a inserção
            return resp == 1;
        }
    }
}
