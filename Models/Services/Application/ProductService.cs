using System;
using MyCourse.Models.Enums;
using MyCourse.Models.ValueObjects;
using WebApp.Models.ViewModels;

namespace WebApp.Models.Services.Application
{
    public class ProductService
    {
        internal List<ProductViewModel> GetServices()
        {
            List<ProductViewModel> productList = new();
        Random rand = new();
        for (int i = 1; i <= 20; i++)
        {
            decimal price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            ProductViewModel product = new()
            {
                Id = i,
                Title = $"Corso {i}",
                CurrentPrice = new Money(Currency.EUR, price),
                FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                Author = "Nome cognome",
                Rating = rand.Next(10, 50) / 10.0,
                ImagePath = "/logo.svg"
            };
            productList.Add(product);
        }
        return productList;
        }
    }
}