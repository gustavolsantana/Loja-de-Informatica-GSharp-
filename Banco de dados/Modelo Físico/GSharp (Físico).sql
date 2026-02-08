-- Gerao de Modelo fsico
-- Sql ANSI 2003 - brModelo.

CREATE DATABASE gsharp CHARACTER SET utf8 COLLATE utf8_general_ci;
USE gsharp;

CREATE TABLE cargo (
    id_cargo INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) UNIQUE NOT NULL,
    observacao VARCHAR(255),
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE marca (
    id_marca INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) UNIQUE NOT NULL,
    observacao VARCHAR(255),
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE categoria (
    id_categoria INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) UNIQUE NOT NULL,
    observacao VARCHAR(255),
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE cliente (
    id_cliente INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100),
    rg CHAR(12),
    cpf CHAR(14) UNIQUE NOT NULL,
    foto VARCHAR(255),
    data_nascimento DATE NOT NULL,
    sexo CHAR(1) NOT NULL,
    estado_civil VARCHAR(13) NOT NULL,
    cep CHAR(9) NOT NULL,
    estado CHAR(2) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    endereco VARCHAR(100) NOT NULL,
    numero VARCHAR(10),
    complemento VARCHAR(100),
    telefone1 CHAR(15) NOT NULL,
    telefone2 CHAR(15),
    email VARCHAR(100),
    usuario VARCHAR(100) UNIQUE NOT NULL,
    senha VARCHAR(100) NOT NULL,
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE funcionario (
    id_funcionario INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100),
    rg VARCHAR(12),
    cpf CHAR(14) UNIQUE NOT NULL,
    foto VARCHAR(255),
    data_nascimento DATE NOT NULL,
    sexo CHAR(1) NOT NULL,
    estado_civil VARCHAR(13) NOT NULL,
    salario DECIMAL(8,2),
    cep CHAR(9) NOT NULL,
    estado CHAR(2) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    endereco VARCHAR(100) NOT NULL,
    numero VARCHAR(10),
    complemento VARCHAR(100),
    telefone1 CHAR(15) NOT NULL,
    telefone2 CHAR(15),
    email VARCHAR(100),
    usuario VARCHAR(100) UNIQUE NOT NULL,
    senha VARCHAR(100) NOT NULL,
    tipo_acesso BIT NOT NULL,
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL,
    id_cargo INTEGER NOT NULL,
    FOREIGN KEY(id_cargo) REFERENCES cargo (id_cargo)
);

CREATE TABLE produto (
    id_produto INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(255),
    foto VARCHAR(255),
    estoque INTEGER NOT NULL DEFAULT 0,
    preco_custo DECIMAL(8,2) NOT NULL,
    percentual_lucro INT NOT NULL,
    preco_venda DECIMAL(8,2) NOT NULL,
    status_promocao BIT NOT NULL,
    desconto INT,
    preco_promocao DECIMAL(8,2),
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL,
    id_marca INTEGER NOT NULL,
    id_categoria INTEGER NOT NULL,
    FOREIGN KEY(id_marca) REFERENCES marca (id_marca),
    FOREIGN KEY(id_categoria) REFERENCES categoria (id_categoria)
);

CREATE TABLE pedido (
    id_pedido INTEGER PRIMARY KEY AUTO_INCREMENT,
    valor_total DECIMAL(8,2) NOT NULL,
    desconto DECIMAL(5,2),
    troco DECIMAL(8,2) NOT NULL,
    data_pedido DATETIME NOT NULL,
    id_cliente INTEGER NOT NULL,
    id_funcionario INTEGER NOT NULL,
    FOREIGN KEY(id_cliente) REFERENCES cliente (id_cliente),
    FOREIGN KEY(id_funcionario) REFERENCES funcionario (id_funcionario)
);

CREATE TABLE itens_pedido (
    id_itens_pedido INTEGER PRIMARY KEY AUTO_INCREMENT,
    quantidade INTEGER NOT NULL DEFAULT 1,
    preco_unitario DECIMAL(8,2) NOT NULL,
    valor_total DECIMAL(8,2) NOT NULL,
    id_produto INTEGER NOT NULL,
    id_pedido INTEGER NOT NULL,
    FOREIGN KEY(id_produto) REFERENCES produto (id_produto),
    FOREIGN KEY(id_pedido) REFERENCES pedido (id_pedido)
);

CREATE TABLE forma_pagamento (
    id_forma_pagamento INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) UNIQUE NOT NULL,
    observacao VARCHAR(255),
    data_cadastro DATETIME NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE detalhe_pagamento (
    id_detalhe_pagamento INTEGER PRIMARY KEY AUTO_INCREMENT,
    valor_pago DECIMAL(8,2) NOT NULL,
    numero_parcelas INTEGER NOT NULL,
    valor_das_parcelas DECIMAL(8,2) NOT NULL,
    id_pedido INTEGER NOT NULL,
    id_forma_pagamento INTEGER NOT NULL,
    FOREIGN KEY(id_pedido) REFERENCES pedido (id_pedido),
    FOREIGN KEY(id_forma_pagamento) REFERENCES forma_pagamento (id_forma_pagamento)
);