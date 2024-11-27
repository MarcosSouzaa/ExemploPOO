// Exportando o Models com a classe
using System.Security.Authentication;
using ExemploPOO.Models;

//******* Criando um objeto p1 do tipo Pessoa estanciando aqui a classe aqui **********

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bob";
// p1.Idade = 20;

// p1.Apresentar();

//******* Criando o objeto ContaCorrente e estanciando a classe com o seu construtor

ContaCorrente c1 = new ContaCorrente(010056, 1000);

Console.WriteLine("Conta corrente Nº " + c1.NumeroConta + "\n");

 c1.Deposito(2000);
 c1.Sacar(4200);

