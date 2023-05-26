using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleMVC.Model;
using ConsoleMVC.View;

namespace ConsoleMVC.Controller
{
    public class ProdutoController
    {
        //instancia de classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();

            // chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
            Produto novoProduto = produtoView.cadastrar();

            produto.inserir(novoProduto);




            




            // Console.WriteLine($"informe o código:");
            // produto.Codigo = int.Parse(Console.ReadLine());

            // Console.WriteLine($"informe o nome:");
            // produto.Nome = Console.ReadLine();
            
            // Console.WriteLine($"informe o preço:");
            // produto.Preco = float.Parse(Console.ReadLine());
            
        }
    }
}