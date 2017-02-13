using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products=new Product[]{
            new Product{Id=1,Name="Tomatoes",Category="Groceries",Price=10},
            new Product{Id=2,Name="Yo-yo",Category="Toys",Price=75},
            new Product{Id=3,Name="Hammer",Category="Hardware",Price=300.50M}
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int Id)
        {
            var product = products.FirstOrDefault((p) => p.Id == Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
