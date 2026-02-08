<?php

require_once '../../conection/conecta.php';


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

    <div class="container-fluid">
        <div class="row">

            <main class="ml-auto">

                <?php

                include('../Mensagem.php');

                ?>

                <div class="container mt-5">

                    <?php
                    if (isset($_GET['id_cliente']) && $_GET['id_cliente'] != '') {
                        $codigo = $_GET['id_cliente'];

                        $sql_editar = "SELECT * FROM cliente WHERE id_cliente = $codigo";
                        $query_editar = mysqli_query($conexao, $sql_editar);
                        $cliente = mysqli_fetch_assoc($query_editar);
                    ?>

                        <div class="card">
                            <div class="card-header d-flex justify-content-between">
                                <h4 class="m-0">Editar Cliente</h4>

                                <a href="../../index.php" class="btn btn-custom btn-sm">
                                    <i class="bi bi-arrow-left-short"></i>
                                    Voltar
                                </a>
                            </div>

                            <div class="card-body">
                                <form action="acoes.php" method="post" enctype="multipart/form-data">
                                    <div class="form-row">

                                        <div class="col-12 text-center mb-4">
                                            <label for="fileInput">
                                                <?php

                                                if ($cliente['foto'] != '') {
                                                    echo '<img id="preview" src="../../images/' . $cliente['foto'] . '" alt="Escolher imagem" style="cursor: pointer; width: 200px;" class="rounded-circle">';
                                                } else {
                                                    echo '<img id="preview" src="../../assets/img/placeholder-funcionario.png" alt="Escolher imagem" style="cursor: pointer; width: 200px;" class="rounded-circle">';
                                                }

                                                ?>

                                            </label>
                                            <input type="file" name="foto" id="fileInput" accept="image/*" style="display: none;">
                                        </div>

                                        <div class="col-12">
                                            <h5>Informações Pessoais:</h5>
                                            <hr class="mt-0 mb-3">
                                        </div>
                                        <div class="col-md-6 mb-3">
                                            <label for="nome"><strong class="text-danger">*</strong> Nome Completo:</label>
                                            <input type="text" name="nome" id="nome" class="form-control" required maxlength="100" value="<?php echo $cliente['nome'] ?>">
                                        </div>
                                        <div class="col-md-6 mb-3">
                                            <label for="nome_social">Nome Social:</label>
                                            <input type="text" name="nome_social" id="nome_social" class="form-control" maxlength="100" value="<?php echo $cliente['nome_social'] ?>">
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label for="rg">RG:</label>
                                            <input type="text" name="rg" id="rg" class="form-control" maxlength="14" data-mask="99.999.999-9" value="<?php echo $cliente['rg'] ?>">
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label for="cpf"><strong class="text-danger">*</strong> CPF:</label>
                                            <input type="text" name="cpf" id="cpf" class="form-control" required maxlength="14" required data-mask="000.000.000-00" value="<?php echo $cliente['cpf'] ?>">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="data_nascimento"><strong class="text-danger">*</strong> Data de Nascimento:</label>
                                            <input type="date" name="data_nascimento" id="data_nascimento" class="form-control" required value="<?php echo $cliente['data_nascimento'] ?>">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="sexo"><strong class="text-danger">*</strong> Sexo:</label>
                                            <select name="sexo" id="sexo" class="form-control" required>
                                                <option value="F" <?php if ($cliente['sexo'] == 'F') echo 'selected' ?>>Feminino</option>
                                                <option value="M" <?php if ($cliente['sexo'] == 'M') echo 'selected' ?>>Masculino</option>
                                                <option value="O" <?php if ($cliente['sexo'] == 'O') echo 'selected' ?>>Não informado</option>
                                            </select>
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="estado_civil"><strong class="text-danger">*</strong> Estado Civil:</label>
                                            <select name="estado_civil" id="estado_civil" class="form-control" required>
                                                <option value="Solteiro" <?php if ($cliente['estado_civil'] == 'Solteiro') echo 'selected' ?>>Solteiro(a)</option>
                                                <option value="Casado" <?php if ($cliente['estado_civil'] == 'Casado') echo 'selected' ?>>Casado(a)</option>
                                                <option value="Divorciado" <?php if ($cliente['estado_civil'] == 'Divorciado') echo 'selected' ?>>Divorciado(a)</option>
                                                <option value="Separado" <?php if ($cliente['estado_civil'] == 'Separado') echo 'selected' ?>>Separado(a)</option>
                                                <option value="Viuvo" <?php if ($cliente['estado_civil'] == 'Viuvo') echo 'selected' ?>>Viuvo(a)</option>
                                            </select>
                                        </div>

                                        <div class="col-12 mt-3">
                                            <h5>Contato:</h5>
                                            <hr class="mt-0 mb-3">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="telefone1"><strong class="text-danger">*</strong> Telefone 1:</label>
                                            <input type="tel" name="telefone1" id="telefone1" class="form-control" required data-mask="(00) 00000-0000" value="<?php echo $cliente['telefone1'] ?>">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="telefone2">Telefone 2:</label>
                                            <input type="tel" name="telefone2" id="telefone2" class="form-control" data-mask="(99) 99999-9999" value="<?php echo $cliente['telefone2'] ?>">
                                        </div>
                                        <div class="col-md-8 mb-3">
                                            <label for="email">E-mail:</label>
                                            <input type="email" name="email" id="email" class="form-control" maxlength="100" value="<?php echo $cliente['email'] ?>">
                                        </div>

                                        <div class="col-12 mt-3">
                                            <h5>Endereço:</h5>
                                            <hr class="mt-0 mb-3">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="cep"><strong class="text-danger">*</strong> CEP:</label>
                                            <input type="text" name="cep" id="cep" class="form-control" required maxlength="9" data-mask="00000-000" onblur="pesquisacep(this.value)" value="<?php echo $cliente['cep'] ?>">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="estado"><strong class="text-danger">*</strong> Estado:</label>
                                            <select name="estado" id="estado" class="form-control" required>
                                                <option value="AC" <?php if ($cliente['estado'] == 'AC') echo 'selected' ?>>Acre</option>
                                                <option value="AL" <?php if ($cliente['estado'] == 'AL') echo 'selected' ?>>Alagoas</option>
                                                <option value="AP" <?php if ($cliente['estado'] == 'AP') echo 'selected' ?>>Amapá</option>
                                                <option value="AM" <?php if ($cliente['estado'] == 'AM') echo 'selected' ?>>Amazonas</option>
                                                <option value="BA" <?php if ($cliente['estado'] == 'BA') echo 'selected' ?>>Bahia</option>
                                                <option value="CE" <?php if ($cliente['estado'] == 'CE') echo 'selected' ?>>Ceará</option>
                                                <option value="DF" <?php if ($cliente['estado'] == 'DF') echo 'selected' ?>>Distrito Federal</option>
                                                <option value="ES" <?php if ($cliente['estado'] == 'ES') echo 'selected' ?>>Espirito Santo</option>
                                                <option value="GO" <?php if ($cliente['estado'] == 'GO') echo 'selected' ?>>Goiás</option>
                                                <option value="MA" <?php if ($cliente['estado'] == 'MA') echo 'selected' ?>>Maranhão</option>
                                                <option value="MT" <?php if ($cliente['estado'] == 'MT') echo 'selected' ?>>Mato Grosso</option>
                                                <option value="MS" <?php if ($cliente['estado'] == 'MS') echo 'selected' ?>>Mato Grosso do Sul</option>
                                                <option value="MG" <?php if ($cliente['estado'] == 'MG') echo 'selected' ?>>Minas Gerais</option>
                                                <option value="PA" <?php if ($cliente['estado'] == 'PA') echo 'selected' ?>>Pará</option>
                                                <option value="PB" <?php if ($cliente['estado'] == 'PB') echo 'selected' ?>>Paraíba</option>
                                                <option value="PR" <?php if ($cliente['estado'] == 'PR') echo 'selected' ?>>Paraná</option>
                                                <option value="PE" <?php if ($cliente['estado'] == 'PE') echo 'selected' ?>>Pernambuco</option>
                                                <option value="PI" <?php if ($cliente['estado'] == 'PI') echo 'selected' ?>>Piauí</option>
                                                <option value="RJ" <?php if ($cliente['estado'] == 'RJ') echo 'selected' ?>>Rio de Janeiro</option>
                                                <option value="RN" <?php if ($cliente['estado'] == 'RN') echo 'selected' ?>>Rio Grande do Norte</option>
                                                <option value="RS" <?php if ($cliente['estado'] == 'RS') echo 'selected' ?>>Rio Grande do Sul</option>
                                                <option value="RO" <?php if ($cliente['estado'] == 'RO') echo 'selected' ?>>Rondônia</option>
                                                <option value="RR" <?php if ($cliente['estado'] == 'RR') echo 'selected' ?>>Roraima</option>
                                                <option value="SC" <?php if ($cliente['estado'] == 'SC') echo 'selected' ?>>Santa Catarina</option>
                                                <option value="SP" <?php if ($cliente['estado'] == 'SP') echo 'selected' ?>>São Paulo</option>
                                                <option value="SE" <?php if ($cliente['estado'] == 'SE') echo 'selected' ?>>Sergipe</option>
                                                <option value="TO" <?php if ($cliente['estado'] == 'TO') echo 'selected' ?>>Tocantins</option>
                                            </select>
                                        </div>
                                        <div class="col-md-4 mb-3">
                                            <label for="cidade"><strong class="text-danger">*</strong> Cidade:</label>
                                            <input type="text" name="cidade" id="cidade" class="form-control" required maxlength="100" value="<?php echo $cliente['cidade'] ?>">
                                        </div>
                                        <div class="col-md-4 mb-3">
                                            <label for="bairro"><strong class="text-danger">*</strong> Bairro:</label>
                                            <input type="text" name="bairro" id="bairro" class="form-control" required maxlength="100" value="<?php echo $cliente['bairro'] ?>">
                                        </div>
                                        <div class="col-md-6 mb-3">
                                            <label for="endereco"><strong class="text-danger">*</strong> Endereço:</label>
                                            <input type="text" name="endereco" id="rua" class="form-control" required maxlength="100" value="<?php echo $cliente['endereco'] ?>">
                                        </div>
                                        <div class="col-md-2 mb-3">
                                            <label for="numero"><strong class="text-danger">*</strong> Número:</label>
                                            <input type="text" name="numero" id="numero" class="form-control" required maxlength="10" value="<?php echo $cliente['numero'] ?>">
                                        </div>
                                        <div class="col-md-4 mb-3">
                                            <label for="complemento">Complemento:</label>
                                            <input type="text" name="complemento" id="complemento" class="form-control" maxlength="100" value="<?php echo $cliente['complemento'] ?>">
                                        </div>

                                        <div class="col-12 mt-3">
                                            <h5>Informações de Acesso:</h5>
                                            <hr class="mt-0 mb-3">
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label for="usuario"><strong class="text-danger">*</strong> Usuário:</label>
                                            <input type="text" name="usuario" id="usuario" class="form-control" required maxlength="100" value="<?php echo $cliente['usuario'] ?>">
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label for="senha"><strong class="text-danger">*</strong> Senha:</label>
                                            <input type="text" name="senha" id="senha" class="form-control" required maxlength="100" value="<?php echo $cliente['senha'] ?>">
                                        </div>
                                        <div class="col-3">
                                            <label for="status"><strong class="text-danger">*</strong>Status</label>
                                            <select name="status" id="status" class="form-control">
                                                <option value="1" <?php if ($cliente['status'] == 1) echo 'selected' ?>>Ativo</option>
                                                <option value="0" <?php if ($cliente['status'] == 0) echo 'selected' ?>>Inativo</option>
                                            </select>
                                        </div>

                                        <div class="col-12 mt-3">
                                            <input type="hidden" name="editar" value="editar_cliente">

                                            <input type="hidden" name="id_cliente" value="<?php echo $codigo ?>">

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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUadn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <script src="../../assets/js/jquery.mask.js"></script>

    <script src="../../assets/js/via-cep.js"></script>

    <script src="../../assets/js/carregar-foto.js"></script>

</body>

</html>