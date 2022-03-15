using Newtonsoft.Json.Linq;

namespace CDSService.Models
{
    public class Action
    {
        public string Type { get; set; } = default!;
        public string Description { get; set; } = default!;
        public JObject? Resource { get; set; }
    }
}