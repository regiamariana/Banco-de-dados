using System;
using System.Threading;
using FinancaDeMesa.Controller;
using FinancaDeMesa.Model;
using FinancaDeMesa.Util;

namespace FinancaDeMesa {
    class Program {
        static void Main (string[] args) {
            int resposta = 0;
            bool querSair = false;
            do {
                Console.Clear ();
                MenuUtil.MenuDeslogado ();
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                        UsuarioViewController.CadastrarUsuario ();
                        break;

                    case 2:
                        

                        UsuarioViewModel UserRec = UsuarioViewController.LogarUsuario();
                        if (UserRec != null)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"         Bem Vindo {UserRec.Nome}!           ");
                            Console.ResetColor();
                            do
                            {
                                MenuUtil.MenuLogado();
                                resposta = int.Parse(Console.ReadLine());
                                switch (resposta)
                                {
                                    case 1:
                                        //Cadastrar transações
                                        TransacaoViewController.CadastrarTransacao();
                                        break;
                                    case 2:
                                        //Exibir Transações Total - infos dee cada Transação
                                        break;
                                    case 3:
                                        //Relatar no word
                                        break;
                                    case 4:
                                        //Exportar Banco de Dados
                                        break;
                                        
                                    case 0:
                                        System.Console.WriteLine("Saindo..");
                                        Thread.Sleep(2000);
                                        querSair = true;
                                        break;
                                    default:
                                        System.Console.WriteLine("Código inválido.. ");
                                        Thread.Sleep(2000);
                                        querSair = false;
                                        break;
                                }
                            } while (!querSair);
                        }
                        else
                        {
                            continue;
                        }
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