using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuExibirUsuarios : Menu {
    
    public static void Executar() {
        ExibirTitulo("Lista Usuários");
        foreach (Usuario usuario in Usuario.listaUsuarios) {
            Console.WriteLine($"ID: {usuario.Id}");
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"Email: {usuario.Email}");
            Console.WriteLine($"Senha: {usuario.Senha}");

            string nomeTipo = usuario.Tipo switch {
                "Strongmans.Modelos.Usuario" => "Usuário Comum",
                "Strongmans.Modelos.Admin" => "Administrador",
                _ => "Erro"
            };

            Console.WriteLine($"Tipo: {nomeTipo}\n");           
        }
    }
}