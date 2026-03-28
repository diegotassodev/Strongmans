Objetivos
1. Fazer com que usuários e strongmans sejam salvos ao invés de em uma lista, em um arquivo.json.
2. Fazer com que usuários e strongmans sejam removidos do arquivo.json.
2. Fazer com que a exibição exiba usuários e strongmans com base nesse arquivo.json.

Ações
1. Criando Pasta para dados de strongmans e usuários
2. Criando classe Lista de Strognamns e Lista de Usuários para controlar desserialização de dados específicos.
3. Adicionando JsonProperty Name para classes de usuário e strongman.
4. AutoIncrement de usuário e strongman, agora recebe o valor da contagem de valores existentes na lista de usuários
5. Lista de usuários recebe o valor da desserialização de dados realizada no início do programa.
6. Usuario e strongman agora possuem classes especificas para serializá-los no momento de sua criação.
7. Adicionando novo atributo de tipo para usuário visando identificação entre usuários e administradores, tendo necessariamente que ser uma string porque não dá para serializar tipo, para isso, usamos toString
8. Nova validação para definição de um tipo de usuário na classe de adição de usuários.
9. Adicionando identação para escrita dos jsons
10. Adicionando escolha de tipo na criação do usuário.
11. Adicionando identação na criação de usuários e strongmans.
12. Gestão de usuário já funcional.
13. Adicionando lista de strongmans a serialização por meio da adição do get set e inicialização da lista na criação do strongman.
14. Adaptando o editar strongman para editar o strongman pelo id
15. Padronizando exibições e edições.
16. Padronizando infos serializadas (snake case)
17. Retirando serialização dos construtores para evitar erros e não violar o SRP
18. Criando menu para edição de usuário
19. Definindo padrão de Lambda para a primeira letra do nome da classe.
20. Definindo remoção de usuários e strongmans buscando pelo ID.
21. Alteranddo o auto increment para que ele lide com a remoção de usuários.
22. Adicionando alguns strongmans aleatórios a base de daddos.