namespace Strongmans.Testes;
using Strongmans.Modelos;
internal class PopularUsuarios {
    public static void Executar() {
        Usuario usuario1 = new Usuario("Carlos Silva", "carlos.silva@email.com", "Senha123");
        Usuario.listaUsuarios.Add(usuario1);

        Usuario usuario2 = new Usuario("Mariana Souza", "mariana.souza@email.com", "Senha456");
        Usuario.listaUsuarios.Add(usuario2);

        Usuario usuario3 = new Usuario("João Pereira", "joao.pereira@email.com", "Senha789");
        Usuario.listaUsuarios.Add(usuario3);

        Usuario usuario4 = new Usuario("Ana Costa", "ana.costa@email.com", "Senha321");
        Usuario.listaUsuarios.Add(usuario4);

        Usuario usuario5 = new Usuario("Lucas Fernandes", "lucas.fernandes@email.com", "Senha654");
        Usuario.listaUsuarios.Add(usuario5);

        Usuario usuario6 = new Usuario("Beatriz Oliveira", "beatriz.oliveira@email.com", "Senha987");
        Usuario.listaUsuarios.Add(usuario6);

        Usuario usuario7 = new Usuario("Rafael Martins", "rafael.martins@email.com", "Senha159");
        Usuario.listaUsuarios.Add(usuario7);

        Usuario usuario8 = new Usuario("Juliana Rocha", "juliana.rocha@email.com", "Senha753");
        Usuario.listaUsuarios.Add(usuario8);

        Usuario usuario9 = new Usuario("Pedro Almeida", "pedro.almeida@email.com", "Senha852");
        Usuario.listaUsuarios.Add(usuario9);

        Usuario usuario10 = new Usuario("Fernanda Lima", "fernanda.lima@email.com", "Senha951");
        Usuario.listaUsuarios.Add(usuario10);

        Usuario usuario11 = new Usuario("Diego", "diego@email.com", "123");
        Usuario.listaUsuarios.Add(usuario11);
    }
}