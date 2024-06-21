Quick exercice to practice DDD:


Criar um aplicativo back-end (.Net 8), utilizando, DDD, Fluent Validator,CQRS com Mediatr
,Entity Framework Core + Migrations e documentar as apis com Swagger;
Critérios de aceite:
A partir das APIS criadas ser possível:
Criar pedidos, contendo uma lista de itens, uma lista de pagamentos, e os endereços de
entrega e cobrança.
Através de um id consultar o pedido contendo todas as informações enviadas no momento
da criação.
Validações:
O campo total_ammount devera ser exatamente o resultado de: total dos itens + frete;
A soma dos pagamentos deve ser igual ao campo total_ammount;
Criar um passo a passo de como subir as aplicações API + banco
