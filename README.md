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

### 5. *Infraestrutura*
Gerencia a injeção de dependências e o acesso ao contexto de dados.

- *GeradorDeServicos.cs*
  - Fornece o contexto do banco de dados.

### 6. *Migrations*
Configurações do banco de dados geradas pelo Entity Framework.

- *20241125005001_Cliente.cs*: Define a tabela Cliente e seus campos.
- *DataContextModelSnapshot.cs*: Captura o estado atual do modelo de banco de dados.

---

## Banco de Dados
O sistema utiliza *SQLite* para armazenamento de dados. A tabela principal é a Cliente, que armazena as informações de identificação, nome, e-mail e CPF dos clientes.

---

## Configuração do Ambiente

### 1. *Configurações de Inicialização*
Definidas no arquivo launchSettings.json:
- *URLs*:
  - HTTP: http://localhost:5297
  - HTTPS: https://localhost:7087

### 2. *Execução*
1. Clone o repositório.
2. Certifique-se de que o .NET SDK está instalado.
3. Execute os comandos:
   ```bash
   - dotnet restore
   - dotnet ef database update
   - dotnet run
