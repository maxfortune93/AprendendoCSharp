using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double valorInvestido = 1000;
            double fatotRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatotRendimento;
                }
                    fatotRendimento += 0.0010;
            }
            Console.WriteLine("O seu beneficio é R$ " + valorInvestido);

             Console.ReadLine();
        }
    }
}
