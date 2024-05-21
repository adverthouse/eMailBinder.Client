namespace eMailBinder.Client.Requests;
public class UnsubscriptionRequest
{
    public int SubscriptionListId { get; set; } 
    public string EmailAddress { get; set; } = String.Empty;  
}