using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.Model;

namespace FinancaDeMesa.Repositorio
{
    public class TransacaoRepositorio
    {
        public static TransacaoViewModel Inserir (TransacaoViewModel transacao) {
            
            /* int contador = 0;
            if (ListaDeUsuarios != null)
            {
                contador = ListaDeUsuarios.Count;
            }

            usuario.id = contador + 1; */

            StreamWriter arquivo = new StreamWriter ("vacilo.csv", true);

            arquivo.WriteLine ($"{transacao.TipoTransacao}; {transacao.Descricao}; {transacao.Valor}; {transacao.DataTransacao}");
            arquivo.Close ();
            return transacao;

            //MÉTODO EM CONSTRUÇÃO!!!!!!!!!!!

            //VOLTR AQUI DPOIS

        }

        public static List<TransacaoViewModel> TrazerListaDeTransacoes () {
            List<TransacaoViewModel> ListaDeTransacoes = new List<TransacaoViewModel> ();
            TransacaoViewModel transacao;
            string[] transacoes = File.ReadAllLines ("vacilo.csv");
            if (!File.Exists ("vacilo.csv")) {
                return null;
            }

            foreach (var item in transacoes) {
                if (item != null) {

                    string[] dadosDaTransacao = item.Split (";");
                    transacao = new TransacaoViewModel ();

                    transacao.Descricao = dadosDaTransacao[0];
                    transacao.Valor = double.Parse(dadosDaTransacao[1]);
                    transacao.TipoTransacao = dadosDaTransacao[2];
                    
                    transacao.DataTransacao = DateTime.Parse (dadosDaTransacao[3]);

                    ListaDeTransacoes.Add (transacao);
                } //fim if null
            } //fim foreach
            return ListaDeTransacoes;
        } // fim listar


        /* public static TransacaoViewModel TrazerTransacao (List<TransacaoViewModel> TrazerListaDeTransacoes){
            List<TransacaoViewModel> ListaDeTransacoes = TransacaoRepositorio.TrazerListaDeTransacoes();

            foreach (var item in ListaUsuarios)
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }return null; */
        }
    }
