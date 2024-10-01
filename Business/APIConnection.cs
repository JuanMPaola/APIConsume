using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class APIConnection
    {
        RestClient _client;
        public APIConnection()
        {
            string url = "https://fakestoreapi.com";
            _client = new RestClient(url);
        }

        public List<Product> GetAll()
        {
            var request = new RestRequest("products", Method.Get);
            List<Product> list = _client.Get<List<Product>>(request);
            return list;
        }
        public Product GetById(int id)
        {
            var request = new RestRequest($"products/{id}", Method.Get);
            Product product = _client.Get<Product>(request);
            return product;
        }
        public List<Product> LimitResults(int limit)
        {
            var request = new RestRequest($"products?limit={limit}");
            List<Product> limitList = _client.Get<List<Product>>(request);
            return limitList;
        }
        public List<Product> SortResults(string order)
        {
            var request = new RestRequest($"products?sort={order}");
            List<Product> orderList = _client.Get<List<Product>>(request);
            return orderList;
        }
        public string[] GetAllCategories()
        {
            return new string[1];
        }
        public string GetInCategory()
        {
            return "";
        }
        public Product PostProudct(Product product)
        {
            var request = new RestRequest("products", Method.Post);
            return _client.Post<Product>(request);
        }
        public Product PutProduct()
        {
            return new Product();
        }
        public Product DeleteProduct() 
        {
            return new Product();
        }



    }
}

