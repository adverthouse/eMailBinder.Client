namespace eMailBinder.Client.Requests;
public class VerifyEmailAddressRequest
{ 
    public string VerificationCode { get; set; } = String.Empty; 

    public VerifyEmailAddressRequest() {}

    public VerifyEmailAddressRequest(string verificationCode){
         VerificationCode = verificationCode;
    }
}