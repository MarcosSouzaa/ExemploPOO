using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Reflection.Metadata.Ecma335;
=======
>>>>>>> 1c531bba158a74f6af0429c1796de5af39d65938
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
<<<<<<< HEAD
        
        //Estou implementando o método Dividir aqui
        //Nesse caso, ele não precisará ser implementado na classe
        int Dividir(int num1, int num2)
        {
            return num1/num2;
        }
=======
        int Dividir(int num1, int num2);
>>>>>>> 1c531bba158a74f6af0429c1796de5af39d65938
    }
}