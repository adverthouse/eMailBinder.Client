using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


/* 
        var result = await SendInvoice();
        Console.WriteLine("Result is "+ result.StatusCode);
        
 */

    //  await Subscribe();      
        await Verify("MkFBQUFCK0xDQUFBQUFBQUFBTUZ3ZDE2Z2lBQUFOQUg0c0tmVDBzdnVqQWI0WkFpSmFQZHRkU0JUSjJtZ2ozOXpobkl1Y0lnQVR5TEVBMUZwUzBUSkJxUDlaMEY1L1l3VGRqYVIzMkxMMEg5RzcybzkxcUtUdDFobThsclJXekQ4aWZFblVIbDBSVTVXTzFZODFXYVArUExrZnFnOEV5dE9WTzF1Ym84Vk00QVpyVEc0cXRaMHJuVmdxZGQ0dm9pUEJCNW9vS2pzVS9vSml1YkczbkFiYjlZenBLVWcvMmVQcERJWnQxMDhiUVJwMjVMZnZxSGNlVHowMWxVV01BOEZmdHZlTXlZU2htK2NlSno3N0xiL1FNczE1ZFUyQUFBQUE9PQ");

        
     //   await CreateCampaign();                   
/*
        Console.WriteLine($"VerifyEmailAddress : {result.Data}, {result.StatusMessage}"); 
        result = await binder.Unsubscribe(new eMailBinder.Client.Requests.UnsubscriptionRequest(){
           EmailAddress = "yunusozturk7@gmail.com",
           SubscriptionListId = 1,
           UnsubscribedCampaignId = 1
        });

        Console.WriteLine($"Unsubscribe : {result.StatusCode}, {result.StatusMessage}"); */

    }

    private static eMailBinder.Client.eMailBinder _emailBinder{
        get { return new eMailBinder.Client.eMailBinder("https://emailbinder.yunus.us","7284b804f6684164817f7ea6a02c7b4b");}
    //    get { return new eMailBinder.Client.eMailBinder("https://localhost:5100","e7a5e92a04234744be4cda09603d0586");}
    }

    private static async Task Verify(string code){
         await _emailBinder.VerifyEmailAddress(new eMailBinder.Client.Requests.VerifyEmailAddressRequest(){
             VerificationCode = code
         });
    } 

    private static async  Task<StatusInfo<string>?>  SendInvoice(){

       return await _emailBinder.SendTransactionalEmail(new TransactionalEmailRequest(){
            EmailTemplateSlug = "invoice",
            ReceiverEmailAddress = "yunusozturk@gmail.com",
            MessageParameters = new Dictionary<string, string>(){
                { "invoice_number" , "#125.100" },
                { "total_amount", "1.250 USD"}
            }
        });

    }

    private static async Task<StatusInfo<string>?> CreateCampaign(){

       return await _emailBinder.CreateCampaign(new CreateCampaignRequest(){
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
             EmailAddress = "yunusozturk@msn.com",
             SubscriptionListSlug = "main-list",
             Name = "Yunus",
             IPAddress = "192.168.1.1"
        });

        Console.WriteLine($"SubscribeToList : {result.StatusCode}, {result.StatusMessage}"); 
    }


}