using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoVsKilo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Valkiria é uma empreendedora que vende produtos naturais, ela está querendo fazer um mini programa para vender lentilha
               Faça um programa que calcule, o valor da lentilha vs o preço do peso.
               Valor do peso da lentilha: 1,50 o KG.
               No final do programa, mostrar o valor total e quantos KG a pessoa selecionou, detalhe o pedido também pode ser vendido em gramas.
             */

            double KgLentilha, Calc, ValorLentilha;
            ValorLentilha = 1.50;

            Console.WriteLine("Olá, o valor do Kilo da lentilha custa R$1.50.\n");
            Console.WriteLine("Digite abaixo quanto kilos você deseja comprar:  ");
            KgLentilha = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Calc = ValorLentilha * KgLentilha;

            Console.Write("Foram: " + KgLentilha);
            Console.WriteLine(" Kilos.\n");
            Console.WriteLine("O valor final é de: R$" + Calc);

            Console.ReadKey();            
        }
    }
}
