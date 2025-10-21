using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(s => s.Genero).Distinct().ToList();

            int quantidadeGenero = 1;

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"{quantidadeGenero++} - {genero}");
            }
        }
        
        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(w => w.Genero!.Contains(genero)).Select(s => s.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

            int quantidadeArtistaGenero = 1;

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"{quantidadeArtistaGenero++} - {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            //Sempre que eu quero pegar um subconjunto de uma lista eu utilizo o where, porém se eu quero selecionar eu utilizo o select.
            //Quando é string se utiliza o equals quando queremos fazer comparação deste tipo.
            var musicasDoArtista = musicas.Where(w => w.Artista!.Equals(nomeDoArtista)).ToList();

            Console.WriteLine(nomeDoArtista);

            int quantidadeMusica = 1;

            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"{quantidadeMusica++} - {musica.Nome}");
            }
        }

        public static void ExibirTodasAsMusicasReferentesATonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicasComTonalidade = musicas.Where(s => s.Tonalidade.Equals(tonalidade)).Select(s => s.Nome).Distinct().ToList();

            int quantidadeMusicaTonalidade = 1;
            Console.WriteLine($"Exibindo todas as músicas com a tonalidade >>> {tonalidade}");

            foreach (var musicasTona in musicasComTonalidade)
            {
                Console.WriteLine($"{quantidadeMusicaTonalidade++} - {musicasTona}");
            }
        }
    }
}
