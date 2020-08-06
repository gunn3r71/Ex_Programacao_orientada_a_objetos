using System;
using System.Globalization;

namespace video_42
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto(); //esta váriavel costuma ser chamada váriavel composta
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);//Instanciando o produto com construtor personalizado

            Console.WriteLine("Dados do produto: " + p); //o c# já converte implicitamento o objeto p para string
            Console.WriteLine("Digite a quantidade de produtos a ser inserido: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("Digite a quantidade de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
