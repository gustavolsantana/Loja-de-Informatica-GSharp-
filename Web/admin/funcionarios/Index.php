<?php

require_once '../../conection/conecta.php';

#Restrição de acesso
include_once '../user_admin.php';

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
                            <h4 class="m-0">Funcionários</h4>

                            <a href="Inserir.php" class="btn btn-custom btn-sm">
                                <i class="bi bi-plus"></i>
                                Adicionar
                            </a>
                        </div>

                        <div class="card-body">
                            <div class="row">
                                <div class="col-2">
                                    <form action="">
                                        <select name="cargo" id="cargo" class="form-control" onchange="buscar()">
                                            <option value="">Cargo</option>

                                            <?php

                                            $sql_cargo = "SELECT id_cargo, nome FROM cargo WHERE status = 1";
                                            $query_cargo = mysqli_query($conexao, $sql_cargo);

                                            foreach ($query_cargo as $cargo) {

                                            ?>

                                                <option value="<?php echo $cargo['id_cargo'] ?>" <?php if ($funcionario['id_cargo'] == $cargo['id_cargo']) echo 'selected' ?>><?php echo $cargo['nome'] ?></option>;

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
                                        <select name="tipo_acesso" id="tipo_acesso" class="form-control" onchange="buscar()">
                                            <option value="">Tipo de Acesso</option>
                                            <option value="1">Administrador(a)</option>
                                            <option value="0">Comum</option>
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
            </main>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <!-- Filtros -->
    <script>
        // Função para listar os funcionarios
        function listar(tipo_acesso, status, cargo, nome) {
            // $('#listar').text('Carregando...');
            $.ajax({
                url: 'tabela.php',
                method: 'POST',
                data: {
                    tipo_acesso,
                    status,
                    cargo,
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
            var tipo_acesso = $('#tipo_acesso').val();
            var status = $('#status').val();
            var cargo = $('#cargo').val();

            listar(tipo_acesso, status, cargo);
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