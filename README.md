
# Projeto: Aplicativo Back-End com .NET 8


## Descrição

Este projeto é um aplicativo desenvolvido com .NET 8, utilizando as seguintes tecnologias e boas práticas:

* **Domain-Driven Design(DDD):** Para estruturar o código de forma clara e coerente, dividindo-o em diferentes camadas e contextos de dominio.
* **Fluent Validation:** Para implementar validações de maneira fluente e robusta.
* **CQRS com MediatR:** Para separar as responsabilidades de leitura e escrita, usando MediatR para facilitar a comunicação entre diferentes partes do sistema.
* **Entity Framework Core + Migrations:** Para gerenciar o acesso ao banco de dados e facilitar a criação de migrações.
* **Swagger:** Para documentar e testar as APIs de maneira interativa.

## Requisitos
* .NET 8 SDK
* EntityFrameWork Core
* EntityFrameWork Core.Sqlite
* Swagger
## Funcionalidades

* **Criar Pedidos:** Deve ser possivel criar pedidos que contenha uma lista de Itens, uma lista de pagamentos e os endereços de cobrança e de entrega.

* **Consultar Pedidos:** Deve ser possivel consultar um pedido através do ID, contendo todas as informações enviadas no momento da criação.

## Validações

* O Campo total_ammount deverá ser exatamente o resultado do total dos itens + frete;

* A soma dos pagamentos deve ser igual ao campo total_ammount;

* Criar um passo a passo de como subir as aplicações API + banco
