-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 05/02/2026 às 21:16
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gsharp`
--
CREATE DATABASE IF NOT EXISTS `gsharp` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `gsharp`;

-- --------------------------------------------------------

--
-- Estrutura para tabela `cargo`
--

CREATE TABLE `cargo` (
  `id_cargo` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `nome`, `observacao`, `data_cadastro`, `status`) VALUES
(3, 'Gerente', '', '2026-02-04 08:35:05', b'1'),
(4, 'Vendedor(a)', '', '2026-02-04 08:35:08', b'1'),
(5, 'Auxiliar de Marketing', '', '2026-02-04 08:35:14', b'1'),
(6, 'Social Mídia', '', '2026-02-04 08:35:19', b'1'),
(7, 'Suporte', '', '2026-02-04 08:35:32', b'1'),
(8, 'Desenvolvedor(a)', '', '2026-02-04 08:35:57', b'1'),
(9, 'CEO', '', '2026-02-04 08:36:02', b'1'),
(10, 'Administrador(a)', '', '2026-02-04 08:36:19', b'1');

-- --------------------------------------------------------

--
-- Estrutura para tabela `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `nome`, `observacao`, `data_cadastro`, `status`) VALUES
(1, 'Processador', '', '2026-02-04 08:36:41', b'1'),
(2, 'Placa de Vídeo', '', '2026-02-04 08:36:46', b'1'),
(3, 'Placa-Mãe', '', '2026-02-04 08:36:48', b'1'),
(4, 'SSD', '', '2026-02-04 08:36:52', b'1'),
(5, 'Monitor', '', '2026-02-04 08:36:55', b'1'),
(6, 'Teclado', '', '2026-02-04 08:36:59', b'1'),
(7, 'Mouse', '', '2026-02-04 08:37:02', b'1'),
(8, 'Headset', '', '2026-02-04 08:37:05', b'1'),
(9, 'Controle', '', '2026-02-04 08:37:08', b'1'),
(10, 'Hardware', '', '2026-02-04 08:37:23', b'1'),
(11, 'Computador', '', '2026-02-04 08:37:27', b'1');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `nome_social` varchar(100) DEFAULT NULL,
  `rg` char(12) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` varchar(13) NOT NULL,
  `cep` char(9) NOT NULL,
  `estado` char(2) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `telefone1` char(15) NOT NULL,
  `telefone2` char(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome`, `nome_social`, `rg`, `cpf`, `foto`, `data_nascimento`, `sexo`, `estado_civil`, `cep`, `estado`, `cidade`, `bairro`, `endereco`, `numero`, `complemento`, `telefone1`, `telefone2`, `email`, `usuario`, `senha`, `data_cadastro`, `status`) VALUES
(1, 'Gustavo Lucena', '', '', '505.250.408-00', '', '2007-10-14', 'M', 'Solteiro', '88339-005', 'SC', 'Balneário Camboriú', 'Estados', 'Avenida Santa Catarina', '2201', '', '(19) 98925-7257', '', '', 'gustavolsantana', 'gustavolsantana123', '2026-02-04 10:51:53', b'1'),
(2, 'Guilherme Correia', '', '', '375.623.456-87', '', '2000-01-13', 'M', 'Casado', '11471-268', 'SP', 'Rio das Pedras', 'Centro', 'Rua Dom Pedro I', '212', '', '(19) 92829-4584', '', '', 'gui505', '50525Gui', '2026-02-05 16:52:24', b'1'),
(3, 'Renata Tenório Costa', '', '', '599.239.423-90', '', '1982-04-15', 'F', 'Casado', '13420-000', 'SP', 'Piracicaba', 'Jardim Brasília', 'Rodovia Luiz de Queiróz', '157', '', '(19) 92850-1851', '', '', 'tenorio321', 'tenorio15721', '2026-02-05 16:53:59', b'1'),
(4, 'Bruna Tauany', '', '', '428.390.492-32', '', '1994-07-18', 'F', 'Casado', '11428-000', 'SP', 'Rio das Pedras', 'Centro', 'Av. XV de Março', '505', '', '(19) 92850-8502', '', '', 'bruna22', '102030B', '2026-02-05 16:57:52', b'1'),
(5, 'Carlos Eduardo Pressutto', '', '', '201.294.385-60', '', '1983-09-29', 'M', 'Casado', '13480-230', 'SP', 'Limeira', 'Jardim Mercedes', 'Rua Presidente Humberto Alencar Castelo Branco', '428', '', '(19) 98218-4583', '', '', 'cadu123', 'senha123@', '2026-02-05 16:59:52', b'1');

