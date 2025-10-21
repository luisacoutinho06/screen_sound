// Screen Sound
// O c# é uma linguagem fortemente tipada, isso significa que precisamos sempre declarar o tipo das variáveis criadas.

// Toda variável deve ser inserida usando o camel case.
using System.Net;

string mensagemDeBoasVindas = " Boas vindas ao Screen Sound!";

// Declaramos uma lista do tipo string. E essa lista está vazia e podemos colocar bandas dentro da lista:
// List<string> bandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };

// Iremos inserir um dicionário. Nele sempre teremos, uma chave, que são os nomes das bandas, Por exemplo, U2 será uma chave. E os valores que serão as notas.
// Repare que agora conseguimos atribuir mais notas para cada uma das bandas. Essas notas não são condicionadas a uma quantidade mínima.
// Já sabemos trabalhar com listas. Lembrando que, nas listas, precisamos definir as quantidades, porque elas são fortemente tipadas. Agora, vamos trabalhar com dicionários.
// As chaves serão os nomes das bandas (strings) e os valores serão uma lista de números.
// Em relação as listas serem fortemente tipadas. Significa que precisamos dizer o tipo: Da estrutura: dicionários. Da chave: string. Dos valores: notas.
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());


// Um conceito conhecido é a capacidade de isolar um código para ser reutilizado em outros momentos, evitando a necessidade de copiá-lo. O nome disso é função.
// Precisamos determinar se a função terá ou não um valor de retorno.
// Quando a função não tem um valor de retorno, ou seja, realiza ações sem retornar um resultado, usamos a palavra reservada "void".


// A linguagem C# reserva setenta e cinco palavras para seu próprio uso. Estas palavras são chamadas de palavras reservadas e cada uma tem um uso particular.
// Palavras reservadas também não são permitidas como nome de variáveis.
// Segue uma lista que identifica todas estas palavras:

//abstract     as           base        Bool
//break	       byte	        case	    Catch
//char	       checked	    class       Const
//continue     decimal      default	    Delegate
//do	       double	    else	    Enum
//event	       explicit	    extern      false
//finally	   fixed        float       for
//foreach	   goto	        if	        implicit
//in	       int          interface   internal
//is           lock         long        namespace
//new	       null	        object      operator
//out	       override	    params      private
//protected    public       readonly    ref
//return	   sbyte        sealed      short
//sizeof	   stackalloc	static      string
//struct       switch	    this        throw

void ExibirLogo()
{
    //Este @ antes de inserir a string, é o verbatim literal. É basicamente você colocar a string do jeito que você quer que ela apareça na função.
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    //Este \n é usado para gerar um espaço.
    Console.WriteLine("\n Digite 1 para registrar uma banda.");
    Console.WriteLine(" Digite 2 para mostrar todas as bandas.");
    Console.WriteLine(" Digite 3 para avaliar uma banda.");
    Console.WriteLine(" Digite 4 para exibir a média de uma banda.");
    Console.WriteLine(" Digite -1 para sair.");

    Console.Write("\n Digite a sua opção:");

    //Estamos armazenando a opção escrita dentro de uma variável.
    //Não queremos trabalhar com valor nulo no nosso programa, porque é necessário que esse valor seja uma string. Então colocamos um "!" para não aceitar valores nulos.
    string opcaoEscolhida = Console.ReadLine()!;

    //Convertendo a variável para int.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //Abaixo temos a interpolação de uma string:
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    //Agora iremos inserir o nome inserido da banda dentro da lista.
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    //Essa função espera dois milisegundos:
    Thread.Sleep(2000);

    //Essa função limpa o console:
    Console.Clear();

    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    // Precisamos pegar a "listaDasBandas" e exibir na tela cada banda que temos dentro dessa lista. Para isso usamos o for uma estrutura de repetição, iremos fazer um loop.
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    // Vamos usar a estrutura de repetição foreach: É outra função do C# não tão verbosa, sem precisar declarar um inteiro para fazer um loop como fizemos no for tradicional.
    // O recurso se chama for each ("para cada"). Assim, conseguimos passar por cada elemento da lista. O foreach é uma palavra reserva escrita toda junta e em minúsculas.

    //Estamos pegando as chaves do dicionário.
    foreach (string banda in bandasRegistradas.Keys)
    {
        // Até a leitura fica mais clara: string banda in listaDasBandas seria "para cada banda na lista de bandas".
        // Também fica mais claro visualmente para entender do que o for tradicional com sua inicialização, condição e expressão de iteração.
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite alguma tecla para voltar ao menu principal! :)");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite ma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}


//Chamando as funções;
ExibirOpcoesDoMenu();

