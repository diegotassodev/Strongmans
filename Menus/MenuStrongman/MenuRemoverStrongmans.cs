using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuRemoverStrongman : Menu {

    public static void Executar() {
        ExibirTitulo("Remover Strongman");
        Strongman.listaStrongmans.ForEach(s => Console.WriteLine($"[{s.Id}] {s.Nome}"));
        Console.Write("Digite o id do Strongman: ");
        int idStrongman; int.TryParse(Console.ReadLine()!, out idStrongman);

        if (Strongman.listaStrongmans.Any(s => s.Id == idStrongman)) {
            Strongman strongman = Strongman.listaStrongmans.First(s => s.Id == idStrongman);
            Console.Write($"Você tem certeza que deseja excluir o {strongman.Nome}? [S] [N]: ");
            string opcao = Console.ReadLine()!;
            if (opcao.Trim().ToUpper() == "S") {
                Strongman.listaStrongmans.Remove(strongman);
                Console.WriteLine($"O {strongman.Nome} foi removido com sucesso!");
                strongman.SerializarStrongman();
            }
            else {
                Console.WriteLine("Procedimento cancelado!");
            }
        }
        else {
            Console.WriteLine($"O strongman com id [{idStrongman}] não existe.");
        }
    }
}