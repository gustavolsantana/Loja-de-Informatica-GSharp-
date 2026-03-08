<?php
$host = "mysql.railway.internal";
$porta = 3306;
$usuario = "root";
$senha = "ezNjbEHnnOXLLsgKgJm5cMsIMweMlyha";
$banco = "railway";

$conexao = new mysqli($host, $usuario, $senha, $banco, $porta);

if ($conexao->connect_error) {
    die("Erro de conexão: " . $conexao->connect_error);
} else {
    echo "Conexão bem-sucedida!";
}
?>
