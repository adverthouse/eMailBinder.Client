namespace eMailBinder.Client.Requests;

public class CreateCampaignRequest
{
    public string SubscriptionListSlug { get; set; } = String.Empty;
    public string CampaignName { get; set; } = String.Empty;
    public string EmailTemplateSlug { get; set; } = String.Empty;

    public DateTime? ScheduledUTCDate { get; set; } 
    public TimeSpan? ScheduledUTCTime { get; set; } 
    public Dictionary<string, string> CampaignParameters { get; set; } = [];
}