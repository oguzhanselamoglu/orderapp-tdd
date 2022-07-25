using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Domain.OrderAggregate
{
    public class PaymentItem
    {
        public PaymentItem(string currency, decimal amount, decimal rate)
        {
            Currency = currency;
            Amount = amount;
            Rate = rate;
        }

        public string Currency { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Rate { get; private set; }

        public decimal LocalAmount
        {
            get
            {
                return Amount * Rate;
            }
        }

        public bool Deleted { get; internal set; }
    }
}
