using System;
using System.Linq;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using PoisonQueueDemo.Entities;

namespace PoisonQueueDemo
{
    public static class MockPayment
    {
        [FunctionName("MockPayment")]
        public static void Run([QueueTrigger("queued-payments", Connection = "")]PaymentDetails item, ILogger log)
        {
            if (IsValid(item)){
                //call some other platform
                log.LogInformation("Payment was a great success");
            }
            else
            {
                throw new ApplicationException("Disappointment and despair");
            }
        }

        private static bool IsValid(PaymentDetails details)
        {
            return IsLuhnValid(details.CardNumber) && IsInDate(details.Expiry) && RandomAmountValidation(details.Amount);
        }

        private static bool IsLuhnValid(string cardNumber)
        {
            var digits = cardNumber.Select(x => x - '0').ToArray();
            var checkMod = digits.Select((d, i) => i % 2 == digits.Length % 2 ? ((2 * d) % 10) + d / 5 : d).Sum() % 10;
            return checkMod == 0;
        }

        private static bool IsInDate(string expiry)
        {
            var parts = expiry.Split('/').Select(Int32.Parse).ToList();
            var currDate = DateTime.UtcNow;
            return parts[1] > currDate.Year || parts[1] == currDate.Year && parts[0] >= currDate.Month;
        }

        private static bool RandomAmountValidation(decimal amount)
        {
            return amount > 0.05M && amount < 100M;
        }
    }
}
