using TesteAPI.Model;

namespace TesteAPI.Validacoes.Interfaces
{
    public interface IValidarSenha
    {       
        string ChamarMetodosValidacao(Senha senha);
        void ValidarNumeroCaracteres(string senha);
        void ValidarDigitoMinimo(string senha);
        void ValidarLetraMinuscula(string senha);
        void ValidarLetraMaiuscula(string senha);
        void ValidarCaracterEspecial(string senha);        
    }
}
