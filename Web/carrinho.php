<?php
require_once("conection/conecta.php");
session_start();
include('cabecalho.php');
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GSharp - Carrinnho</title>

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Exo+2:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
</head>
<body>
    
</body>
</html>
<div class="container" style="padding-top: 215px;">

    <div class="vitrine" style="padding: 20px; background-color: #1a1a1a;">
        <?php
        if (empty($_SESSION['carrinho'])) {
            echo "<p style='text-align: center; padding: 50px;'>O seu carrinho está vazio.</p>";
        } else {
            $total_geral = 0;

            foreach ($_SESSION['carrinho'] as $id => $qtd) {
                $id = mysqli_real_escape_string($conexao, $id);
                $sql = "SELECT * FROM produto WHERE id_produto = '$id'";
                $res = mysqli_query($conexao, $sql);
                $p = mysqli_fetch_assoc($res);

                // Lógica de preço igual a de pesquisa e detalhe
                $preco = ($p['status_promocao'] == 1) ? $p['preco_promocao'] : $p['preco_venda'];
                $total_geral += $preco;

                $foto = (empty($p['foto']) || !file_exists("images/" . $p['foto'])) ? "assets/img/placeholder-produto.jpg" : "images/" . $p['foto'];
        ?>
                <div style="display: flex; align-items: center; justify-content: space-between; border-bottom: 1px solid #333; padding: 15px 0;">
                    <img src="<?php echo $foto; ?>" style="width: 80px; height: 80px; object-fit: contain;">

                    <div style="flex: 1; margin-left: 20px;">
                        <h5 style="margin: 0;"><?php echo $p['nome']; ?></h5>
                        <small style="color: #888;">Quantidade: 1</small>
                    </div>

                    <div style="text-align: right; margin-right: 30px;">
                        <span style="display: block; font-size: 18px; color: #5f4b89; font-weight: 700;">
                            R$ <?php echo number_format($preco, 2, ',', '.'); ?>
                        </span>
                    </div>

                    <a href="carrinho_acoes.php?remover=<?php echo $id; ?>" style="color: #ff4757; font-size: 20px;">
                        <i class="bi bi-trash3"></i>
                    </a>
                </div>
            <?php
            }
            ?>
            <div style="margin-top: 30px; text-align: right; padding: 20px; border-top: 2px solid #5f4b89;">
                <h3 style="margin-bottom: 20px;">Total: R$ <?php echo number_format($total_geral, 2, ',', '.'); ?></h3>
                <a href="pesquisa.php" style="text-decoration: none; color: #cacaca; margin-right: 20px;">Continuar Comprando</a>
                <button style="background-color: #5f4b89; color: white; border: none; padding: 12px 30px; border-radius: 5px; cursor: pointer; font-weight: 600;">
                    Finalizar Pedido
                </button>
            </div>
        <?php } ?>
    </div>
</div>

<?php include('rodape.php'); ?>