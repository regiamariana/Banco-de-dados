using System;
using Senai.Revisao.MVC.Utils;
using Senai.Revisao.MVC.ViewController;
using Senai.Revisao.MVC.ViewModel;

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
                    UsuarioViewController.ListarUsuario();
                    break;

                    case 3:
                    //Efetuar login
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null)
                    {
                        System.Console.WriteLine($"Bem vindo {usuarioRecuperado.Nome}");
                        
                        int opcaoLogado = 0;
                        do
                        {
                        MenuUtil.MenuLogado();
                        opcaoLogado = int.Parse(Console.ReadLine());

                        switch (opcaoLogado)
                        {
                            case 1:
                            //cadastrar produto
                            ProdutoViewController.CadastrarProduto(usuarioRecuperado);
                            break;

                            case 2:
                            //Listar produtos
                            break;

                            case 3:
                            //Buscar por id
                            break;

                            case 0:
                            //sair
                            System.Console.WriteLine("volty sempry");
                            break;

                            default:
                            System.Console.WriteLine("Opção inválida");
                            break;
                        }

                        } while (opcaoLogado != 0);
                    }
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
