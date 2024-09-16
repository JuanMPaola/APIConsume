using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Business
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public static List<Product> GetAll(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Product> list = client.Get<List<Product>>(request);
            return list;
        }
        public static Product GetById(string url, int id)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/{id}", Method.Get);
            Product product = client.Get<Product>(request);
            return product;
        }
    }
}
