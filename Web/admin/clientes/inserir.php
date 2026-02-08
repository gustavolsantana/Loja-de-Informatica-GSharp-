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
                    <div class="card">
                        <div class="card-header d-flex justify-content-between">
                            <h4 class="m-0">Novo Cliente</h4>

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
                                            <img id="preview" src="../../assets/img/placeholder-funcionario.png" alt="Escolher imagem" style="cursor: pointer; width: 200px;" class="rounded-circle">
                                        </label>
                                        <input type="file" name="foto" id="fileInput" accept="image/*" style="display: none;">
                                    </div>

                                    <div class="col-12">
                                        <h5>Informações Pessoais:</h5>
                                        <hr class="mt-0 mb-3">
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="nome"><strong class="text-danger">*</strong> Nome Completo:</label>
                                        <input type="text" name="nome" id="nome" class="form-control" required maxlength="100">
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="nome_social">Nome Social:</label>
                                        <input type="text" name="nome_social" id="nome_social" class="form-control" maxlength="100">
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="rg">RG:</label>
                                        <input type="text" name="rg" id="rg" class="form-control" maxlength="14" data-mask="99.999.999-9">
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="cpf"><strong class="text-danger">*</strong> CPF:</label>
                                        <input type="text" name="cpf" id="cpf" class="form-control" required maxlength="14" required data-mask="000.000.000-00">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="data_nascimento"><strong class="text-danger">*</strong> Data de Nascimento:</label>
                                        <input type="date" name="data_nascimento" id="data_nascimento" class="form-control" required>
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="sexo"><strong class="text-danger">*</strong> Sexo:</label>
                                        <select name="sexo" id="sexo" class="form-control" required>
                                            <option value="">- Selecione -</option>
                                            <option value="M">Masculino</option>
                                            <option value="F">Feminino</option>
                                            <option value="O">Não Informado</option>
                                        </select>
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="estado_civil"><strong class="text-danger">*</strong> Estado Civil:</label>
                                        <select name="estado_civil" id="estado_civil" class="form-control" required>
                                            <option value="">- Selecione -</option>
                                            <option value="Casado">Casado(a)</option>
                                            <option value="Divorciado">Divorciado(a)</option>
                                            <option value="Separado">Separado(a)</option>
                                            <option value="Solteiro">Solteiro(a)</option>
                                            <option value="Viuvo">Viúvo(a)</option>
                                        </select>
                                    </div>

                                    <div class="col-12 mt-3">
                                        <h5>Contato:</h5>
                                        <hr class="mt-0 mb-3">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="telefone1"><strong class="text-danger">*</strong> Telefone 1:</label>
                                        <input type="tel" name="telefone1" id="telefone1" class="form-control" required data-mask="(00) 00000-0000">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="telefone2">Telefone 2:</label>
                                        <input type="tel" name="telefone2" id="telefone2" class="form-control" data-mask="(99) 99999-9999">
                                    </div>
                                    <div class="col-md-8 mb-3">
                                        <label for="email">E-mail:</label>
                                        <input type="email" name="email" id="email" class="form-control" maxlength="100">
                                    </div>

                                    <div class="col-12 mt-3">
                                        <h5>Endereço:</h5>
                                        <hr class="mt-0 mb-3">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="cep"><strong class="text-danger">*</strong> CEP:</label>
                                        <input type="text" name="cep" id="cep" class="form-control" required maxlength="9" data-mask="00000-000" onblur="pesquisacep(this.value)">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="estado"><strong class="text-danger">*</strong> Estado:</label>
                                        <select name="estado" id="estado" class="form-control" required>
                                            <option value="">- Selecione -</option>
                                            <option value="AC">Acre</option>
                                            <option value="AL">Alagoas</option>
                                            <option value="AP">Amapá</option>
                                            <option value="AM">Amazonas</option>
                                            <option value="BA">Bahia</option>
                                            <option value="CE">Ceará</option>
                                            <option value="DF">Distrito Federal</option>
                                            <option value="ES">Espirito Santo</option>
                                            <option value="GO">Goiás</option>
                                            <option value="MA">Maranhão</option>
                                            <option value="MT">Mato Grosso</option>
                                            <option value="MS">Mato Grosso do Sul</option>
                                            <option value="MG">Minas Gerais</option>
                                            <option value="PA">Pará</option>
                                            <option value="PB">Paraíba</option>
                                            <option value="PR">Paraná</option>
                                            <option value="PE">Pernambuco</option>
                                            <option value="PI">Piauí</option>
                                            <option value="RJ">Rio de Janeiro</option>
                                            <option value="RN">Rio Grande do Norte</option>
                                            <option value="RS">Rio Grande do Sul</option>
                                            <option value="RO">Rondônia</option>
                                            <option value="RR">Roraima</option>
                                            <option value="SC">Santa Catarina</option>
                                            <option value="SP">São Paulo</option>
                                            <option value="SE">Sergipe</option>
                                            <option value="TO">Tocantins</option>
                                        </select>
                                    </div>
                                    <div class="col-md-4 mb-3">
                                        <label for="cidade"><strong class="text-danger">*</strong> Cidade:</label>
                                        <input type="text" name="cidade" id="cidade" class="form-control" required maxlength="100">
                                    </div>
                                    <div class="col-md-4 mb-3">
                                        <label for="bairro"><strong class="text-danger">*</strong> Bairro:</label>
                                        <input type="text" name="bairro" id="bairro" class="form-control" required maxlength="100">
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="endereco"><strong class="text-danger">*</strong> Endereço:</label>
                                        <input type="text" name="endereco" id="rua" class="form-control" required maxlength="100">
                                    </div>
                                    <div class="col-md-2 mb-3">
                                        <label for="numero"><strong class="text-danger">*</strong> Número:</label>
                                        <input type="text" name="numero" id="numero" class="form-control" required maxlength="10">
                                    </div>
                                    <div class="col-md-4 mb-3">
                                        <label for="complemento">Complemento:</label>
                                        <input type="text" name="complemento" id="complemento" class="form-control" maxlength="100">
                                    </div>

                                    <div class="col-12 mt-3">
                                        <h5>Informações de Acesso:</h5>
                                        <hr class="mt-0 mb-3">
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="usuario"><strong class="text-danger">*</strong> Usuário:</label>
                                        <input type="text" name="usuario" id="usuario" class="form-control" required maxlength="100">
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="senha"><strong class="text-danger">*</strong> Senha:</label>
                                        <input type="text" name="senha" id="senha" class="form-control" required maxlength="100">
                                    </div>

                                    <div class="col-12 mt-3">
                                        <input type="hidden" name="cadastrar" value="cadastrar_cliente">

                                        <input type="submit" value="Cadastrar" class="btn btn-custom mt-3">
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                    <br>
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