using System.Text.Json;
using System.Text.Json.Serialization;

namespace Strongmans.Modelos;
internal class Strongman {

    [JsonPropertyName("id")]
    public int Id {get;set;}

    [JsonPropertyName("nome")]
    public string? Nome {get; set;}

    [JsonPropertyName("altura_metros")]
    public double AlturaMetros {get; set;}

    [JsonPropertyName("peso_kilogramas")]
    public double PesoKilogramas {get; set;}
    
    [JsonPropertyName("levantamentos_strongman")]
    public List<Levantamento>? listaLevantamentosStrongman {get;set;}

    internal static List<Strongman> listaStrongmans = new();

    private int autoIncrement = listaStrongmans.Count();

    string nomeArquivoDados = "./Dados/dados-strongmans.json";

    public Strongman(string? nome, double alturaMetros, double pesoKilogramas) {
        AutoIncrementId();
        Nome = nome;
        AlturaMetros = alturaMetros;
        PesoKilogramas = pesoKilogramas;

        listaLevantamentosStrongman = new();
        autoIncrement++;
        listaStrongmans.Add(this);
    }

    public void SerializarStrongman() {
        var opcoes = new JsonSerializerOptions {WriteIndented = true};
        var dadosJson = JsonSerializer.Serialize(new {
            listaStrongmans,
        }, opcoes);

        File.WriteAllText(nomeArquivoDados, dadosJson);
    }

    public void AutoIncrementId() {
        if (autoIncrement == 0) Id = 1;
        else if (autoIncrement == 1) Id = 2;

        else if (listaStrongmans.Any(u => u.Id > autoIncrement)) {
            Strongman strongman = listaStrongmans.Last(s => s.Id > autoIncrement);
            Id = strongman.Id + 1;
        }

        else if (autoIncrement != 0 && autoIncrement != 1) Id = autoIncrement+1;
    }
}