namespace Senai.PastelStore.MVC.Utils
{
    public class ValidacoesUtil
    {
        /// <sumary> valida o email do usuario, verficca se o mesmo possui @ e .true , e contém ao menos 6 cararcteres <sumary>
        /// <param name= "email"> Email do usuario </param>
        /// /// <returns>Retorna true caso o email seja váido, caso contrário, retorna false</returns>
        public static bool ValidadorDeEmail (string email){
            if (email.Contains("@") && email.Contains(".") && email.Length>5)
            {
                return true;
            }
            return false;
        }
        public static bool ValidadorDeSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length >5)
            {
                return true;
            }
            return false;
        }
    }
}