using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        //construtor sem passar o nome
        public Pessoa()
        {
            
        }
        //Construtor passando nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; } 
        public string Email { get; set; }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos\n" +
                             $"e meu email é {Email}.\n");
        } 
    }
}