-- --------------------------------------------------------

--
-- Estrutura para tabela `detalhe_pagamento`
--

CREATE TABLE `detalhe_pagamento` (
  `id_detalhe_pagamento` int(11) NOT NULL,
  `valor_pago` decimal(8,2) NOT NULL,
  `numero_parcelas` int(11) NOT NULL,
  `valor_das_parcelas` decimal(8,2) NOT NULL,
  `id_pedido` int(11) NOT NULL,
  `id_forma_pagamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `detalhe_pagamento`
--

INSERT INTO `detalhe_pagamento` (`id_detalhe_pagamento`, `valor_pago`, `numero_parcelas`, `valor_das_parcelas`, `id_pedido`, `id_forma_pagamento`) VALUES
(1, 2911.53, 1, 2911.53, 1, 1),
(2, 2554.92, 3, 851.64, 2, 4),
(3, 416.25, 1, 416.25, 3, 5),
(4, 1000.00, 1, 1000.00, 4, 2),
(5, 1245.63, 5, 249.13, 5, 4),
(6, 2000.00, 1, 2000.00, 6, 2),
(7, 281.29, 1, 281.29, 6, 4);

-- --------------------------------------------------------

--
-- Estrutura para tabela `forma_pagamento`
--

CREATE TABLE `forma_pagamento` (
  `id_forma_pagamento` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `forma_pagamento`
--

INSERT INTO `forma_pagamento` (`id_forma_pagamento`, `nome`, `observacao`, `data_cadastro`, `status`) VALUES
(1, 'Pix', '', '2026-02-05 16:47:20', b'1'),
(2, 'Cheque', '', '2026-02-05 16:47:25', b'1'),
(3, 'Dinheiro', '', '2026-02-05 16:47:29', b'1'),
(4, 'Cartão de Crédito', '', '2026-02-05 16:47:37', b'1'),
(5, 'Cartão de Débito', '', '2026-02-05 16:47:44', b'1'),
(6, 'Boleto', '', '2026-02-05 16:47:51', b'1');

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id_funcionario` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `nome_social` varchar(100) DEFAULT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` varchar(13) NOT NULL,
  `salario` decimal(8,2) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `estado` char(2) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `telefone1` char(15) NOT NULL,
  `telefone2` char(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `tipo_acesso` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL,
  `id_cargo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`id_funcionario`, `nome`, `nome_social`, `rg`, `cpf`, `foto`, `data_nascimento`, `sexo`, `estado_civil`, `salario`, `cep`, `estado`, `cidade`, `bairro`, `endereco`, `numero`, `complemento`, `telefone1`, `telefone2`, `email`, `usuario`, `senha`, `tipo_acesso`, `data_cadastro`, `status`, `id_cargo`) VALUES
