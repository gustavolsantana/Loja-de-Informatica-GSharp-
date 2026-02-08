<?php
require_once("conection/conecta.php"); //

// 1. Recebimento e limpeza de dados
$pesquisa = isset($_POST['pesquisa']) ? mysqli_real_escape_string($conexao, $_POST['pesquisa']) : '';
$marcas = isset($_POST['marca']) ? mysqli_real_escape_string($conexao, $_POST['marca']) : '';
$categorias = isset($_POST['categoria']) ? mysqli_real_escape_string($conexao, $_POST['categoria']) : '';
$min = isset($_POST['min']) ? str_replace(['.', ','], ['', '.'], $_POST['min']) : '';
$max = isset($_POST['max']) ? str_replace(['.', ','], ['', '.'], $_POST['max']) : '';
$ofertas = isset($_POST['ofertas']) ? (int)$_POST['ofertas'] : 0;
$busca_rapida = isset($_POST['busca_rapida']) ? mysqli_real_escape_string($conexao, $_POST['busca_rapida']) : '';
$perifericos = isset($_POST['perifericos']) ? (int)$_POST['perifericos'] : 0;

// 2. Lógica de Paginação
$paginaAtual = (isset($_POST['pagina']) && (int)$_POST['pagina'] > 0) ? (int)$_POST['pagina'] : 1;
$registrosPorPagina = 8; //
$valorInicial = ($paginaAtual * $registrosPorPagina) - $registrosPorPagina; //

// 3. Construção da cláusula WHERE dinâmica
$where = "WHERE status = 1";
if ($pesquisa != "") {
    $where .= " AND nome LIKE '%$pesquisa%'";
}
if ($marcas != "") {
    $where .= " AND id_marca IN ($marcas)";
}
if ($categorias != "") {
    $where .= " AND id_categoria IN ($categorias)";
}
if ($min != "") {
    $where .= " AND preco_venda >= '$min'";
}
if ($max != "") {
    $where .= " AND preco_venda <= '$max'";
}
// Lógica de Ofertas
if ($ofertas == 1) {
    $where .= " AND status_promocao = 1";
}

// Lógica de Kit Upgrade e Computador (Busca por nome específico)
if ($busca_rapida != "") {
    $where .= " AND nome LIKE '%$busca_rapida%'";
}

// Lógica de Periféricos (Filtra por categorias comuns)
if ($perifericos == 1) {
    $where .= " AND id_categoria IN (SELECT id_categoria FROM categoria WHERE nome REGEXP 'mouse|teclado|headset|mousepad|controle|periferico')";
}

// 4. Contagem total para o cálculo de páginas
$sql_count = "SELECT COUNT(*) as total FROM produto $where";
$res_count = mysqli_query($conexao, $sql_count);
$total_registros = mysqli_fetch_assoc($res_count)['total'];
$totalPaginas = ceil($total_registros / $registrosPorPagina); //

// 5. Consulta com Limite
$sql = "SELECT * FROM produto $where ORDER BY nome ASC LIMIT $valorInicial, $registrosPorPagina";
$query = mysqli_query($conexao, $sql);

if (mysqli_num_rows($query) > 0) {
    // Exibição dos produtos
    foreach ($query as $produto) {
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
?>
        <div class="produtos">
            <div class="imagem-do-produto imagem-pesquisa">
                <a href="detalhe-produto.php?id_produto=<?php echo $produto['id_produto']; ?>">
                    <img src="<?php echo $caminho_imagem; ?>" alt="<?php echo $produto['nome']; ?>">
                </a>
            </div>
            <div class="nome-do-produto"><?php echo $produto['nome']; ?></div>
            <div class="de-por"><?php echo $preco_de; ?></div>
            <div class="a-vista"><?php echo $preco_por; ?> À Vista</div>
            <div class="desconto"><?php echo $exibir_desconto; ?></div>
        </div>
<?php
    }

    // 6. Geração da Paginação
    if ($totalPaginas > 1) {
        echo '<div class="paginacao-container">';

        // Botão Anterior
        if ($paginaAtual > 1) {
            echo '<button type="button" class="btn-pag" onclick="realizarBusca(' . ($paginaAtual - 1) . ')">&laquo;</button>';
        }

        // Números das páginas
        for ($i = 1; $i <= $totalPaginas; $i++) {
            $classeAtiva = ($i == $paginaAtual) ? 'active' : '';
            echo '<button type="button" class="btn-pag ' . $classeAtiva . '" onclick="realizarBusca(' . $i . ')">' . $i . '</button>';
        }

        // Botão Próximo
        if ($paginaAtual < $totalPaginas) {
            echo '<button type="button" class="btn-pag" onclick="realizarBusca(' . ($paginaAtual + 1) . ')">&raquo;</button>';
        }

        echo '</div>';
    }
} else {
    echo '<div class="alert alert-danger w-100">Nenhum produto encontrado para esses filtros!</div>';
}
?>