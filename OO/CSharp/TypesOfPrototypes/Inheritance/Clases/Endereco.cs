using Inheritance.Interfaces;

namespace Inheritance.Clases
{
    public class Endereco : ICopiaDeValor<Endereco>
    {
        public Endereco()
        {

        }

        public Endereco(string enderecoPrimario, string enderecoSegundario)
        {
            EnderecoPrimario = enderecoPrimario;
            EnderecoSegundario = enderecoSegundario;
        }

        public string EnderecoPrimario { get; set; } = "";
        public string EnderecoSegundario { get; set; } = "";

        public void CopiarPara(Endereco objetoAlvo)
        {
            objetoAlvo.EnderecoPrimario = EnderecoPrimario;
            objetoAlvo.EnderecoSegundario = EnderecoSegundario;
        }

        public override string ToString()
        {
            return $"Endereco Primario {EnderecoPrimario}, EnderecoSegundario {EnderecoSegundario}";
        }
    }
}
