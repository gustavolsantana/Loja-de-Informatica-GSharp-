$(document).ready(function() {
    
    function calcularPrecoVenda(triggerPromoUpdate = true) {
        var precoCustoText = $('#preco_custo').val().replace('.', '').replace(',', '.');
        
        var custo = parseFloat(precoCustoText) || 0;
        var lucroPercentual = parseInt($('#percentual_lucro').val()) || 0; 

        var precoVenda = 0;

        if (custo > 0 && lucroPercentual >= 0) {
            var lucroDecimal = lucroPercentual / 100;
            precoVenda = custo * (1 + lucroDecimal);
            $('#preco_venda').val(precoVenda.toFixed(2).replace('.', ','));
        } else {
            $('#preco_venda').val('');
        }

        // Se a chamada veio do keyup, não ativamos a atualização de promoção,
        // mas se veio do blur, ativamos.
        if (triggerPromoUpdate) {
            atualizarPromocao(); 
        }
    }

    function calcularPrecoPromocao() {
        var precoVendaText = $('#preco_venda').val().replace('.', '').replace(',', '.');
        var precoCustoText = $('#preco_custo').val().replace('.', '').replace(',', '.');
        
        var precoVenda = parseFloat(precoVendaText) || 0;
        var desconto = parseInt($('#desconto').val()) || 0; 
        var custo = parseFloat(precoCustoText) || 0;
        
        var precoPromocao = 0;

        if (precoVenda > 0) {
            if (desconto > 0) {
                var descontoDecimal = desconto / 100;
                precoPromocao = precoVenda * (1 - descontoDecimal);
            } else {
                precoPromocao = precoVenda;
            }
            
            // A VALIDAÇÃO É EXECUTADA AQUI (FORA DE FOCO)
            if (precoPromocao < custo) {
                alert('O preço de promoção não pode ser menor que o preço de custo. O desconto será ajustado para 0.');
                $('#desconto').val('0'); 
                precoPromocao = precoVenda;
            }

            $('#preco_promocao').val(precoPromocao.toFixed(2).replace('.', ','));
            
        } else {
            $('#preco_promocao').val('');
        }
    }

    function atualizarPromocao() {
        var statusPromocao = $('#status_promocao').val();
        var $desconto = $('#desconto');

        if (statusPromocao === '1') {
            $desconto.prop('disabled', false);
            // Chama a função de cálculo e verificação de custo
            calcularPrecoPromocao();
        } else {
            $desconto.val('');
            $desconto.prop('disabled', true);
            $('#preco_promocao').val('');
        }
    }

    // 🚀 EVENTOS EM TEMPO REAL (KEYUP) para cálculo do Preço de Venda
    // Passamos 'false' para evitar que o cálculo de promoção/verificação seja acionado
    $('#preco_custo, #percentual_lucro').on('keyup', function() {
        calcularPrecoVenda(false);
    });

    // 🛑 EVENTOS FORA DE FOCO (BLUR/CHANGE) para cálculo da Promoção e Verificação
    $('#preco_custo, #percentual_lucro').on('blur', function() {
        // Quando sai do campo, refaz o cálculo e dispara a verificação
        calcularPrecoVenda(true);
    });

    $('#status_promocao').on('change', atualizarPromocao);
    $('#desconto').on('blur', atualizarPromocao);
    
    // Inicialização
    calcularPrecoVenda();
});