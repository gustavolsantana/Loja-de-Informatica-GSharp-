<?php
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
                #Início log
                include('../log.php');
                #Final log

                include('../Mensagem.php');
                ?>

                <div class="container mt-5">
                    <div class="card">
                        <div class="card-header d-flex justify-content-between">
                            <h4 class="m-0">Nova Marca</h4>

                            <a href="index.php" class="btn btn-custom btn-sm">
                                <i class="bi bi-arrow-left-short"></i>
                                Voltar
                            </a>
                        </div>

                        <div class="card-body">
                            <form action="acoes.php" method="post">
                                <div class="form-row">
                                    <div class="col-6">
                                        <label for="marca"><strong class="text-danger">*</strong>Marca:</label>
                                        <input type="text" name="marca" id="cargo" class="form-control" required maxlength="60" required>
                                    </div>

                                    <div class="col-6">
                                        <label for="status">Status</label>
                                        <select name="status" id="status" class="form-control" disabled>
                                            <option value="1">Ativo</option>
                                            <option value="0">Inativo</option>
                                        </select>
                                    </div>

                                    <div class="col-12 mt-3">
                                        <label for="observacao">Observação</label>
                                        <textarea name="observacao" id="observacao" class="form-control" maxlenth="100"></textarea>

                                        <input type="hidden" name="cadastrar" value="cadastrar_marca">

                                        <input type="submit" value="Cadastrar" class="btn btn-custom mt-3">
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </main>
        </div>
    </div>

    <!-- BOOTSTRAP JS -->
    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>