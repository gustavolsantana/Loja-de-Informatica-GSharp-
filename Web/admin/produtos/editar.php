<?php
require_once '../../conection/conecta.php';
#Restrição de acesso
include_once '../user_common.php';
?>

<!doctype html>
<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>GSharp - Painel</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link rel="stylesheet" href="../../assets/css/dashboard.css">
    <link rel="stylesheet" href="../../assets/css/styles.css">
    <link rel="shortcut icon" href="../../assets/img/favicon.ico" type="image/x-icon">
    <link rel="stylesheet" href="../../custom/css/styles.css">
    <link rel="stylesheet" href="../../assets/css/style.css">
</head>

<body>

    <?php include('../Topo.php'); ?>

    <div class="container-fluid">
        <div class="row">

            <?php include('../Navegacao.php'); ?>

            <main class="ml-auto col-lg-10 px-md-4">

                <?php include('../log.php'); ?>

                <?php include('../Mensagem.php'); ?>

                <div class="container mt-5">

                    <?php
                    if (isset($_GET['id_produto']) && $_GET['id_produto'] != '') {
                        $codigo = $_GET['id_produto'];

                        $sql_editar = "SELECT * FROM produto WHERE id_produto = $codigo";
                        $query_editar = mysqli_query($conexao, $sql_editar);
                        $produto = mysqli_fetch_assoc($query_editar);
                    ?>

                        <div class="card">
                            <div class="card-header d-flex justify-content-between">
                                <h4 class="m-0">Editar Produto</h4>
                                <a href="index.php" class="btn btn-custom btn-sm">
                                    <i class="bi bi-arrow-left-short"></i>
                                    Voltar
                                </a>
                            </div>

                            <div class="card-body">
                                <form action="acoes.php" method="post" enctype="multipart/form-data">
                                    <div class="form-row justify-content-between">
                                        <div class="form-row col-9">
                                            <div class="col-md-12">
                                                <label for="nome"><strong class="text-danger">*</strong> Nome:</label>
                                                <input type="text" name="nome" id="nome" class="form-control" required maxlength="100" value="<?php echo $produto['nome'] ?>">
                                            </div>
                                            <div class="col-12 mt-3">
                                                <label for="descricao">Descrição:</label>
                                                <textarea name="descricao" id="descricao" class="form-control" maxlength="1000" value="<?php echo $produto['descricao'] ?>"><?php echo $produto['descricao'] ?></textarea>
                                            </div>
                                            <div class="col-3 mt-3">
                                                <label for="id_marca"><strong class="text-danger">*</strong> Marca:</label>
                                                <select name="id_marca" id="id_marca" class="form-control" required>
                                                    <option value="">- Selecione -</option>

                                                    <?php

                                                    $sql_marca = "SELECT id_marca, nome FROM marca WHERE status = 1";
                                                    $query_marca = mysqli_query($conexao, $sql_marca);

                                                    foreach ($query_marca as $marca) {

                                                    ?>

                                                        <option value="<?php echo $marca['id_marca'] ?>" <?php if ($produto['id_marca'] == $marca['id_marca']) echo 'selected' ?>><?php echo $marca['nome'] ?></option>;

                                                    <?php
                                                    }
                                                    ?>

                                                </select>
                                            </div>
                                            <div class="col-3 mt-3">
                                                <label for="id_categoria"><strong class="text-danger">*</strong> Categoria:</label>
                                                <select name="id_categoria" id="id_categoria" class="form-control" required>
                                                    <option value="">- Selecione -</option>

                                                    <?php

                                                    $sql_categoria = "SELECT id_categoria, nome FROM categoria WHERE status = 1";
                                                    $query_categoria = mysqli_query($conexao, $sql_categoria);

                                                    foreach ($query_categoria as $categoria) {

                                                    ?>

                                                        <option value="<?php echo $categoria['id_categoria'] ?>" <?php if ($produto['id_categoria'] == $categoria['id_categoria']) echo 'selected' ?>><?php echo $categoria['nome'] ?></option>;

                                                    <?php
                                                    }
                                                    ?>

                                                </select>
                                            </div>
                                            <div class="col-3 mt-3">
                                                <label for="estoque"><strong class="text-danger">*</strong> Estoque:</label>
                                                <input type="text" name="estoque" id="estoque" class="form-control" required value="<?php echo $produto['estoque'] ?>">
                                            </div>
                                            <div class="col-3 mt-3">
                                                <label for="status"><strong class="text-danger">*</strong>Status</label>
                                                <select name="status" id="status" class="form-control">
                                                    <option value="1" <?php if ($produto['status'] == 1) echo 'selected' ?>>Ativo</option>
                                                    <option value="0" <?php if ($produto['status'] == 0) echo 'selected' ?>>Inativo</option>
                                                </select>
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="preco_custo"><strong class="text-danger">*</strong> Preço Custo:</label>
                                                <input type="text" name="preco_custo" id="preco_custo" class="form-control" required data-mask="000000,00" data-mask-reverse=true value="<?php echo $produto['preco_custo'] ?>">
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="percentual_lucro"><strong class="text-danger">*</strong> Lucro(%):</label>
                                                <input type="text" name="percentual_lucro" id="percentual_lucro" class="form-control" required data-mask="000" value="<?php echo $produto['percentual_lucro'] ?>">
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="preco_venda"> Preço Venda:</label>
                                                <input type="text" name="preco_venda" id="preco_venda" class="form-control" readonly data-mask="000000,00" data-mask-reverse=true value="<?php echo $produto['preco_venda'] ?>">
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="status_promocao"> Status Promoção:</label>
                                                <select name="status_promocao" id="status_promocao" class="form-control">
                                                    <option value="">- Selecione -</option>

                                                    <option value="1" <?php if ($produto['status_promocao'] == 1) echo 'selected' ?>>Ativo</option>
                                                    <option value="0" <?php if ($produto['status_promocao'] == 0) echo 'selected' ?>>Inativo</option>

                                                </select>
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="desconto"> Desconto(%):</label>
                                                <input type="text" name="desconto" id="desconto" class="form-control" data-mask="000" value="<?php echo $produto['desconto'] ?>">
                                            </div>
                                            <div class="col-2 mt-3">
                                                <label for="preco_promocao"> Preço Promoção:</label>
                                                <input type="text" name="preco_promocao" id="preco_promocao" class="form-control" readonly data-mask="000000,00" data-mask-reverse=true value="<?php echo $produto['preco_promocao'] ?>">
                                            </div>
                                        </div>
                                        <div class="form-row col-3 align-items-center">
                                            <div class="">
                                                <label for="fileInput">
                                                    <?php

                                                    if ($produto['foto'] != '') {
                                                        echo '<img id="preview" src="../../images/' . $produto['foto'] . '" alt="Escolher imagem" style="cursor: pointer; width: 100%;" class="rounded-3">';
                                                    } else {
                                                        echo '<img id="preview" src="../../assets/img/placeholder-produto.jpg" alt="Escolher imagem" style="cursor: pointer; width: 100%;" class="rounded-3">';
                                                    }

                                                    ?>
                                                </label>
                                                <input type="file" name="foto" id="fileInput" accept="image/*" style="display: none;">
                                            </div>
                                        </div>
                                        <div class="col-12 mt-3">

                                            <input type="hidden" name="editar" value="editar_produto">

                                            <input type="hidden" name="id_produto" value="<?php echo $codigo ?>">

                                            <input type="submit" value="Editar" class="btn btn-custom mt-3">

                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    <?php
                    } else {
                    }
                    ?>
                </div>
            </main>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <script src="../../assets/js/jquery.mask.js"></script>
    <script src="../../assets/js/carregar-foto.js"></script>
    <script src="../../assets/js/calcular-preco-venda.js"></script>
</body>

</html>