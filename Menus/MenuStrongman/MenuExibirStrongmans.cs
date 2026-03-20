using Strongmans.Modelos;

namespace Strongmans.Menus;
internal class MenuExibirStrongmans : Menu {

    public static void Executar() {
        ExibirTitulo("Lista Strongmans");
        if (Strongman.listaStrongmans.Count > 0) {
            foreach(Strongman strongman in Strongman.listaStrongmans) {
                Console.WriteLine($"ID: {strongman.Id}");
                Console.WriteLine($"Nome: {strongman.Nome}   ");
                Console.WriteLine($"Altura: {strongman.AlturaMetros}m");
                Console.WriteLine($"Peso: {strongman.PesoKilogramas}kg");
                if (strongman.listaLevantamentosStrongman.Count() > 0) {
                    Console.WriteLine("Recordes: ");
                    foreach (Levantamento levantamento in strongman.listaLevantamentosStrongman) {
                        Console.WriteLine($"- {levantamento.Nome}: {levantamento.QuantiaPeso}kg em {levantamento.AnoRealizado}");
                    }
                }
                Console.WriteLine("");
            }
        }
        else {
            Console.WriteLine("Nenhum strongman foi encontrado no sistema.");
        }
    }
}