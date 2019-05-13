using System;
using FinancaDeMesa.Model;
using FinancaDeMesa.Util;

namespace FinancaDeMesa.Controller {
    public class TransacaoViewController {
        public void CadastrarTransacao () {
            string tipoTransacao;
            string descricao;
            double valor;
            double confirmaValor;
            DateTime dataTransacao;
            

            MenuUtil.EscolhaTransacao ();
            int respTransacao = int.Parse (Console.ReadLine ());
            do {

                switch (respTransacao) {
                    case 1:
                        tipoTransacao = "Despesa";

                        break;

                    case 2:
                        tipoTransacao = "Receita";

                        break;

                    case 0:
                        System.Console.WriteLine ("Volte sempre");
                        tipoTransacao = null;

                        break;
                    default:
                        System.Console.WriteLine ("Digite algo válido");
                        tipoTransacao = null;
                        break;

                }
            } while (!tipoTransacao.Equals(null));
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
            
        }
    }
}