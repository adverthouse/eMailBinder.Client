using eMailBinder.Client;
using eMailBinder.Client.Requests;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //eMailBinder.Client.eMailBinder binder = new("https://localhost:5100","fbf397b2f81c4bf0b24b9e886051b794");
        
        //await Subscribe();
        await CreateCampaign();

     /*   result = await binder.VerifyEmailAddress(new eMailBinder.Client.Requests.VerifyEmailAddressRequest(){
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

    private static eMailBinder.Client.eMailBinder _emailBinder{
        get { return new eMailBinder.Client.eMailBinder("https://emailbinder.yunus.us","a95225e6105f4a7fb9dfce6fbe0793fa");}
      //  get { return new eMailBinder.Client.eMailBinder("https://localhost:5100","fbf397b2f81c4bf0b24b9e886051b794");}
    }

    private static async Task CreateCampaign(){

       await _emailBinder.CreateCampaign(new CreateCampaignRequest(){
                    SubscriptionListSlug = "main-list",
                    CampaignName = "New Vehicle alert "+ DateTime.Now.ToString("yyyy-MM-dd"),
                    EmailTemplateSlug = "single-car",
                    ScheduledUTCDate = DateTime.UtcNow,
                    ScheduledUTCTime = DateTime.UtcNow.TimeOfDay,
                    CampaignParameters = new Dictionary<string, string>{
                        { "vehicle_details", "1967 Pontiac GTO" },
                        { "vehicle_price", "$59,500" },
                        { "vehicle_image",  "https://www.southernmotors.com/vi/1967-pontiac-gto-21613_w960.webp" },
                        { "vehicle_url", "https://www.southernmotors.com/gm/gto-vh_3805.html"}
                    }
                });  
    }

    private static async Task Subscribe(){
        

        var result = await _emailBinder.SubscribeToList(new eMailBinder.Client.Requests.SubscriptionRequest(){
             EmailAddress = "yunusozturk@gmail.com",
             SubscriptionListSlug = "main-list",
             Name = "Yunus",
             IPAddress = "192.168.1.1"
        });

        Console.WriteLine($"SubscribeToList : {result.StatusCode}, {result.StatusMessage}"); 
    }


}