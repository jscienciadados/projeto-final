using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Utils
{
    /// <summary>
    /// Classe de apoio ao Elevador
    /// </summary>
    public class Utilidades
    {
        /// <summary>
        /// Este método devolve uma mensagem personalizada
        /// </summary>
        public static void PrintInfo(String info)
        {


            Console.WriteLine("┼═══════════════════════┼");
            Console.WriteLine("║\t\t\t║");
            Console.WriteLine("║\t" + info + "\t║");
            Console.WriteLine("║\t\t\t║");
            Console.WriteLine("┼═══════════════════════┼");
        }

        /// <summary>
        /// Este método faz a seleção de cores dando a opção de escolha para o usuario.
        /// </summary>
        public static void PrintInfo(String info, ConsoleColor cor, ConsoleColor fundo = ConsoleColor.Black)
        {

            ConsoleColor Oldbackground = Console.BackgroundColor;
            ConsoleColor Oldforeground = Console.ForegroundColor;

            Console.ForegroundColor = cor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("┼═══════════════════════════════════════┼");
            Console.WriteLine("║\t\t\t\t\t║");
            Console.WriteLine("║\t\t" + info + "\t\t║");
            Console.WriteLine("║\t\t\t\t\t║");
            Console.WriteLine("┼═══════════════════════════════════════┼");
            Console.ForegroundColor = Oldforeground;
            Console.BackgroundColor = Oldbackground;
        }

    }
}
