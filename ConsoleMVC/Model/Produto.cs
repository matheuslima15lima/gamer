using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        

        
      //camiho da pasta e do arquivo csv
      private const string PATH = "Database/Produto.csv";

      public Produto()
      {
        // criar a lógica para gerar a pasta e o arquivo
        // obter o caminho para pasta
        string pasta = PATH.Split("/")[0];

          //verificar se no caminho ja existe uma pasta
        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        // verificar se no caminho ja existe um arquivo
        if(!File.Exists(PATH))
        {
            File.Create(PATH);
        }
      } 



     //metodo para ler os dados do arquivo csv
      public List<Produto> Ler()
      {
        List<Produto> produtos = new List<Produto>();
        string[] linhas = File.ReadAllLines(PATH);


        foreach (var item in linhas)
        {
            //separacao de atributos de cada linha
            string[] atributos = item.Split(";");

            //instancia de produto
            Produto p = new Produto();

            // atribuicao de valores dentro do objeto
            p.Codigo = int.Parse(atributos[0]);
            p.Nome = atributos[1];
            p.Preco = float.Parse(atributos[2]);

            produtos.Add(p);
        }
        //retorna lista de produtos
        return produtos;
      }

      // metodo para preparar as linhas  serem inseridas no csv

      public string PrepararLinhasCSV(Produto p)
      {
        return $"{p.Codigo};{p.Nome};{p.Preco}"; //1020;Coca Zero;6,5
      }

      public void inserir (Produto p)
      {
        //array que armazena as linhas obtidas pelo metodo 
        string[] linhas = {PrepararLinhasCSV(p)};

      //inserir todas as linhAS no arquivo dentro do Path
        File.AppendAllLines(PATH, linhas);
      }
    }
}