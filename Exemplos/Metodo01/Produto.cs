using System.Globalization;

namespace Metodo01 {
    internal class Produto {

        //Criando classe atraves da UML
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        //retorna void = vai na caixa onde esta com 10 e altera esse valor
        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto (int quantidade) {
            Quantidade = Quantidade - quantidade;
        }


        public override string ToString() {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
