using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class User_Subscription
    {
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
