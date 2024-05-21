using eMailBinder.Client;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        eMailBinder.Client.eMailBinder binder = new("http://localhost:5100","test");

        var result = await binder.SubscribeToList(new eMailBinder.Client.Requests.SubscriptionRequest(){
             EmailAddress = "yunusozturk@gmail.com",
             ListId = 1,
             Name = "Yunus"
        });

        Console.WriteLine($"{result.StatusCode}, {result.StatusMessage}"); 
    }
}