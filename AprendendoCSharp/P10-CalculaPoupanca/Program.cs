using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10");

            double valorInvestido = 1000;
            int contadorMes = 1;

            //0.36% = 0.0036
            while (valorInvestido <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("O seu beneficio no mês " + contadorMes + " é R$ " + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
