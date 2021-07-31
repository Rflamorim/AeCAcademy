using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressaoBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado a seguinte expressão: x + y + d + 5 * 77 + 8 - 10 * (8 / 3)

             Qual é o resultado da operação feita em algoritmo.
            */

            double varx, vary, vard, calc;

            Console.WriteLine("Olá, insira os valores de X, Y e D:\n");
            Console.WriteLine("Primeiro digite o valor de X: ");
            varx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora digite o valor de Y: ");
            vary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("E por último o valor de D: ");
            vard = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            /*
             * Simplicar a equação para evitar erro no calculo, separar * / de + -.
            */ 

            calc = varx + vary + vard + 616.000000001;

            Console.WriteLine("Segue o resultado da expressão com os valores inseridos: \n" + calc);
            Console.WriteLine("\nAté mais!");

            Console.ReadKey();
        }
    }
}
