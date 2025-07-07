/*Fazer um programa para ler nome e salário de dois funcionários.
 * Depois, mostrar o salário médio dos funcionários.*/
using System;

namespace Classe01Ex02 {
    internal class Program {
        static void Main(string[] args) {

            //instanciacao
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            //Em C#, você pode declarar e já atribuir o valor na mesma linha.
            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Media: " + media.ToString("F2"));

        }
    }
}
