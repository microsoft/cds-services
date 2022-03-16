using Hl7.Fhir.Model;

namespace CDSService.Models;

public class PatientViewSampleRequest : ServiceRequestBase
{
    public PatientViewContext Context { get; set; } = default!;
    public PatientViewSamplePrefetch Prefetch { get; set; } = default!;
}
