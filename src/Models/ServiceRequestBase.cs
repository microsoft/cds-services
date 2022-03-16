namespace CDSService.Models;

/// <summary>
/// Request payload from CDS Client --> CDS Service
/// </summary>
public abstract class ServiceRequestBase
{
    public string Hook { get; set; } = default!;
    public string HookInstance { get; set; } = default!;
    public string? FhirServer { get; set; }
    public FhirAuthorization? FhirAuthorization { get; set; }
}
