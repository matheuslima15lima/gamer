using ConsoleMVC.Model;

namespace ConsoleMVC.View
{
    public class ProdutoView
    {
        // metodo para exibir os dados da lista console
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                
                
                Console.WriteLine($"Nome: {item.Nome}");
                
                
                Console.WriteLine($"Preço: {item.Preco:C}"); 
            }
        }

        public Produto cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"informe o código");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"informe o nome:");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"informe o preço:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
            
            
            
            
            
        }
    }
}