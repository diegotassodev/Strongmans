using System.Text.Json;

namespace Strongmans.Modelos;
internal class ListaStrongmans {
    public List<Strongman>? listaStrongmans {get;set;}

    public static void Executar() {

        var nomeArquivoDados = "./Dados/dados-strongmans.json";
        var dadosArquivos = File.ReadAllText(nomeArquivoDados);
        var response = JsonSerializer.Deserialize<ListaStrongmans>(dadosArquivos);
        Strongman.listaStrongmans = response!.listaStrongmans!;
        
    }
}