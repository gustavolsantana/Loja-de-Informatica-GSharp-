<?php

#Iniciando sessão
if (!isset($_SESSION)) {
  session_start();
}

?>


<!doctype html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>GSharp - Login</title>

  <!-- BOOTSTRAP CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link rel="stylesheet" href="assets/css/signin.css">
  <link rel="stylesheet" href="assets/css/styles.css">

  <!-- FAVICON -->
  <link rel="shortcut icon" href="assets/img/favicon.ico" type="image/x-icon">

  <!-- CSS   -->
  <link rel="stylesheet" href="custom/css/style.css">

</head>

<body class="text-center">

  <main class="form-signin">
    <form action="login.php" method="POST">
      <h2 class="h3 mb-3">Faça seu Login</h2>

      <input type="text" class="form-control mb-2" name="usuarioCliente" placeholder="Usuário" required>

      <input type="password" class="form-control" name="senhaCliente" placeholder="Senha" required>

      <button class="w-100 btn btn-lg btn-primary" type="submit">Login</button>

      <div class="criar-conta" style="color: #5F4A8B; margin-top: 15px;"><a href="admin/clientes/inserir.php" style="text-decoration: none;">Ou crie sua conta</a></div>

    </form>

    <div class="pt-2">
      <?php

      if (isset($_SESSION['loginErroCliente'])) {
        // 'text-danger' para vermelho
        echo '<span class="text-danger">' . $_SESSION['loginErroCliente'] . '</span>';
        unset($_SESSION['loginErroCliente']);
      }

      if (isset($_SESSION['loginVazioCliente'])) {
        echo '<span class="text-danger">' . $_SESSION['loginVazioCliente'] . '</span>';
        unset($_SESSION['loginVazioCliente']);
      }

      if (isset($_SESSION['logOffCliente'])) {
        // 'text-success' para a cor verde de sucesso
        echo '<span class="text-success">' . $_SESSION['logOffCliente'] . '</span>';
        unset($_SESSION['logOffCliente']);
      }

      ?>
    </div>

    <p class="mt-5 text-muted">&copy; <?= date('Y') ?></p>
  </main>

  <!-- BOOTSTRAP JS -->
  <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>