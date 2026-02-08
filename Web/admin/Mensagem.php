<?php
// Verifica se existe uma mensagem na sessão
if (isset($_SESSION['mensagem']) && isset($_SESSION['tipo_mensagem'])) {

    // Pega o tipo da mensagem (ex: 'success' ou 'danger') para usar como classe do CSS
    $tipo_alerta = $_SESSION['tipo_mensagem'];

    // Pega a mensagem
    $mensagem = $_SESSION['mensagem'];

    // Exibe o alerta do Bootstrap com a classe e a mensagem corretas
    echo "<div class='alert alert-{$tipo_alerta} mt-3' role='alert'>";
    echo $mensagem;
    echo "</div>";

    // Limpa as variáveis da sessão para que a mensagem não apareça novamente
    unset($_SESSION['mensagem']);
    unset($_SESSION['tipo_mensagem']);
}
