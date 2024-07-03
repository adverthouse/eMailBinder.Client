namespace eMailBinder.Client.Requests;
public class UnsubscriptionRequest
{
    public string UnsubscribeCode { get; set; } = String.Empty; 
    public UnsubscriptionRequest(){ }

    public UnsubscriptionRequest(string unsubscribeCode){
        UnsubscribeCode = unsubscribeCode;
    } 
}