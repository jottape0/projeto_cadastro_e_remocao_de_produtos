using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public string AdicionarProdutos(int quantidade)
        //método que permite o usuário adicionar produtos no estoque. O metodo é void porque não retorna nada, apenas altera a Quantidade
        {
            try
            {
                if (quantidade > 0)
                {
                    Quantidade += quantidade;
                    return "Adicionado com sucesso";
                }
                else
                {
                    return "A quantidade deve ser um número inteiro e positivo.";
                }


            }
            catch (FormatException)
            {
                return "Erro!! Entre com um valor válido.";
            }


        }

        public string RemoverProdutos(int quantidade)
        //método que permite o usuario remover produtos no estoque desde que não exceda a quantidade
        {
            try
            {
                if (Quantidade >= quantidade)
                {
                    Quantidade -= quantidade;

                    return "Removido com sucesso";
                }
                else
                {
                    return "Erro!!. Quantidade superior ao que tem no estoque.";
                }
            }
            catch (FormatException)
            {
                return "Erro!! Entre com um valor válido.";
            }


        }
        public override string ToString()
        {
            return _nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

