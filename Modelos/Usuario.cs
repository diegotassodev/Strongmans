using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Strongmans.Modelos;
internal class Usuario {

    [JsonPropertyName("id")]
    public int Id {get;set;}

    [JsonPropertyName("nome")]
    public string? Nome {get;set;}

    [JsonPropertyName("email")]
    public string? Email {get;set;}

    [JsonPropertyName("senha")]
    public string? Senha {get;set;}

    [JsonPropertyName("tipo")]
    public string? Tipo {get;set;}

    internal static List<Usuario> listaUsuarios = new();

    private int autoIncrement = listaUsuarios.Count();

    string nomeArquivoDados = "./Dados/dados-usuarios.json";

    public Usuario(string? nome, string? email, string? senha) {
        AutoIncrementId();
        Nome = nome;
        Email = email;
        Senha = senha;
        Tipo = GetType().ToString();

        autoIncrement++;
        listaUsuarios.Add(this);
    }

    public virtual void SerializarUsuario() {
        var opcoes = new JsonSerializerOptions {WriteIndented = true};
        var dadosJson = JsonSerializer.Serialize(new {
            listaUsuarios
        }, opcoes);

        File.WriteAllText(nomeArquivoDados, dadosJson);
    }

    public void AutoIncrementId() {
        if (autoIncrement == 0) Id = 1;
        else if (autoIncrement == 1) Id = 2;

        else if (listaUsuarios.Any(u => u.Id > autoIncrement)) {
            Usuario usuario = listaUsuarios.Last(u => u.Id > autoIncrement);
            Id = usuario.Id + 1;
        }

        else if (autoIncrement != 0 && autoIncrement != 1) Id = autoIncrement+1;
    }
}