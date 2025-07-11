using System;

namespace Metodo01Ex01 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            //Chamar o metodo area
            double area = r.Area();
            Console.WriteLine("Area = " + area.ToString("F2"));

            //Chamando o metodo
            double perimetro = r.Perimetro();
            Console.WriteLine("Perimetro = " + perimetro.ToString("F2"));

            //Chmando o metodo
            double diagonal = r.Diagonal();
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2"));



        }
    }
}
