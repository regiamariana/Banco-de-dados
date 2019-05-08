using System;
using Lixoso.Util;

namespace Lixoso.ViewController {
    public class LixoViewController {
        public static void CadastrarLixo () {
            string nomeLixo;
            int categoriaEscolhida = 0;

            System.Console.WriteLine ("Digite o nome do lixo");
            nomeLixo = Console.ReadLine ();

            do {

                System.Console.WriteLine ("Selecione sua categoria:");
                MenuUtil.Menu2 ();
                categoriaEscolhida = int.Parse (Console.ReadLine ());

                switch (categoriaEscolhida) {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine ("O cesto é o cesto VERMELHO");
                        Console.ResetColor ();
                        break;

                    case 2:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine ("O cesto é o cesto AMARELO");
                        Console.ResetColor ();
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("O cesto é o cesto VERDE");
                        Console.ResetColor ();
                        break;

                    case 4:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine ("O cesto é o cesto AZUL");
                        Console.ResetColor ();
                        break;

                    case 5:
                        
                        System.Console.WriteLine ("O cesto é o cesto PRETO");
                        
                        break;

                    case 6:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        System.Console.WriteLine ("O cesto é o cesto CINZA");
                        Console.ResetColor ();
                        break;

                    default:
                        System.Console.WriteLine ("Digite algo válido");
                        break;
                }

            } while (categoriaEscolhida != 0);

        }
    }
}