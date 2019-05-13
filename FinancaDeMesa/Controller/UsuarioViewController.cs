using System;
using System.Collections.Generic;
using System.Threading;
using FinancaDeMesa.Model;
using FinancaDeMesa.Repositorio;
using FinancaDeMesa.Util;

namespace FinancaDeMesa.Controller {
    public class UsuarioViewController {

        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha;

            do {
                System.Console.WriteLine ("Digite o seu nome completo");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Digite um nome válido");
                }
            } while (string.IsNullOrEmpty (nome));
            do {
                System.Console.WriteLine ("Digite seu e-mail");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidacaoEmail (email)) {
                    System.Console.WriteLine ("Digite um e-mail válido");
                    Thread.Sleep (2000);
                }
            } while (!ValidacaoUtil.ValidacaoEmail (email));

            do {
                System.Console.WriteLine ("Digite a senha de 6 caracteres por favor");
                senha = Console.ReadLine ();
                System.Console.WriteLine ("Confirme a senha");
                confirmacaoSenha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidacaoSenha (senha, confirmacaoSenha)) {
                    System.Console.WriteLine ("a senha não confere");

                }

            } while (!ValidacaoUtil.ValidacaoSenha (senha, confirmacaoSenha));

            UsuarioViewModel usuario = new UsuarioViewModel ();

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.Data = DateTime.Now;

            //INSERIR USUÁRIO
            usuarioRepositorio.Inserir (usuario);

            //INSERIR USUÁRIO

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Cadastro realizado com sucesso");
            Console.ResetColor ();

        }

        public static UsuarioViewModel LogarUsuario () {
            string email, senha;
            do {
                System.Console.Write ("Digite seu email: ");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidacaoEmail (email)) {
                    System.Console.WriteLine ("Email Inválido..");
                    Thread.Sleep (1200);
                }
            } while (!ValidacaoUtil.ValidacaoEmail (email));
            System.Console.Write ("Digite sua senha: ");
            senha = Console.ReadLine ();
            UsuarioViewModel UserRecuperado = UsuarioRepositorio.TrazerUserLogado (email, senha);
            if (UserRecuperado != null) {
                return UserRecuperado;
            } else {
                return null;
            }
        }

    }
}