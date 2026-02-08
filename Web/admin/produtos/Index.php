<?php
require_once("../../conection/conecta.php");

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
                    <div class="card">
                        <div class="card-header d-flex justify-content-between">
                            <h4 class="m-0">Produtos</h4>
                            <a href="Inserir.php" class="btn btn-custom btn-sm">
                                <i class="bi bi-plus"></i>
                                Adicionar
                            </a>
                        </div>



                        <div class="card-body">
                            <div class="row">
                                <div class="col-2">
                                    <form action="">
                                        <select name="marca" id="marca" class="form-control" onchange="buscar()">
                                            <option value="">Marca</option>

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
                                    </form>
                                </div>
                                <div class="col-2">
                                    <form action="">
                                        <select name="status" id="status" class="form-control" onchange="buscar()">
                                            <option value="">Status</option>
                                            <option value="1">Ativo</option>
                                            <option value="0">Inativo</option>
                                        </select>
                                    </form>
                                </div>
                                <div class="col-2">
                                    <form action="">
                                        <select name="categoria" id="categoria" class="form-control" onchange="buscar()">
                                            <option value="">Categoria</option>

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
                                    </form>
                                </div>
                                <div class="col-6">
                                    <form action="">
                                        <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Pesquise por nome...">
                                    </form>
                                </div>
                            </div>
                        </div>

                        <div class="card-body">
                            <div id="listar"></div> <!-- Nova Tabela -->
                        </div>

                    </div>
                </div>
            </main>
        </div>
    </div>

    <?php
    mysqli_close($conexao);
    ?>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <!-- Filtros -->
    <script>
        // Função para listar os produtos
        function listar(marca, status, categoria, nome) {
            // $('#listar').text('Carregando...');
            $.ajax({
                url: 'tabela.php',
                method: 'POST',
                data: {
                    marca,
                    status,
                    categoria,
                    nome
                },
                dataType: 'html',
                success: function(res) {
                    $('#listar').html(res);
                }
            })
        }

        // Função para realizar a buscar pelos filtros
        function buscar() {
            var marca = $('#marca').val();
            var status = $('#status').val();
            var categoria = $('#categoria').val();

            listar(marca, status, categoria);
        }

        $(document).ready(function() {
            listar()

            $('#pesquisa').keyup(function() {
                var pesquisa = $(this).val();
                listar('', '', '', pesquisa)
            })
        })
    </script>

</body>

</html>