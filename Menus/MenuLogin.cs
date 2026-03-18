using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuLogin : Menu {

    public static void Exibir() {
        ExibirTitulo("SISTEMA DE LOGIN");
        ValidandoLogin();
    }

    private static string EntradaEmailUsuario() {
        try {
            Console.Write ("Email: "); string emailUsuario = Console.ReadLine()!;
            return emailUsuario;
        }
        catch (Exception) {
            Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
            return "Erro";
        }
    }
    private static string EntradaSenhaUsuario() {
        try {
            Console.Write ("Senha: "); string senhaUsuario = Console.ReadLine()!;
            return senhaUsuario;
        }
        catch (Exception) {
            Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
            return "Erro";
        }
    }

    private static void ValidandoLogin() {
        string email = EntradaEmailUsuario();
        string senha = EntradaSenhaUsuario();
        try {
            if (Usuario.listaUsuarios.Any(u => u.Email!.Equals(email))) {
                Usuario usuarioDigitado = Usuario.listaUsuarios.First(u => u.Email!.Equals(email));
                if (usuarioDigitado.Senha!.Equals(senha)) {
                    Console.WriteLine("Login realizado com sucesso!");
                    Thread.Sleep(1000);
                    MenuPrincipal.Exibir();
                }
                else {
                    Console.WriteLine("Usuário ou senha incorretos!");
                }
            }
            else {
                Console.WriteLine("Usuário ou senha incorretos!");
            }
        }
        catch (Exception) {
            Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
        }
    }

}