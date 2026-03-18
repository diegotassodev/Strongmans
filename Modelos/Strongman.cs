namespace Strongmans.Modelos;
internal class Strongman {

    public string? Nome {get;}
    public double AlturaMetros {get;}
    public double PesoKilogramas {get;}

    internal List<Levantamento> listaLevantamentosStrongman = new();
    internal static List<Strongman> listaStrongmans = new();

    public Strongman(string? nome, double alturaMetros, double pesoKilogramas) {
        Nome = nome;
        AlturaMetros = alturaMetros;
        PesoKilogramas = pesoKilogramas;
    }
}