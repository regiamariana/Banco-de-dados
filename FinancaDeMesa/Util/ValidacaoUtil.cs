namespace FinancaDeMesa.Util {
    public class ValidacaoUtil {
        public static bool ValidacaoEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }

        public static bool ValidacaoSenha (string senha, string confirmaSenha) {
            if (senha.Equals (confirmaSenha) && senha.Length >= 6) {
                return true;
            }
            return false;
        }

        public static bool ValidacaoValor (double valor, double confirmaValor){
            if(valor.Equals (confirmaValor)){
                return true;
            }return false;
        }
    }
}