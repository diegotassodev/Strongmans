namespace Strongmans.Modelos;
internal class Usuario {

    private static int autoIncrement = 1;

    public int Id;
    public string? Nome {get;}
    public string? Email {get;}
    public string? Senha {get;}
    internal static List<Usuario> listaUsuarios = new();

    public Usuario(string? nome, string? email, string? senha) {
        Id = autoIncrement;
        Nome = nome;
        Email = email;
        Senha = senha;

        autoIncrement++;
        listaUsuarios.Add(this);
    }
}