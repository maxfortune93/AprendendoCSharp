using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idade = 17;
            int pessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("Max possui idade maior ou egale a 18. Pode entrar");
            }
            else
            {
                if (pessoas >= 2)
                {
                    Console.WriteLine("Max nao tem idade suficiente para entrar, mas esta aconpahnado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Max nao tem idade suficiente para entrar");
                }

            }

            Console.ReadLine();
        }
    }
}
