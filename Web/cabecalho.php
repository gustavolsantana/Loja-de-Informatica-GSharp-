<?php
# Conexão com o Banco de Dados
require_once 'conection/conecta.php';

# Iniciando sessão se não estiver iniciada
if (!isset($_SESSION)) {
    session_start();
}

$cliente = []; // Inicializa a variável para evitar erros

// Verifica se o usuário está logado antes de buscar no banco
if (isset($_SESSION['NAMECliente'])) {

    // 1. Protege contra SQL Injection
    $nome_cliente = mysqli_real_escape_string($conexao, $_SESSION['NAMECliente']);

    // 2. Busca o ID apenas deste cliente específico
    $sql = "SELECT id_cliente FROM cliente WHERE nome = '$nome_cliente' LIMIT 1";

    $query = mysqli_query($conexao, $sql);

    // 3. Popula a variável $cliente com o resultado
    if ($query && mysqli_num_rows($query) > 0) {
        $cliente = mysqli_fetch_assoc($query);
    }
}
?>

<header class="cabecalho">
    <div class="parte-de-cima">
        <div class="logo">
            <a href="index.php"><img src="assets/img/Logo.png" alt="LOGOTIPO DA EMPRESA"></a>
        </div>
        <form action="pesquisa.php" method="GET" class="pesquisar">
            <input type="search" name="pesquisa" id="pesquisa" placeholder="Digite o que procura..."
                value="<?php echo isset($_GET['pesquisa']) ? $_GET['pesquisa'] : ''; ?>">
        </form>

        <button class="btn-menu-mobile" onclick="toggleMainMenu()">
            <i class="bi bi-list"></i>
        </button>

        <div class="usuario">
            <ul>
                <?php if (!empty($_SESSION['NAMECliente'])) { ?>
                    <li class="dropdown">
                        <a href="javascript:void(0)" class="dropbtn" onclick="toggleMenu()">
                            <i class="bi bi-person-circle"></i>
                            <span style="text-transform: capitalize;">Olá, <?php echo explode(' ', $_SESSION['NAMECliente'])[0]; ?>!</span>
                        </a>
                        <div id="dropdownUsuario" class="dropdown-content">
                            <a href="admin/clientes/editar.php?id_cliente=<?php echo isset($cliente['id_cliente']) ? $cliente['id_cliente'] : ''; ?>">Minha Conta</a>
                            <a href="logoff.php" class="sair">Sair</a>
                        </div>
                    </li>
                <?php } else { ?>
                    <li><a href="entre.php"><i class="bi bi-person-circle"></i><span>Minha Conta</span></a></li>
                <?php } ?>
                <li><a href="carrinho.php"><i class="bi bi-cart2"></i> <span>Carrinho</span></a></li>
            </ul>
        </div>
    </div>
    <div class="parte-de-baixo">
        <nav class="menu">
            <ul>
                <li><a href="index.php">Home</a></li>
                <li><a href="pesquisa.php?ofertas=1">Ofertas</a></li>
                <li><a href="pesquisa.php?busca_rapida=kit upgrade">Kit Upgrade</a></li>
                <li><a href="pesquisa.php?busca_rapida=computador">Computador</a></li>
                <li><a href="pesquisa.php?perifericos=1">Periféricos</a></li>
            </ul>
        </nav>
    </div>
</header>

<script>
    function toggleMenu() {
        document.getElementById("dropdownUsuario").classList.toggle("show");
    }

    function toggleMainMenu() {
        document.querySelector(".parte-de-baixo").classList.toggle("show");
    }

    // Fecha o menu se o usuário clicar fora dele
    window.onclick = function(event) {
        if (!event.target.matches('.dropbtn') && !event.target.closest('.dropbtn')) {
            var dropdowns = document.getElementsByClassName("dropdown-content");
            for (var i = 0; i < dropdowns.length; i++) {
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    }
</script>