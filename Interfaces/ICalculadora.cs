using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        
        //Estou implementando o método Dividir aqui
        //Nesse caso, ele não precisará ser implementado na classe
        int Dividir(int num1, int num2)
        {
            return num1/num2;
        }
    }
}