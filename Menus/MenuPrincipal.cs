namespace Strongmans.Menus;
internal class MenuPrincipal : Menu {

    public static void Executar() {
        ExibirTitulo("STRONGMANS");
        Console.WriteLine ("1. Adicionar Strongman");
        Console.WriteLine ("2. Remover Strongman");
        Console.WriteLine ("3. Editar Strongman");
        Console.WriteLine ("4. Mostrar Strongmans");
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
            case 1: MenuAdicionarStrongman.Executar(); RetornandoTelaPrincipal(); break;
            case 2: MenuRemoverStrongman.Executar(); RetornandoTelaPrincipal(); break;
            case 3: MenuEditarStrongman.Executar(); RetornandoTelaPrincipal(); break;
            case 4: MenuExibirStrongmans.Executar(); RetornandoTelaPrincipal(); break;
            case 0: Console.WriteLine ("Encerrando o Programa."); break;
            default: RetornandoTelaPrincipal(); break;
        }
    }
}