using System;
using System.Collections.Generic;
using Senai.Revisao.MVC.Repositorio;
using Senai.Revisao.MVC.Utils;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.ViewController {
    public class UsuarioViewController {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha;

            do {
                System.Console.WriteLine ("Digite o nome do usuário");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Digite um nome válido");
                }
            } while (string.IsNullOrEmpty (nome)); {
                do {
                    System.Console.WriteLine ("Digite o email do uuário");
                    email = Console.ReadLine ();
                    if (!ValidacaoUtil.ValidacaoEmail (email)) {
                        System.Console.WriteLine ("email inválido");
                    }

                } while (!ValidacaoUtil.ValidacaoEmail (email));
                {
                    do
                    {
                        System.Console.WriteLine("Digite a senha");
                        senha = Console.ReadLine();
                        System.Console.WriteLine("Confirme a senha");
                        confirmacaoSenha = Console.ReadLine();

                        if (!ValidacaoUtil.ValidacaoSenha(senha,  confirmacaoSenha))
                        {System.Console.WriteLine("a senha não confere");
                            
                        
                        }
                        
                    } while (!ValidacaoUtil.ValidacaoSenha(senha,  confirmacaoSenha));
                        {
                            UsuarioViewModel usuario = new UsuarioViewModel();

                            usuario.Nome = nome;
                            usuario.Email = email;
                            usuario.senha = senha;

                            usuarioRepositorio.Inserir(usuario);

                            System.Console.WriteLine("Cadastro efetuado com sucesso");
                    
                    }
                }
            }
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"id {item.Id} - Nome {item.Nome}");
                }
            }
        }
    }
}