using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuExibirUsuarios : Menu {
    
    public static void Executar() {
        ExibirTitulo("Lista Usuários");
        Usuario.listaUsuarios.ForEach(usuario => Console.WriteLine($"[{usuario.Id}] {usuario.Nome} - {usuario.Email} - {usuario.Senha}"));
    }
}