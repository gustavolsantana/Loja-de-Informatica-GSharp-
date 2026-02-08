<?php
# Iniciando sessão
if (!isset($_SESSION)) {
    session_start();
}

// Limpa todas as variáveis da sessão
$_SESSION = array();

// Destrói a sessão completamente
session_destroy();

// Inicia uma nova sessão apenas para mostrar a mensagem de sucesso
session_start();
unset($_SESSION['USERCliente']);
unset($_SESSION['NAMECliente']);
$_SESSION['logOffCliente'] = "Você saiu da sua conta";

header('Location: index.php');
exit();
?>