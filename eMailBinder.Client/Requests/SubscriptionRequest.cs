using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMailBinder.Client.Requests
{
    public class SubscriptionRequest
    {
        public int ListId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string EmailAddress { get; set; } = String.Empty;         
    }
}