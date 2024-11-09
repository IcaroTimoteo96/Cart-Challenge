# Cart-Challenge

O Cart-Challenge é um desafio técnico que foi gerado pelo ChatGPT para aprimorar as minhas habilidades técnicas, onde estou fazendo o desenvolvimento com base nos conceitos de arquitetura limpa, padrão de projeto Repository, injeção de dependência, e também testes automatizados.

# Tarefa

O desafio solicitou a resolução de problemas de concorrência e integridade de dados no carrinho de compras, garantindo a escalabilidade do sistema e mantendo a performance em cenários de alta carga.

# Especificações Técnicas

## 1. Tecnologias:

Utilize C# com ASP.NET Core para desenvolver uma solução.
Utilize Entity Framework Core para manipulação do banco de dados.
O banco de dados pode ser SQL Server ou SQLite.
Implemente Testes Unitários usando xUnit ou NUnit.

## 2. Entidades:

### Carrinho:

- ID (int)
- UserId (int)
- Itens (lista de objetos ItemCarrinho)

### ItemCarrinho:

- ProdutoId (int)
- Quantidade (int)
- PreçoUnitário (decimal)

## 3. Funcionalidades Requeridas:

- Adicionar um item ao carrinho: Se o item já existir, deve apenas atualizar a quantidade.

- Remover um item do carrinho.

- Atualizar a quantidade de um item.

- Obter todos os itens do carrinho.

- Garantir que não ocorra duplicação de itens.

- Evitar problemas de concorrência quando dois ou mais usuários tentarem modificar o mesmo item simultaneamente.

- Garantir alta performance em cenários de concorrência (múltiplas requisições simultâneas).

# Desenvolvimento

## O que foi feito:

- Adicionar um item ao carrinho: Se o item já existir, deve apenas atualizar a quantidade.
- Remover um item do carrinho.
- Atualizar a quantidade de um item.
- Obter todos os itens do carrinho.

## O que falta fazer:

- Garantir que não ocorra duplicação de itens.
- Evitar problemas de concorrência quando dois ou mais usuários tentarem modificar o mesmo item simultaneamente.
- Garantir alta performance em cenários de concorrência (múltiplas requisições simultâneas).
- Testes Unitários usando xUnit ou NUnit.
