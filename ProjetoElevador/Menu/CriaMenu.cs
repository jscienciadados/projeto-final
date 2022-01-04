using ProjetoElevador.Model;
using ProjetoElevador.Utils;
using System;

namespace ProjetoElevador
{
    /// <summary>
    /// Menu Principal de Interação com o Elevador
    /// </summary>
    public class CriaMenu
    {
        public static void Menu()
        {
            // Projeto Elevador
            Console.WriteLine("======================== PROJETO ELEVADOR ========================");
            Console.WriteLine("Altura do Edifício: 10 andares e Capacidade do Elevador: 8 pessoas");
            Elevador elevador = new Elevador();
            ConsoleKeyInfo op;



            do
            {
                // MENU DO ELEVADOR
                MenuStatus(elevador);
                op = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("======================= SISTEMA DE ELEVADOR =======================");

                switch (op.Key)
                {
                    // ENTRADA DE NOVOS PARAMETROS DO ELEVADOR
                    case ConsoleKey.S:
                        Console.WriteLine(" Quantos Andares o Elevador possui?");
                        int newAndares = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Qual a capacidade de passageiros");
                        int newCapacidade = int.Parse(Console.ReadLine());
                        elevador.TotalDeAndares = newAndares;
                        elevador.Capacidade = newCapacidade;
                        break;

                    case ConsoleKey.U or ConsoleKey.UpArrow:
                        if (elevador.Localizar() < elevador.TotalDeAndares)
                        {
                            Utilidades.PrintInfo("Subindo", ConsoleColor.Green);
                            elevador.Up();

                        }
                        else
                        {
                            Utilidades.PrintInfo("Ultimo Andar", ConsoleColor.Red);
                        }
                        break;

                    // Descer
                    case ConsoleKey.D or ConsoleKey.DownArrow:
                        if (elevador.Localizar() > 0)
                        {
                            Utilidades.PrintInfo(" Descendo", ConsoleColor.DarkGreen);
                            elevador.Down();
                        }
                        else
                        {
                            Utilidades.PrintInfo(" Andar Terreo", ConsoleColor.DarkYellow);
                        }
                        break;

                    // Entrada no Elevador
                    case ConsoleKey.I or ConsoleKey.Enter or ConsoleKey.RightArrow:
                        if (elevador.QtdVagas() != 0)
                        {
                            Utilidades.PrintInfo(" Entrando", ConsoleColor.DarkCyan);
                            elevador.addPessoa("Passageiro", 1);
                        }
                        else if (elevador.Capacidade == 8)
                        {
                            Utilidades.PrintInfo("Elevador Lotado", ConsoleColor.Red);
                        }
                        break;

                    // Sair do Elevador
                    case ConsoleKey.O or ConsoleKey.Delete or ConsoleKey.LeftArrow:
                        if (elevador.Ocupacao() > 0)
                        {
                            Utilidades.PrintInfo("Sair", ConsoleColor.Black);
                            elevador.Sair();
                        }
                        else
                        {
                            Utilidades.PrintInfo("Elevador Vazio", ConsoleColor.Yellow);
                        }
                        break;



                }


            } while (op.Key != ConsoleKey.Q && op.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Menu de Interação
        /// elevador -> variavel do tipo Elevador
        /// </summary>
        private static void MenuStatus(Elevador elevador)
        {
            Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");
            Console.WriteLine("Quantas Vagas = " + elevador.QtdVagas());
            Console.WriteLine("Quantas Pessoas = " + elevador.Ocupacao());
            Console.WriteLine("Quantos Andares = " + elevador.Capacidade);
            Console.WriteLine("Qual Andar Atual = " + elevador.Localizar());

            Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");
            Console.WriteLine("Digite uma opção: (__)");
            Console.WriteLine("( I ) para Entrar (TECLA PARA DIREITA OU [ENTER])");
            Console.WriteLine("( O ) para Sair (TECLA PARA ESQUERDA OU [DELETE])");
            Console.WriteLine("( U ) para Subir um Andar (TECLA PARA CIMA)");
            Console.WriteLine("( D ) para Descer um Andar (TECLA PARA BAIXO)");
            Console.WriteLine("( S ) para Definir PADRÕES DO ELEVADOR");
            Console.WriteLine("( Q ) para Sair do Sistema (TECLA ESC)");
        }

    }
}