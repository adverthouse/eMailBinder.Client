using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;
public interface IeMailBinder
{
    Task<StatusInfo<string>?>  SubscribeToList(SubscriptionRequest subscriptionRequest);
    Task<StatusInfo<string>?> Unsubscribe(UnsubscriptionRequest unsubscriptionRequest);
    Task<StatusInfo<string>?> VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest);
}