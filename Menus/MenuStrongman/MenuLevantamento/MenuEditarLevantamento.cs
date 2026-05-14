using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuEditarLevantamento : Menu {
    public static void Executar(Strongman strongman) {

        Console.Clear();
        ExibirTitulo($"Editar Levantamentos - {strongman.Nome}");

        int i;
        for (i = 0; i < strongman.listaLevantamentosStrongman!.Count(); i++) {
            var levantamento = strongman.listaLevantamentosStrongman![i];
            Console.WriteLine($"[{i}] {levantamento.Nome} - {levantamento.QuantiaPeso}KG");
        }
        Console.Write("Selecione o ID do levantamento que deseja editar: ");
        int idLevantamentoEditar; int.TryParse(Console.ReadLine()!, out idLevantamentoEditar);
        var levantamentoSelecionado = strongman.listaLevantamentosStrongman![idLevantamentoEditar];

        Console.Clear();
        Console.WriteLine("1. Nome");
        Console.WriteLine("2. Peso");
        Console.WriteLine("3. Ano");
        Console.Write("Selecione o que você deseja editar: ");
        int opcao; int.TryParse(Console.ReadLine()!, out opcao);

        switch (opcao) {
            case 1: EditarNome(levantamentoSelecionado); break;
            case 2: EditarPeso(levantamentoSelecionado); break;
            case 3: EditarAno(levantamentoSelecionado); break;
        }
    }

    private static void EditarNome(Levantamento levantamento) {
        Console.Write("Digite o novo nome para o levantamento: ");
        string nomeLevantamento = Console.ReadLine()!;
        levantamento.Nome = nomeLevantamento;
        Console.WriteLine($"Sucesso na operação de troca de nome para: {nomeLevantamento}");
    }

    private static void EditarPeso(Levantamento levantamento) {
        Console.Write("Digite o novo peso para o levantamento: ");
        double pesoLevantamento; double.TryParse(Console.ReadLine()!, out pesoLevantamento);
        levantamento.QuantiaPeso = pesoLevantamento;
        Console.WriteLine($"Sucesso na operação de troca de peso para: {pesoLevantamento} KG");
    }

    private static void EditarAno(Levantamento levantamento) {
        Console.Write("Digite o novo ano para o levantamento: ");
        int anoLevantamento; int.TryParse(Console.ReadLine()!, out anoLevantamento);
        levantamento.AnoRealizado = anoLevantamento;
        Console.WriteLine($"Sucesso na operação de troca de ano para: {anoLevantamento}.");
    }
}