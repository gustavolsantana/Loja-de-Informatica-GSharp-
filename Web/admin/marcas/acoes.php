<?php

require_once "../../conection/conecta.php";

if (!isset($_SESSION)) {
    session_start();
}

try {
    if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_marca") {
        $marca = mysqli_real_escape_string($conexao, $_POST['marca']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "INSERT INTO marca VALUES (0, '$marca', '$observacao', NOW(), 1)";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Marca cadastrado com sucesso!";
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

//Editar marca
try {
    if (isset($_POST['editar']) && $_POST['editar'] == "editar_marca") {
        $codigo = $_POST['id_marca'];
        $status = $_POST['status'];
        $marca = mysqli_real_escape_string($conexao, $_POST['marca']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "UPDATE marca SET nome = '$marca', observacao = '$observacao', status = $status WHERE id_marca = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Marca alterada com sucesso!";
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

//-----------------------------------------------------------------------------------------
try {
    //EXCLUIR marca
    if (isset($_POST['excluir_marca'])) {
        $codigo = $_POST['excluir_marca'];

        $sql = "DELETE FROM marca WHERE id_marca = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Marca Excluída com Sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('location: Index.php');
        } else {
            $_SESSION['mensagem'] = "Erro ao Excluir a Marca";
            $_SESSION['tipo_mensagem'] = "danger";
            header('location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $sql = "SELECT COUNT(*) AS 'contagem' FROM produto WHERE id_marca = $codigo";
    $query = mysqli_query($conexao, $sql);

    $resultado = mysqli_fetch_row($query);
    $contagem = $resultado[0];

    $_SESSION['mensagem'] = "Esta Marca Está Associada a " . $contagem . " Produto(s) e não pode ser excluído";
    $_SESSION['tipo_mensagem'] = "info";
    header('location: Index.php');
}
