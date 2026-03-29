using System.Text.Json.Serialization;

namespace Strongmans.Modelos;
internal class Levantamento {

    [JsonPropertyName("nome")]
    public string? Nome {get;}

    [JsonPropertyName("quantia_peso")]
    public double QuantiaPeso {get;}

    [JsonPropertyName("ano_realizado")]
    public int AnoRealizado {get;}

    public Levantamento(string? nome, double quantiaPeso, int anoRealizado) {
        Nome = nome;
        QuantiaPeso = quantiaPeso;
        AnoRealizado = anoRealizado;
    }
}