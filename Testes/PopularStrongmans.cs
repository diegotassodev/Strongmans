namespace Strongmans.Testes;
using Strongmans.Modelos;
internal class PopularStrongmans {
    public static void Executar() {
        Strongman strongman1 = new Strongman("Louis", 2, 200);
        Strongman.listaStrongmans.Add(strongman1);
        Levantamento levantamento01 = new Levantamento("Deadlift", 300, 2008);
        strongman1.listaLevantamentosStrongman.Add(levantamento01);

        Strongman strongman2 = new Strongman("Eddie", 3, 190);
        Strongman.listaStrongmans.Add(strongman2);
        Levantamento levantamento02 = new Levantamento("Deadlift", 500, 2016);
        strongman2.listaLevantamentosStrongman.Add(levantamento02);

        Strongman strongman3 = new Strongman("Hafthor", 4, 205);
        Strongman.listaStrongmans.Add(strongman3);
        Levantamento levantamento03 = new Levantamento("Deadlift", 501, 2020);
        strongman3.listaLevantamentosStrongman.Add(levantamento03);

        Strongman strongman4 = new Strongman("Brian", 4, 200);
        Strongman.listaStrongmans.Add(strongman4);

        Strongman strongman5 = new Strongman("Zydrunas", 5, 180);
        Strongman.listaStrongmans.Add(strongman5);
        Levantamento levantamento05 = new Levantamento("Log Lift", 228, 2015);
        strongman5.listaLevantamentosStrongman.Add(levantamento05);
        Levantamento levantamento06 = new Levantamento("Deadlift", 460, 2014);
        strongman5.listaLevantamentosStrongman.Add(levantamento06);

        Strongman strongman6 = new Strongman("Martins", 2, 170);
        Strongman.listaStrongmans.Add(strongman6);

        Strongman strongman7 = new Strongman("Tom", 3, 185);
        Strongman.listaStrongmans.Add(strongman7);
        Levantamento levantamento07 = new Levantamento("Atlas Stone", 286, 2021);
        strongman7.listaLevantamentosStrongman.Add(levantamento07);

        Strongman strongman8 = new Strongman("Oleksii", 2, 195);
        Strongman.listaStrongmans.Add(strongman8);
        Levantamento levantamento08 = new Levantamento("Deadlift", 465, 2022);
        strongman8.listaLevantamentosStrongman.Add(levantamento08);

        Strongman strongman9 = new Strongman("Julius", 1, 180);
        Strongman.listaStrongmans.Add(strongman9);

        Strongman strongman10 = new Strongman("Mark", 2, 175);
        Strongman.listaStrongmans.Add(strongman10);
        Levantamento levantamento09 = new Levantamento("Log Lift", 210, 2008);
        strongman10.listaLevantamentosStrongman.Add(levantamento09);

        Strongman strongman11 = new Strongman("Robert", 3, 185);
        Strongman.listaStrongmans.Add(strongman11);
        Levantamento levantamento10 = new Levantamento("Deadlift", 470, 2020);
        strongman11.listaLevantamentosStrongman.Add(levantamento10);
        Levantamento levantamento11 = new Levantamento("Farmer Walk", 160, 2019);
        strongman11.listaLevantamentosStrongman.Add(levantamento11);
    }
}