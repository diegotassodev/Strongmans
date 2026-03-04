var loginUsuario = new Dictionary<string, string>(); AdicionandoUsuarios();
var strongmans = new Dictionary<string, Dictionary<int, int>>(); AdicionandoStrongmans();

ExibirInterfaceLogin();
ValidandoLogin();

void AdicionandoUsuarios() {
    loginUsuario.Add("admin", "root");
}
void AdicionandoStrongmans() {
    strongmans.Add("Louis Cyr", new Dictionary<int, int>());
    strongmans.Add("George Hackensmith", new Dictionary<int, int>());
    strongmans.Add("Sandow", new Dictionary<int, int>());

    strongmans["Louis Cyr"].Add (124,227);
    strongmans["George Hackensmith"].Add (125,164);
    strongmans["Sandow"].Add (122,136);
}

void ExibirTitulo (string titulo) {
    int quantiaLetrasTitulo = titulo.Length;
    string molduraTitulo = string.Empty.PadLeft(quantiaLetrasTitulo, '=');

    Console.WriteLine ($"========{molduraTitulo}========");
    Console.WriteLine ($"        {titulo}        ");
    Console.WriteLine ($"========{molduraTitulo}========");
}

void ExibirInterfaceLogin() {
    Console.Clear();
    ExibirTitulo("SISTEMA DE LOGIN");
}
string EntradaNomeUsuario() {
    try {
        Console.Write ("Usuário: "); string nomeUsuario = Console.ReadLine()!;
        return nomeUsuario;
    }
    catch (Exception) {
        Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
        return "Erro";
    }
}
string EntradaSenhaUsuario() {
    try {
        Console.Write ("Senha: "); string senhaUsuario = Console.ReadLine()!;
        return senhaUsuario;
    }
    catch (Exception) {
        Console.WriteLine ($"Um erro foi encontrado ao tentar entrar no sistema.");
        return "Erro";
    }
}
void ValidandoLogin() {
    string nomeUsuario = EntradaNomeUsuario();
    string senhaUsuario = EntradaSenhaUsuario();

    if (loginUsuario.ContainsKey(nomeUsuario)) {
        if (loginUsuario[nomeUsuario] == senhaUsuario) {
            Console.Write($"Seja bem vindo {nomeUsuario}");
            Console.ReadKey();
            ExibirInterfacePrincipal();
        }
        else {
            Console.WriteLine ("Usuário ou senha incorretos.");
        }
    }
    else {
        Console.WriteLine ("Usuário ou senha incorretos.");
    }
}

void ExibirInterfacePrincipal() {
    Console.Clear();
    ExibirTitulo("STRONGMANS");
    Console.WriteLine ("1. Adicionar Strongman");
    Console.WriteLine ("2. Mostrar Strongmans");
    Console.WriteLine ("3. Pesquisar Strongman");
    Console.WriteLine ("4. Excluir Strongman");
    Console.WriteLine ("0. Sair");
    int opcao = EntradaOpcaoUsuario();
    ProcessandoOpcaoUsuario(opcao);
}
int EntradaOpcaoUsuario() {
    try {
        Console.Write ("Digite sua opção: "); 
        int opcao = int.Parse(Console.ReadLine()!);
        return opcao;
    }
    catch (Exception) {
        return 0;
    }
}
void ProcessandoOpcaoUsuario(int opcao) {
    switch (opcao) {
        case 1: AdicionarStrongman(); RetornandoTelaPrincipal(); break;
        case 2: MostrarStrongmans(); RetornandoTelaPrincipal(); break;
        case 3: PesquisarStrongman(); RetornandoTelaPrincipal(); break;
        case 4: ExcluirStrongman(); RetornandoTelaPrincipal(); break;
        case 0: Console.WriteLine ("Encerrando o Programa."); break;
        default: Console.WriteLine ("Um erro foi encontrado."); RetornandoTelaPrincipal(); break;
    }
}
void AdicionarStrongman() {
    Console.Clear();
    ExibirTitulo("ADICIONAR STRONGMAN");
    try {
        Console.Write ("Digite o nome do Strongman que deseja adicionar: "); string nomeStrongman = Console.ReadLine()!;
        Console.Write ($"Digite o recorde do {nomeStrongman} no Bent Press: "); int pesoBentPress = int.Parse(Console.ReadLine()!);
        Console.Write ($"Digite o recorde do {nomeStrongman} no Floor Press: "); int pesoFloorPress = int.Parse(Console.ReadLine()!);
        strongmans.Add(nomeStrongman, new Dictionary<int, int>());
        strongmans[nomeStrongman].Add(pesoBentPress, pesoFloorPress);
        Console.WriteLine ($"As informações sobre o {nomeStrongman} foram salvas com sucesso.");
    }
    catch (Exception) {
        Console.WriteLine ("Um erro foi encontrado, operação cancelada.");
        return;
    }
}
void MostrarStrongmans() {
    Console.Clear();
    ExibirTitulo("MOSTRAR STRONGMANS");
    foreach (string strongman in strongmans.Keys) {
        Console.WriteLine (strongman);
    }
}
void PesquisarStrongman() {
    int recordeBentPress = 0;
    int recordeFloorPress = 0;

    Console.Clear();
    ExibirTitulo("PESQUISAR STRONGMANS");
    try {
        Console.Write ("Digite o nome do Strongman que deseja pesquisar: "); string nomeStrongman = Console.ReadLine()!;
        foreach (string strongman in strongmans.Keys) {
            if (strongman == nomeStrongman) {
                foreach (int recorde in strongmans[strongman].Keys) {
                    recordeBentPress = recorde;
                }
                foreach (int recorde in strongmans[strongman].Values) {
                    recordeFloorPress = recorde;
                }
            }
        }
        if (strongmans.ContainsKey(nomeStrongman)) {
            Console.Clear();
            ExibirTitulo("FICHA STRONGMAN");
            Console.WriteLine ($"Nome: {nomeStrongman}");
            Console.WriteLine ($"Recorde no Bent Press: {recordeBentPress}KG");
            Console.WriteLine ($"Recorde no Floor Press: {recordeFloorPress}KG");
        }
        else {
            Console.WriteLine ($"O Strongman: {nomeStrongman}, não existe no sistema.");  
        }
    }
    catch(Exception) {
        Console.WriteLine ("Um erro foi encontrado, operação cancelada.");
        return;
    }
}
void ExcluirStrongman() {
    Console.Clear();
    ExibirTitulo("EXCLUIR STRONGMAN");
    try {
        Console.Write ("Digite o nome do Strongman que deseja apagar: "); string nomeStrongman = Console.ReadLine()!;

        if (strongmans.ContainsKey(nomeStrongman)) {
            Console.Write ($"Você tem certeza que deseja apagar o {nomeStrongman}? [Sim] [Não]: "); string escolha = Console.ReadLine()!;
            if (escolha.ToUpper() == "SIM") {
                strongmans.Remove(nomeStrongman);
                Console.WriteLine ($"O Strongman {nomeStrongman} foi removido com sucesso.");
                return;
            }
            else if (escolha.ToUpper() == "NÃO") {
                Console.WriteLine ("Tudo bem, operação cancelada.");
                return;
            }
            else {
                Console.WriteLine ("Um erro foi encontrado, operação cancelada.");
                return;
            }
        }
        else {
            Console.WriteLine ("Esse strongman não existe.");
            return;        
        }
    }
    catch (Exception) {
        Console.WriteLine ("Um erro foi encontrado, operação cancelada.");
        return;
    }
}

void RetornandoTelaPrincipal() {
    Console.WriteLine ("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    ExibirInterfacePrincipal();
}