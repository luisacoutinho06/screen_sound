// Uma classe no C# é uma estrutura que define o comportamento e as propriedades de um objeto, servindo como um molde para criar insâncias desde objeto.
// Ela agrupa dados (atributos ou propriedades) e comportamentos (métodos) relacionados em uma única entidade(nesse caso musica).
// Um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância(é um novo objeto criado dessa classe, com o operador new)
// específica desta classe.
// Uma propriedade é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.

// Esse conceito é uma classe:
class Musica
{
    // Quando uma música é criada no nosso código? O new Musica() é quando criamos uma nova música.
    // Um construtor é um método especial que é executado no momento da criação do objeto (no caso Musica).
    // As características de um construtor são: ele não tem retorno (void, override), o nome dele é o tipo.
    public Musica(Banda artista, string nome)
    {
        // A propriedade recebe o argumento do construtor
        Artista = artista;
        Nome = nome;
    }

    // Tipos primitivos (string, int, bool):
    public string Nome { get; }
    public Banda Artista { get; }
    // Nessa parte de DescricaoResumida, nós não queremos que alguém consiga escrever valor aqui. Para informar isso, removemos o set de DescricaoResumida.
    // É basicamente isso. Passamos que não existe a operação de escrita nessa classe Musica.
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}.";
        }

    }
    public int Duracao { get; set; }

    // A palavra reservada "private" é usada para especificar que um membro de uma classe só pode ser acessado dentro dessa mesma classe.
    public bool Disponivel { get; set; }



    // Agora será criado um comportamento para esta classe, onde será exbido todos os atributos e seus valores:
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    // O método que terá como responsabilidade escrever o atributo disponivel.
    // Utilizaremos a palavra reservada public, pois desejamos que outras classes possam ter acesso.
    // Como esse método não retorna nenhum valor, utilizaremos a palavra reservada void.
    //public void EscreveDisponievel(bool value)
    //{
    //    disponivel = value;
    //}

    // Agora criar o método responsável pela leitura do atributo disponível.
    // Utilizaremos a palavra reservada public, pois desejamos que outras classes possam ter acesso.
    // Como o valor retornado será do tipo boobleano, definimos esse tipo como o tipo de retorno do método public bol.
    //public bool LerDisponivel()
    //{
    //    return disponivel;
    //}
}