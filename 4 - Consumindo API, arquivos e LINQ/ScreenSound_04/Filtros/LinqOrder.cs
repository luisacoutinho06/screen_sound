using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasMusicaisOrdenados = musicas.OrderBy(musica => musica.Artista).Select(s => s.Artista).Distinct().ToList();

            int quantidadeArtista = 1;

            foreach (var artista in artistasMusicaisOrdenados)
            {
                Console.WriteLine($"{quantidadeArtista++} - {artista}");
            }
        }
    }
}
