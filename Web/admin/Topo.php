<?php 

  $url_completa = $_SERVER['REQUEST_URI'];

  $caminho = explode('/', $url_completa);

  $url = "http://" . $_SERVER['HTTP_HOST'] . "/" . $caminho[1] . "/" . $caminho[2] . "/" . $caminho[3];

?>

<header class="navbar navbar-dark sticky-top flex-md-nowrap p-0 shadow" style="background-color: #0d0d0d;">
  <a class="navbar-brand col-md-3 col-lg-2 px-3" href="<?= $url ?>/admin.php">GSharp</a>
  <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="navbar-nav">
    <div class="nav-item text-nowrap">
      <a class="nav-link px-3" href="<?= $url ?>/logoff.php">Sair</a>
    </div>
  </div>
</header>