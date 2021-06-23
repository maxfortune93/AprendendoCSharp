using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoEmOutrostiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

           double salario1;
            salario1 = 1200.50;

            int salarioEmInteiro1;
            salarioEmInteiro1 = (int)salario1; // para fazer a conversao de tipo numerico... colocar um dougle em int
            Console.WriteLine(salarioEmInteiro1);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();


         
            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores ate 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
