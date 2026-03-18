using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuAdicionarUsuario : Menu {
    public static void Executar() {
        ExibirTitulo("Adicionar Usuário");
        Console.Write("Digite o nome do usuário: ");
        string nomeUsuario = Console.ReadLine()!;
        Console.Write("Digite o email do usuário: ");
        string emailUsuario = Console.ReadLine()!;
        Console.Write("Digite a senha do usuário: ");
        string senhaUsuario = Console.ReadLine()!;
        try {
            Usuario usuario = new Usuario(nomeUsuario, emailUsuario, senhaUsuario);
            Usuario.listaUsuarios.Add(usuario);
            Console.WriteLine("Usuário adicionado com sucesso!");
        } 
        catch {
            Console.WriteLine("Ocorreu um erro ao adicionar o usuário.");    
        }
    }
}