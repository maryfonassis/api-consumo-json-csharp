# Consumo de API com C# e LINQ

Projeto desenvolvido em C# com foco em consumo de API REST, desserialização de JSON, orientação a objetos e consultas utilizando LINQ.

A aplicação consome dados da API Random User e realiza filtros, ordenações, agrupamentos e manipulação de dados diretamente no console.

---

# Tecnologias utilizadas

- C#
- .NET
- System.Text.Json
- LINQ
- API Random User

---

# Objetivos do projeto

Durante o desenvolvimento deste projeto foram praticados conceitos como:

- Consumo de APIs
- Requisições HTTP com HttpClient
- Desserialização de JSON
- Criação de classes e objetos
- Organização de código
- Métodos e responsabilidades
- Nullable Reference Types
- Manipulação de listas com LINQ

---

# Funcionalidades

## Exibição de usuários
- Nome
- Cidade
- País
- Email

## Filtros com LINQ
- Filtrar usuários brasileiros
- Ordenar usuários por nome
- Exibir emails únicos
- Agrupar usuários por país
- Contar quantidade de usuários por país

---

# Exemplos de LINQ utilizados

```csharp
usuarios.Where(usuario => usuario.Localizacao?.Pais == "Brazil")

usuarios.OrderBy(usuario => usuario.Nome?.PrimeiroNome)

usuarios.Select(usuario => usuario.Email)

usuarios.GroupBy(usuario => usuario.Localizacao?.Pais)

usuarios.Distinct()