using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMVC.Model;

namespace ProductMVC.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista de produtos

        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:C2}");
                                
            }
        }
    }
}