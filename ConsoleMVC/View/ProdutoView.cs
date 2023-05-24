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
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}"); 
            }
        }
    }
}