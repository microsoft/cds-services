using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CDSService.Models
{
    public class FhirAuthorization
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; } = default!;
        [JsonProperty("token_type")]
        public string TokenType { get; set; } = default!;
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        public string Scope { get; set; } = default!;
        public string Subject { get; set; } = default!;
    }
}