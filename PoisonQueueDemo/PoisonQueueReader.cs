using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PoisonQueueDemo.Entities;

namespace PoisonQueueDemo
{
    public static class PoisonQueueReader
    {
        /*[FunctionName("PoisonQueueReader")]
        public static void Run(
            [QueueTrigger("queued-payments-poison", Connection = "")]string poisonItem,
            [Queue("queued-payments", Connection = "")] out string fixedItem, 
            ILogger log)
        {
            log.LogInformation($"Retrieved an item from the poison queue");

            //if this really was card data, obviously we wouldn't just log in plaintext
            log.LogInformation($"Invalid data was: {poisonItem}");

            fixedItem = FixTheData(poisonItem);
        }

        private static string FixTheData(string item)
        {
            var details = JsonConvert.DeserializeObject<PaymentDetails>(item);

            details.Expiry = FixedExpiry(details.Expiry);

            return JsonConvert.SerializeObject(details);
        }

        private static string FixedExpiry(string expiry)
        {
            var parts = expiry.Split('/');
            return $"{parts[0]}/20{parts[1]}";
        }*/
    }
}
