# Strongmans - Sistema de Gerenciamento de Atletas

## 📋 Descrição

Sistema de gerenciamento de informações sobre atletas de **Strongman**. Permite cadastrar, visualizar, editar e remover strongmans, além de registrar seus levantamentos e recordes pessoais.

Também oferece gerenciamento de usuários e administradores, com autenticação e controle de acesso.

## 🧩 O que mudou nesta versão

- Persistência de dados em arquivos JSON (`Dados/dados-strongmans.json` e `Dados/dados-usuarios.json`)
- Carregamento automático de dados ao iniciar o programa
- Criação de arquivos vazios quando não existem
- Serialização em `snake_case` usando `JsonPropertyName`
- Cadastro de usuário com seleção de tipo: `Administrador (A)` ou `Usuário comum (C)`
- Edição e remoção de registros por `id`
- Menus de usuário expandidos com edição e remoção segura
- Refatoração para reduzir serialização em construtores
- Base inicial com strongmans reais adicionados para testes

## 🏗️ Estrutura do Projeto

### Modelos de Dados

#### `Usuario`
Representa um usuário do sistema com credenciais de acesso.
- **Propriedades:**
  - `Id`
  - `Nome`
  - `Email`
  - `Senha`
  - `Tipo`
- **Armazenamento:** `List<Usuario>` estática

#### `Admin`
Representa um administrador do sistema, herdando de `Usuario`.
- **Herança:** `Admin` estende `Usuario`
- **Permissões:** pode gerenciar usuários

#### `Strongman`
Representa um atleta de Strongman com dados físicos e históricos de levantamento.
- **Propriedades:**
  - `Id`
  - `Nome`
  - `AlturaMetros`
  - `PesoKilogramas`
- **Relacionamento:** `listaLevantamentosStrongman`
- **Armazenamento:** `List<Strongman>` estática

#### `Levantamento`
Registra um levantamento específico realizado por um strongman.
- **Propriedades:**
  - `Nome`
  - `QuantiaPeso`
  - `AnoRealizado`

### Persistência

#### `ListaUsuarios`
Responsável por desserializar `Dados/dados-usuarios.json` e popular `Usuario.listaUsuarios`.

#### `ListaStrongmans`
Responsável por desserializar `Dados/dados-strongmans.json` e popular `Strongman.listaStrongmans`.

## 🎯 Funcionalidades

### Login
- Autenticação por `email` e `senha`
- Validação de credenciais existentes
- Redirecionamento para menu de administrador ou menu principal

### Menu Principal
1. **Adicionar Strongman**
2. **Editar Strongman**
3. **Remover Strongman**
4. **Mostrar Strongmans**
5. **Sair**

### Menu do Administrador
- **Adicionar usuário**
- **Editar usuário**
- **Remover usuário**
- **Mostrar usuários**
- **Entrar no menu principal**

## 📁 Organização das Pastas

```
Strongmans/
├── Dados/                # Arquivos JSON de persistência
│   ├── dados-strongmans.json
│   └── dados-usuarios.json
├── Modelos/              # Classes de dados e serialização
│   ├── Admin.cs
│   ├── ListaStrongmans.cs
│   ├── ListaUsuarios.cs
│   ├── Levantamento.cs
│   ├── Strongman.cs
│   └── Usuario.cs
├── Menus/                # Menus de interação no console
│   ├── Menu.cs
│   ├── MenuAdmin.cs
│   ├── MenuLogin.cs
│   ├── MenuPrincipal.cs
│   ├── MenuStrongman/
│   │   ├── MenuAdicionarStrongman.cs
│   │   ├── MenuEditarStrongman.cs
│   │   ├── MenuExibirStrongmans.cs
│   │   └── MenuRemoverStrongmans.cs
│   └── MenuUsuario/
│       ├── MenuAdicionarUsuario.cs
│       ├── MenuEditarUsuario.cs
│       ├── MenuExibirUsuarios.cs
│       └── MenuRemoverUsuario.cs
├── Program.cs            # Inicialização e entrada do sistema
└── Strongmans.csproj     # Configuração do projeto
```

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 ou superior
- C# 12.0 ou superior

### Execução

```bash
dotnet run
```

## 💡 Dados Iniciais
O projeto já carrega registros de teste que incluem:
- usuário admin padrão `admin` / `root`
- usuário comum `Diego`
- strongmans reais como Eddie Hall, Hafthor Björnsson, Zydrunas Savickas, Tom Stoltman e Oleksii Novikov

## 🔧 Detalhes Técnicos
- **Persistência:** JSON via `System.Text.Json`
- **Serialização:** `snake_case` com `JsonPropertyName`
- **CRUD:** criação, leitura, edição e remoção de usuários e strongmans
- **Gerenciamento por ID:** edição e remoção usando `id` para reduzir erros por nome duplicado
- **Design:** responsabilidades de serialização organizadas em classes específicas

## 🔁 Fluxo do Programa

1. Verifica existência dos arquivos JSON
2. Cria arquivos vazios, se necessário
3. Desserializa os dados para memória
4. Exibe tela de login
5. Autentica o usuário
6. Exibe menu correto conforme tipo de usuário
7. Executa operações e salva alterações no JSON
