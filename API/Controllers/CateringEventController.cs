using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Cartfunctions.getCart;
using API.CateringEventFunctions;
using API.CateringEventFunctions.addEvent;
using API.CateringEventFunctions.getEvents;
using API.CateringEventFunctions.removeEvent;
using API.CateringEventFunctions.updateEvents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateringEventController : ControllerBase
    {
        // GET: api/CateringEvent
        [HttpGet]
        public List<CateringEvent> Get()
        {
            iReadAllEventData readEventObject = new readEventData();
            return readEventObject.GetAllItems();
        }

        // // GET: api/CateringEvent/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/CateringEvent
        [HttpPost]
        public void Post([FromBody] CateringEvent value)
        {
            Console.WriteLine(value);
            iPostEvent insertObject = new saveEventData();
            insertObject.UpdateEvent(value.orderID, value.orderPlaced, value.orderDate, value.fulfilledStatus, value.orderEventMethod, value.orderDescription);
        }

        // PUT: api/CateringEvent/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CateringEvent value)
        {
            iAddEvent putObject = new addEvent();
            putObject.addOrderEvent(value.orderID, value.orderPlaced, value.orderDate, value.fulfilledStatus, value.orderEventMethod, value.orderDescription);
        }

        // DELETE: api/CateringEvent/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iDelEvent deleteObject = new delEvent();
            deleteObject.DeleteOrderEvent(id);
            Console.WriteLine(id);
        }
    }
}
