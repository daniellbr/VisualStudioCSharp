using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.ViewComponents
{
    [ViewComponent(Name ="Carrinho")]
    public class CarrinhoViewComponents : ViewComponent
    {
        public int itensCarrinho { get; set; }

        public CarrinhoViewComponents()
        {
            itensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(itensCarrinho);
        }
    }
}
