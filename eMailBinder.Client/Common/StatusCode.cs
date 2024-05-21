namespace eMailBinder.Core.Common;
public enum StatusCode{
    
    Ok = 200,
    Unsubscribed = 201,
    AlreadySubscribed = 202,
    InvalidEmailAddress = 203,
    


    Error = 400,
    InvalidAPIKey = 500,
    APIKeyNotPassed = 501,
    SubscriptionListNotFound = 502 ,
    EmailAddressDoesntExists = 503,
    EmailAddressAlreadyConfirmed = 504 

}