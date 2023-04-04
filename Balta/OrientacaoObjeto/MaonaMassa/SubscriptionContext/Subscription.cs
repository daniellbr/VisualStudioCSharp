using System;
using MaoNaMassa.SharedContext;

namespace MaoNaMassa.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; private set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive => EndDate <= DateTime.Now;

    }
}