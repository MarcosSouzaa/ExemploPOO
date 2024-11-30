using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //Aluno herda de pessoa
    public class Aluno: Pessoa
    {
        public int Nota { get; set; }
    }
}