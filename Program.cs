﻿// Exportando o Models com a classe
using System.Security.Authentication;
using System.Security.Cryptography;
using ExemploPOO.Interfaces;
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

// ContaCorrente cc = new ContaCorrente();
// cc.Depositar(5000);
// cc.ExibisSaldo();

// //******* Usando Aluno e Professoar que herdam de Pessoa  *******
// Pessoa p2 = new Pessoa("Letícia");
// Professor pr1 = new Professor("Gisele");
// Aluno a2 = new Aluno("Fernanda");
// Diretor d1 = new Diretor("Marcos");
 
// p2.Apresentar();
// pr1.Apresentar();
// a2.Apresentar();
// d1.Apresentar();

// *********** Criando a classe Computador para mostrar a Class Object ***********

//Computador comp = new Computador();
//Se eu marcar um dos métodos que o obj chama e apertar F12
//Ele me mostra a implementação de todos métodos da classe mãe Object 
//Console.WriteLine(comp.ToString());

//**********Criando um objeto a partir da Classe que implementa uma interface

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10,20));
Console.WriteLine(calc.Multiplicar(9,5));
Console.WriteLine(calc.Dividir(81, 9));
Console.WriteLine(calc.Subtrair(81, 9));