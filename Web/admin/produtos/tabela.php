<?php

require_once '../../conection/conecta.php';

// Filtros
$status = $_POST['status'];
$marca = $_POST['marca'];
$categoria = $_POST['categoria'];

// Pesquisar
$nome = mysqli_real_escape_string($conexao, $_POST['nome']);

?>

<table class="table table-striped">

    <?php

    $sql = "SELECT produto.id_produto, produto.nome as nome_produto, marca.nome as nome_marca, categoria.nome as nome_categoria, produto.estoque, produto.data_cadastro, produto.status FROM produto JOIN marca ON produto.id_marca = marca.id_marca JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE 1=1";

    if ($status != "") {
        $sql .= " AND produto.status = $status";
    }

    if ($categoria != "") {
        $sql .= " AND produto.id_categoria = $categoria";
    }

    if ($marca != "") {
        $sql .= " AND produto.id_marca = $marca";
    }

    if ($nome != "") {
        $sql .= " AND produto.nome LIKE '%$nome%'";
    }

    $query = mysqli_query($conexao, $sql);

    if (mysqli_num_rows($query) > 0) {
    ?>

        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Produto</th>
                <th scope="col">Marca</th>
                <th scope="col">Categoria</th>
                <th scope="col">Estoque</th>
                <th scope="col">Data do Cadastro</th>
                <th scope="col">Status</th>
                <th scope="col">Ações</th>
            </tr>
        </thead>
        <tbody>
            <?php
            foreach ($query as $produto) {
            ?>
                <tr>
                    <td><?php echo $produto["id_produto"] ?></td>

                    <td><?php echo $produto["nome_produto"] ?></td>

                    <td><?php echo $produto["nome_marca"] ?></td>
                    <td><?php echo $produto["nome_categoria"] ?></td>
                    <td><?php echo $produto["estoque"] ?></td>
                    <td><?php echo date('d/m/Y', strtotime($produto["data_cadastro"])) ?></td>
                    <td>
                        <?php
                        if ($produto["status"] == 1) {
                            echo '<span class="badge badge-pill badge-success">Ativo</span>';
                        } else {
                            echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                        }
                        ?>
                    </td>
                    <td>
                        <a href="editar.php?id_produto=<?php echo $produto["id_produto"] ?>" class="btn btn-outline-success btn-sm">
                            <i class="bi bi-pencil"></i>
                        </a>
                        <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="excluir_produto" value="<?php echo $produto['id_produto'] ?>" onclick="return confirm('Você tem certeza que deseja excluir este produto?')">
                                <i class="bi bi-trash3"></i>
                            </button>
                        </form>
                    </td>
                </tr>
            <?php
            } // Fim do foreach
            ?>
        </tbody>
    <?php
    } else {
        echo '<div class="alert alert-danger m-3" role="alert">Nenhum registro encontrado!</div>';
    }
    ?>
</table>