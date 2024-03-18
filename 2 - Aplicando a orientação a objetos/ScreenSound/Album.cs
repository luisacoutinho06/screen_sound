class Album
{
    // Essa variável so estará disponivel dentro das chaves, já que é um campo privado. Podemos criar relacionamentos entre classes no c#.
    // Onde a classe possui uma instância de outra classe como um de seus membros. Isso permite que a classe tenha acesso aos membros e comportamentos da classe relacionada.
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do ábum {Nome}.");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}.");
        }
        Console.WriteLine($"Para ouvir este ábum inteiro você precisa de {DuracaoTotal} segundos.");
    }
}