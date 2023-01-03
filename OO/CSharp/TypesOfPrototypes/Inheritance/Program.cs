using Inheritance.Clases;

Pessoa moradorPrimarioDaCasa = new Pessoa("Andre", "Soares Gomes", 22, new Endereco("Rua Alagoas 91", "Casa na praia"));
Console.WriteLine(moradorPrimarioDaCasa.ToString());
Console.WriteLine("--------------------------------------");

Pessoa filhoDoMoradorPrimario = new Pessoa();
moradorPrimarioDaCasa.CopiarPara(filhoDoMoradorPrimario);
filhoDoMoradorPrimario.Nome = "Alexsander";
filhoDoMoradorPrimario.Idade = 4;

Console.WriteLine(filhoDoMoradorPrimario.ToString());
