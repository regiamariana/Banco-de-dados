using System;

namespace FinancaDeMesa.Model
{
    public class TransacaoViewModel
    {

        
        public string TipoTransacao {get;set;}
        
        public string Descricao {get; set;}

        public DateTime DataTransacao {get; set;}

        public double Valor {get; set;}
    }
}