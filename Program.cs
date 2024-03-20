using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A OPÇÃO A SEGUIR");

            Console.WriteLine("1 -MÉDIA GEOMETRICA");

            Console.WriteLine("2 -MÉDIA PONDERADA");

            Console.WriteLine("3 -MÉDIA HARMÔNICA");

            Console.WriteLine("4 -MÉDIA ARITIMÉDICA");

            int w = int.Parse(Console.ReadLine());

            if (w == 0)
            {
                Console.WriteLine("OPÇÃO INVÁLIDA ");
            }
            else if (w == 1)
            {

                Console.WriteLine("1 -MÉDIA GEOMETRICA ");
                Console.WriteLine("Digite o valor do X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Z");
                int z = int.Parse(Console.ReadLine());

                double resultado = Math.Sqrt(x * y * z);
                Console.WriteLine(" MÉDIA GEOMETRICA -------" + resultado);
            }
            else if (w == 2)
            {
                Console.WriteLine("2 -MÉDIA PONDERADA ");
                Console.WriteLine("Digite o valor do X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Z");
                int z = int.Parse(Console.ReadLine());
                double resultadop = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine("MÉDIA PONDERADA --------" + resultadop);
            }
            else if (w == 3)
            {
                Console.WriteLine("3 -MÉDIA HARMÔNICA");
                Console.WriteLine("Digite o valor do X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Z");
                int z = int.Parse(Console.ReadLine());
                double resultadoh = 1 / (1 / x + 1 / y + 1 / z);
                Console.WriteLine("MÉDIA HARMÔNICA------" + resultadoh);


            }
            else if (w == 4)
            {
                Console.WriteLine("4 -MÉDIA ARITIMÉDICA");
                Console.WriteLine("Digite o valor do X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Z");
                int z = int.Parse(Console.ReadLine());
                double resultadoa = (x + y + z) / 3;
                Console.WriteLine("MÉDIA ARITIMÉDICA------" + resultadoa);
            }
            else
            {
                Console.WriteLine("OPÇÃO INVÁLIDA");
            }
            Console.ReadKey();





        }

    }
}