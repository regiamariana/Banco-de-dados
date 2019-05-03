using System;
namespace Senai.PastelStore.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){

           Console.WriteLine("-------------------------------------------");
           Console.WriteLine("-------------Pastelaria TKuaaa--------------");
           Console.WriteLine("-----------      Cadastro      -------------");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (1) Cadastrar usuário            ");
           Console.WriteLine("           (2) Login                        ");
           Console.WriteLine("           (3) listar usuários              ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (0) cadastrar produto            ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           Escolha uma opção                ");
       }
       /// <summary>
       /// Mostra as opções do usuário logado
       /// </summary>
       public static void MenuLogado(){
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("-------------Pastelaria paxteu--------------");
           Console.WriteLine("-----------      Cardápio      -------------");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (1) Cadastrar Produto            ");
           Console.WriteLine("           (2) Listar                       ");
           Console.WriteLine("           (3) buscar produto por ID        ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (0) Sair                         ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           Escolha uma opção                ");
       }
       public static void Cardapio(){
           Console.WriteLine("-----------      Cardápio      -------------");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (1) Carne 5 reais                ");
           Console.WriteLine("           (2) Queijo 5 reais               ");
           Console.WriteLine("           (3) Carne com queijo 6 reais     ");
           Console.WriteLine("--------------------------------------------");
       }
        }
    }
