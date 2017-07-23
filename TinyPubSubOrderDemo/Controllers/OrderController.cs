using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TinyPubSubLib;

namespace TinyPubSubOrderDemo.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "No orders for you!";
        }
        
        // POST api/values
        [HttpPost]
        public void Post()
        {
            TinyPubSub.Publish(Topics.Orders,"A little bit of event data");
        }
        
    }
}
