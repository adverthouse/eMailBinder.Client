namespace eMailBinder.Core.Common;

public class StatusInfo<TData>
{
    public StatusCode StatusCode { get; set; } = StatusCode.Error; 
    public string StatusMessage { get; set; } = string.Empty;

    public TData? Data { get; set; }

    public StatusInfo()
    {
    }

    public StatusInfo(StatusCode statusCode)
    {
        StatusCode = statusCode;
    }
}

