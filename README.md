# 💻 GSharp - Sistema de Gestão para Loja de Informática

![Status](https://img.shields.io/badge/Status-Concluído-brightgreen) ![Language](https://img.shields.io/badge/Linguagem-C%23_|_PHP-blue) ![Database](https://img.shields.io/badge/Banco-MySQL-orange)

> **Projeto Integrador** focado no gerenciamento completo de uma loja de hardware, unindo a robustez do Desktop com a acessibilidade da Web.

---

## 📸 Visão Geral

O **GSharp** é uma solução híbrida que integra duas plataformas compartilhando o mesmo banco de dados:
1.  **Desktop (Administrativo):** Para controle total de estoque, gestão de funcionários e fluxo de caixa.
2.  **Web (E-commerce):** Vitrine para clientes visualizarem produtos, realizarem buscas e simularem compras.

---

## 🚀 Funcionalidades

### 🖥️ Módulo Desktop (C# .NET)
* **Controle de Acesso:** Login seguro para administradores e funcionários.
* **Gestão de Produtos:** CRUD completo (Cadastrar, Ler, Editar, Excluir) de hardware e periféricos.
* **Gestão de Pessoas:** Cadastro de clientes e funcionários com níveis de acesso.
* **Relatórios:** Geração de relatórios de vendas e estoque (via Report Viewer).

### 🌐 Módulo Web (PHP)
* **Catálogo Dinâmico:** Listagem de produtos atualizada em tempo real com o estoque.
* **Sistema de Busca:** Filtros por categoria, marca e preço.
* **Carrinho de Compras:** Simulação de pedido e área do cliente.
* **Interface Responsiva:** Design amigável para navegação.

---

## 🛠️ Tecnologias Utilizadas

* **Front-end Web:** HTML5, CSS3, JavaScript (jQuery/Mask).
* **Back-end Web:** PHP Nativo.
* **Aplicação Desktop:** C# (Windows Forms), .NET Framework.
* **Banco de Dados:** MySQL (Relacional).
* **Ferramentas:** Visual Studio 2022, VS Code, XAMPP/WampServer.

---

## ⚙️ Instalação e Execução

### Pré-requisitos
* Visual Studio (com carga de trabalho .NET Desktop).
* Servidor local (XAMPP ou MySQL Workbench).

### Passo a Passo

1.  **Banco de Dados:**
    * Acesse a pasta `/Banco de dados`.
    * Importe o arquivo `GSharp (Físico).sql` ou `GSharp (BKP).sql` no seu gerenciador MySQL.
    * *Nota: Verifique as credenciais de conexão nos arquivos `conecta.php` (Web) e `App.config` (Desktop).*

2.  **Executar o Desktop:**
    * Abra o arquivo `GSharp.sln` na pasta `/Desktop`.
    * Compile a solução e clique em **Iniciar**.

3.  **Executar a Web:**
    * Mova a pasta `/Web` para o diretório público do seu servidor (ex: `htdocs` no XAMPP).
    * Acesse `http://localhost/Web` no navegador.

---

## 👨‍💻 Autor

Desenvolvido por **Gustavo Santana** como parte do Projeto Integrador.

---

## 📄 Licença

Este projeto é de uso acadêmico e livre para consulta.

:)
