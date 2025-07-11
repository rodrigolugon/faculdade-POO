using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Metodo01Ex02 {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        //Atento aqui
        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto * (1 + porcentagem/100);
        }

        //Digitar overrige espaço ToString + tab
        public override string ToString() {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}
