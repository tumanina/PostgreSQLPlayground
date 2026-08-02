namespace PostgreSqlPlayground.Database.Entities;

public class HistoryEntity
{
    public HistoryEntity()
    { }

    public HistoryEntity(string tenant, EventType eventType, string endpointUrl, string payload, int responseStatus, string response)
    {
        Id = Guid.NewGuid();
        Tenant = tenant;
        EventType = eventType;
        EndpointUrl = endpointUrl;
        Payload = payload;
        ResponseStatus = responseStatus;
        Response = response;
    }

    public Guid Id { get; set; }
    public string Tenant { get; set; }
    public EventType EventType { get; set; }
    public string EndpointUrl { get; set; }
    public string Payload { get; set; }
    public int ResponseStatus { get; set; }
    public string Response { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
