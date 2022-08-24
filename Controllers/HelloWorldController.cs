using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebApp.Models.Services.Application;
using WebApp.Models.ViewModels;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            var productService = new ProductService();
            List<ProductViewModel> products = productService.GetServices();
            return View(products);
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
            {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            }
    }
}