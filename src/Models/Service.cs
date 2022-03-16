namespace CDSService.Models;

public class Service 
{
    public string Hook { get; set; } = default!;
    public string Id { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? Title { get; set; }
    public Dictionary<string, string>? Prefetch { get; set; }
}

public class ServicePayload
{
    public IList<Service> Services { get; set; } = default!;
}
