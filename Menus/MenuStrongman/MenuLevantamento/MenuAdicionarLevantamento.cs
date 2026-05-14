using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuAdicionarLevantamento : Menu {
    public static void Executar(Strongman strongman) {

        Console.Clear();
        ExibirTitulo ($"Adicionar Levantamentos - {strongman.Nome}");

        var opcao = "S";
        while (opcao.Trim().ToUpper() == "S") {
            Console.Write("Qual nome do levantamento: ");
            string nomeLevantamento = Console.ReadLine()!;
            Console.Write("Qual foi a quantia de peso [KG]: ");
            double quantiaPeso; double.TryParse(Console.ReadLine()!, out quantiaPeso);
            Console.Write("Em que ano foi realizado: ");
            int anoRealizado; int.TryParse(Console.ReadLine()!, out anoRealizado);

            Levantamento levantamento = new (nomeLevantamento, quantiaPeso, anoRealizado);
            strongman!.listaLevantamentosStrongman!.Add(levantamento);
            Console.Write("Deseja adicionar outro? [S][N]: ");
            opcao = Console.ReadLine()!.Trim().ToUpper();
        }
    }
}