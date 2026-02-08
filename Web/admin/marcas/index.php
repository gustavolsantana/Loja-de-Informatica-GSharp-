<?php

#CONEXÃO COM O BANCO DE DADOS #
require_once "../../conection/conecta.php";

#Restrição de acesso
include_once '../user_common.php';

?>

<!doctype html>
<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>GSharp - Painel</title>

    <!-- BOOTSTRAP CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <!-- BOOTSTRAP ICONS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

    <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
    <link rel="stylesheet" href="../../assets/css/dashboard.css">
    <link rel="stylesheet" href="../../assets/css/styles.css">

    <!-- FAVICON -->
    <link rel="shortcut icon" href="../../assets/img/favicon.ico" type="image/x-icon">
    <!-- CSS -->
    <link rel="stylesheet" href="../../custom/css/style.css">

    <link rel="stylesheet" href="../../assets/css/style.css">

</head>

<body>

    <?php
    #Início TOPO
    include('../Topo.php');
    #Final TOPO
    ?>

    <div class="container-fluid">
        <div class="row">
            <?php
            #Início MENU
            include('../Navegacao.php');
            #Final MENU
            ?>

            <main class="ml-auto col-lg-10 px-md-4">
                <?php
                #Início MENU
                include('../log.php');
                #Final MENU
                ?>

                <?php
                #Início MENSAGEM
                include('../Mensagem.php');
                #Final MENSAGEM
                ?>

                <div class="container mt-5">
                    <div class="card">
                        <div class="card-header d-flex justify-content-between">
                            <h4 class="m-0">Marcas</h4>

                            <a href="Inserir.php" class="btn btn-custom btn-sm">
                                <i class="bi bi-plus"></i>
                                Adicionar
                            </a>
                        </div>

                        <!-- INICIO PHP -->
                        <?php
                        if (isset($_GET['status']) && $_GET['status'] != "") {
                            $status = $_GET['status'];

                            $sql = "SELECT * FROM marca WHERE status = $status";
                        } elseif (isset($_GET['pesquisa']) && $_GET['pesquisa'] != "") {
                            $pesquisa = $_GET['pesquisa'];

                            $sql = "SELECT * FROM marca WHERE nome LIKE '%$pesquisa%'";
                        } else {
                            $sql = "SELECT * FROM marca";
                        }


                        $query = mysqli_query($conexao, $sql);

                        if (mysqli_num_rows($query) > 0) {
                        ?>

                            <div class="card-body">
                                <div class="row">
                                    <div class="col-2">
                                        <form action="" method="get">
                                            <select name="status" id="status" class="form-control" onchange="form.submit()">
                                                <option value="">Status</option>
                                                <option value="1" <?php if (isset($status) && $status = 1) echo 'selected' ?>>Ativo</option>
                                                <option value="0" <?php if (isset($status) && $status = 0) echo 'selected' ?>>Inativo</option>
                                            </select>
                                        </form>
                                    </div>
                                    <div class="col-4">
                                        <form action="" method="get">
                                            <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Pesquise por marca..." value="<?php echo $pesquisa ?>">
                                        </form>
                                    </div>
                                </div>
                            </div>

                            <div class="card-body">
                                <table class="table table-striped">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Marca</th>
                                            <th scope="col">Observação</th>
                                            <th scope="col">Data Cadastro</th>
                                            <th scope="col">Status</th>
                                            <th scope="col">Ações</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <?php
                                        foreach ($query as $marca) {

                                        ?>

                                            <tr>

                                                <td><?php echo $marca['id_marca'] ?></td>
                                                <td><?php echo $marca['nome'] ?></td>
                                                <td><?php echo $marca['observacao'] ?></td>


                                                <td><?php echo date('d/m/Y', strtotime($marca['data_cadastro'])) ?></td>

                                                <td>
                                                    <?php
                                                    if ($marca['status'] == 1) {
                                                        echo '<span class="badge badge-pill badge-success">Ativo</span>';
                                                    } else {
                                                        echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                                                    }

                                                    ?>

                                                </td>

                                                <td>
                                                    <a href="editar.php?id_marca=<?php echo $marca['id_marca'] ?>" class="btn btn-outline-success btn-sm" title="Editar">
                                                        <i class="bi bi-pencil"></i>

                                                    </a>
                                                    <form action="acoes.php" method="post" class="d-inline">
                                                        <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="excluir_marca" value="<?php echo $marca['id_marca'] ?>" onclick="return confirm('Você tem certeza que deseja excluir esta marca?')">
                                                            <i class="bi bi-trash3"></i>
                                                        </button>
                                                    </form>

                                                </td>
                                            </tr>
                                        <?php
                                        }
                                        ?>

                                    </tbody>
                                </table>

                            </div>

                        <?php
                        } else {
                            echo '<div class="alert alert-danger m-3" role="alert">Nenhum registro encontrado!</div>';
                        }


                        ?>
                    </div>
            </main>
        </div>
    </div>

    <!-- FECHANDO A CONEXÃO COM BANCO DE DADOS -->
    <?php mysqli_close($conexao) ?>

    <!-- BOOTSTRAP JS -->
    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>