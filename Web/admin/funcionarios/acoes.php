<?php

require_once "../../conection/conecta.php";

if (!isset($_SESSION)) {
    session_start();
}

try {
    if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_funcionario") {
        $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
        $nome_social = mysqli_real_escape_string($conexao, $_POST['nome_social']);
        $rg = mysqli_real_escape_string($conexao, $_POST['rg']);
        $cpf = mysqli_real_escape_string($conexao, $_POST['cpf']);

        //enviando a imagens para o servidor
        # pegando o caminho da imagem #
        $foto = basename($_FILES['foto']['name']);
        //salvando um caminho temporario na pasta tmp
        $tmp = $_FILES['foto']['tmp_name'];
        //criando um caminho para a pasta final
        $final = "../../images/" . $foto;
        //movendo a foto para a pasta imagens
        move_uploaded_file($tmp, $final);

        $data_nascimento = mysqli_real_escape_string($conexao, $_POST['data_nascimento']);
        $sexo = mysqli_real_escape_string($conexao, $_POST['sexo']);
        $estado_civil = mysqli_real_escape_string($conexao, $_POST['estado_civil']);

        // Substitui ',' por '.' para formato decimal
        $salario_limpo = str_replace(',', '.', $_POST['salario']);
        $salario = mysqli_real_escape_string($conexao, $salario_limpo);

        $cep = mysqli_real_escape_string($conexao, $_POST['cep']);
        $estado = mysqli_real_escape_string($conexao, $_POST['estado']);
        $cidade = mysqli_real_escape_string($conexao, $_POST['cidade']);
        $bairro = mysqli_real_escape_string($conexao, $_POST['bairro']);
        $endereco = mysqli_real_escape_string($conexao, $_POST['endereco']);
        $numero = mysqli_real_escape_string($conexao, $_POST['numero']);
        $complemento = mysqli_real_escape_string($conexao, $_POST['complemento']);
        $telefone1 = mysqli_real_escape_string($conexao, $_POST['telefone1']);
        $telefone2 = mysqli_real_escape_string($conexao, $_POST['telefone2']);
        $email = mysqli_real_escape_string($conexao, $_POST['email']);
        $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
        $senha = mysqli_real_escape_string($conexao, $_POST['senha']);
        $tipo_acesso = mysqli_real_escape_string($conexao, $_POST['tipo_acesso']);
        $cargo = mysqli_real_escape_string($conexao, $_POST['id_cargo']);

        $sql = "INSERT INTO funcionario VALUES (0, '$nome', '$nome_social', '$rg', '$cpf', '$foto', '$data_nascimento', '$sexo', '$estado_civil', '$salario', '$cep', '$estado', '$cidade', '$bairro', '$endereco', '$numero', '$complemento', '$telefone1', '$telefone2', '$email', '$usuario', '$senha', $tipo_acesso, NOW(), 1, '$cargo')";

        if (mysqli_query($conexao, $sql)) {

            $_SESSION['mensagem'] = "Funcionário(a) cadastrado(a) com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Inserir.php');
        } else {
            $_SESSION['mensagem'] = 'Erro ao cadastrar!';
            $_SESSION['tipo_mensagem'] = 'danger';
            header('Location: Inserir.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'Erro ao cadastrar!';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Inserir.php');
}
try {



    //Editar Funcionário
    if (isset($_POST['editar']) && $_POST['editar'] == "editar_funcionario") {
        $codigo = $_POST['id_funcionario'];
        $status = $_POST['status'];
        $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
        $nome_social = mysqli_real_escape_string($conexao, $_POST['nome_social']);
        $rg = mysqli_real_escape_string($conexao, $_POST['rg']);
        $cpf = mysqli_real_escape_string($conexao, $_POST['cpf']);

        //enviando a imagens para o servidor
        # pegando o caminho da imagem #
        $foto = basename($_FILES['foto']['name']);
        //salvando um caminho temporario na pasta tmp
        $tmp = $_FILES['foto']['tmp_name'];
        //criando um caminho para a pasta final
        $final = "../../images/" . $foto;
        //movendo a foto para a pasta imagens
        move_uploaded_file($tmp, $final);

        $data_nascimento = mysqli_real_escape_string($conexao, $_POST['data_nascimento']);
        $sexo = mysqli_real_escape_string($conexao, $_POST['sexo']);
        $estado_civil = mysqli_real_escape_string($conexao, $_POST['estado_civil']);

        // Substitui ',' por '.' para formato decimal
        $salario_limpo = str_replace(',', '.', $_POST['salario']);
        $salario = mysqli_real_escape_string($conexao, $salario_limpo);

        $cep = mysqli_real_escape_string($conexao, $_POST['cep']);
        $estado = mysqli_real_escape_string($conexao, $_POST['estado']);
        $cidade = mysqli_real_escape_string($conexao, $_POST['cidade']);
        $bairro = mysqli_real_escape_string($conexao, $_POST['bairro']);
        $endereco = mysqli_real_escape_string($conexao, $_POST['endereco']);
        $numero = mysqli_real_escape_string($conexao, $_POST['numero']);
        $complemento = mysqli_real_escape_string($conexao, $_POST['complemento']);
        $telefone1 = mysqli_real_escape_string($conexao, $_POST['telefone1']);
        $telefone2 = mysqli_real_escape_string($conexao, $_POST['telefone2']);
        $email = mysqli_real_escape_string($conexao, $_POST['email']);
        $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
        $senha = mysqli_real_escape_string($conexao, $_POST['senha']);
        $tipo_acesso = mysqli_real_escape_string($conexao, $_POST['tipo_acesso']);
        $cargo = mysqli_real_escape_string($conexao, $_POST['id_cargo']);

        $sql = "UPDATE funcionario SET nome = '$nome', nome_social = '$nome_social', rg = '$rg', cpf = '$cpf', data_nascimento = '$data_nascimento', sexo = '$sexo', estado_civil = '$estado_civil', salario = '$salario', cep = '$cep', estado = '$estado', cidade = '$cidade', bairro = '$bairro', endereco = '$endereco', numero = '$numero', complemento =  '$complemento', telefone1 = '$telefone1', telefone2 = '$telefone2', email = '$email', usuario = '$usuario', senha = '$senha', tipo_acesso = $tipo_acesso, status = $status, id_cargo = '$cargo'";

        //Verificando se a foto está vazia.
        if (!empty($foto)) {
            $sql .= ", foto = '$foto'";
        }

        //Completando o update com a clausula where
        $sql .= " WHERE id_funcionario = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Funcionário(a) alterado com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Index.php');
        } else {
            $_SESSION['mensagem'] = 'Erro ao alterar!';
            $_SESSION['tipo_mensagem'] = 'danger';
            header('Location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'Erro ao alterar!';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Index.php');
}

//-----------------------------------------------------------------------------------------
try {
    //EXCLUIR funcionario
    if (isset($_POST['excluir_funcionario'])) {
        $codigo = $_POST['excluir_funcionario'];

        $sql = "DELETE FROM funcionario WHERE id_funcionario = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Funcionário Excluído com Sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('location: Index.php');
        } else {
            $_SESSION['mensagem'] = "Erro ao Excluir o Funcionário";
            $_SESSION['tipo_mensagem'] = "danger";
            header('location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao Excluir o Funcionário";
    $_SESSION['tipo_mensagem'] = "danger";
    header('location: Index.php');
}
