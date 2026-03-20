# Strongmans - Sistema de Gerenciamento de Atletas

## 📋 Descrição

Sistema de gerenciamento de informações sobre atletas de **Strongman**. Permite cadastrar, visualizar, editar e remover strongmans, além de registrar seus levantamentos e recordes pessoais. 

Inclui também gerenciamento de usuários e administradores. Esse sistema utiliza orientação a objetos aplicando conceitos de herança.

---

## 🏗️ Estrutura do Projeto

### Modelos de Dados

#### `Usuario`
Representa um usuário do sistema com credenciais de acesso.
- **Propriedades:**
  - `Nome`: Identificador do usuário
  - `Email`: Email associado à conta
  - `Senha`: Senha para autenticação
- **Armazenamento:** `List<Usuario>`

#### `Admin`
Representa um administrador do sistema, herdando de `Usuario`.
- **Herança:** Extende `Usuario` com permissões adicionais para gerenciar usuários.
- **Armazenamento:** Incluído na `List<Usuario>`

#### `Strongman`
Representa um atleta de Strongman com seus dados físicos e histórico de levantamentos.
- **Propriedades:**
  - `Nome`: Nome do atleta
  - `AlturaMetros`: Altura em metros
  - `PesoKilogramas`: Peso em quilogramas
- **Relacionamentos:**
  - `listaLevantamentosStrongman`: Lista de levantamentos realizados pelo atleta
- **Armazenamento:** `List<Strongman>` estática

#### `Levantamento`
Registra um levantamento específico realizado por um strongman.
- **Propriedades:**
  - `Nome`: Tipo do levantamento (ex: Deadlift, Log Lift, Atlas Stone)
  - `QuantiaPeso`: Peso levantado em quilogramas
  - `AnoRealizado`: Ano em que o levantamento foi realizado

---
## 🎯 Funcionalidades

### Menu de Login
- Autenticação de usuários
- Validação de credenciais cadastradas
- Acesso seguro ao sistema

### Menu Principal (Acesso para Todos os Usuários)
Após autenticação bem-sucedida:

1. **Adicionar Strongman** - Cadastra um novo atleta com seus dados físicos
2. **Editar Strongman** - Atualiza informações de um atleta cadastrado
3. **Remover Strongman** - Deleta um atleta do sistema
4. **Mostrar Strongmans** - Exibe lista completa de atletas cadastrados
5. **Sair** - Encerra o programa

---
## 📁 Organização das Pastas

```
Strongmans/
├── Modelos/              # Classes de dados
│   ├── Usuario.cs
│   ├── Admin.cs          # Herda de Usuario
│   ├── Strongman.cs
│   └── Levantamento.cs
├── Menus/                # Interfaces de usuário
│   ├── Menu.cs           # Classe base com funcionalidades comuns
│   ├── MenuLogin.cs
│   ├── MenuAdmin.cs      # Menu para administradores
│   ├── MenuPrincipal.cs  # Menu para usuários comuns
│   ├── MenuStrongman/    # Submenus do strongman
│   │   ├── MenuAdicionarStrongman.cs
│   │   ├── MenuEditarStrongman.cs
│   │   ├── MenuExibirStrongmans.cs
│   │   └── MenuRemoverStrongmans.cs
│   └── MenuUsuario/      # Submenus do usuário
│       ├── MenuAdicionarUsuario.cs
│       ├── MenuExibirUsuarios.cs
│       └── MenuRemoverUsuario.cs
├── Testes/               # Dados pré-populados para testes
│   ├── PopularUsuarios.cs
│   └── PopularStrongmans.cs
├── Program.cs            # Ponto de entrada
└── Strongmans.csproj     # Configuração do projeto
```

---
## 🚀 Como Executar

### Pré-requisitos
- **.NET 8.0** ou superior
- **C# 12.0** ou superior

### Execução
```bash
dotnet run
```

---

## 💡 Dados Iniciais (Testes)

O sistema é pré-populado com dados de atletas reais de Strongman para facilitar testes:

- **Eddie Hall** - Deadlift 500kg (2016)
- **Hafthor Björnsson** - Deadlift 501kg (2020)
- **Zydrunas Savickas** - Log Lift 228kg, Deadlift 460kg
- **Tom Stoltman** - Atlas Stone 286kg (2021)
- **Oleksii Novikov** - Deadlift 465kg (2022)
- E mais...

---

## 🔧 Detalhes Técnicos

- **Paradigma:** Orientação a Objetos com herança (ex: `Admin` herda de `Usuario`)
- **Persistência:** Em memória (sem banco de dados)
- **Interface:** Terminal/Console
- **Controle de Acesso:** Diferenciação entre usuários comuns e administradores

---
## Fluxo Geral do Algoritmo

```cs
Inicialização  
│  
├── Popular Listas iniciais  
│  
├── Exibir Tela de Login  
│   ├── Solicitar Usuário  
│   ├── Solicitar Senha  
│   └── Validar Credenciais  
│  
└── Se autenticado:  
      ├── Se Admin:  
      │     └── Exibir Menu Admin  
      │           ├── Adicionar Usuário  
      │           ├── Remover Usuário  
      │           ├── Mostrar Usuários  
      │           ├── Entrar Menu Principal  
      │           └── Sair  
      └── Senão (Usuário comum):  
            └── Exibir Menu Principal  
                  ├── Adicionar Strongman  
                  ├── Editar Strongman  
                  ├── Remover Strongman  
                  ├── Mostrar Strongmans  
                  └── Sair
```