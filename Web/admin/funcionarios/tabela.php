<?php

require_once '../../conection/conecta.php';

#Restrição de acesso
include_once '../user_common.php';

// Filtros
$status = $_POST['status'];
$cargo = $_POST['cargo'];
$tipo_acesso = $_POST['tipo_acesso'];

// Pesquisar
$nome = mysqli_real_escape_string($conexao, $_POST['nome']);

?>

<table class="table table-striped">

    <?php

    $sql = "SELECT funcionario.id_funcionario, funcionario.nome as nome_funcionario, cargo.nome as nome_cargo, funcionario.salario, funcionario.telefone1, funcionario.data_cadastro, funcionario.status FROM funcionario join cargo on funcionario.id_cargo = cargo.id_cargo WHERE 1=1";

    if ($status != "") {
        $sql .= " AND funcionario.status = $status";
    }

    if ($cargo != "") {
        $sql .= " AND funcionario.id_cargo = $cargo";
    }

    if ($tipo_acesso != "") {
        $sql .= " AND funcionario.tipo_acesso = $tipo_acesso";
    }

    if ($nome != "") {
        $sql .= " AND funcionario.nome LIKE '%$nome%'";
    }

    $query = mysqli_query($conexao, $sql);

    if (mysqli_num_rows($query) > 0) {

    ?>

        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Nome</th>
                <th scope="col">Cargo</th>
                <th scope="col">Salário</th>
                <th scope="col">Telefone</th>
                <th scope="col">Data do Cadastro</th>
                <th scope="col">Status</th>

                <!-- Ocultando a coluna ações para usuários comuns --> 
                <?php 
                
                    if ($_SESSION['TYPE'] == '1')
                    {
                        echo '<th scope="col">Ações</th>';
                    }
                
                ?>
                
            </tr>
        </thead>
        <tbody>

            <?php

            foreach ($query as $funcionario) {

            ?>
                <tr>
                    <td><?php echo $funcionario['id_funcionario'] ?></td>
                    <td><?php echo $funcionario['nome_funcionario'] ?></td>
                    <td><?php echo $funcionario['nome_cargo'] ?></td>
                    <td><?php echo 'R$ ' . number_format($funcionario['salario'], 2, ',', '.') ?></td>
                    <td><?php echo $funcionario['telefone1'] ?></td>
                    <td><?php echo date('d/m/Y', strtotime($funcionario['data_cadastro'])) ?></td>
                    <td>
                        <?php

                        if ($funcionario["status"] == 1) {
                            echo '<span class="badge badge-pill badge-success">Ativo</span>';
                        } else {
                            echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                        }

                        ?>
                    </td>

                    <?php 
                    
                    if ($_SESSION['TYPE'] == '1')
                    {
                    
                    ?>

                    <td>
                        <a href="editar.php?id_funcionario=<?php echo $funcionario['id_funcionario'] ?>" class="btn btn-outline-success btn-sm" title="Editar">
                            <i class="bi bi-pencil"></i>
                        </a>
                        <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="excluir_funcionario" value="<?php echo $funcionario['id_funcionario'] ?>" onclick="return confirm('Você tem certeza que deseja excluir este funcionário?')">
                                <i class="bi bi-trash3"></i>
                            </button>
                        </form>
                    </td>

                    <?php 
                    
                    }
                    
                    ?>
                    
                </tr>

            <?php

            }

            ?>

        </tbody>

    <?php

    } else {
        echo '<div class="alert alert-danger m-3" role="alert">Nenhum registro encontrado!</div>';
    }

    ?>

</table>