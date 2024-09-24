using Business;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class APIConnection
    {
        RestClient cliente;

        public APIConnection(string url)
        {
            cliente = new RestClient("https://fakestoreapi.com");
        }

        public List<Product> GetProducts()
        {
            var request = new RestRequest("products", Method.Get);
            List<Product> products = cliente.Get<List<Product>>(request);
            return products;
        }

        public Product GetById(string url, int id)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/{id}", Method.Get);
            Product product = client.Get<Product>(request);
            return product;
        }
    }
}
