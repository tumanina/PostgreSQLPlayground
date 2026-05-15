namespace PostgreSqlPlayground;

public class Subscription
{
    /// <summary>
    /// Unique identifier of the subscription
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Type of the event to what 
    /// </summary>
    public EventType EventType { get; set; }
    /// <summary>
    /// Name of the tenant who subribes to event
    /// </summary>
    public string Tenant { get; set; }
    /// <summary>
    /// Endpoint that will be called
    /// </summary>
    public string EndpointUrl { get; set; }
    /// <summary>
    /// Api key to authorisation
    /// </summary>
    public string ApiKey { get; set; }
    /// <summary>
    /// Flag that is shown is subscription active or not
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// When subscription was created
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// When subscription was updated
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
