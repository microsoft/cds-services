namespace CDSService.Models
{
    public class Link
    {
        public string Label { get; set; } = default!;
        public string Url { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string? AppContext { get; set; }
    }
}