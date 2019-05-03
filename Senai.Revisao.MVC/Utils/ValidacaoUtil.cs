namespace Senai.Revisao.MVC.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidacaoEmail(string email){
            if (email.Contains("@") && email.Contains(".")){
                return true;
            } return false;
        }

        public static bool ValidacaoSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha)){
                return true;
            }return false;
            
        }
    }
}