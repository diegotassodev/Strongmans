namespace Strongmans.Modelos;
internal class Usuario {

    public string? Nome {get;}
    public string? Email {get;}
    public string? Senha {get;}
    internal static List<Usuario> listaUsuarios = new();

    public Usuario(string? nome, string? email, string? senha) {
        Nome = nome;
        Email = email;
        Senha = senha;
    }
}