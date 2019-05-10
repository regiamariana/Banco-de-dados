using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.Model;

namespace FinancaDeMesa.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            List<UsuarioViewModel> ListaDeUsuarios = null;
            /* int contador = 0;
            if (ListaDeUsuarios != null)
            {
                contador = ListaDeUsuarios.Count;
            }

            usuario.id = contador + 1; */

            StreamWriter arquivo = new StreamWriter("sw.csv", true);

            arquivo.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Data}");
            arquivo.Close();
            return usuario;


            //MÉTODO EM CONSTRUÇÃO!!!!!!!!!!!

            //VOLTR AQUI DPOIS
        

        }

        public List<UsuarioViewModel> TrazerListaDeUsuarios(){
            List<UsuarioViewModel> ListaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuario;

            //CRIAR ARQUIVO CSV


            //DEFINIR STRING DE USUARIOS POR LINHA

            //DEFINIR STRING DOS ITENS DE CAADA USUÁRIO

            return ListaDeUsuarios;
        }



    }
}