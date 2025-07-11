using System;

namespace Metodo01Ex02 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f );

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            int porcentagem = int.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + f);


        }
    }
}
