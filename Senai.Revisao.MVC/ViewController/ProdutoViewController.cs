using System;
using System.Collections.Generic;
using Senai.Revisao.MVC.Repositorio;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.ViewController
{
    public class ProdutoViewController
    {

        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        public static void CadastrarProduto(UsuarioViewModel usuario){
            string nome, descricao, categoria;
            float preco;

            System.Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();
            
            System.Console.WriteLine("digite a descrição do produto");
            descricao = Console.ReadLine();
            
            System.Console.WriteLine("Digite a categoria");
            categoria = Console.ReadLine();
            
            System.Console.WriteLine("digite o preço");
            preco = int.Parse(Console.ReadLine());

            ProdutoViewModel produto = new ProdutoViewModel();

            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Categoria = categoria;
            produto.Preco = preco;
            produto.IdResponsavel = usuario.Id;

            produtoRepositorio.Inserir(produto);

        }//fim cadastrar produto

        public static void Listar(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();

            foreach (var item in listaDeProdutos)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"ID: {item.Id} - Nome: {item.Nome} - Criador: {item.IdResponsavel}");
                }
            }

        }
    }
}