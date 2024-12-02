using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{//Implementando a interface ICalculadora 
    public class Calculadora : ICalculadora
    {
<<<<<<< HEAD
=======
        public int Dividir(int num1, int num2)
        {
            return num1/num2;
        }
>>>>>>> 1c531bba158a74f6af0429c1796de5af39d65938

        public int Multiplicar(int num1, int num2)
        {
             return num1*num2;
        }

        public int Somar(int num1, int num2)
        {
             return num1+num2;
        }

        public int Subtrair(int num1, int num2)
        {
             return num1-num2;
        }
    }
}