using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");

            int idade = 18;
            int pessoas = 2;
            //bool aconpanhado = pessoas >= 2;
            bool aconpanhado = true;
            // if (idade >= 18 || pessoas >= 2)
            //if (idade >= 18 && pessoas >= 2)
            if (idade >= 18 || aconpanhado == true)
            {
                Console.WriteLine("Max pode entrar.");
            }
            else
            {
                Console.WriteLine("Max nao pode entrar");
            }

            Console.ReadLine();
        }
    }
}
