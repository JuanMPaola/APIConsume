using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Business
{
    namespace Business
    {
        public class API
        {
            private string url = "https://fakestoreapi.com";
            public List<Product> GetAll()
            {
   

                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Get);
                List<Product> list = client.Get<List<Product>>(request);
                return list;
            }
            public Product GetById(int id)
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{id}", Method.Get);
                Product product = client.Get<Product>(request);
                return product;
            }
        }
    }
}
