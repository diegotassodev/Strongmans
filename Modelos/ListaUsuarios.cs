using System.Text.Json;

namespace Strongmans.Modelos;
internal class ListaUsuarios {
    public List<Usuario>? listaUsuarios {get;set;}

    public static void Executar() {

        var nomeArquivoDados = "./Dados/dados-usuarios.json";
        var dadosArquivos = File.ReadAllText(nomeArquivoDados);
        var response = JsonSerializer.Deserialize<ListaUsuarios>(dadosArquivos);
        Usuario.listaUsuarios = response!.listaUsuarios!;

    }
}