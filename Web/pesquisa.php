<?php
require_once("conection/conecta.php");

$ofertas = isset($_GET['ofertas']) ? 1 : 0;
$busca_rapida = isset($_GET['busca_rapida']) ? $_GET['busca_rapida'] : '';
$perifericos = isset($_GET['perifericos']) ? 1 : 0;
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Busca | GSharp</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Exo+2:wght@100..900&display=swap" rel="stylesheet">
</head>

<body>

    <?php include('cabecalho.php'); ?>

    <div class="container">
        <?php $termo_inicial = isset($_GET['pesquisa']) ? $_GET['pesquisa'] : ''; ?>

        <div class="pesquisa">
            <h2 id="titulo-busca" style="width: 100%;">
                <?php echo ($termo_inicial !== "") ? "Resultados para: <strong>$termo_inicial</strong>" : "Todos os produtos"; ?>
            </h2>

            <button class="btn-filtro-toggle" id="btn-toggle-filtro">
                <i class="bi bi-funnel"></i> Filtrar Produtos
            </button>

            <div class="filtro">
                <div class="marca">
                    <h5>Marca</h5>
                    <?php
                    $sql_m = "SELECT * FROM marca WHERE status = 1";
                    $res_m = mysqli_query($conexao, $sql_m);
                    foreach ($res_m as $m) {
                        echo '<label><input type="checkbox" class="filtro-marca" value="' . $m['id_marca'] . '" onchange="buscar()"> ' . $m['nome'] . '</label><br>';
                    }
                    ?>
                </div>

                <div class="categoria">
                    <h5>Categoria</h5>
                    <?php
                    $sql_c = "SELECT * FROM categoria WHERE status = 1";
                    $res_c = mysqli_query($conexao, $sql_c);
                    foreach ($res_c as $c) {
                        echo '<label><input type="checkbox" class="filtro-categoria" value="' . $c['id_categoria'] . '" onchange="buscar()"> ' . $c['nome'] . '</label><br>';
                    }
                    ?>
                </div>

                <div class="preco">
                    <h5>Preço</h5>
                    <input type="text" id="min" placeholder="Mínimo" data-mask="000.000,00" data-mask-reverse="true" onkeyup="buscarComDelay()">
                    <input type="text" id="max" placeholder="Máximo" data-mask="000.000,00" data-mask-reverse="true" onkeyup="buscarComDelay()">
                </div>
            </div>

            <div id="resultado-ajax" class="resultado">
            </div>
        </div>
    </div>

    <?php include('rodape.php'); ?>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
    <script src="assets/js/jquery.mask.js"></script>

    <script>
        let timer;

        function realizarBusca(pagina = 1) {
            const pesquisa = '<?php echo $termo_inicial; ?>';
            const ofertas = '<?php echo $ofertas; ?>';
            const busca_rapida = '<?php echo $busca_rapida; ?>';
            const perifericos = '<?php echo $perifericos; ?>';

            let marcas = [];
            $('.filtro-marca:checked').each(function() {
                marcas.push($(this).val());
            });

            let categorias = [];
            $('.filtro-categoria:checked').each(function() {
                categorias.push($(this).val());
            });

            const min = $('#min').val();
            const max = $('#max').val();

            $.ajax({
                url: 'resultado.php',
                method: 'POST',
                data: {
                    pesquisa: pesquisa,
                    ofertas: ofertas,
                    busca_rapida: busca_rapida,
                    perifericos: perifericos,
                    marca: marcas.join(','),
                    categoria: categorias.join(','),
                    min: min,
                    max: max,
                    pagina: pagina
                },
                success: function(res) {
                    $('#resultado-ajax').html(res);
                    if (pagina > 1) {
                        $('html, body').animate({
                            scrollTop: $("#titulo-busca").offset().top - 20
                        }, 300);
                    }
                }
            });
        }

        function buscar() {
            realizarBusca(1);
        }

        function buscarComDelay() {
            clearTimeout(timer);
            timer = setTimeout(buscar, 800);
        }

        $(document).ready(function() {
            buscar();

            $('#btn-toggle-filtro').click(function() {
                $('.filtro').toggleClass('aberto');

                let icone = $(this).find('i');
                if ($('.filtro').hasClass('aberto')) {
                    icone.removeClass('bi-funnel').addClass('bi-x-lg');
                } else {
                    icone.removeClass('bi-x-lg').addClass('bi-funnel');
                }
            });
        });
    </script>
</body>

</html>