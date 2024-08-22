using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;

public class eMailBinder :IeMailBinder
{
     private string _apiKey;
     private string _apiEndPoint;
     private APIService apiService;

     public eMailBinder(string apiEndPoint, string apiKey)
     {
        _apiKey = apiKey;
        _apiEndPoint = apiEndPoint;

        apiService = new APIService(new HttpClient(){
           BaseAddress = new Uri(apiEndPoint),                       
        },apiKey);
     }

     public async Task<StatusInfo<string>?> SubscribeToList(SubscriptionRequest subscriptionRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,SubscriptionRequest>($"api/subscription/add",subscriptionRequest);
          if (result.IsSuccess){
               return result.result;
          } else {
               result.result = new(StatusCode.Error,result.ErrorMessage ?? "Server error"); 
          }     
    
          return result.result;
     }

     public async Task<StatusInfo<string>?> Unsubscribe(UnsubscriptionRequest unsubscriptionRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,UnsubscriptionRequest>($"api/subscription/unsubscribe",unsubscriptionRequest);
          if (result.IsSuccess){
               return result.result;
          } else {
               result.result = new(StatusCode.Error,result.ErrorMessage ?? "Server error"); 
          }     
    
          return result.result;
     }

     public async Task<StatusInfo<string>?> VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,VerifyEmailAddressRequest>($"api/subscription/verify",verifyEmailAddressRequest);
          if (result.IsSuccess){
               return result.result;
          } else {
               result.result = new(StatusCode.Error,result.ErrorMessage ?? "Server error"); 
          }     
    
          return result.result;
     }

     public async Task<StatusInfo<string>?> CreateCampaign(CreateCampaignRequest createCampaignRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,CreateCampaignRequest>($"api/campaign/create",createCampaignRequest);
          if (result.IsSuccess){
               return result.result;
          } else {
               result.result = new(StatusCode.Error,result.ErrorMessage ?? "Server error"); 
          }     
    
          return result.result;
     }

     public async Task<StatusInfo<string>?> SendTransactionalEmail(TransactionalEmailRequest transactionalEmailRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,TransactionalEmailRequest>($"api/TransactionalEmail/send",transactionalEmailRequest);
          if (result.IsSuccess){
               return result.result;
          } else {
               result.result = new(StatusCode.Error,result.ErrorMessage ?? "Server error"); 
          }     
    
          return result.result;
     }
}
