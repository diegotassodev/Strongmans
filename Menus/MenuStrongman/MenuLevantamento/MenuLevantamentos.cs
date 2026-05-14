using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuLevantamento : Menu {
    public static void Executar(Strongman strongman) {

        ExibirTitulo ($"Menu Levantamentos - {strongman.Nome}");

        Console.WriteLine("1. Adicionar Levantamentos");
        Console.WriteLine("2. Remover Levantamentos");
        Console.WriteLine("3. Editar Levantamentos");
        Console.Write("Selecione o que deseja editar: ");
        int opcao; int.TryParse(Console.ReadLine()!, out opcao);

        switch (opcao) {
            case 1: MenuAdicionarLevantamento.Executar(strongman); break;
            case 2: MenuRemoverLevantamento.Executar(strongman); break;
            case 3: MenuEditarLevantamento.Executar(strongman); break;
            case 4: RetornandoTelaPrincipal(); break;
        }
    }
}