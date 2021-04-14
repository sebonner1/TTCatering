using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cartfunctions.addCart;
using Cartfunctions.removeCart;
using Cartfunctions.updateCart;
using Cartfunctions.getCart;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cartAPIController : ControllerBase
    {
        // GET: api/cartAPI
        //[EnableCors("AnotherPolicy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            iReadAllData readObject = new readData();
            return readObject.GetAllItems();
        }

        // GET: api/cartAPI/5
        //[EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/cartAPI
        //[EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
            iPostCart insertObject = new saveData();
            insertObject.InsertPost(value);
        }

        // PUT: api/cartAPI/5
        //[EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            iAddCart putObject = new addCart();
            putObject.addCartItem(id, value);
        }

        // DELETE: api/cartAPI/5
        //[EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iDelCart deleteObject = new delCart();
            deleteObject.DeleteCartItem(id);
            Console.WriteLien(id);
        }
    }
}
