using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   
    //professor herda de pessoa
     public class Professor : Pessoa
       {

        //construtor sem passar o nome
        public Professor()
        {
          
        }
        //como na minha classe Pessoa tenho um Construtor que passa o nome
        //tenho que criar um construtor aqui que passa o nome para Pessoa  
        public Professor(string nome) : base (nome)          
          {
            
          }  
        }        
    }
