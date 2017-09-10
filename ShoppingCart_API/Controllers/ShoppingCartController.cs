using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart_API.Models;

namespace ShoppingCart_API.Controllers
{
    public class ShoppingCartController : ApiController
    {

        [Route("api/GetProducts")]
        [HttpGet]
        public List<Product> GetProducts()
        {
            ShoppingCartEntities1 db = new ShoppingCartEntities1();
            
            
            db.Configuration.ProxyCreationEnabled = false;

            return db.Products.ToList();
        }
        
    }
}
