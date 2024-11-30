using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //Aluno herda de pessoa
    public class Aluno: Pessoa
    {
        //construtor sem passar o nome
        public Aluno()
        {
            
        }
        //como na minha classe Pessoa tenho um Construtor que passa o nome
        //tenho que criar um construtor aqui que passa o nome para Pessoa   
        public Aluno(string nome) : base(nome)
        {
            
        }
        public int Nota { get; set; }
    }
}