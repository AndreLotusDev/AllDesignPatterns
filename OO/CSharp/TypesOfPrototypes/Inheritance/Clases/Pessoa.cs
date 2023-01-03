using Inheritance.Interfaces;

namespace Inheritance.Clases
{
    public class Pessoa : ICopiaDeValor<Pessoa>
    {
        public string Nome { get; set; } = "";
        public string SobreNome { get; set; } = "";
        public int Idade { get; set; }
        public Endereco Endereco { get; set; } = new Endereco();
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobreNome, int idade, Endereco endereco)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Idade = idade;
            Endereco = endereco;
        }
        public void CopiarPara(Pessoa objetoAlvo)
        {
            objetoAlvo.Nome = Nome;
            objetoAlvo.SobreNome = SobreNome;
            objetoAlvo.Idade = Idade;

            Endereco.CopiarPara(objetoAlvo.Endereco);
        }

        public override string ToString()
        {
            return $"Nome {Nome}, Sobrenome {SobreNome}, Idade {Idade}, Endereco -> {Endereco.ToString()}";
        }
    }
}
