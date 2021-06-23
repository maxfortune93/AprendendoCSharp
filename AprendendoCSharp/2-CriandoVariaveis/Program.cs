using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 20;
            Console.WriteLine(idade);

            idade = 20 + 32;
            Console.WriteLine(idade);

            idade = 20 + 4 * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

        }
    }
}
