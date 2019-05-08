namespace Lixoso.Util
{
    public class MenuUtil
    {
        public static void Menu1(){
            System.Console.WriteLine("==============================================================");
            System.Console.WriteLine("    Seja Bem vindo ao lixão                                   ");
            System.Console.WriteLine("==============================================================");
            System.Console.WriteLine("    Escolha 1 opção:                                          ");
            System.Console.WriteLine("    1 - cadastre um lixo                                      ");
            System.Console.WriteLine("    2 - liste os lixos cadastrados e em qual lixeira pertencem");
            System.Console.WriteLine("    0 - sair                                                  ");
            System.Console.WriteLine("==============================================================");
        }

        public static void Menu2(){
            System.Console.WriteLine("============================================================");
            System.Console.WriteLine("     Escolha Uma Categoria:                                 ");
            System.Console.WriteLine("     1 - plástico                                           ");
            System.Console.WriteLine("     2 - metal                                              ");
            System.Console.WriteLine("     3 - vidro                                              ");
            System.Console.WriteLine("     4 - papel                                              ");
            System.Console.WriteLine("     5 - orgânico                                           ");
            System.Console.WriteLine("     6 - indefinido                                         ");
            System.Console.WriteLine("     0 - não sei, não quero saber e tenho raiva de quem sabe");
            System.Console.WriteLine("============================================================");
        }
    }
}