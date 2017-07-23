using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TinyPubSubLib;
using TinyPubSubOrderDemo.Controllers;

namespace TinyPubSubOrderDemo.Observers
{
    public class BillingObserver : IObserver
    {
        public BillingObserver()
        {
            TinyPubSub.Subscribe(Topics.Orders, (x) => BillOrderCommand(x));
        }

        public void BillOrderCommand(string order)
        {
            Debug.WriteLine("Billed: " + order);
        }
    }
}
