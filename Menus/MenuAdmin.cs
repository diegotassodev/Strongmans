namespace Strongmans.Menus;
internal class MenuAdmin : Menu {

    public static void Executar() {
        ExibirTitulo("ADMINISTRADOR");
        Console.WriteLine ("1. Adicionar Usuário");
        Console.WriteLine ("2. Remover Usuário");
        Console.WriteLine ("3. Mostrar Usuários");
        Console.WriteLine ("4. Entrar Menu Principal");
        Console.WriteLine ("0. Sair");
        int opcao = EntradaOpcaoUsuario();
        ProcessandoOpcaoUsuario(opcao);
    }

    public static int EntradaOpcaoUsuario() {
        try {
            Console.Write ("Digite sua opção: "); 
            int opcao = int.Parse(Console.ReadLine()!);
            return opcao;
        }
        catch (Exception) {
            return -1;
        }
    }
    public static void ProcessandoOpcaoUsuario(int opcao) {
        switch (opcao) {
            case 1: MenuAdicionarUsuario.Executar(); RetornandoTelaAdmin(); break;
            case 2: MenuRemoverUsuario.Executar(); RetornandoTelaAdmin(); break;
            case 3: MenuExibirUsuarios.Executar(); RetornandoTelaAdmin(); break;
            case 4: MenuPrincipal.Executar(); break;
            case 0: Console.WriteLine ("Encerrando o Programa."); break;
            default: RetornandoTelaAdmin(); break;
        }
    }
}