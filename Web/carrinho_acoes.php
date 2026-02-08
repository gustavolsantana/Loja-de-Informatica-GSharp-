<?php
session_start();

if (isset($_POST['adicionar'])) {
    $id = $_POST['id_produto'];

    // Cria o array do carrinho se não existir
    if (!isset($_SESSION['carrinho'])) {
        $_SESSION['carrinho'] = array();
    }

    // Adiciona o produto ao carrinho (chave é o ID, valor é a quantidade fixa 1)
    $_SESSION['carrinho'][$id] = 1;

    header("Location: carrinho.php");
    exit;
}

// Lógica para remover item
if (isset($_GET['remover'])) {
    $id = $_GET['remover'];
    unset($_SESSION['carrinho'][$id]);
    header("Location: carrinho.php");
    exit;
}
?>