<?php

require_once "../../conection/conecta.php";

if (!isset($_SESSION)) {
    session_start();
}

try {
    if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_cargo") {
        $cargo = mysqli_real_escape_string($conexao, $_POST['cargo']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "INSERT INTO cargo VALUES (0, '$cargo', '$observacao', NOW(), 1)";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Cargo cadastrado com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Inserir.php');
        } else {
            $_SESSION['mensagem'] = 'Ocorreu um erro no banco de dados ao cadastrar.';
            $_SESSION['tipo_mensagem'] = "danger";
            header('Location: Inserir.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'Erro ao cadastrar!';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Inserir.php');
}

//Editar cargo
try {
    if (isset($_POST['editar']) && $_POST['editar'] == "editar_cargo") {
        $codigo = $_POST['id_cargo'];
        $status = $_POST['status'];
        $cargo = mysqli_real_escape_string($conexao, $_POST['cargo']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "UPDATE cargo SET nome = '$cargo', observacao = '$observacao', status = $status WHERE id_cargo = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Cargo alterado com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Index.php');
        } else {
            $_SESSION['mensagem'] = 'Erro ao editar!';
            $_SESSION['tipo_mensagem'] = "danger";
            header('Location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'Erro ao editar!';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Index.php');
}

try {
    //EXCLUIR CARGO
    if (isset($_POST['excluir_cargo'])) {
        $codigo = $_POST['excluir_cargo'];

        $sql = "DELETE FROM cargo WHERE id_cargo = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Cargo Excluído com Sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('location: Index.php');
        } else {
            $_SESSION['mensagem'] = "Erro ao Excluir o Cargo";
            $_SESSION['tipo_mensagem'] = "danger";
            header('location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $sql = "SELECT COUNT(*) AS 'contagem' FROM funcionario WHERE id_cargo = $codigo";
    $query = mysqli_query($conexao, $sql);

    $resultado = mysqli_fetch_row($query);
    $contagem = $resultado[0];

    $_SESSION['mensagem'] = "Este Cargo Está Associado a " . $contagem . " Funcionário(s) e não pode ser excluído";
    $_SESSION['tipo_mensagem'] = "info";
    header('location: Index.php');
}
