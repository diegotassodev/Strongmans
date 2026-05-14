using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuRemoverLevantamento : Menu {
    public static void Executar(Strongman strongman) {

        Console.Clear();
        ExibirTitulo ($"Remover Levantamentos - {strongman.Nome}");
        
        int i;
        for (i = 0; i < strongman.listaLevantamentosStrongman!.Count(); i++) {
            var levantamento = strongman.listaLevantamentosStrongman![i];
            Console.WriteLine($"[{i}] {levantamento.Nome} - {levantamento.QuantiaPeso}KG");
        }
        Console.Write("Selecione o ID do levantamento que deseja remover: ");
        int idLevantamentoRemover; int.TryParse(Console.ReadLine()!, out idLevantamentoRemover);

        for (i = 0; i < strongman.listaLevantamentosStrongman!.Count(); i++) {
            if (idLevantamentoRemover == i) {
                 Console.Write($"Você tem certeza que deseja excluir o {strongman.Nome}? [S] [N]: ");
                string opcao = Console.ReadLine()!;
                if (opcao.Trim().ToUpper() == "S") {
                    strongman.listaLevantamentosStrongman!
                    .Remove(strongman.listaLevantamentosStrongman[i]);
                    Console.WriteLine("Levantamento removido com sucesso!");
                }
                else {
                    Console.WriteLine("Procedimento cancelado.");
                }
            }
        }
    }
}