using System.Text;
using System.Text.RegularExpressions;
using TesteAPI.Model;
using TesteAPI.Validacoes.Interfaces;

namespace TesteAPI.Validacoes.Implementacoes
{
    public class ValidarSenha : BaseValidacao, IValidarSenha
    {
        StringBuilder mensagem = new StringBuilder();
        public string ChamarMetodosValidacao(Senha senha)
        {            
            ValidarCaracterEspecial(senha.Valor);
            ValidarDigitoMinimo(senha.Valor);
            ValidarLetraMaiuscula(senha.Valor);
            ValidarLetraMinuscula(senha.Valor);
            ValidarNumeroCaracteres(senha.Valor);

            if (string.IsNullOrEmpty(mensagem.ToString())) mensagem.Append("Senha OK");

            return mensagem.ToString();
        }

        public void ValidarCaracterEspecial(string senha)
        {
            var hasSpecialChar = new Regex(@"[!@#$%^&*()-+]");
            this.HasSpecial = hasSpecialChar.IsMatch(senha);

            if (!this.HasSpecial)
                mensagem.Append("É necessário ao menos um caracter especial/");
        }

        public void ValidarDigitoMinimo(string senha)
        {
            var hasNumber = new Regex(@"[0-9]+");
            this.HasNumber = hasNumber.IsMatch(senha);

            if (!this.HasNumber)
                mensagem.Append("É necessário ao menos um digito numérico/");
        }

        public void ValidarLetraMaiuscula(string senha)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            this.HasUpperChar = hasUpperChar.IsMatch(senha);

            if (!this.HasUpperChar)
                mensagem.Append("É necessário ao menos uma letra Maiuscula/");
        }

        public void ValidarLetraMinuscula(string senha)
        {
            var hasLower = new Regex(@"[a-z]+");
            this.HasLower = hasLower.IsMatch(senha);

            if (!this.HasLower)
                mensagem.Append("É necessário ao menos uma letra Minuscula/");
        }

        public void ValidarNumeroCaracteres(string senha)
        {
            var hasMinimum9Chars = new Regex(@".{9,}");
            this.HasMinimum9Chars = hasMinimum9Chars.IsMatch(senha);

            if (!this.HasMinimum9Chars)
                mensagem.Append("A senha precisa conter no mínimo 9 caracteres/");
        }
    }
}
