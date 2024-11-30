using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   //Herdei a classe conta e ele pede para implementar
    //o método Depositar que é abstrato 
    public class ContaCorrente : Conta
    {
        public override void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}