(2, 'Matheus Santana', '', '', '505.282.428-01', '', '1999-04-28', 'M', 'Casado', 2893.15, '13380-000', 'SP', 'Mombuca', 'Centro', 'Rua Santa Cruz', '523', '', '(19) 99473-6022', '', '', 'matheus019', '487120M', b'1', '2026-02-04 08:47:41', b'1', 3),
(3, 'Thiago Lucena', '', '', '505.293.401-08', '', '2006-07-17', 'M', 'Solteiro', 19408.23, '11420-000', 'SP', 'Guarujá', 'Vila Alzira', 'Avenida General Rondon', '172', '', '(19) 98953-3829', '', '', 'matiam1539', '17072006', b'1', '2026-02-04 08:49:45', b'1', 9),
(4, 'Letícia Souza', '', '', '220.248.393-07', '', '2000-07-10', 'M', 'Solteiro', 0.00, '11425-000', 'SP', 'Guarujá', 'Vila Outeiro', 'Loteamento Vila Outeiro', '523', '', '(11) 99197-8343', '', '', 'leticia.souza', '1042918', b'0', '2026-02-04 08:52:15', b'1', 6),
(5, 'Felipe Santos Martins', '', '', '297.458.391-20', '', '2005-11-25', 'M', 'Casado', 0.00, '13475-000', 'SP', 'Americana', 'Chácara Letônia', 'Rodovia Anhanguera', '943', '', '(11) 96197-2943', '', '', 'felipesantos.011', '15472999', b'0', '2026-02-04 08:54:46', b'1', 5),
(6, 'Matheus Henrique', 'Berno', '66.517.298-0', '478.290.182-09', '', '2004-01-30', 'M', 'Solteiro', 1872.07, '88339-005', 'SC', 'Balneário Camboriú', 'Estados', 'Avenida Santa Catarina', '2203', 'Bl 01 Ap 502', '(19) 99593-7008', '(11) 98974-0028', 'berno@gmail.com', 'berno123', 'berno559', b'0', '2026-02-04 08:59:10', b'1', 4),
(7, 'Lucas Almeida', '', '', '248.928.359-30', '', '1982-11-23', 'M', 'Viuvo', 1872.07, '88339-005', 'SC', 'Balneário Camboriú', 'Estados', 'Avenida Santa Catarina', '2139', '', '(11) 97842-2391', '', '', 'almeida505', 'almeida1909', b'0', '2026-02-04 09:01:50', b'1', 4),
(8, 'Juliana Costa', '', '', '428.792.129-00', '', '2007-09-25', 'F', 'Solteiro', 1872.07, '13425-380', 'SP', 'Piracicaba', 'Pompéia', 'Avenida Rio das Pedras', '2202', '', '(19) 98927-2753', '', '', 'juju.costa', '593092Ju', b'0', '2026-02-04 09:10:31', b'1', 4);

-- --------------------------------------------------------

--
-- Estrutura para tabela `itens_pedido`
--

