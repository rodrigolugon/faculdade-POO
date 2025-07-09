using System;
using System.Globalization;

namespace Classe01 {
    internal class Triangulo {
        public double A;
        public double B;
        public double C;

        //Metodo = funcao dentro da classe
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }









    }
}
