using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuRemoverUsuario : Menu {
    
    public static void Executar() {
        ExibirTitulo("Remover Usuário");
        Usuario.listaUsuarios.ForEach(u => Console.WriteLine($"[{u.Id}] {u.Nome}"));
        Console.Write("Digite o id do usuário: ");
        int idUsuario; int.TryParse(Console.ReadLine()!, out idUsuario);

        if (Usuario.listaUsuarios.Any (u => u.Id == idUsuario)) {
            Usuario usuarioRemover = Usuario.listaUsuarios.First(usuario => usuario.Id!.Equals(idUsuario));
            Console.Write($"Você tem certeza que deseja excluir o {usuarioRemover.Nome}? [S] [N]: ");
            string opcao = Console.ReadLine()!;
            if (opcao.Trim().ToUpper() == "S") {
                Usuario.listaUsuarios.Remove(usuarioRemover);
                Console.WriteLine($"O {usuarioRemover.Nome} foi removido com sucesso!");
                usuarioRemover.SerializarUsuario();
            }
            else {
                Console.WriteLine("Procedimento cancelado!");
            }
        }
        else {
            Console.WriteLine($"O Usuário com id [{idUsuario}] não existe.");
        }
    }
}