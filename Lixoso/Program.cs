using System;
using Lixoso.Util;
using Lixoso.ViewController;

namespace Lixoso
{
    class Program
    {
        static void Main(string[] args)
        {
            int respostaDoLixo = 0; 
            do
            {  
            MenuUtil.Menu1();
            respostaDoLixo = int.Parse(Console.ReadLine());

            switch (respostaDoLixo)
            {
                case 1:
                    LixoViewController.CadastrarLixo();
                break;

                case 2:
                break;

                default:
                System.Console.WriteLine("Digite algo válido");
                break;
            }

            } while (respostaDoLixo != 0);
        }
    }
}
