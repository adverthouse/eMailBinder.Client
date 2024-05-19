using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;

public class eMailBinder :IeMailBinder
{
     private string _apiKey;
     private string _apiEndPoint;

     public eMailBinder(string apiEndPoint,string apiKey)
     {
          _apiKey = apiKey;
          _apiEndPoint = apiEndPoint;
     }

     public StatusInfo<string> SubscribeToList(SubscriptionRequest subscriptionRequest)
     {
          var result = new StatusInfo<string>();
          
          /// trigger subscribe

    
          return result;
     }
}
