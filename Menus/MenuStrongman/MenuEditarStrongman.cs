using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuEditarStrongman : Menu {

    public static void Executar() {
        ExibirTitulo("Editar Strogman");
        Strongman.listaStrongmans.ForEach(s => Console.WriteLine($"[{s.Id}] {s.Nome}"));
        Console.Write("Selecione o id do strongman que você deseja editar: ");
        int idStrongman; int.TryParse(Console.ReadLine()!, out idStrongman);  

        if (Strongman.listaStrongmans.Any(s => s.Id == idStrongman)) {
            Strongman strongman = Strongman.listaStrongmans.First(s => s.Id == idStrongman);
            ExibirTitulo(strongman.Nome!);
            Console.WriteLine($"1. Nome: {strongman.Nome}");
            Console.WriteLine($"2. Altura: {strongman.AlturaMetros}m");
            Console.WriteLine($"3. Peso: {strongman.PesoKilogramas}kg");
            Console.Write("Selecione o que deseja editar: ");
            int opcao; int.TryParse(Console.ReadLine()!, out opcao);
            
            switch (opcao) {
                case 1: EditarNome(strongman); strongman.SerializarStrongman(); RetornandoTelaPrincipal(); break;
                case 2: EditarAltura(strongman); strongman.SerializarStrongman(); RetornandoTelaPrincipal(); break;
                case 3: EditarPeso(strongman); strongman.SerializarStrongman(); RetornandoTelaPrincipal(); break;
                default: Console.WriteLine("Processo cancelado."); RetornandoTelaPrincipal(); break;
            }
        }
        else {
            Console.WriteLine("Strongman não encontrado.");
            RetornandoTelaPrincipal();
        }
    }

    public static void EditarNome(Strongman strongman) {
        Console.Write("Digite o novo nome para o strongman: ");
        string nomeStrongman = Console.ReadLine()!;
        strongman.Nome = nomeStrongman;
        Console.WriteLine($"Sucesso na operação de troca de nome para: {nomeStrongman}");
    }

    public static void EditarAltura(Strongman strongman) {
        Console.Write("Digite a nova altura para o strongman: ");
        double altura; double.TryParse(Console.ReadLine()!, out altura);
        strongman.AlturaMetros = altura;
        Console.WriteLine($"Sucesso na operação de troca de altura para: {altura}m");
    }

       public static void EditarPeso(Strongman strongman) {
        Console.Write("Digite o novo peso para o strongman: ");
        double peso; double.TryParse(Console.ReadLine()!, out peso);
        strongman.PesoKilogramas = peso;
        Console.WriteLine($"Sucesso na operação de troca de peso para: {peso}kg");
    }
}