namespace FinancaDeMesa.Util
{
    public class MenuUtil
    {
        public static void MenuDeslogado (){
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Seja bem-vindo à MobiTec          ");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Escolha 1 opção:                  ");
            System.Console.WriteLine("           1 - cadastro de usuário           ");
            System.Console.WriteLine("           2 - login de usuário              ");
            System.Console.WriteLine("           0 - sair                          ");
            System.Console.WriteLine("=============================================");                                     
            System.Console.WriteLine("Código");
        } 

        public static void MenuLogado (){
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Seja bem-vindo à MobiTec          ");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Parabéns por se logar!            ");
            System.Console.WriteLine("           1 - cadastrar transações          ");
            System.Console.WriteLine("           2 - exibir transações totais      ");
            System.Console.WriteLine("           3 - relatar no Word               ");
            System.Console.WriteLine("           4 - exportar banco de dados       ");
            System.Console.WriteLine("           0 - sair                          ");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("Código");

        }

        public static void EscolhaTransacao (){
            System.Console.WriteLine("    Selecione o tipo de transação entre:   ");
            System.Console.WriteLine("    Digite Despesa                         ");
            System.Console.WriteLine("    Digite Receita                         ");
            System.Console.WriteLine("    0 - sair                               ");
            System.Console.WriteLine("Código                                     ");
        }
    }
}