using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.Model;
using Spire.Doc;
using Spire.Doc.Documents;

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

            StreamWriter arquivo = new StreamWriter ("transacoes.csv", true);

            arquivo.WriteLine ($"{transacao.TipoTransacao}; {transacao.Descricao}; {transacao.Valor}; {transacao.DataTransacao}");
            arquivo.Close ();
            return transacao;

            //MÉTODO EM CONSTRUÇÃO!!!!!!!!!!!

            //VOLTR AQUI DPOIS

        }

        public static List<TransacaoViewModel> TrazerListaDeTransacoes () {
            List<TransacaoViewModel> ListaDeTransacoes = new List<TransacaoViewModel> ();
            TransacaoViewModel transacao;
            string[] transacoes = File.ReadAllLines ("transacoes.csv");
            if (!File.Exists ("transacoes.csv")) {
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

        public static void GerarDocWord(){
            Document doc = new Document();
            Section section = doc.AddSection();
            Paragraph Paragrafo = section.AddParagraph();
            var ListaUser = UsuarioRepositorio.TrazerListaDeUsuarios();
            UsuarioViewModel usuario = new UsuarioViewModel();
            var transacao = new TransacaoViewModel ();
            Paragrafo.AppendText("                                                                 Relatório das Minhas Transações                                                  ");
            // foreach (var item in ListaUser)
            // {
            //     if (item.Email.Equals(DadosUserLogado.Email) && item.Senha.Equals(DadosUserLogado.Senha) && item != null)
            //     {
                    //Escrever relatório das transações do user
                    foreach (var user in ListaUser)
                    {
                        if (user.Id.Equals(transacao.IdUsuarioCriador) && user != null)
                        {
                            Paragrafo.AppendText($"Id Usuário Criador: {transacao.IdUsuarioCriador} - Tipo da Transação: {transacao.TipoTransacao} - Descrição: {transacao.Descricao} - Valor: {transacao.Valor} - Data da Transação: {transacao.DataTransacao}");
                        }
                    }
            //     }
            // }
           
            Paragrafo.AppendText("");
            doc.SaveToFile("ExtratoTransações.docx", FileFormat.Docx);
        }

        /* public static TransacaoViewModel TrazerTransacao (List<TransacaoViewModel> TrazerListaDeTransacoes){
            List<TransacaoViewModel> ListaDeTransacoes = TransacaoRepositorio.TrazerListaDeTransacoes();

            foreach (var  in ListaUsuarios)
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }return null;*/
        }
    }
