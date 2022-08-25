using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebApp.Models.Services.Application;
using WebApp.Models.ViewModels;

namespace MvcMovie.Controllers
{
    public class ProductController : Controller
    {
    

        public IActionResult Detail(int id)
        {
            var productService = new ProductService();
            ProductDetailViewModel viewModel = productService.GetProduct(id);
            return View(viewModel);
        }

      
        public string Welcome(string name, int ID = 1)
            {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            }
    }
}