using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        var result = await SendInvoice();
        Console.WriteLine("Result is "+ result.StatusCode+","+result.StatusMessage);
       


   //   await Subscribe();      
 //        var result =  await Verify("N0FBQUFCK0xDQUFBQUFBQUFBTUZ3Y3QyUkRBQUFOQVBta1hHbktoWWRFRWFyMVRGYTA1MVp4UlZFa1FZZlAzY080ZFJUUy8rNVR1eFBHYisxVSt3SS85SlpWTmtLT0lmU2xGZ1d5T25NV29HYTJGdzJlNmlMeHllZEhrZFh2Y01WekNMOFRIdEVqMkVaZ0IzU2MyVmpZcU1OWUV4MGxtbjFXSWd1VnR4TDFwNjEwUmhaSlU3T0lJR0k5aTIzSDc0N1FwUkYyREhGRUg2NVpXZmpCNHoram1WcUFEZm1Pb054dzUvRSt1T0s0TUczWXd6YldINXJjRE9yV3IwK1JyOWsrbEVwZ0EySFpaU1FqN0pmSlVUSWlDVFFsRWozZDZrZmxMeS9nS0dqdXNyN0FBQUFBPT0");
//Console.WriteLine("Result is "+ result.StatusCode);
        
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
      // get { return new eMailBinder.Client.eMailBinder("https://emailbinder.yunus.us","7284b804f6684164817f7ea6a02c7b4b");}
        get { return new eMailBinder.Client.eMailBinder("https://localhost:5100","6fae697427f24c9d8a0d7292b97589d4");}
    }

    private static async  Task<StatusInfo<string>?> Verify(string code){
         return await _emailBinder.VerifyEmailAddress(new eMailBinder.Client.Requests.VerifyEmailAddressRequest(){
             VerificationCode = code
         });
    } 

    private static async  Task<StatusInfo<string>?>  SendInvoice(){

       // string path = "/Users/yunus/Desktop/Works/adverthouse/eMailBinderClient/eMailBinder.TestClient/Invoice-1013412315005.pdf";

        return await _emailBinder.SendTransactionalEmail(new TransactionalEmailRequest()
        {
            EmailTemplateSlug = "customer-invoice",
            ReceiverEmailAddress = "YunusOzturk@gmail.com",
            MessageParameters = new Dictionary<string, string>(){
                    { "invoice_number" , "#125.100" },
                    { "total_amount", "1.250 USD"}
                },
        //    FileStream = File.ReadAllBytes(path),
         //   FileName = "invoice.pdf"
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
             EmailAddress = "YunusOzturk@gmail.com",
             SubscriptionListSlug = "main-list",
             Name = "Yunus",
             IPAddress = "192.168.1.1"
        });

        Console.WriteLine($"SubscribeToList : {result.StatusCode}, {result.StatusMessage}"); 
    }


}