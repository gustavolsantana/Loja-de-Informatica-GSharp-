<?php

require_once "../../conection/conecta.php";

if (!isset($_SESSION)) {
    session_start();
}

try {
    if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_produto") {

        if (!empty($_FILES['foto']['name'])) {
            $foto = basename($_FILES['foto']['name']);
            $tmp = $_FILES['foto']['tmp_name'];
            $final = "../../images/" . $foto;
            move_uploaded_file($tmp, $final);
        } else {
            $foto = "placeholder-produto.jpg";
        }

        $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
        $descricao = mysqli_real_escape_string($conexao, $_POST['descricao']);
        $estoque = mysqli_real_escape_string($conexao, $_POST['estoque']);
        $marca = mysqli_real_escape_string($conexao, $_POST['id_marca']);
        $categoria = mysqli_real_escape_string($conexao, $_POST['id_categoria']);

        $status_promocao = (!empty($_POST['status_promocao'])) ? $_POST['status_promocao'] : 0;
        $desconto = (!empty($_POST['desconto'])) ? $_POST['desconto'] : 0;

        $preco_custo = str_replace(',', '.', $_POST['preco_custo']);
        $percentual_lucro = mysqli_real_escape_string($conexao, $_POST['percentual_lucro']);
        $preco_venda = str_replace(',', '.', $_POST['preco_venda']);

        $preco_promocao = (!empty($_POST['preco_promocao'])) ? str_replace(',', '.', $_POST['preco_promocao']) : 0;

        $sql = "INSERT INTO produto VALUES (0, '$nome', '$descricao', '$foto', $estoque, $preco_custo, $percentual_lucro, $preco_venda, $status_promocao, $desconto, $preco_promocao, NOW(), 1, $marca, $categoria)";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Produto cadastrado com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Inserir.php');
        } else {
            $_SESSION['mensagem'] = 'Erro ao cadastrar!';
            $_SESSION['tipo_mensagem'] = 'danger';
            header('Location: Inserir.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'Erro ao cadastrar!';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Inserir.php');
}

//EDITAR PRODUTO

try {
    if (isset($_POST['editar']) && $_POST['editar'] == "editar_produto") {

        //enviando a imagens para o servidor
        # pegando o caminho da imagem #
        $foto = basename($_FILES['foto']['name']);
        //salvando um caminho temporario na pasta tmp
        $tmp = $_FILES['foto']['tmp_name'];
        //criando um caminho para a pasta final
        $final = "../../images/" . $foto;
        //movendo a foto para a pasta imagens
        move_uploaded_file($tmp, $final);

        $codigo = $_POST['id_produto'];
        $status = $_POST['status'];
        $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
        $descricao = mysqli_real_escape_string($conexao, $_POST['descricao']);
        $estoque = mysqli_real_escape_string($conexao, $_POST['estoque']);
        $marca = mysqli_real_escape_string($conexao, $_POST['id_marca']);
        $categoria = mysqli_real_escape_string($conexao, $_POST['id_categoria']);
        $status_promocao = mysqli_real_escape_string($conexao, $_POST['status_promocao']);
        $desconto = mysqli_real_escape_string($conexao, $_POST['desconto']);
        $preco_custo = str_replace(',', '.', $_POST['preco_custo']);
        $percentual_lucro = mysqli_real_escape_string($conexao, $_POST['percentual_lucro']);
        $preco_venda = str_replace(',', '.', $_POST['preco_venda']);
        $preco_promocao = str_replace(',', '.', $_POST['preco_promocao']);

        $sql = "UPDATE produto SET nome = '$nome', descricao = '$descricao', estoque = '$estoque', preco_custo = '$preco_custo', percentual_lucro = '$percentual_lucro', preco_venda = '$preco_venda', status_promocao = $status_promocao, desconto = '$desconto', preco_promocao = '$preco_promocao', status = $status, id_marca = '$marca', id_categoria = '$categoria'";

        //Verificando se a foto está vazia.
        if (!empty($foto)) {
            $sql .= ", foto = '$foto'";
        }

        //Completando o update com a clausula where
        $sql .= " WHERE id_produto = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Produto alterado com sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('Location: Index.php');
        } else {
            $_SESSION['mensagem'] = 'Erro ao alterar!';
            $_SESSION['tipo_mensagem'] = 'danger';
            header('Location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = 'exceção';
    $_SESSION['tipo_mensagem'] = 'danger';
    header('Location: Index.php');
}

//-----------------------------------------------------------------------------------------
try {
    //EXCLUIR produto
    if (isset($_POST['excluir_produto'])) {
        $codigo = $_POST['excluir_produto'];

        $sql = "DELETE FROM produto WHERE id_produto = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Produto Excluído com Sucesso!";
            $_SESSION['tipo_mensagem'] = "success";
            header('location: Index.php');
        } else {
            $_SESSION['mensagem'] = "Erro ao Excluir o Produto";
            $_SESSION['tipo_mensagem'] = "danger";
            header('location: Index.php');
        }
    }
} catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao Excluir o Produto";
    $_SESSION['tipo_mensagem'] = "danger";
    header('location: Index.php');
}
