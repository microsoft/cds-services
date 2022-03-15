using Newtonsoft.Json.Linq;

namespace CDSService.Models
{
    public class ServiceRequest
    {
        public string Hook { get; set; } = default!;
        public string HookInstance { get; set; } = default!;
        public string? FhirServer { get; set; }
        public FhirAuthorization? FhirAuthorization { get; set; }
        public JObject Context { get; set; } = default!;
        public JObject? Prefetch { get; set; }
    }
}