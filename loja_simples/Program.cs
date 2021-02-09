using System;
using System.Globalization;

namespace loja_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estouque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados inseridos: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " +p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atalizados: " + p);
            /* double? x = null;
             double? y = 10.0;

             Console.WriteLine(x.GetValueOrDefault());
             Console.WriteLine(y.GetValueOrDefault());

             Console.WriteLine(x.HasValue);
             Console.WriteLine(y.HasValue);

             if(x.HasValue)
                 Console.WriteLine(x.Value);
             else
                 Console.WriteLine("X is null");
             if(y.HasValue)
                 Console.WriteLine(y.Value);
             else
                 Console.WriteLine("Y is null");
 */
        }
    }
}
