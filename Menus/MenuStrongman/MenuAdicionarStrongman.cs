using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuAdicionarStrongman : Menu {

    public static void Executar() {
        ExibirTitulo("Adicionar Strongman");
        Console.Write("Digite o nome do Strongman: ");
        string nomeStrongman = Console.ReadLine()!;
        Console.Write("Digite a altura do strongman [Metros]: ");
        double alturaStrongman; double.TryParse(Console.ReadLine()!, out alturaStrongman);
        Console.Write("Digite o peso do strongman [KG]: ");
        double pesoKilogramas; double.TryParse(Console.ReadLine()!, out pesoKilogramas);

        Strongman strongman = new(nomeStrongman, alturaStrongman, pesoKilogramas);
        Console.Write($"Deseja adicionar algum levantamento ao {nomeStrongman}? [S][N]: ");
        string opcao = Console.ReadLine()!;
        
        while (opcao.Trim().ToUpper() == "S") {
            Console.Write("Qual nome do levantamento: ");
            string nomeLevantamento = Console.ReadLine()!;
            Console.Write("Qual foi a quantia de peso [KG]: ");
            double quantiaPeso; double.TryParse(Console.ReadLine()!, out quantiaPeso);
            Console.Write("Em que ano foi realizado: ");
            int anoRealizado; int.TryParse(Console.ReadLine()!, out anoRealizado);

            Levantamento levantamento = new (nomeLevantamento, quantiaPeso, anoRealizado);
            strongman.listaLevantamentosStrongman.Add(levantamento);
            Console.Write("Deseja adicionar outro? [S][N]: ");
            opcao = Console.ReadLine()!.Trim().ToUpper();
        }
        Strongman.listaStrongmans.Add(strongman);
        Console.WriteLine($"Cadastro do {nomeStrongman} completo.");
    }
}