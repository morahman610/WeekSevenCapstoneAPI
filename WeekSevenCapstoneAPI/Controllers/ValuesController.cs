using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeekSevenCapstoneAPI.Models;


namespace WeekSevenCapstoneAPI.Controllers
{
    public class ValuesController : ApiController
    {
        NORTHWNDEntities northwind = new NORTHWNDEntities();

        // GET api/values
        public ArrayList GetProduct()
        {
            Product[] products = new Product[northwind.Products.Count()];
            ArrayList productNameID = new ArrayList();

            foreach (Product p in northwind.Products)
            {
                string NameID = p.ProductID + " " + p.ProductName;
                productNameID.Add(NameID);
            }

            return productNameID;
        }

        public List<Product> GetProduct(int id)
        {
            List < Product > products = (from p in northwind.Products
                                where p.ProductID == id
                                select p).ToList();
            return products;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
