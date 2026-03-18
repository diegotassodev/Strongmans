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
    
    public static void RetornandoTelaPrincipal() {
        Console.WriteLine ("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuPrincipal.Executar();
    }
}