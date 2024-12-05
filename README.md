# Documentação do Sistema de Gerenciamento de Clientes

## Visão Geral
Este projeto implementa um sistema básico de gerenciamento de clientes usando **ASP.NET Core** e **Entity Framework Core**. Ele oferece endpoints para criação e consulta de clientes em uma API RESTful.

---

## Estrutura do Projeto
A estrutura do projeto segue o padrão MVC, organizado em diretórios e camadas para melhor separação de responsabilidades.

### 1. **Controller**
Gerencia as requisições HTTP e as encaminha para o serviço apropriado.

- **`ClienteController.cs`**
  - **Endpoints:**
    - `GET /api/cliente/{id}`: Obtém informações de um cliente pelo ID.
    - `POST /api/cliente`: Cria um novo cliente.

### 2. **DTO (Data Transfer Object)**
Define o formato de dados que trafegam entre o cliente e o servidor.

- **`ClienteDTO.cs`**
  - **Campos:**
    - `id`: Identificador único do cliente.
    - `nome`: Nome do cliente.
    - `email`: E-mail do cliente.
    - `cpf`: CPF do cliente.

### 3. **Entidades**
Representa os dados armazenados no banco.

- **`Cliente.cs`**
  - **Campos:**
    - `Id`: Identificador único.
    - `Nome`: Nome do cliente.
    - `Email`: E-mail do cliente.
    - `CPF`: CPF do cliente.

### 4. **Serviços**
Contém a lógica de negócio.

- **`ServCliente.cs`**
  - **Métodos:**
    - `GetClienteById(int id)`: Busca um cliente pelo ID.
    - `CreateCliente(ClienteDTO dto)`: Cria um novo cliente com base no DTO.
