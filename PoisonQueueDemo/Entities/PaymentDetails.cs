using System;
using System.Collections.Generic;
using System.Text;

namespace PoisonQueueDemo.Entities
{
    public class PaymentDetails
    {
        public string CardNumber { get; set; }

        public string Expiry { get; set; }

        public decimal Amount { get; set; }
    }
}
