using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;
public interface IeMailBinder
{
    Task<StatusInfo<string>?>  SubscribeToList(SubscriptionRequest subscriptionRequest);
    Task<StatusInfo<string>?> Unsubscribe(UnsubscriptionRequest unsubscriptionRequest);
    Task<StatusInfo<string>?> VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest);
    Task<StatusInfo<string>?> CreateCampaign(CreateCampaignRequest createCampaignRequest);   
    Task<StatusInfo<string>?> SendTransactionalEmail(TransactionalEmailRequest transactionalEmailRequest);
}