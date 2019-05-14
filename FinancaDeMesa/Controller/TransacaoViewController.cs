using System;
using FinancaDeMesa.Model;
using FinancaDeMesa.Repositorio;
using FinancaDeMesa.Util;


namespace FinancaDeMesa.Controller {
    public class TransacaoViewController {
        public static void CadastrarTransacao () {
            string descricao;
            double valor;
            double confirmaValor;
            string tipoTransacao;


            MenuUtil.EscolhaTransacao ();
            tipoTransacao = Console.ReadLine();

            if (tipoTransacao == "Despesa"+ "Receita")
            {

            do {

                System.Console.WriteLine ("Digite um valor");
                valor = double.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Confirme o valor");
                confirmaValor = double.Parse (Console.ReadLine ());
            } while (!ValidacaoUtil.ValidacaoValor (valor, confirmaValor));
            do
            {
                
            System.Console.WriteLine("Descreva sua transação");
            descricao = Console.ReadLine();
            if (String.IsNullOrEmpty (descricao)){
                System.Console.WriteLine("Insira algo válido");
            } }
            while (string.IsNullOrEmpty(descricao));

            TransacaoViewModel transacao = new TransacaoViewModel ();

            transacao.Descricao = descricao;
            transacao.Valor = valor;
            transacao.TipoTransacao = tipoTransacao;
            transacao.DataTransacao = DateTime.Now;

            //INSERIR USUÁRIO
            TransacaoRepositorio.Inserir(transacao);

            //INSERIR USUÁRIO

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Cadastro realizado com sucesso");
            Console.ResetColor ();
            
            }else if(tipoTransacao != "Despesa" + "Receita")
            {
                System.Console.WriteLine("Volte sempre");

            }
            }

            

           

        
    }
}