using System;
using Senai.PastelStore.MVC.Repositorio;

namespace Senai.PastelStore.MVC.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio ();

        public static void CadastrarProduto(){
            string Nome;
            uint Preco;
            int contador = 0;
            for ( contador = 0; contador < 5; contador++)
            {
                
            do {
                System.Console.WriteLine ("Digite o nome do produto");
                Nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (Nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
                } while (!string.IsNullOrEmpty (Nome));
                {
                    System.Console.WriteLine("Digite o preço");
                    Preco = uint.Parse(Console.ReadLine());
                } 
            }
            }
        }

    }
