using System;
using Senai.Revisao.MVC.Utils;
using Senai.Revisao.MVC.ViewController;

namespace Senai.Revisao.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                    //cadastrar novo usuário
                    UsuarioViewController.CadastrarUsuario(); 
                    break;

                    case 2 :
                    //Listar usuários
                    break;

                    case 3:
                    //Efetuar login
                    break;

                    case 0:
                    //Sair
                    System.Console.WriteLine("Volte sempre");
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida");
                    break;
                } 
            } while (opcaoDeslogado !=0);
        }
    }
}
