<?php
require_once("conection/conecta.php");
session_start();

header("Cache-Control: no-cache, no-store, must-revalidate");
header("Pragma: no-cache");
header("Expires: 0");

// Função para renderizar cada card de produto dinamicamente
function renderizarCardProduto($produto)
{
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

    return '
    <div class="produto-item">
        <div class="produtos">
            <div class="imagem-do-produto">
                <a href="detalhe-produto.php?id_produto=' . $produto['id_produto'] . '">
                    <img src="' . $caminho_imagem . '" alt="' . $produto['nome'] . '">
                </a>
            </div>
            <div class="nome-do-produto">' . $produto['nome'] . '</div>
            <div class="de-por">' . $preco_de . '</div>
            <div class="a-vista">' . $preco_por . ' À Vista</div>
            <div class="desconto">' . $exibir_desconto . '</div>
        </div>
    </div>';
}

// 1. EM ALTA: Busca produtos mais vendidos via itens_pedido
$sql_alta = "SELECT p.*, SUM(i.quantidade) as total_vendas 
             FROM produto p 
             LEFT JOIN itens_pedido i ON p.id_produto = i.id_produto 
             WHERE p.status = 1 
             GROUP BY p.id_produto 
             ORDER BY total_vendas DESC, p.id_produto DESC 
             LIMIT 12";
$query_alta = mysqli_query($conexao, $sql_alta);

// 2. RECOMENDAÇÕES: Aleatório
$query_rec = mysqli_query($conexao, "SELECT * FROM produto WHERE status = 1 ORDER BY RAND() LIMIT 12");

// 3. LANÇAMENTOS: Data de cadastro mais recente
$query_lan = mysqli_query($conexao, "SELECT * FROM produto WHERE status = 1 ORDER BY data_cadastro DESC LIMIT 12");

// 4. VISTO RECENTEMENTE
$produtos_vistos = [];
if (isset($_SESSION['vistos']) && is_array($_SESSION['vistos']) && !empty($_SESSION['vistos'])) {
    $ids_limpos = array_map('intval', $_SESSION['vistos']);
    $ids_vistos = implode(',', array_reverse($ids_limpos));

    if (!empty($ids_vistos)) {
        $sql_vis = "SELECT * FROM produto WHERE id_produto IN ($ids_vistos) ORDER BY FIELD(id_produto, $ids_vistos)";
        $res_vis = mysqli_query($conexao, $sql_vis);
        if ($res_vis) {
            while ($row = mysqli_fetch_assoc($res_vis)) {
                $produtos_vistos[] = $row;
            }
        }
    }
}
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home | GSharp</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Exo+2:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="assets/img/favicon.ico" type="image/x-icon">
</head>

<body>
    <?php include('cabecalho.php'); ?>

    <div class="banner-container">
        <div class="banner-track" id="bannerTrack">
            <img src="assets/img/banner1.png" alt="Banner 1">
            <img src="assets/img/banner2.png" alt="Banner 2">
        </div>
    </div>

    <div class="container">
        <div class="vitrine" style="background: transparent; box-shadow: none;">

            <div class="secao-relacionados">
                <h4>Em Alta</h4>
                <div class="carrossel-container">
                    <button class="seta-carrossel anterior" onclick="moverVitrine(-1, 'trackAlta')">&#10094;</button>
                    <div class="carrossel-janela">
                        <div class="carrossel-track" id="trackAlta">
                            <?php while ($p = mysqli_fetch_assoc($query_alta)) echo renderizarCardProduto($p); ?>
                        </div>
                    </div>
                    <button class="seta-carrossel proximo" onclick="moverVitrine(1, 'trackAlta')">&#10095;</button>
                </div>
            </div>

            <div class="secao-relacionados">
                <h4>Recomendações</h4>
                <div class="carrossel-container">
                    <button class="seta-carrossel anterior" onclick="moverVitrine(-1, 'trackRec')">&#10094;</button>
                    <div class="carrossel-janela">
                        <div class="carrossel-track" id="trackRec">
                            <?php while ($p = mysqli_fetch_assoc($query_rec)) echo renderizarCardProduto($p); ?>
                        </div>
                    </div>
                    <button class="seta-carrossel proximo" onclick="moverVitrine(1, 'trackRec')">&#10095;</button>
                </div>
            </div>

            <div class="secao-relacionados">
                <h4>Lançamentos</h4>
                <div class="carrossel-container">
                    <button class="seta-carrossel anterior" onclick="moverVitrine(-1, 'trackLan')">&#10094;</button>
                    <div class="carrossel-janela">
                        <div class="carrossel-track" id="trackLan">
                            <?php while ($p = mysqli_fetch_assoc($query_lan)) echo renderizarCardProduto($p); ?>
                        </div>
                    </div>
                    <button class="seta-carrossel proximo" onclick="moverVitrine(1, 'trackLan')">&#10095;</button>
                </div>
            </div>

            <div class="banner2-container">
                <div class="banner2-track" id="miniBannerTrack">
                    <img src="assets/img/mini-banner.png" alt="Mini Banner 1">
                    <img src="assets/img/mini-banner2.png" alt="Mini Banner 2">
                </div>
            </div>

            <div class="secao-relacionados">
                <h4>Visto Recentemente</h4>
                <?php if (!empty($produtos_vistos)): ?>
                    <div class="carrossel-container">
                        <button class="seta-carrossel anterior" onclick="moverVitrine(-1, 'trackVis')">&#10094;</button>
                        <div class="carrossel-janela">
                            <div class="carrossel-track" id="trackVis">
                                <?php foreach ($produtos_vistos as $p) echo renderizarCardProduto($p); ?>
                            </div>
                        </div>
                        <button class="seta-carrossel proximo" onclick="moverVitrine(1, 'trackVis')">&#10095;</button>
                    </div>
                <?php endif; ?>
            </div>

        </div>
    </div>

    <?php include('rodape.php'); ?>

    <script>
        let bIdx = 0;
        const bTrk = document.getElementById('bannerTrack');
        setInterval(() => {
            bIdx = (bIdx + 1) % bTrk.children.length;
            bTrk.style.transform = `translateX(-${bIdx * 100}%)`;
        }, 5000);

        let mIdx = 0;
        const mTrk = document.getElementById('miniBannerTrack');
        setInterval(() => {
            mIdx = (mIdx + 1) % mTrk.children.length;
            mTrk.style.transform = `translateX(-${mIdx * 100}%)`;
        }, 5000);

        const pos = {
            'trackAlta': 0,
            'trackRec': 0,
            'trackLan': 0,
            'trackVis': 0
        };

        function moverVitrine(dir, id) {
            const trk = document.getElementById(id);
            const cards = trk.querySelectorAll('.produto-item');
            if (cards.length === 0) return;
            const w = cards[0].offsetWidth + 20;
            const vis = Math.round(trk.parentElement.offsetWidth / w);
            const max = cards.length - vis;
            pos[id] += dir;
            if (pos[id] < 0) pos[id] = 0;
            if (pos[id] > max) pos[id] = max;
            trk.style.transform = `translateX(-${pos[id] * w}px)`;
        }
    </script>
</body>

</html>