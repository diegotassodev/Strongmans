using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuRemoverStrongman : Menu {

    public static void Executar() {
        ExibirTitulo("Remover Strongman");
        Console.Write("Digite o nome do Strongman: ");
        string nomeStrongman = Console.ReadLine()!;

        if (Strongman.listaStrongmans.Any(strongman => strongman.Nome!.Equals(nomeStrongman))) {
            Strongman strongman = Strongman.listaStrongmans.First(strongman => strongman.Nome!.Equals(nomeStrongman));
            Console.Write($"Você tem certeza que deseja excluir o {nomeStrongman}? [S] [N]: ");
            string opcao = Console.ReadLine()!;
            if (opcao.Trim().ToUpper() == "S") {
                Strongman.listaStrongmans.Remove(strongman);
                Console.WriteLine($"O {nomeStrongman} foi removido com sucesso!");
            }
            else {
                Console.WriteLine("Procedimento cancelado!");
            }
        }
        else {
            Console.WriteLine($"{nomeStrongman} não foi encontrado no sistema.");
        }
    }
}