using System;
using System.Threading;
using FinancaDeMesa.Controller;
using FinancaDeMesa.Util;

namespace FinancaDeMesa {
    class Program {
        static void Main (string[] args) {
            int resposta = 0;
            do {
                Console.Clear ();
                MenuUtil.MenuDeslogado ();
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                        UsuarioViewController.CadastrarUsuario ();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 0:
                        System.Console.WriteLine ("Saindo...");
                        Thread.Sleep (2000);
                        break;

                    default:
                        System.Console.WriteLine ("Código inválido. Carregando opções...");
                        Thread.Sleep (2000);

                        break;
                }

            } while (resposta != 0);
        }
    }
}