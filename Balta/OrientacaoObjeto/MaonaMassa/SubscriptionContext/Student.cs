using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MaoNaMassa.NotficationContext;

namespace MaoNaMassa.SubscriptionContext
{
    public class Student : Subscription
    {
        public Student(string name, string email, User user)
        {
            Name = name;
            Email = email;
            User = user;

            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já é premium e tem uma assinatura ativa."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}