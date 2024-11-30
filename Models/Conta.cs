using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   
    //A classe abstrata não pode ser usada diretamente
    // Não consigo estanciar
    //serve apenas como modelo para ser herdada.
    public abstract class Conta
    {    
        //Atributos protegido contra alterações de classes externas,
        // com excessão das suas classes filhas
        //protected é como se fosse um private mais permissível
        protected decimal saldo;

        //Método abstrato que não recebe implementação
        //somente passo um valor para ele
        // ele não tem corpo: {}
        public abstract void Depositar(decimal valor);
        
        public void ExibisSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }
    } 
}