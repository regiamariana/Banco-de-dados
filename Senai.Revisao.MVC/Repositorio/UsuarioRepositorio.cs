using System;
using System.Collections.Generic;
using System.IO;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.Repositorio
{
    public class UsuarioRepositorio
    {
        private object listaDeUsuarios;

        public UsuarioRepositorio()
        {
        }

        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            //aqui
            List<UsuarioViewModel> ListaDeUsuarios = Listar();
            int contador = 0;
            if (listaDeUsuarios != null)
            {
            contador = ListaDeUsuarios.Count;
                
            }
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            //gera um arquivo CSV

            StreamWriter sw = new StreamWriter("usuarios.csv", true);

            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.senha};{usuario.DataCriacao};");
            sw.Close();
            return usuario;


        }//fim inserir

        public List<UsuarioViewModel> Listar(){
            List<UsuarioViewModel> ListaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuario;
            if (!File.Exists("usuarios.csv"))
            {
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios)
            {
                if (item != null)
                {
                    
                string[] dadosDoUsuario = item.Split(";");
                usuario = new UsuarioViewModel();
                usuario.Id = int.Parse(dadosDoUsuario[0]);
                usuario.Nome = dadosDoUsuario[1];
                usuario.Email = dadosDoUsuario[2];
                usuario.senha = dadosDoUsuario[3];
                usuario.DataCriacao = DateTime.Parse(dadosDoUsuario[4]);

                ListaDeUsuarios.Add(usuario);
                }//fim if null
            }//fim foreach
             return ListaDeUsuarios;
        }// fim listar

        public UsuarioViewModel BuscarUsuario(string email, string senha){
            List <UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item != null)
                {
                    if (email.Equals(item.Email) && senha.Equals(item.senha))
                    {
                        return item;
                    }
                }
            }//fim foreach
            return null;
        }
    }
}