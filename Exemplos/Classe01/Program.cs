﻿// Resolvendo um problema sem orientacao a objetos
using System;
using System.Globalization;

namespace Classe01 {
    internal class Program {
        static void Main(string[] args) {

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medida do triangulo X: ");
            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medida do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p-xA) * (p-xB) * (p-xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p-yA) * (p-yB) * (p-yC));

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de x = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior area: X");
            } else {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
