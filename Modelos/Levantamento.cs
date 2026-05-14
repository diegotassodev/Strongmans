using System.Text.Json.Serialization;

namespace Strongmans.Modelos;
internal class Levantamento {
    
    [JsonPropertyName("nome")]
    public string? Nome {get;set;}

    [JsonPropertyName("quantia_peso")]
    public double QuantiaPeso {get;set;}

    [JsonPropertyName("ano_realizado")]
    public int AnoRealizado {get;set;}

    public Levantamento(string? nome, double quantiaPeso, int anoRealizado) {
        Nome = nome;
        QuantiaPeso = quantiaPeso;
        AnoRealizado = anoRealizado;
    }
}