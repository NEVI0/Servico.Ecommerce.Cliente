# Documentação do Sistema de Gerenciamento de Clientes

## Visão Geral
Este projeto implementa um sistema de gerenciamento de clientes utilizando **ASP.NET Core** e **Entity Framework Core**. Ele fornece uma API RESTful com endpoints para criação e consulta de clientes.

## Estrutura do Projeto
A estrutura do projeto segue o padrão MVC, com a separação de responsabilidades em camadas:

### 1. **Controller**
Gerencia as requisições HTTP e as encaminha para os serviços correspondentes.

- **`ClienteController.cs`**
  - **Endpoints:**
    - `GET /api/cliente/{id}`: Obtém as informações de um cliente pelo ID.
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
Representa os dados armazenados no banco de dados.

- **`Cliente.cs`**
  - **Campos:**
    - `Id`: Identificador único.
    - `Nome`: Nome do cliente.
    - `Email`: E-mail do cliente.
    - `CPF`: CPF do cliente.

### 4. **Serviços**
Contém a lógica de negócios.

- **`ServCliente.cs`**
  - **Métodos:**
    - `GetClienteById(int id)`: Busca um cliente pelo ID.
    - `CreateCliente(ClienteDTO dto)`: Cria um novo cliente com base no DTO.

### 5. **Infraestrutura**
Gerencia a injeção de dependências e o acesso ao contexto de dados.

- **`GeradorDeServicos.cs`**
  - Fornece o contexto do banco de dados.

### 6. **Migrations**
Configurações do banco de dados geradas pelo Entity Framework.

- **`20241125005001_Cliente.cs`**: Define a tabela Cliente e seus campos.
- **`DataContextModelSnapshot.cs`**: Captura o estado atual do modelo de banco de dados.

## Banco de Dados
O sistema utiliza **SQLite** para o armazenamento de dados. A tabela principal, `Cliente`, armazena informações de identificação, nome, e-mail e CPF dos clientes.

## Configuração do Ambiente

### 1. **Configurações de Inicialização**
As configurações iniciais estão no arquivo `launchSettings.json`:
- **URLs**:
  - HTTP: `http://localhost:5297`
  - HTTPS: `https://localhost:7087`

### 2. **Execução**
1. Clone o repositório.
2. Certifique-se de que o .NET SDK está instalado.
3. Execute os comandos necessários para rodar o projeto.

## Função do Microsserviço

O **Microsserviço de Gerenciamento de Clientes** é responsável por gerenciar os dados dos clientes em um sistema de e-commerce. Ele permite a criação, consulta e manutenção das informações dos clientes, garantindo que os dados sejam corretamente armazenados e acessíveis para outras operações, como o gerenciamento de pedidos.

### Principais Funcionalidades

- **Criação de Clientes**: Cadastra novos clientes com informações como nome, e-mail e CPF.
- **Consulta de Clientes**: Permite consultar os dados de um cliente específico pelo **ID**.
- **Armazenamento Seguro de Dados**: Garante o gerenciamento seguro de dados sensíveis, como CPF e e-mail.

Este microsserviço foi projetado para ser **modular** e **escável**, permitindo fácil integração com outros microsserviços, como **Pedidos**, **Produtos** e **Pagamentos**, assegurando a fluidez nas operações do sistema de e-commerce.
