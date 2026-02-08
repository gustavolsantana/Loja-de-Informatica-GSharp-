<?php
require_once("conection/conecta.php");
session_start();

// 1. CAPTURA DO ID
if (isset($_GET['id_produto'])) {
    $id = mysqli_real_escape_string($conexao, $_GET['id_produto']);

    $sql = "SELECT * FROM produto WHERE id_produto = '$id'";
    $res = mysqli_query($conexao, $sql);
    $produto = mysqli_fetch_assoc($res);

    // Se o produto não existir no banco, redireciona
    if (!$produto) {
        header("Location: pesquisa.php");
        exit;
    }

    // 2. LÓGICA VISTO RECENTEMENTE
    if (!isset($_SESSION['vistos'])) {
        $_SESSION['vistos'] = [];
    }

    // Se o produto já estiver na lista, removemos para reinseri-lo no final (topo do histórico)
    if (($chave = array_search($id, $_SESSION['vistos'])) !== false) {
        unset($_SESSION['vistos'][$chave]);
    }

    // Adiciona o ID ao final do array
    $_SESSION['vistos'][] = $id;

    // Mantém apenas os últimos 12 produtos no histórico
    if (count($_SESSION['vistos']) > 12) {
        array_shift($_SESSION['vistos']);
    }

    // 3. FORMATAÇÃO DE PREÇOS
    $promo_ativa = $produto['status_promocao'];
    if ($promo_ativa == 1) {
        $preco_de = "de R$ " . number_format($produto['preco_venda'], 2, ',', '.');
        $preco_por = "R$ " . number_format($produto['preco_promocao'], 2, ',', '.');
        $exibir_desconto = $produto['desconto'] . "% de Desconto";
    } else {
        $preco_de = "&nbsp;";
        $preco_por = "R$ " . number_format($produto['preco_venda'], 2, ',', '.');
        $valor_parcela = $produto['preco_venda'] / 12;
        $exibir_desconto = "Ou até 12x de R$ " . number_format($valor_parcela, 2, ',', '.');
    }

    $caminho_imagem = "images/" . $produto['foto'];
    if (empty($produto['foto']) || !file_exists($caminho_imagem)) {
        $caminho_imagem = "assets/img/placeholder-produto.jpg";
    }
} else {
    // Se não houver ID na URL, volta para a pesquisa
    header("Location: pesquisa.php");
    exit;
}
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php echo $produto['nome']; ?> | GSharp</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Exo+2:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
</head>

<body>

    <?php include('cabecalho.php'); ?>

    <div class="container">
        <div class="main">
            <div class="imagem-principal">
                <img src="<?php echo $caminho_imagem; ?>" alt="<?php echo $produto['nome']; ?>">
            </div>
            <div class="resumo-do-produto">
                <div class="banner3"><img src="assets/img/mini-banner3.png" alt="BANNER3"></div>
                <div class="nome-do-produto"><?php echo $produto['nome']; ?></div>
                <div class="estoque">Estoque: <?php echo $produto['estoque']; ?></div>
                <div class="de-por"><?php echo $preco_de; ?> por:</div>
                <div class="a-vista"><?php echo $preco_por; ?> À Vista</div>
                <div class="desconto"><?php echo $exibir_desconto; ?></div>

                <form action="carrinho_acoes.php" method="POST">
                    <input type="hidden" name="id_produto" value="<?php echo $produto['id_produto']; ?>">
                    <button type="submit" name="adicionar">
                        Adicionar ao carrinho
                    </button>
                </form>
            </div>
        </div>

        <div class="descricao">
            <h2>Descrição do Produto</h2>
            <?php if (!empty($produto['descricao'])): ?>
                <span><?php echo $produto['descricao']; ?></span>
            <?php else: ?>
                <p style="color: #cacaca; font-style: italic; margin-top: 10px;">
                    <i class="bi bi-info-circle"></i> Não há uma descrição para este produto.
                </p>
            <?php endif; ?>
        </div>

        <div class="secao-relacionados">
            <h4>Produtos Relacionados</h4>
            <div class="carrossel-container">
                <button class="seta-carrossel anterior" onclick="moverCarrossel(-1)">&#10094;</button>

                <div class="carrossel-janela">
                    <div class="carrossel-track" id="track">
                        <?php
                        $id_cat = $produto['id_categoria'];
                        $sql_rel = "SELECT * FROM produto WHERE id_categoria = '$id_cat' AND id_produto != '$id' AND status = 1 LIMIT 12";
                        $res_rel = mysqli_query($conexao, $sql_rel);

                        while ($rel = mysqli_fetch_assoc($res_rel)) {
                            $f_rel = (empty($rel['foto']) || !file_exists("images/" . $rel['foto'])) ? "assets/img/placeholder-produto.jpg" : "images/" . $rel['foto'];

                            $promo_rel = $rel['status_promocao'];
                            if ($promo_rel == 1) {
                                $p_de = "de R$ " . number_format($rel['preco_venda'], 2, ',', '.');
                                $p_por = "R$ " . number_format($rel['preco_promocao'], 2, ',', '.');
                                $desc_rel = $rel['desconto'] . "% de Desconto";
                            } else {
                                $p_de = "&nbsp;";
                                $p_por = "R$ " . number_format($rel['preco_venda'], 2, ',', '.');
                                $v_parcela = $rel['preco_venda'] / 12;
                                $desc_rel = "Ou até 12x de R$ " . number_format($v_parcela, 2, ',', '.');
                            }
                        ?>
                            <div class="produto-item">
                                <div class="produtos">
                                    <div class="imagem-do-produto">
                                        <a href="detalhe-produto.php?id_produto=<?php echo $rel['id_produto']; ?>">
                                            <img src="<?php echo $f_rel; ?>" alt="<?php echo $rel['nome']; ?>">
                                        </a>
                                    </div>
                                    <div class="nome-do-produto"><?php echo $rel['nome']; ?></div>
                                    <div class="de-por"><?php echo $p_de; ?></div>
                                    <div class="a-vista"><?php echo $p_por; ?> À Vista</div>
                                    <div class="desconto"><?php echo $desc_rel; ?></div>
                                </div>
                            </div>
                        <?php } ?>
                    </div>
                </div>

                <button class="seta-carrossel proximo" onclick="moverCarrossel(1)">&#10095;</button>
            </div>
        </div>
    </div>

    <?php include('rodape.php'); ?>

    <script>
        let posicaoAtual = 0;

        function moverCarrossel(direcao) {
            const track = document.getElementById('track');
            const itens = track.querySelectorAll('.produto-item');
            if (itens.length === 0) return;

            const larguraItem = itens[0].offsetWidth + 20;
            const totalItens = itens.length;
            const itensVisiveis = Math.round(track.parentElement.offsetWidth / larguraItem);
            const limiteMaximo = totalItens - itensVisiveis;

            posicaoAtual += direcao;

            if (posicaoAtual < 0) {
                posicaoAtual = 0;
            } else if (posicaoAtual > limiteMaximo) {
                posicaoAtual = limiteMaximo;
            }

            const deslocamento = posicaoAtual * larguraItem;
            track.style.transform = `translateX(-${deslocamento}px)`;
        }
    </script>

</body>

</html>