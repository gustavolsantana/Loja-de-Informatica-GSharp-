<?php 

    # Conexão com o Banco de Dados
    require_once 'conection/conecta.php';

    #Iniciando sessão
    if (!isset($_SESSION))
    {
        session_start();
    }

    if (isset($_POST['usuarioCliente']) && $_POST['usuarioCliente'] != '' && isset($_POST['senhaCliente']) && $_POST['senhaCliente'] != '')
    {
        $usuarioCliente = mysqli_real_escape_string($conexao, $_POST['usuarioCliente']);
        $senhaCliente = mysqli_real_escape_string($conexao, $_POST['senhaCliente']);

        $sql = "SELECT * FROM cliente WHERE usuario = '$usuarioCliente' AND senha = '$senhaCliente'";

        $query = mysqli_query($conexao, $sql);

        $cliente = mysqli_fetch_assoc($query);

        if (isset($cliente))
        {
            $_SESSION['IDCliente'] = $cliente['id_cliente'];
            $_SESSION['NAMECliente'] = $cliente['nome'];
            $_SESSION['USERCliente'] = $cliente['usuario'];

            header('Location: index.php');
        }
        else
        {
            $_SESSION['loginErroCliente'] = "Usuário ou senha invalidos.";
            header('Location: entre.php');
        }
    }
    else
    {
        $_SESSION['loginVazioCliente'] = "Insira um usuário ou senha";
        header('Location: entre.php');
    }

?>