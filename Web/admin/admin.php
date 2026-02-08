<?php

require_once '../conection/conecta.php';

#Iniciando sessão
if (!isset($_SESSION)) {
  session_start();
}

#Verificando se existe usuário logado para permitir o acesso
if (!$_SESSION['USER']) {
  $_SESSION['naoAutorizado'] = "Apenas administradores podem acessar esta página";
  header('Location: Index.php');
}

?>

<!doctype html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>GSharp - Painel</title>

  <!-- BOOTSTRAP CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <!-- BOOTSTRAP ICONS -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link rel="stylesheet" href="../assets/css/dashboard.css">
  <link rel="stylesheet" href="../assets/css/styles.css">

  <!-- FAVICON -->
  <link rel="shortcut icon" href="../assets/img/favicon.ico" type="image/x-icon">

  <!-- CSS   -->
  <link rel="stylesheet" href="../custom/css/style.css">

  <link rel="stylesheet" href="../assets/css/style.css">

</head>

<body>

  <?php
  #Início TOPO
  include('Topo.php');
  #Final TOPO
  ?>

  <div class="container-fluid">
    <div class="row">
      <?php
      #Início MENU
      include('Navegacao.php');
      #Final MENU
      ?>

      <main class="ml-auto col-lg-10 px-md-4">
        <?php
        #Início CABECALHO
        include('log.php');
        #Final CABECALHO
        ?>


        <div class="pt-2" style="color: #Ff6961;">
          <?php

          if (isset($_SESSION['naoAdmen'])) {
            echo $_SESSION['naoAdmen'];
            unset($_SESSION['naoAdmen']);
          }

          ?>
        </div>

        <div class="container d-flex flex-wrap justify-content-between">

          <div class="widget mt-5">
            <h6>Funcionário que Mais Vendeu</h6>
            <?php
            $sql = "SELECT f.nome, COUNT(p.id_pedido) as total 
                    FROM pedido p 
                    JOIN funcionario f ON p.id_funcionario = f.id_funcionario 
                    GROUP BY f.id_funcionario ORDER BY total DESC LIMIT 1";
            $query = mysqli_query($conexao, $sql);
            $res = mysqli_fetch_assoc($query);
            echo "<span>" . ($res['nome'] ?? 'Nenhum') . " (" . ($res['total'] ?? 0) . ")</span>";
            ?>
          </div>

          <div class="widget mt-5">
            <h6>Quantidade de Vendas</h6>
            <?php
            $sql = "SELECT COUNT(*) as total FROM pedido";
            $query = mysqli_query($conexao, $sql);
            $res = mysqli_fetch_assoc($query);
            echo "<span>" . ($res['total'] ?? 0) . "</span>";
            ?>
          </div>

          <div class="widget mt-5">
            <h6>Faturamento Total</h6>
            <?php
            $sql = "SELECT SUM(valor_total) as total FROM pedido";
            $query = mysqli_query($conexao, $sql);
            $res = mysqli_fetch_assoc($query);
            $faturamento = $res['total'] ?? 0;
            echo "<span>R$ " . number_format($faturamento, 2, ',', '.') . "</span>";
            ?>
          </div>

          <div class="widget mt-5">
            <h6>Faturamento do Mês</h6>
            <?php
            $sql = "SELECT SUM(valor_total) as total FROM pedido WHERE MONTH(data_pedido) = MONTH(CURRENT_DATE()) AND YEAR(data_pedido) = YEAR(CURRENT_DATE())";
            $query = mysqli_query($conexao, $sql);
            $res = mysqli_fetch_assoc($query);
            $mensal = $res['total'] ?? 0;
            echo "<span>R$ " . number_format($mensal, 2, ',', '.') . "</span>";
            ?>
          </div>

          <div class="container mt-5 p-0">
            <div class="card card-dashboard">
              <div class="card-header d-flex justify-content-between">
                <h4 class="m-0">Top 10 Produtos Mais Vendidos</h4>
              </div>
              <div class="card-body">
                <table class="table table-striped">
                  <?php
                  // SQL Corrigido com JOINs para buscar nomes de marcas e categorias
                  $sql = "SELECT p.id_produto, p.nome, m.nome as marca, c.nome as categoria, p.estoque, p.data_cadastro, p.status, SUM(ip.quantidade) as total_vendido
                                FROM itens_pedido ip
                                JOIN produto p ON ip.id_produto = p.id_produto
                                JOIN marca m ON p.id_marca = m.id_marca
                                JOIN categoria c ON p.id_categoria = c.id_categoria
                                GROUP BY p.id_produto
                                ORDER BY total_vendido DESC LIMIT 10";
                  $query = mysqli_query($conexao, $sql);

                  if (mysqli_num_rows($query) > 0) {
                  ?>
                    <thead>
                      <tr>
                        <th>#</th>
                        <th>Produto</th>
                        <th>Marca</th>
                        <th>Categoria</th>
                        <th>Estoque</th>
                        <th>Data Cadastro</th>
                        <th>Status</th>
                      </tr>
                    </thead>
                    <tbody>
                      <?php while ($produto = mysqli_fetch_assoc($query)) { ?>
                        <tr>
                          <td><?php echo $produto["id_produto"] ?></td>
                          <td><?php echo $produto["nome"] ?></td>
                          <td><?php echo $produto["marca"] ?></td>
                          <td><?php echo $produto["categoria"] ?></td>
                          <td><?php echo $produto["estoque"] ?></td>
                          <td><?php echo date('d/m/Y', strtotime($produto["data_cadastro"])) ?></td>
                          <td>
                            <span class="badge badge-pill badge-<?php echo $produto['status'] == 1 ? 'success' : 'danger'; ?>">
                              <?php echo $produto['status'] == 1 ? 'Ativo' : 'Inativo'; ?>
                            </span>
                          </td>
                        </tr>
                      <?php } ?>
                    </tbody>
                  <?php } else {
                    echo '<div class="alert alert-warning m-3">Nenhuma venda registrada!</div>';
                  } ?>
                </table>
              </div>
            </div>
          </div>
        </div>

      </main>
    </div>
  </div>

  <!-- BOOTSTRAP JS -->
  <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>