using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

/*

    Nesse curso, vamos entender de forma prática como integrar uma aplicação em C# com uma API externa. Para isso, vamos aprender como funciona o HttpClient, uma importante biblioteca no C#.
    Também temos outros conteúdos interessantes. Por exemplo, para poder pegar essas fontes de informações, vamos conhecer sobre exceções.
    Depois que tivermos essa coleção da API em memória, vamos começar a manipular essas coleções. Para isso, vamos usar uma biblioteca importante no desenvolvimento .NET, o LINQ.
    Com isso, vamos aprender a ordenar, filtrar e mapear para outros elementos.

    Essa API abaixo contém diversas músicas aleatórias e queremos integrá-la no projeto:
    [
        {
            ""artist"": ""The Chainsmokers"",
            ""song"": ""#SELFIE - Original Mix"",
            ""duration_ms"": 183750,
            ""explicit"": ""False"",
            ""year"": ""2014"",
            ""popularity"": ""0"",
            ""danceability"": ""0.789"",
            ""energy"": ""0.915"",
            ""key"": 0,
            ""loudness"": ""-3.263"",
            ""mode"": ""1"",
            ""speechiness"": ""0.248"",
            ""acousticness"": ""0.0135"",
            ""instrumentalness"": ""8.77e-06"",
            ""liveness"": ""0.0818"",
            ""valence"": ""0.66"",
            ""tempo"": ""127.955"",
            ""genre"": ""pop, Dance/Electronic""
        },
    ]


    O nosso desafio é acessar o endereço desse arquivo que chamamos de endpoint e pegar todas essas músicas e trazer para a nossa aplicação.
    Por isso, vamos utilizar a ideia de cliente e servidor.
*/

// Já que é algo tão comum realizar requisições para APIs externas, 
// pegar os dados e trabalhar naqueles dados no nosso sistema usando HTTP, provavelmente deve existir uma biblioteca, um tipo responsável para nos auxiliar nesse tarefa.

// A IDE até dá uma sugestão de autocomplete de HttpClient client = new HttpClient(). Geralmente, por convenção, chamamos a variável do tipo HttpClient de client (cliente).
// Após fechar os parênteses do using, abrimos chaves.
// Essa palavra reservada 'using' usamos para se referir a um tipo
using (HttpClient client = new HttpClient())
{
    // O try, ele basicamente executa o código que está inserido dentro dele
    try
    {
        // Realizando uma requisição para pegar o json.
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // É um processo para converter uma estrutura de dados ou um objeto em um formato que possa ser armazenado ou transferido.
        // O ponto de exclamação no final mostra que não aceita que seja nula a musica.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //Console.WriteLine($"Quantidade de músicas existentes na API: {musicas.Count}!");

        //Console.WriteLine();
        //Console.WriteLine();

        //musicas[1].ExibirDetalhesDaMusica();

        //Console.WriteLine();
        //Console.WriteLine();

        //Console.WriteLine($"Todos os gêneros da API:");
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        //Console.WriteLine();
        //Console.WriteLine();

        //Console.WriteLine($"Todos os artistas da API:");
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        //Console.WriteLine();
        //Console.WriteLine();

        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");

        //Console.WriteLine();
        //Console.WriteLine();

        //Console.WriteLine($"Músicas do artista:");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //Console.WriteLine();
        //Console.WriteLine();

        //var musicasPreferidasDeUsuario = new MusicasPreferidas("Usuário");
        //musicasPreferidasDeUsuario.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDeUsuario.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDeUsuario.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDeUsuario.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDeUsuario.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDeUsuario.ExibirMusicasFavoritas();

        //var musicasPreferidasDeUsuario2 = new MusicasPreferidas("Usuário2");
        //musicasPreferidasDeUsuario2.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDeUsuario2.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasDeUsuario2.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasDeUsuario2.AdicionarMusicasFavoritas(musicas[13]);

        //musicasPreferidasDeUsuario2.ExibirMusicasFavoritas();
        //musicasPreferidasDeUsuario2.GerarArquivoJson();

        Console.WriteLine();
        Console.WriteLine();

        LinqFilter.ExibirTodasAsMusicasReferentesATonalidade(musicas, "C#");

    }
    // O catch serve para lançarmos um exceção. Ou seja, gostariamos que caso ocorra algum erro ele faça o tratamento, ou seja me mostre o erro gerado.
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}



