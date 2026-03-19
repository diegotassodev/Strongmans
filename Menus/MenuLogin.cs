using System.Text;
using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuLogin : Menu {

    public static void Executar() {
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
            Console.Write ("Senha: "); string senhaUsuario = MascararSenha();
            return senhaUsuario;
        }
        catch (Exception) {
            Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
            return "Erro";
        }
    }

    private static string MascararSenha() {
        var senha = new StringBuilder();
        while (true) {
            var tecla = Console.ReadKey(intercept: true);

            if (tecla.Key == ConsoleKey.Enter) break;
            else if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0) {
                senha.Remove(senha.Length - 1, 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(tecla.KeyChar)) {
                senha.Append(tecla.KeyChar);
                Console.Write("*");
            }
        }
        Console.WriteLine("");
        return senha.ToString();
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
                    MenuPrincipal.Executar();
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