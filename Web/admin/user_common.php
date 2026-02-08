<?php

#Iniciando sessão
if (!isset($_SESSION)) {
  session_start();
}

#Verificando se existe usuário logado para permitir o acesso
if (!$_SESSION['USER'])
{
  $_SESSION['naoAutorizado'] = "Apenas administradores podem acessar está página";
  header('Location: ../index.php');
}

?>