CREATE TABLE `itens_pedido` (
  `id_itens_pedido` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL DEFAULT 1,
  `preco_unitario` decimal(8,2) NOT NULL,
  `valor_total` decimal(8,2) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_pedido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `itens_pedido`
--

INSERT INTO `itens_pedido` (`id_itens_pedido`, `quantidade`, `preco_unitario`, `valor_total`, `id_produto`, `id_pedido`) VALUES
(1, 1, 2911.53, 2911.53, 15, 1),
(2, 1, 2554.92, 2554.92, 16, 2),
(3, 1, 416.25, 416.25, 20, 3),
(4, 1, 839.46, 839.46, 19, 4),
(5, 1, 416.25, 416.25, 20, 5),
(6, 1, 271.97, 271.97, 9, 5),
(7, 1, 244.94, 244.94, 7, 5),
(8, 1, 312.47, 312.47, 8, 5),
(9, 1, 2401.36, 2401.36, 10, 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `marca`
--

CREATE TABLE `marca` (
  `id_marca` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `marca`
--

INSERT INTO `marca` (`id_marca`, `nome`, `observacao`, `data_cadastro`, `status`) VALUES
(1, 'AMD', '', '2026-02-04 08:37:56', b'1'),
(2, 'Intel', '', '2026-02-04 08:37:59', b'1'),
(3, 'Gigabyte', '', '2026-02-04 08:38:01', b'1'),
(4, 'Nvidia', '', '2026-02-04 08:38:03', b'1'),
(5, 'Redragon', '', '2026-02-04 08:38:05', b'1'),
(6, 'Kingston', '', '2026-02-04 08:38:11', b'1'),
(7, 'Logitech', '', '2026-02-04 08:38:27', b'1'),
(8, 'Asus', '', '2026-02-04 08:38:38', b'1'),
(9, 'ASRock', '', '2026-02-04 08:39:14', b'1'),
(10, 'LG', '', '2026-02-04 08:39:45', b'1'),
(11, 'Sony', '', '2026-02-04 08:39:54', b'1'),
(12, 'Corsair', '', '2026-02-04 08:40:08', b'1');

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedido`
--

CREATE TABLE `pedido` (
  `id_pedido` int(11) NOT NULL,
  `valor_total` decimal(8,2) NOT NULL,
  `desconto` decimal(5,2) DEFAULT NULL,
  `troco` decimal(8,2) NOT NULL,
  `data_pedido` datetime NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_funcionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `pedido`
--

INSERT INTO `pedido` (`id_pedido`, `valor_total`, `desconto`, `troco`, `data_pedido`, `id_cliente`, `id_funcionario`) VALUES
(1, 2911.53, 0.00, 0.00, '2026-02-05 17:00:27', 5, 6),
(2, 2554.92, 0.00, 0.00, '2026-02-05 17:00:54', 3, 7),
(3, 416.25, 0.00, 0.00, '2026-02-05 17:01:24', 4, 8),
(4, 797.49, 41.97, 202.51, '2026-02-05 17:02:15', 2, 8),
(5, 1245.63, 0.00, 0.00, '2026-02-05 17:03:30', 1, 6),
(6, 2281.29, 120.07, 0.00, '2026-02-05 17:14:10', 1, 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `id_produto` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `estoque` int(11) NOT NULL DEFAULT 0,
  `preco_custo` decimal(8,2) NOT NULL,
  `percentual_lucro` int(11) NOT NULL,
  `preco_venda` decimal(8,2) NOT NULL,
  `status_promocao` bit(1) NOT NULL,
  `desconto` int(11) DEFAULT NULL,
  `preco_promocao` decimal(8,2) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL,
  `id_marca` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `produto`
--

INSERT INTO `produto` (`id_produto`, `nome`, `descricao`, `foto`, `estoque`, `preco_custo`, `percentual_lucro`, `preco_venda`, `status_promocao`, `desconto`, `preco_promocao`, `data_cadastro`, `status`, `id_marca`, `id_categoria`) VALUES
(1, 'Placa De Vídeo Amd Radeon Rx 580, 8GB GDDR5 256 Bit Full Hd, HDMI Displayport PCi Express 3.0', '', 'Placa-De-V-deo-Amd-Radeon-Rx-580-8GB-GDDR5-256-Bit-Full-Hd-HDMI-Displayport-PCi-Express-3-0_1768845827.jpg', 792, 592.00, 85, 1095.20, b'1', 15, 930.92, '2026-02-04 09:15:39', b'1', 1, 2),
(2, 'Placa de Vídeo RX 7600 Series Graphics Cards XFX AMD Radeon, 8GB GDDR6', '', 'placa-de-video-rx-7600-series-graphics-cards-xfx-amd-radeon-8gb-gddr6-rx-76pqickby_1689273145_gg.jpg', 72, 1007.23, 85, 1863.38, b'1', 10, 1677.04, '2026-02-04 09:16:41', b'1', 1, 2),
(3, 'Placa de Vídeo RX 6600 CLD 8G ASRock AMD Radeon, 8GB, GDDR6', '', 'placa-de-video-asrock-amd-radeon-rx-6600-cld-8g-8gb-90-ga2rzz-00uanf_1634738812_gg.jpg', 27, 985.83, 85, 1823.79, b'0', 0, 0.00, '2026-02-04 09:17:29', b'1', 1, 2),
(4, 'Placa de Vídeo ASUS DUAL RTX 5060 O8G NVIDIA GeForce, 8GB GDDR7, 2565MHz, 128 bits, OpenGL 4.6, DLSS', '', 'placa-de-video-dual-rtx5060-o8g_1747314234_gg.jpg', 96, 1271.09, 85, 2351.52, b'1', 5, 2233.94, '2026-02-04 09:19:21', b'1', 4, 2),
(5, 'Mouse Gamer Redragon Cobra, Chroma RGB, 12400 DPI, 8 Botões, Preto', '', 'mouse-gamer-redragon-cobra-chroma-rgb-10000dpi-7-botoes-preto-m711-v2_1742821619_gg.jpg', 128, 53.00, 85, 98.05, b'0', 0, 0.00, '2026-02-04 09:19:59', b'1', 5, 7),
(6, 'Mouse Gamer Sem Fio Redragon King 4K Pro, Wireless, 26000 DPI, 7 Botões, Preto', '', 'mouse-gamer-sem-fio-redragon-king-4k-pro-wireless-26000-dpi-7-botoes-preto-m916-pro-4k_1726748089_gg.jpg', 37, 128.01, 85, 236.82, b'1', 5, 224.98, '2026-02-04 09:21:06', b'1', 5, 7),
(7, 'Mouse Gamer Sem Fio Logitech G305 LIGHTSPEED, 12000 DPI, 6 Botões, Preto', '', 'mouse-gamer-sem-fio-logitech-g305-lightspeed-12000-dpi-6-botoes-preto-910-005281_1755627793_gg.jpg', 88, 132.40, 85, 244.94, b'1', 12, 215.55, '2026-02-04 09:22:18', b'1', 7, 7),
(8, 'Headset Gamer Sem Fio Redragon Zeus Pro, 7.1, Driver 53mm, Bluetooth, Preto', 'Fone de ouvido sem fio', 'headset-gamer-redragon-zeus-pro-preto-h510-pro_1700743328_gg.jpg', 14, 168.90, 85, 312.47, b'0', 0, 0.00, '2026-02-04 09:23:25', b'1', 5, 8),
(9, 'Teclado Sem Fio Mecânico Gamer Redragon Kumara Pro, RGB, Switch Brown, ABNT2, Anti-Ghosting', '', 'teclado-mecanico-redragon-kumara-pro-rgb-switch-brown-wireless-bluetooth-preto-k552rgb-brs-b_1678358410_gg.jpg', 24, 147.01, 85, 271.97, b'1', 15, 231.17, '2026-02-04 09:25:25', b'1', 5, 6),
(10, 'Monitor Gamer Curvo LG UltraGear 34\", 2K WQHD, UltraWide, 160Hz, 1ms, FreeSync Premium, HDR10', '', 'monitor-gamer-lg-ultragear-lg-34-curvo-led-wqhd-ultrawide-160hz-1ms-displayport-e-hdmi-amd-freesync-premium-hdr10-99-srgb-34gp63a-b_1717591886_gg.jpg', 17, 1298.03, 85, 2401.36, b'1', 20, 1921.09, '2026-02-04 09:27:37', b'1', 10, 5),
(11, 'Kit Upgrade Amd Ryzen 5 5500 Placa Mãe B550m Ddr4 Memória Ram 16gb Ddr4 3200mhz', '', 'Kit-Upgrade-Amd-Ryzen-5-5500-Placa-M-e-B550m-Ddr4-Mem-ria-Ram-16gb-Ddr4-3200mhz_1738093436_gg.jpg', 5, 1600.00, 85, 2960.00, b'0', 0, 0.00, '2026-02-04 09:29:49', b'1', 1, 10),
(12, 'Kit Upgrade Amd Ryzen 7 5700g Vega 8 Placa Mãe A520 Memória Ram 16gb Ddr4', '', 'Kit-Upgrade-Amd-Ryzen-7-5700g-Vega-8-Placa-M-e-A520-Mem-ria-Ram-16gb-Ddr4_1765214918.jpg', 7, 1408.00, 85, 2604.80, b'0', 0, 0.00, '2026-02-04 09:30:57', b'1', 1, 10),
(13, 'Kit Upgrade AMD Ryzen 5 4500, Placa Mãe A520M, 16GB DDR4, Neologic', '', 'Kit-Upgrade-AMD-Ryzen-5-4500-Placa-M-e-A520M-16GB-DDR4-Neologic-Nli84048_1741269039.jpg', 9, 1523.09, 85, 2817.72, b'1', 15, 2395.06, '2026-02-04 09:31:56', b'1', 1, 10),
(14, 'Kit Upgrade AMD Ryzen 3 3200G, Placa Mae A520, 16GB DDR4, Neologic', '', 'Kit-Upgrade-AMD-Ryzen-3-3200G-Placa-Mae-A520-16GB-DDR4-Neologic-Nli84294_1726583870_gg.jpg', 12, 1194.75, 85, 2210.29, b'1', 5, 2099.78, '2026-02-04 09:32:41', b'1', 1, 10),
(15, 'Computador GAMER Executor AMD Ryzen 7 5700G / 16GB (2x8GB) DDR4 / SSD 480GB', '', 'pc-gamer-t-gamer-executor-amd-ryzen-7-5700g-16gb-2x8gb-ddr4-ssd-480gb_261477.jpg', 3, 1573.80, 85, 2911.53, b'0', 0, 0.00, '2026-02-04 09:34:41', b'1', 1, 11),
(16, 'Computador HOME OFFICE AMD Ryzen 5 5600GT / 16GB DDR4 / SSD 480GB', '', 'pc-home-flex-amd-ryzen-5-5600gt-16gb-ddr4-ssd-480gb_260212.jpg', 12, 1381.04, 85, 2554.92, b'0', 0, 0.00, '2026-02-04 09:35:51', b'1', 1, 11),
(17, 'Processador Intel Core Ultra 5-245K, 5.2GHz, Até 14 Núcleos, Com suporte a PCIe 5.0 e 4.0', 'Processador nova geração Intel', 'processador-intel-core-ultra-5-245k-5-2ghz-ate-14-nucleos-com-suporte-a-pcie-5-0-e-4-0-e-suporte-a-ddr5-bx80768245k_1728593868_gg.jpg', 21, 982.70, 85, 1818.00, b'1', 15, 1545.30, '2026-02-04 09:37:48', b'1', 2, 1),
(18, 'Processador Intel Core Ultra 7-265KF, 5.5GHz, Até 20 Núcleos, Com suporte a PCIe 5.0 e 4.0', '', 'processador-intel-core-ultra-7-265kf-5-5ghz-ate-20-nucleos-com-suporte-a-pcie-5-0-e-4-0-e-suporte-a-ddr5-bx80768265kf_1728592999_gg.jpg', 23, 1024.00, 85, 1894.40, b'0', 0, 0.00, '2026-02-04 09:38:42', b'1', 2, 1),
(19, 'Processador AMD Ryzen 5 5600GT, 3.6 GHz, (4.6GHz Max Turbo), Cache 4MB, 6 Núcleos, 12 Threads, AM4', '', 'processador-amd-ryzen-5-5600gt-3-6-ghz-4-6ghz-max-turbo-cache-4mb-6-nucleos-12-threads-am4-100-100001488box_1708024586_gg.jpg', 6, 453.76, 85, 839.46, b'0', 0, 0.00, '2026-02-04 09:39:49', b'1', 1, 1),
(20, 'Controle Sony DualSense PS5, Sem Fio, Branco', '', 'controle-sem-fio-ps5-dualsense_1598897393_gg.jpg', 15, 225.00, 85, 416.25, b'1', 10, 374.63, '2026-02-04 09:41:20', b'1', 11, 9),
(21, 'Controle Sem Fio Sony para PS4 e PC, Dualshock 4, Preto', '', 'Controle-para-PS4-e-PC-Sem-Fio-Dualshock-4-Sony_1690376175_gg.jpg', 53, 192.00, 85, 355.20, b'1', 15, 301.92, '2026-02-04 09:42:11', b'1', 11, 9),
(22, 'SSD 500gb M.2 Nvme PCie 4 5000mb/s Leit - 3000mb/s Grav Nv3 Snv3s/500g Kingston', '', 'SSD-500gb-M-2-Nvme-PCie-4-5000mb-s-Leit-3000mb-s-Grav-Nv3-Snv3s-500g-Kingston_1768698525.jpg', 51, 238.97, 85, 442.09, b'0', 0, 0.00, '2026-02-04 10:12:50', b'1', 6, 4),
(23, 'Placa-Mãe Gigabyte A520M K V2 Rev. 1.0, AMD, Micro ATX, DDR4, Preto', '', 'placa-mae-gigabyte-a520m-k-v2-amd-micro-atx-ddr4-a520m-k-v2_1689086164_gg.jpg', 14, 192.16, 85, 355.50, b'0', 0, 0.00, '2026-02-04 10:13:42', b'1', 3, 3),
(24, 'Placa Mãe Gigabyte B550M DS3H AC R2, AMD AM4, Micro ATX, DDR4, RGB, Wi-Fi 6, Bluetooth, Preto', 'Placa-Mãe Gigabyte B550M DS3H AC R2, AMD, AM4, Micro-ATX, DDR4, Wi-Fi, Bluetooth, RGB\nEleve o desempenho do seu computador a um novo patamar com a Placa-Mãe Gigabyte B550M DS3H AC R2. Projetada para entusiastas de PC e gamers que buscam o máximo em perfo', 'placa-mae-gigabyte-b550m-ds3h-ac-r2-amd-am4-micro-atx-ddr4-rgb-wi-fi-6-bluetooth-preto-b550m-ds3h-ac-r2_1751913498_gg.jpg', 62, 379.53, 85, 702.13, b'1', 5, 667.02, '2026-02-04 10:16:18', b'1', 3, 3);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`id_cargo`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- Índices de tabela `detalhe_pagamento`
--
ALTER TABLE `detalhe_pagamento`
  ADD PRIMARY KEY (`id_detalhe_pagamento`),
  ADD KEY `id_pedido` (`id_pedido`),
  ADD KEY `id_forma_pagamento` (`id_forma_pagamento`);

--
-- Índices de tabela `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  ADD PRIMARY KEY (`id_forma_pagamento`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `usuario` (`usuario`),
  ADD KEY `id_cargo` (`id_cargo`);

--
-- Índices de tabela `itens_pedido`
--
ALTER TABLE `itens_pedido`
  ADD PRIMARY KEY (`id_itens_pedido`),
  ADD KEY `id_produto` (`id_produto`),
  ADD KEY `id_pedido` (`id_pedido`);

--
-- Índices de tabela `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_funcionario` (`id_funcionario`);

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `id_marca` (`id_marca`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargo`
--
ALTER TABLE `cargo`
  MODIFY `id_cargo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `detalhe_pagamento`
--
ALTER TABLE `detalhe_pagamento`
  MODIFY `id_detalhe_pagamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  MODIFY `id_forma_pagamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `itens_pedido`
--
ALTER TABLE `itens_pedido`
  MODIFY `id_itens_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `detalhe_pagamento`
--
ALTER TABLE `detalhe_pagamento`
  ADD CONSTRAINT `detalhe_pagamento_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`),
  ADD CONSTRAINT `detalhe_pagamento_ibfk_2` FOREIGN KEY (`id_forma_pagamento`) REFERENCES `forma_pagamento` (`id_forma_pagamento`);

--
-- Restrições para tabelas `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`id_cargo`) REFERENCES `cargo` (`id_cargo`);

--
-- Restrições para tabelas `itens_pedido`
--
ALTER TABLE `itens_pedido`
  ADD CONSTRAINT `itens_pedido_ibfk_1` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`),
  ADD CONSTRAINT `itens_pedido_ibfk_2` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`);

--
-- Restrições para tabelas `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`);

--
-- Restrições para tabelas `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
