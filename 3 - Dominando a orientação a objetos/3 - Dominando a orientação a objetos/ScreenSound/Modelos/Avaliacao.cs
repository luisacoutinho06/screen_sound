namespace ScreenSound.Modelos
{
    // O termo internal está relacionado a visibilidade de classes. Apenas o projeto consegue enxergar esta classe.
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
            Nota = nota;
        }

        public int Nota { get; }

 // Os métodos static são funções que não depende de nenhuma variável de instância (new), quando invocados executam uma função sem a dependência do conteúdo de um objeto.
 // Veremos que as instruções dentro do método Avaliacao Parse() não utilizam nada de fora da instância do objeto, como, por exemplo, nota.
 // Neste tipo de cenário, podemos marcar este método como estático. Dessa forma, ele se tornará apenas uma função com elementos autocontidos.
 // O static informa que o conteúdo executado não utiliza nenhuma informação da instância desta classe — no caso, Avaliacao. Podemos chamar o método diretamente pelo tipo.
        public static Avaliacao Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new Avaliacao(nota);
        }
    }
}
