using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuExibirUsuarios : Menu {
    
    public static void Executar() {
        ExibirTitulo("Lista Usuários");
        Console.WriteLine("Lista de Usuários:");
        Usuario.listaUsuarios.ForEach(usuario => Console.WriteLine($"{usuario.Nome} - {usuario.Email} - {usuario.Senha}"));
        Console.ReadKey();
    }
}