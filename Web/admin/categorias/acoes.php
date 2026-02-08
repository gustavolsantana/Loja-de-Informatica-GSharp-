<?php

require_once "../../conection/conecta.php";

if (!isset($_SESSION)) {
    session_start();
}

try {
    if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_categoria") {
        $categoria = mysqli_real_escape_string($conexao, $_POST['categoria']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "INSERT INTO categoria VALUES (0, '$categoria', '$observacao', NOW(), 1)";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "categoria cadastrado com sucesso!";
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

//Editar categoria
try {
    if (isset($_POST['editar']) && $_POST['editar'] == "editar_categoria") {
        $codigo = $_POST['id_categoria'];
        $status = $_POST['status'];
        $categoria = mysqli_real_escape_string($conexao, $_POST['categoria']);
        $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

        $sql = "UPDATE categoria SET nome = '$categoria', observacao = '$observacao', status = $status WHERE id_categoria = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Categoria alterada com sucesso!";
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
    //EXCLUIR categoria
    if (isset($_POST['excluir_categoria'])) {
        $codigo = $_POST['excluir_categoria'];

        $sql = "DELETE FROM categoria WHERE id_categoria = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Categoria Excluída com Sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('location: Index.php');
        } else {
            $_SESSION['mensagem'] = "Erro ao Excluir a Categoria";
            $_SESSION['tipo_mensagem'] = "danger";
            header('location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $sql = "SELECT COUNT(*) AS 'contagem' FROM produto WHERE id_categoria = $codigo";
    $query = mysqli_query($conexao, $sql);

    $resultado = mysqli_fetch_row($query);
    $contagem = $resultado[0];

    $_SESSION['mensagem'] = "Esta Categoria Está Associada a " . $contagem . " Produto(s) e não pode ser excluído";
    $_SESSION['tipo_mensagem'] = "info";
    header('location: Index.php');
}
