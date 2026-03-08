<?php
$host = "mysql.railway.internal";
$usuario = "root";
$senha = "ezNjbEHnnOXLLsgKgJmScMslMweMlyha";
$banco = "railway";

$conexao = new mysqli($host, $usuario, $senha, $banco);

if ($conexao->connect_error) {
    die("Erro de conexão: " . $conexao->connect_error);
} else {
    echo "Conexão bem-sucedida!";
}
?>
