using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   
    // Exemplo de classe selada
    // public sealed class Professor : Pessoa

    //professor herda de pessoa    
     public class Professor : Pessoa
       {
        public decimal Salario { get; set; }

        //construtor sem passar o nome
        public Professor()
        {
          
        }
        //como na minha classe Pessoa tenho um Construtor que passa o nome
        //tenho que criar um construtor aqui que passa o nome para Pessoa  
        public Professor(string nome) : base (nome)          
          {
            
          }  
           // Método selado não pode ser reescrito
           //public sealed override void Apresentar() 

           //com override pode ser rescrito nas outras classes
           public override void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos\n" +
                             $"e meu email é {Email}.\n");
        } 
       
      }        
    }
