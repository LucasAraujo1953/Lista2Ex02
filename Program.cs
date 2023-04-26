using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Entre com dois valores quaisquer: ");
            Console.Write("De o primeiro Valor: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b=int.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("Os valores são iguais");
            else
                if (a > b)
                Console.WriteLine("O primeiro valor é o maior");
            else
                Console.WriteLine("O segundo valor é o maior");

        }
    }
}
