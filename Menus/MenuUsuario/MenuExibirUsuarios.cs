using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuExibirUsuarios : Menu {
    
    public static void Executar() {
        ExibirTituloTabela("Tabela Usuários", 35);
        
        var colunaId = "ID".PadRight(10);
        var colunaNome = "Nome".PadRight(20);
        var colunaEmail = "Email".PadRight(20);
        var colunaSenha = "Senha".PadRight(20);
        var colunaTipo = "Tipo".PadRight(10);

        Console.WriteLine($"{colunaId}{colunaNome}{colunaEmail}{colunaSenha}{colunaTipo}");

        foreach (Usuario usuario in Usuario.listaUsuarios) {

            string nomeTipo = usuario.Tipo switch {
                "Strongmans.Modelos.Usuario" => "Usuário Comum",
                "Strongmans.Modelos.Admin" => "Administrador",
                _ => "Erro"
            };

            Console.WriteLine($"{usuario.Id,-10}{usuario.Nome,-20}{usuario.Email,-20}{usuario.Senha,-20}{nomeTipo,-20}");         
        }
    }
}