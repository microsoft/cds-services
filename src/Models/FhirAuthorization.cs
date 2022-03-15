using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CDSService.Models;

public class FhirAuthorization
{
    [JsonPropertyName("access_token")]
    [JsonProperty("access_token")]
    public string AccessToken { get; set; } = default!;
    [JsonPropertyName("token_type")]
    [JsonProperty("token_type")]
    public string TokenType { get; set; } = default!;
    [JsonPropertyName("expires_in")]
    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }
    public string Scope { get; set; } = default!;
    public string Subject { get; set; } = default!;
}
