using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{     
    //criei uma classe ContCorrente
    public class ContaCorrente
    {
        //e defini um construtor para classe. Quando eu estanciá-la eu
        //vou receber um número da conta e um saldo inicial 
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            //essa propriedade vai receber o número da conta 
            NumeroConta = numeroConta;
            //essa propriedade vai receber o saldo inicial
            saldo = saldoInicial;
        }
        //essa propriedade é do tipo pública que qualquer um pode ver
        public int NumeroConta { get; set; }

         //essa propriedade é do tipo privada e é bloqueada para alterações 
         //externas. Só a minha classe consegue alterar essa propriedade.
        private decimal saldo;

         public void Deposito(decimal valor)
      {
        saldo += valor;
        Console.WriteLine($"Valor do depósito R${valor},00\n");
        Console.WriteLine("Depósito realizado com sucesso!\n");
        Console.WriteLine($"Seu saldo atual é de R${saldo},00 ");   
      }
        
         // aqui foi criado um método público sacar que é uma maneira de alterar a 
         // propriedade privada saldo.
         // criado uma regra de negócio para só permitir o saque se o saldo for maior ou 
         // igual o valor que quero sacar.
         public void Sacar(decimal valor)
         {
          if(saldo >= valor)       
        {
            // saldo é igual a saldo menos valor
            saldo -= valor;

            Console.WriteLine($"Valor do saque R${valor},00");
            Console.WriteLine("Saque realizado com sucesso!\n");
            Console.WriteLine($"Seu saldo atual é de R${saldo},00 ");
        }else
        {
            Console.WriteLine($"Valor do saque R${valor},00\n");
            Console.WriteLine("Seu saldo é insuficiente, por favor\n" +
                            "tente um valor compatível com seu saldo!");
        }     
      }
      public void ExibirSaldo()
      {
        Console.WriteLine("Seu saldo disponível é: R$" + saldo +",00");                         
      }     
    }
}