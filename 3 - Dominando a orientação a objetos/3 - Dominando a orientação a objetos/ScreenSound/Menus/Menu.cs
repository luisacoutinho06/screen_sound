
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        // Inserimos o virtual, pois precisamos indicar no ancestral que ele pode ser sobrescrito. Para isso, temos a palavra reservada virtual
        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();

        }
    }
}
