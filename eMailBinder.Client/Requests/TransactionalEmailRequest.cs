namespace eMailBinder.Client.Requests;
public class TransactionalEmailRequest
{    
    public string ReceiverEmailAddress { get; set; } = String.Empty; 
    public string EmailTemplateSlug { get; set; } = String.Empty;
    public Dictionary<string, string> MessageParameters { get; set; } = [];
}