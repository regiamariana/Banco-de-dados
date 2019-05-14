using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.Model;

namespace FinancaDeMesa.Repositorio {
    public class UsuarioRepositorio {
        public UsuarioViewModel Inserir (UsuarioViewModel usuario)
        {

            int contador = 0;
            if (TrazerListaDeUsuarios() != null)
            {
                contador = TrazerListaDeUsuarios().Count;
            }

            usuario.Id = contador + 1;

            using (var arquivo = new StreamWriter("usuarios.csv", true))
            {
                arquivo.WriteLine($" {usuario.Id} ;{usuario.Nome}; {usuario.Email}; {usuario.Senha}; {usuario.Data};");
                arquivo.Close();
            }
            return usuario;

            //MÉTODO EM CONSTRUÇÃO!!!!!!!!!!!

            //VOLTR AQUI DPOIS

        }

        public static List<UsuarioViewModel> TrazerListaDeUsuarios () {
            List<UsuarioViewModel> ListaDeUsuarios = new List<UsuarioViewModel> ();
            UsuarioViewModel usuario;
            string[] usuarios = File.ReadAllLines("usuarios.csv");
            if (!File.Exists ("usuarios.csv")) {
                return null;
            }

            foreach (var item in usuarios) {
                if (item != null) {

                    string[] dadosDoUsuario = item.Split (";");
                    usuario = new UsuarioViewModel ();
                    usuario.Id = int.Parse(dadosDoUsuario[0]);
                    usuario.Nome = dadosDoUsuario[1];
                    usuario.Email = dadosDoUsuario[2];
                    
                    usuario.Senha = dadosDoUsuario[3];
                    usuario.Data = DateTime.Parse (dadosDoUsuario[4]);

                    ListaDeUsuarios.Add (usuario);
                } //fim if null
            } //fim foreach
            return ListaDeUsuarios;
        } // fim listar

        public static UsuarioViewModel TrazerUserLogado (string email, string senha){
            List<UsuarioViewModel> ListaUsuarios = UsuarioRepositorio.TrazerListaDeUsuarios();

            foreach (var item in ListaUsuarios)
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }return null;
        }

    }

}