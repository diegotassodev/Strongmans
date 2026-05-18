namespace Strongmans.Menus;
internal abstract class Menu {

    public static void ExibirTitulo (string titulo) {
        int quantiaLetrasTitulo = titulo.Length;
        string molduraTitulo = string.Empty.PadLeft(quantiaLetrasTitulo, '━');
        titulo = titulo.ToUpper();

        Console.Clear();
        Console.WriteLine ($"━━━━━━━━━{molduraTitulo}━━━━━━━━━");
        Console.WriteLine ($"         {titulo}         ");
        Console.WriteLine ($"━━━━━━━━━{molduraTitulo}━━━━━━━━━");
    }

    public static void ExibirTituloTabela (string titulo, int tamanhoTabela) {
        int quantiaLetrasTitulo = titulo.Length;
        string molduraTitulo = string.Empty.PadLeft(quantiaLetrasTitulo, '━');

        string padTabela = string.Empty.PadLeft(tamanhoTabela, '━');
        string padTitulo = string.Empty.PadLeft(tamanhoTabela);

        titulo = titulo.ToUpper();

        Console.Clear();
        Console.WriteLine ($"{padTabela}{molduraTitulo}{padTabela}");
        Console.WriteLine ($"{padTitulo}{titulo}{padTitulo}");
        Console.WriteLine ($"{padTabela}{molduraTitulo}{padTabela}");
    }
    
    public static void RetornandoTelaPrincipal() {
        Console.WriteLine ("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuPrincipal.Executar();
    }

    public static void RetornandoTelaAdmin() {
        Console.WriteLine ("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuAdmin.Executar();
    }
    
}