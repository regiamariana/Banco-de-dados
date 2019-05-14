using System;

namespace FinancaDeMesa.Model
{
    public class UsuarioViewModel
    {

        public int Id {get; set;}
        public string Nome {get; set;}

        public string Email {get; set;}

        public string Senha {get; set;}

        public DateTime Data {get; set;}
    }
}