namespace HandTools.ApplicationCore.Entities;

public class ErrorViewModel
{
    public string? RequestId
    {
        get; set;
    }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
