using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business
{
    public class APIConnection
    {
        RestClient _client;
        public APIConnection()
        {
            string url = ConfigurationManager.AppSettings["urlApi"];
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
        public List<string> GetAllCategories()
        {
            var request = new RestRequest($"products/categories");
            List<string> categories = _client.Get<List<string>>(request);
            return categories;
        }
        public List<Product> GetInCategory(List<Product> apiProducts, string selectedCategory)
        {
            var request = new RestRequest($"products/category/${selectedCategory}");
            List<Product> categoryProducts = _client.Get<List<Product>>(request);
            return apiProducts.Where(p => p.Category == selectedCategory).ToList();
        }
        public Product PostProudct(Product product)
        {
            var request = new RestRequest("products", Method.Post);
            request.AddJsonBody(product);
            return _client.Post<Product>(request);
        }
        public Product PutProduct()
        {
            return new Product();
        }
        public Product DeleteProduct(int id)
        {
            var request = new RestRequest($"products/{id}", Method.Delete);
            var response = _client.Execute(request);
            return JsonSerializer.Deserialize<Product>(response.Content);
        }
    }
}

