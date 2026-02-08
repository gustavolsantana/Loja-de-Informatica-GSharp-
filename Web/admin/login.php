<?php 

    # Conexão com o Banco de Dados
    require_once '../conection/conecta.php';

    #Iniciando sessão
    if (!isset($_SESSION))
    {
        session_start();
    }

    if (isset($_POST['usuario']) && $_POST['usuario'] != '' && isset($_POST['senha']) && $_POST['senha'] != '')
    {
        $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
        $senha = mysqli_real_escape_string($conexao, $_POST['senha']);

        $sql = "SELECT * FROM funcionario WHERE usuario = '$usuario' AND senha = '$senha'";

        $query = mysqli_query($conexao, $sql);

        $funcionario = mysqli_fetch_assoc($query);

        //echo $funcionario['nome'];

        if (isset($funcionario))
        {
            $_SESSION['ID'] = $funcionario['id_funcionario'];
            $_SESSION['NAME'] = $funcionario['nome'];
            $_SESSION['USER'] = $funcionario['usuario'];
            $_SESSION['TYPE'] = $funcionario['tipo_acesso'];

            header('Location: admin.php');
        }
        else
        {
            $_SESSION['loginErro'] = "Usuário ou senha invalidos.";
            header('Location: index.php');
        }
    }
    else
    {
        $_SESSION['loginVazio'] = "Insira um usuário ou senha";
        header('Location: index.php');
    }

?>