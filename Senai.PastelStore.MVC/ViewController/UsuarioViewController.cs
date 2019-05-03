using System;
using System.Collections.Generic;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.ViewController {
    public class UsuarioViewController {

        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;

            do {
                System.Console.WriteLine ("Digite o nome do usuário");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));
            do {
                System.Console.WriteLine ("Digite o e-mail");
                email = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeEmail (email)) {
                    System.Console.WriteLine ("Email inválido");
                }

            } while (!ValidacoesUtil.ValidadorDeEmail (email));

            do {
                System.Console.WriteLine ("Digite a senha");
                senha = Console.ReadLine ();

                System.Console.WriteLine ("Confirme a senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeSenha (senha, confirmaSenha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacoesUtil.ValidadorDeSenha (senha, confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //instanciar o repositório


            usuarioRepositorio.Inserir (usuarioViewModel);

            System.Console.WriteLine ("Usuário cadastrado com sucesso");
        } //fim cadastro usuário
        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                System.Console.WriteLine($"id: {item.Nome} - e-mail: {item.Email} - senha: {item.Senha} - Data de criação: {item.DataCriacao}");
            }
    }

    public static UsuarioViewModel EfetuarLogin(){
        string email, Senha;

        do
        {
            System.Console.WriteLine("digite o email");
            email = Console.ReadLine();

            if(!ValidacoesUtil.ValidadorDeEmail(email)){
                System.Console.WriteLine("Email inválido");
            }
            
        } while (!ValidacoesUtil.ValidadorDeEmail(email));

        System.Console.WriteLine("digite sua senha");
        Senha = Console.ReadLine();
        
        usuarioRepositorio.BuscarUsuario(email, Senha);

        UsuarioViewModel usuarioRetorno = usuarioRepositorio.BuscarUsuario(email, Senha);

        if(usuarioRetorno != null){

            return usuarioRetorno;
        }else{
            System.Console.WriteLine("usuário ou senha inválida");
            return null;
        }

    }//fim efetuar login


    }
    }