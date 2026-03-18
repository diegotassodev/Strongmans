namespace Strongmans.Modelos;
internal class Levantamento {

    public string? Nome {get;}
    public double QuantiaPeso {get;}
    public int AnoRealizado {get;}

    public Levantamento(string? nome, double quantiaPeso, int anoRealizado) {
        Nome = nome;
        QuantiaPeso = quantiaPeso;
        AnoRealizado = anoRealizado;
    }
}