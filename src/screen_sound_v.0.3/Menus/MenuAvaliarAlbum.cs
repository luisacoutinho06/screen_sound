using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpcao("Avaliar álbum");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                    //Existe uma distinção entre métodos de instância (executados com as informações do próprio objeto) e métodos que não são da instância,
                    //por exemplo, o int parse() utilizado anteriormente.
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
