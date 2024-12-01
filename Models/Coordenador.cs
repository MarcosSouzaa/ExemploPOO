using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   
    //professor herda de pessoa
     public class Coordenador : Pessoa
       {

        //construtor sem passar o nome
        public Coordenador()
        {
          
        }
        //como na minha classe Pessoa tenho um Construtor que passa o nome
        //tenho que criar um construtor aqui que passa o nome para Pessoa  
        public Coordenador(string nome) : base (nome)          
          {
            
          }  
        }        
    }
