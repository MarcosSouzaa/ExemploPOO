// Exportando o Models com a classe
using System.Security.Authentication;
using System.Security.Cryptography;
using ExemploPOO.Models;

//******* Criando um objeto p1 do tipo Pessoa estanciando a classe aqui **********

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bob";
// p1.Idade = 20;

// p1.Apresentar();

//******* Criando o objeto ContaCorrente e estanciando a classe com o seu construtor *********

// ContaCorrente c1 = new ContaCorrente(010056, 1000);

// Console.WriteLine("Conta corrente Nº " + c1.NumeroConta + "\n");

//  c1.Deposito(2000);
//  c1.Sacar(4200);

//******* Estanciando a Classe Aluno e a classe Professor *********

// Aluno a1 = new Aluno();

// a1.Nome = "João";
// a1.Idade = 20;
// a1.Email = "teste@teste.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor pr = new Professor();
// pr.Nome = "Gisele";
// pr.Idade = 50;
// pr.Email = "gisele@gmail.com";
// pr.Apresentar();

//******* Criando o objeto ContaCorrente que vai herdar da Classe Conta  *******

ContaCorrente cc = new ContaCorrente();
cc.Depositar(5000);
cc.ExibisSaldo();

