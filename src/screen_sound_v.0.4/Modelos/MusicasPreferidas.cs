using System.Text.Json;

namespace ScreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas do(a) -> {Nome}");

            int quantidadeMusicaPreferida = 1;

            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"{quantidadeMusicaPreferida++}- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            //Nós iremos agora fazer a serialização de dados, criar uma string que contenha essas informações. 
            string json = JsonSerializer.Serialize(new
            {
                // Estamos criando um objeto anônimo.
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo json foi criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
