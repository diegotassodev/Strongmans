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
        Console.Write("Digite seu tipo de usuário [A] [C]: ");
        string tipoUsuario = Console.ReadLine()!;

        try {
            switch (tipoUsuario.ToUpper()) {
                case "A": Admin admin = new Admin(nomeUsuario, emailUsuario, senhaUsuario); Console.WriteLine("Administrador adicionado com sucesso!");
                        admin.SerializarUsuario(); break;
                case "C": Usuario usuario = new Usuario(nomeUsuario, emailUsuario, senhaUsuario); Console.WriteLine("Usuário adicionado com sucesso!");
                        usuario.SerializarUsuario(); break;
            }
            
        } 
        catch (Exception ex) {
            Console.WriteLine($"Ocorreu um erro ao adicionar o usuário: {ex.Message}");    
        }
    }
}