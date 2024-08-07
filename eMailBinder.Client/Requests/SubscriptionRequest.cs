using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMailBinder.Client.Requests;
public class SubscriptionRequest
{
    public string SubscriptionListSlug { get; set; } = String.Empty;
    public string? Name { get; set; } = String.Empty;
    public string EmailAddress { get; set; } = String.Empty;   
    public string? CustomFields { get; set; }
    public string IPAddress { get; set; } = String.Empty; 
}