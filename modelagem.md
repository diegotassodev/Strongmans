Modelos

    Usuario
    - Nome: string
    - Email: string
    - Senha: string
    - Static listaUsuarios: List<Usuario>

    Strongman
    - Nome: String
    - Altura: double
    - Peso: double
    - listaLevantamentosStrongman: List<Levantamento>
    - Static listaStrongman: List<Strongman>

    Levantamento
    - Nome: string
    - QuantiaPeso: decimal
    - AnoRealizado: int

Menus

    Menu
    + Static ExibirTitulo()
    + Static RetornandoTelaPrincipal()

    MenuLogin : Menu
    + Static Exibir()
    + Static EntradaEmailUsuario()
    + Static EntradaSenhaUsuario()
    + Static ValidandoLogin()

    MenuPrincipal : Menu
    + Static Exibir()
    + Static EntradaOpcaoUsuario()
    + Static ProcessandoOpcaoUsuario()

    MenuUsuario
        MenuAdicionarUsuario : Menu
        + Static Executar();

        MenuRemoverUsuario : Menu
        + Static Executar();

        MenuExibirUsuario : Menu
        + Static Executar()

    MenuStrongmans
        MenuAdicionarStrongman : Menu
        + Static Executar();

        MenuRemoverStrongman : Menu
        + Static Executar();

        MenuExibirStrongmans : Menu
        + Static Executar()
        
Testes: Vão popular as classes

    PopularStrongmans
    + Executar

    PopularUsuarios
    + Executar