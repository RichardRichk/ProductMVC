using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMVC.Model;
using ProductMVC.View;

namespace ProductMVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto Produto e ProdutoView
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();


        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }
    }
}