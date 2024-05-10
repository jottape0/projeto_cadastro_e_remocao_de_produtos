using System.Globalization;

namespace TesteProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Models.Produto produto = new Models.Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
