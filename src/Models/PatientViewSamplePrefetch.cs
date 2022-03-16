using Hl7.Fhir.Model;

namespace CDSService.Models;

public class PatientViewSamplePrefetch
{
    public Patient Patient { get; set; } = default!;
}
