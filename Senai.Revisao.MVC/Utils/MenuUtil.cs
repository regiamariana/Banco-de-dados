using System;
namespace Senai.Revisao.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("  1 - Cadastrar Novo Usuário  ");
            System.Console.WriteLine("  2 - listar                  ");
            System.Console.WriteLine("  3 - Efetuar Login           ");
            System.Console.WriteLine("  0 - Sair                    ");
            System.Console.WriteLine("------------------------------");
            
        }
        public static void MenuLogado(){
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("  1 - Cadastrar Produto       ");
            System.Console.WriteLine("  2 - listar                  ");
            System.Console.WriteLine("  3 - Efetuar Login           ");
            System.Console.WriteLine("  0 - Sair                    ");
            System.Console.WriteLine("------------------------------");
            
        }
    }
}