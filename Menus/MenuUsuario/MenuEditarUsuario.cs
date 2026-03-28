using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuEditarUsuarios : Menu {
    
    public static void Executar() {
        ExibirTitulo("Editar Usuários");
        Usuario.listaUsuarios.ForEach(usuario => Console.WriteLine($"[{usuario.Id}] {usuario.Nome}"));
        Console.Write("Selecione o id do usuário que você deseja editar: ");
        int idUsuario; int.TryParse(Console.ReadLine()!, out idUsuario);

        if (Usuario.listaUsuarios.Any(u => u.Id == idUsuario)) {
            Usuario usuario = Usuario.listaUsuarios.First(u => u.Id == idUsuario);
            ExibirTitulo(usuario.Nome!);
            Console.WriteLine($"1. Nome: {usuario.Nome}");
            Console.WriteLine($"2. Email: {usuario.Email}m");
            Console.WriteLine($"3. Senha: {usuario.Senha}kg");
            Console.Write("Selecione o que deseja editar: ");
            int opcao; int.TryParse(Console.ReadLine()!, out opcao);

            switch (opcao) {
                case 1: EditarNome(usuario); usuario.SerializarUsuario(); RetornandoTelaPrincipal(); break;
                case 2: EditarEmail(usuario); usuario.SerializarUsuario(); RetornandoTelaAdmin(); break;
                default: Console.WriteLine("Processo cancelado."); RetornandoTelaAdmin(); break;
            }
        }
    }

    public static void EditarNome(Usuario usuario) {
        Console.WriteLine("Digite um novo nome para o usuário: ");
        string nomeUsuario = Console.ReadLine()!;
        usuario.Nome = nomeUsuario;
        Console.WriteLine($"Sucesso na operação de troca de nome para: {nomeUsuario}!");
    }

    public static void EditarEmail(Usuario usuario) {
        Console.WriteLine("Digite um novo email para o usuário: ");
        string emailUsuario = Console.ReadLine()!;
        usuario.Email = emailUsuario;
        Console.WriteLine($"Sucesso na operação de troca de email para: {emailUsuario}!");
    }

    public static void EditarSenha(Usuario usuario) {
        Console.WriteLine("Digite uma nova senha para o usuário: ");
        string senhaUsuario = Console.ReadLine()!;
        usuario.Senha = senhaUsuario;
        Console.WriteLine($"Sucesso na operação de troca de senha para: {senhaUsuario}!");
    }
}