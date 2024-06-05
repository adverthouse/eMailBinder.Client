namespace eMailBinder.Client.Requests;
public class CreateCampaignRequest
{
    public int SubscriptionListId { get; set; }
    public string CampaignName { get; set; } = String.Empty;
    public int EmailTemplateId { get; set; } = -1; 
    public DateTime? ScheduledUTCDate { get; set; } 
    public TimeSpan? ScheduledUTCTime { get; set; } 
    public Dictionary<string, string> CampaignParameters { get; set; } = [];
}