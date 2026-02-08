<?php

#Fazer a conexão com o banco de dados
require_once("../../conection/conecta.php");

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

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

    <link rel="stylesheet" href="../../assets/css/dashboard.css">
    <link rel="stylesheet" href="../../assets/css/styles.css">

    <link rel="shortcut icon" href="../../assets/img/favicon.ico" type="image/x-icon">
    <link rel="stylesheet" href="../../custom/css/styles.css">
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
                            <h4 class="m-0">Cargos</h4>

                            <a href="Inserir.php" class="btn btn-custom btn-sm">
                                <i class="bi bi-plus"></i>
                                Adicionar
                            </a>
                        </div>

                        <?php
                        if (isset($_GET['status']) && $_GET['status'] != "") {
                            $status = $_GET['status'];

                            $sql = "SELECT * FROM cargo WHERE status = $status";
                        } elseif (isset($_GET['pesquisa']) && $_GET['pesquisa'] != "") {
                            $pesquisa = $_GET['pesquisa'];

                            $sql = "SELECT * FROM cargo WHERE nome LIKE '%$pesquisa%'";
                        } else {
                            $sql = "SELECT * FROM cargo";
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
                                            <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Pesquise por cargo..." value="<?php echo $pesquisa ?>">
                                        </form>
                                    </div>
                                </div>
                            </div>

                            <div class="card-body">
                                <table class="table table-striped">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Cargo</th>
                                            <th scope="col">Observação</th>
                                            <th scope="col">Data Cadastro</th>
                                            <th scope="col">Status</th>
                                            <th scope="col">Ações</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <?php

                                        foreach ($query as $cargo) {

                                        ?>

                                            <tr>
                                                <td><?php echo $cargo["id_cargo"] ?></td>
                                                <td><?php echo $cargo["nome"] ?></td>
                                                <td><?php echo $cargo["observacao"] ?></td>
                                                <td><?php echo date('d/m/Y', strtotime($cargo["data_cadastro"])) ?></td>
                                                <td>
                                                    <?php

                                                    if ($cargo["status"] == 1) {
                                                        echo '<span class="badge badge-pill badge-success">Ativo</span>';
                                                    } else {
                                                        echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                                                    }

                                                    ?>
                                                </td>
                                                <td>
                                                    <a href="editar.php?id_cargo=<?php echo $cargo["id_cargo"] ?>" class="btn btn-outline-success btn-sm">
                                                        <i class="bi bi-pencil" title="Editar"></i>
                                                    </a>
                                                    <form action="acoes.php" method="post" class="d-inline">
                                                        <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="excluir_cargo" value="<?php echo $cargo['id_cargo'] ?>" onclick="return confirm('Você tem certeza que deseja excluir este cargo?')">
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
                </div>
            </main>
        </div>
    </div>

    <?php

    mysqli_close($conexao)

    ?>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>