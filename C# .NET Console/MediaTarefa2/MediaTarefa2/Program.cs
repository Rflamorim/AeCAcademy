using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTarefa2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeAluno, NomeAluno1, NomeAluno2, NomeAluno3;

            double nota1, nota2, nota3, media;
            double Anota1, Anota2, Anota3, Amedia;
            double Bnota1, Bnota2, Bnota3, Bmedia;
            double Cnota1, Cnota2, Cnota3, Cmedia;

            Console.Write("Olá, seja bem-vindo a calculadora de média escolar da AeC Academy 2021.\n");
            Console.WriteLine("\nDigite o nome do Aluno: ");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("Agora digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.Clear();

            Console.WriteLine("Digite o nome do segundo Aluno: ");           
            NomeAluno1 = Console.ReadLine();

            Console.WriteLine("Agora digite a primeira nota: ");
            Anota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            Anota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            Anota3 = Convert.ToDouble(Console.ReadLine());

            Amedia = (Anota1 + Anota2 + Anota3) / 3;

            Console.Clear();

            Console.WriteLine("Digite o nome do terceiro Aluno: ");
            NomeAluno2 = Console.ReadLine();

            Console.WriteLine("Agora digite a primeira nota: ");
            Bnota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            Bnota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            Bnota3 = Convert.ToDouble(Console.ReadLine());

            Bmedia = (Bnota1 + Bnota2 + Bnota3) / 3;

            Console.Clear();

            Console.WriteLine("Digite o nome do quarto Aluno: ");
            NomeAluno3 = Console.ReadLine();

            Console.WriteLine("Agora digite a primeira nota: ");
            Cnota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            Cnota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            Cnota3 = Convert.ToDouble(Console.ReadLine());

            Cmedia = (Cnota1 + Cnota2 + Cnota3) / 3;

            Console.Clear();

            Console.WriteLine("Segue a média de todos alunos inscritos: \n");

            Console.WriteLine("O Aluno: " + NomeAluno);
            Console.WriteLine("Tem nota média de: " + media);
            Console.WriteLine("O Aluno: "+NomeAluno1);
            Console.WriteLine("Tem nota média de: " + Amedia);
            Console.WriteLine("O Aluno: "+NomeAluno2);
            Console.WriteLine("Tem nota média de: " + Bmedia);
            Console.WriteLine("O Aluno: " + NomeAluno3);
            Console.WriteLine("Tem nota média de: " + Cmedia);

            Console.ReadKey();
        }
    }
}
