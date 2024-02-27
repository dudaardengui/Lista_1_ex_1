using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, SOMA;
            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            b = int.Parse(Console.ReadLine());
            SOMA = a + b;

            if (SOMA > 10)
            {
                SOMA = SOMA + 5;
                Console.WriteLine();
                Console.WriteLine(SOMA);
            }
            else
            {
                SOMA = SOMA - 7;
                Console.WriteLine();
                Console.WriteLine(SOMA);
            }
            Console.ReadKey();
        }
    }
}
