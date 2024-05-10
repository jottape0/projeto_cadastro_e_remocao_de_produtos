//using System;
//using System.Globalization;


//namespace TesteProduto
//{
//    internal class Produto
//    {
//        private string _nome;
//        public double Preco { get; private set; }
//        public int Quantidade { get; private set; }

//        public Produto()
//        {

//        }
//        public Produto(string nome, double preco, int quantidade)
//        {
//            this._nome = nome;
//            this.Preco = preco;
//            this.Quantidade = quantidade;
//        }

//        public string Nome
//        {
//            get { return _nome; }
//            set
//            {
//                if (value != null && value.Length > 1)
//                {
//                    _nome = value;
//                }
//            }
//        }
//        public double ValorTotalEmEstoque()
//        {
//            return Preco * Quantidade;
//        }

//        public void AdicionarProdutos(int quantidade)
//        //método que permite o usuário adicionar produtos no estoque. O metodo é void porque não retorna nada, apenas altera a Quantidade
//        {
//            {
//                Quantidade += quantidade;
//            }
//        }

//        public void RemoverProdutos(int quantidade)
//        //método que permite o usuario remover produtos no estoque desde que não exceda a quantidade
//        {
//           if (Quantidade >= quantidade)
//            {
//                Quantidade -= quantidade;
//            }
//            else
//            {
//                Console.WriteLine("Remoção inválida. Quantidade superior ao que tem no estoque.");
//            }
            
//        }
//        public override string ToString()
//        {
//            return _nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
//                + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
//        }
//    }
//}
