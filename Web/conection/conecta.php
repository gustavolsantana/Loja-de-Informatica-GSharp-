<?php

$host = "trolley.proxy.rlwy.net";
$porta = 42537;
$usuario = "root";
$senha = "ezNjbEHnnOXLLsgKgJmScMslMweMlyha";
$banco = "railway";

// Se você usa mysqli, adicione a porta no final da conexão:
$conexao = new mysqli($host, $usuario, $senha, $banco, $porta);

if ($conexao->connect_error) {
    die("Erro de conexão: " . $conexao->connect_error);
}
