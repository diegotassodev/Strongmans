# Especificações Técnicas: Sistema de Cadastro e Consulta de Strongmans

## 1. Estruturas de Dados

### 1.1 Dicionário de Usuários (`LoginUsuario`)

Estrutura responsável pelo armazenamento das credenciais de acesso ao sistema.

- **Chave (Key):** Nome do usuário
- **Valor (Value):** Senha do usuário

Finalidade: Permitir autenticação baseada em correspondência exata de chave e valor.

---
### 1.2 Dicionário de Strongmans (`Strongmans`)

Estrutura responsável pelo armazenamento dos registros de atletas e seus respectivos recordes.

- **Chave externa:** Nome do strongman
- **Valor:** Dicionário interno contendo os levantamentos:

Dicionário interno:

- `"BentPress"` → Peso levantado no Bent Press
- `"FloorPress"` → Peso levantado no Floor Press

**Finalidade:** Organizar dados de forma simples.

---
## 2. Funções do Sistema

### 2.1 Funções de Abstração

- **ExibirTitulo()**  
    Responsável por padronizar a apresentação visual dos títulos das interfaces.

- **AdicionandoUsuarios()**  
    Responsável por popular o dicionário `LoginUsuario` com dados pré-configurados.

- **AdicionandoStrongmans()**  
    Responsável por popular o dicionário `Strongmans` com dados iniciais.

---
### 2.2 Fluxo de Autenticação

- **ExibirInterfaceLogin()**  
    Apresenta a interface de login ao usuário.

- **EntradaNomeUsuario(()**  
    Captura o nome do usuário via entrada padrão.

- **EntradaSenhaUsuario()**  
    Captura a senha via entrada padrão.

- **ValidandoLogin()**  
    Processo:
    1. Verifica se o nome do usuário existe como chave no dicionário `LoginUsuario`.
    2. Caso exista, compara a senha informada com o valor associado à chave.
    3. Se ambas as verificações forem verdadeiras → autenticação concedida.
    4. Caso contrário → exibe mensagem:  
        `"Usuário ou senha incorretos"`.

- **ExibirInterfacePrincipal()**  
    Exibe o menu principal após autenticação bem-sucedida.

---
## 3. Menu Principal do Sistema

Após login válido, o sistema apresenta as seguintes opções:

---
### 3.1 Adicionar Strongman

Fluxo:

1. Solicita o nome do strongman.
2. Cria nova chave no dicionário `Strongmans`.
3. Solicita o peso no **Bent Press**.
4. Solicita o peso no **Floor Press**.
5. Armazena os valores no dicionário interno associado ao nome.
6. Retorna ao menu principal.

---
### 3.2 Mostrar Strongmans

Fluxo:

1. Percorre todas as chaves do dicionário `Strongmans`.
2. Exibe a lista completa de nomes cadastrados.
3. Retorna ao menu principal.

---
### 3.3 Pesquisar Strongman

Fluxo:

1. Solicita o nome do strongman.
2. Verifica se a chave existe no dicionário `Strongmans`.
    - Se não existir → exibe mensagem de erro.
    - Se existir → recupera diretamente o dicionário interno associado.

3. Obtém:
    - Valor de `"BentPress"`: Conforme a chave do dicionário dentro do dicionário.
    - Valor de `"FloorPress"`: Conforme o valor do dicionário dentro do dicionário.

4. Exibe ficha técnica do atleta contendo seus recordes.
5. Retorna ao menu principal.    

---
### 3.4 Excluir Strongman

Fluxo:

1. Solicita o nome do strongman.
2. Verifica se a chave existe.
3. Remove o Strongman
4. Retorna ao menu principal.

---
### 3.5 Sair

1. Exibe mensagem informando encerramento do sistema.
2. Finaliza a execução do programa.

---
# 4. Fluxo Geral do Algoritmo

```cs
Inicialização  
│  
├── Popular dicionários iniciais  
│  
├── Exibir Tela de Login  
│   ├── Solicitar Usuário  
│   ├── Solicitar Senha  
│   └── Validar Credenciais  
│  
└── Se autenticado:  
      └── Exibir Menu Principal  
            ├── Adicionar Strongman  
            ├── Mostrar Strongmans  
            ├── Pesquisar Strongman  
            ├── Excluir Strongman  
            └── Sair
```