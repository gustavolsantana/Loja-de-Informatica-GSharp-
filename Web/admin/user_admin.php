<?php 

#Iniciando sessão
if (!isset($_SESSION)) {
  session_start();
}

#Verificando se o usuario é admen
if ($_SESSION['TYPE'] != '1')
{
    $_SESSION['naoAdmen'] = "Apenas administradores podem acessar esta página";
    header('Location: ../admin.php');
}

?>