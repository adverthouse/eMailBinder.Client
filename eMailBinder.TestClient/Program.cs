using eMailBinder.Client;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        eMailBinder.Client.eMailBinder binder = new("https://emailbinder.yunus.us","45795dd61a204856b41fbb0ccde653db");

        var result = await binder.SubscribeToList(new eMailBinder.Client.Requests.SubscriptionRequest(){
             EmailAddress = "yunusozturk@gmail.com",
             SubscriptionListId = 1,
             Name = "Yunus",
             IPAddress = "192.168.1.1"
        });
/*
        Console.WriteLine($"SubscribeToList : {result.StatusCode}, {result.StatusMessage}"); 

        result = await binder.VerifyEmailAddress(new eMailBinder.Client.Requests.VerifyEmailAddressRequest(){
           VerificationCode = "8Baz/KfrlNipBURKW2Eu9FcYJ75dAU8zjqzyMsIioiINwdA8lDvbi+Cszoa0Rx79"
        });

        Console.WriteLine($"VerifyEmailAddress : {result.Data}, {result.StatusMessage}"); 

        result = await binder.Unsubscribe(new eMailBinder.Client.Requests.UnsubscriptionRequest(){
           EmailAddress = "yunusozturk7@gmail.com",
           SubscriptionListId = 1,
           UnsubscribedCampaignId = 1
        });

        Console.WriteLine($"Unsubscribe : {result.StatusCode}, {result.StatusMessage}"); */

    }
}