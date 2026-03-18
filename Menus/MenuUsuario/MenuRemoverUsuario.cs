using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuRemoverUsuario : Menu {
    
    public static void Executar() {
        ExibirTitulo("Remover Usuário");
        Console.Write("Digite o nome do usuário: ");
        string nomeUsuario = Console.ReadLine()!;
        Usuario usuarioRemover = Usuario.listaUsuarios.First(usuario => usuario.Nome!.Equals(nomeUsuario));
        Usuario.listaUsuarios.Remove(usuarioRemover);
    }
}