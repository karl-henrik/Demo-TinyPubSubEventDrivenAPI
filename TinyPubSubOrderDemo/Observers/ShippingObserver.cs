using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TinyPubSubLib;
using TinyPubSubOrderDemo.Controllers;

namespace TinyPubSubOrderDemo.Observers 
{
    public class ShippingObserver : IObserver
    {
        public ShippingObserver()
        {
            TinyPubSub.Subscribe(Topics.Orders, (x) => ShipOrderCommand(x));
        }

        private void ShipOrderCommand(string order)
        {
            Debug.WriteLine("Shipped :" + order);
        }
    }
}
