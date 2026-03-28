using Strongmans.Menus;
using Strongmans.Modelos;

string dadosStrongman = "./Dados/dados-strongmans";
string dadosUsuario = "./Dados/dados-usuarios";

if (File.Exists(dadosStrongman+".json"))ListaStrongmans.Executar();
else { 
    File.Create("./Dados/dados-strongmans.json").Close();
    File.WriteAllText(dadosStrongman+".json", "{\"listaStrongmans\":[]}");
}

if (File.Exists(dadosUsuario+".json")) ListaUsuarios.Executar();
else {
    File.Create("./Dados/dados-usuarios.json").Close();
    File.WriteAllText(dadosUsuario+".json", "{\"listaUsuarios\":[]}");
}

MenuLogin.Executar();