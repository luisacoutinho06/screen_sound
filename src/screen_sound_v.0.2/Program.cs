//Já sabemos que o C# é uma linguagem fortemente tipada, por isso vamos criar uma variável cujo tipo é uma música.
//Para isso, escrevemos o tipo Musica e escrevemos o nome da primeira variável, que pode ser musica1, pois criaremos outras músicas depois.
//Em seguida, adicionamos um sinal de igual (=). Então: Musica musica1 =.
//Essa variável receberá uma música que criaremos usando a palavra reservada new, que já conhecemos e usamos em outras situações.
//Mas, agora estamos usando para o tipo música: new Musica().Nesse momento, criamos um objeto específico para o tipo Musica:
//Musica musica1 = new Musica();


//Agora vamos setar os valores que serão inseridos. Primeiro digitamos musica1 para acessar essa variável.
//Em seguida adicionamos um ponto final, usado para fazer referência a propriedades do tipo da variável.
//musica1.Nome = "Roxane";
//musica1.Artista = "The Police";
//musica1.Duracao = 273;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);
//musica1.EscreveDisponievel(true);
//Console.WriteLine(musica1.LerDisponivel());



//Musica musica2 = new Musica();
//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 367;
//musica2.Disponivel = false;
//Console.WriteLine(musica2.LerDisponivel());



//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();


// Inserindo uma variável e a instanciamos:
// Isso é um construtor implícito:
Album albumDoQueen = new Album("A night at the opera");
Banda queen = new Banda("Queen");


Musica musica1 = new Musica(queen, "Love of my life")
{
    // Isso é um inicializador de propriedads opcionais do objeto.
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();




//Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
//Console.WriteLine(ep1.Resumo);
//ep1.AdicionarConvidados("Maria");
//ep1.AdicionarConvidados("Marcelo");

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
