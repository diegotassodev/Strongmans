namespace Strongmans.Modelos;
internal class Strongman {
    
    private static int autoIncrement = 1;

    public int Id;
    public string? Nome {get; set;}
    public double AlturaMetros {get; set;}
    public double PesoKilogramas {get; set;}

    internal List<Levantamento> listaLevantamentosStrongman = new();
    internal static List<Strongman> listaStrongmans = new();

    public Strongman(string? nome, double alturaMetros, double pesoKilogramas) {
        Id = autoIncrement;
        Nome = nome;
        AlturaMetros = alturaMetros;
        PesoKilogramas = pesoKilogramas;

        autoIncrement++;
        listaStrongmans.Add(this);
    }
}