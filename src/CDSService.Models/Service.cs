using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace CDSService.Models 
{
    public class Service 
    {
        [Required]
        public string Hook { get; set; } = default!;
        [Required]
        public string Id { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        public string? Title { get; set; }
        public JObject? Prefetch { get; set; }
    }
}