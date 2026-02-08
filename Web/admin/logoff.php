<?php

#Iniciando sessão
if (!isset($_SESSION)) {
  session_start();
}

unset($_SESSION['USER'], $_SESSION['TYPE']);
$_SESSION['logOff'] = "Você saiu da sua conta";
header('Location: index.php');



?>